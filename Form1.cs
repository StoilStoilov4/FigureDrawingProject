namespace FigureDrawingApp
{
    public partial class FormMain : Form
    {
        private static readonly List<Figure> _figures = new List<Figure>();
        private Stack<List<Figure>> undoStack = new Stack<List<Figure>>();
        private Stack<List<Figure>> redoStack = new Stack<List<Figure>>();

        private Point startPoint;
        private bool isDrawingAllowed = false;
        private Color fillColor = Color.Transparent;
        private Color outlineColor = Color.Black;
        private bool fillReady = false;
        private Figure? selectedFigure;
        private Point mouseOffset;
        private bool isReadyToMove = false;
        private FigureType? currentFigureType = null;
        private Figure? currentFigure;
        private bool getArea = false;
        private double dpiX;
        private double dpiY;
        private bool isErasable = false;

        public FormMain()
        {

            InitializeComponent();
            comboBox1.DataSource = (Enum.GetValues(typeof(FigureType)));
            comboBox1.SelectedIndex = 0;

            undoStack.Push(CreateAppStateSnapshot());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            getArea = false;

            var prevState = CreateAppStateSnapshot();

            if (!fillReady && e.Button == MouseButtons.Left)
            {
                if (isDrawingAllowed)
                {
                    startPoint = e.Location;
                }
            }
            if (isReadyToMove && e.Button == MouseButtons.Left)
            {
                isDrawingAllowed = false;
                foreach (var figure in _figures)
                {
                    if (figure.Contains(e.Location))
                    {
                        selectedFigure = figure;

                        selectedFigure.SetPosition(e.Location.X, e.Location.Y);
                        mouseOffset = new Point(e.Location.X - selectedFigure.X, e.Location.Y - selectedFigure.Y);

                        break;
                    }
                }
            }
            undoStack.Push(prevState);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (isReadyToMove && selectedFigure != null && e.Button == MouseButtons.Left)
            {
                int newX = e.Location.X - mouseOffset.X;
                int newY = e.Location.Y - mouseOffset.Y;

                if (fillReady)
                {
                    selectedFigure.FillColor = fillColor;
                }

                selectedFigure.SetPosition(newX, newY);

                Invalidate();

            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            var prevState = CreateAppStateSnapshot();

            if (!fillReady && isDrawingAllowed && e.Button == MouseButtons.Left && startPoint != Point.Empty)
            {
                int x = Math.Min(startPoint.X, e.Location.X);
                int y = Math.Min(startPoint.Y, e.Location.Y);
                int width = Math.Abs(e.Location.X - startPoint.X);
                int height = Math.Abs(e.Location.Y - startPoint.Y);

                switch (currentFigureType)
                {
                    case FigureType.Rectangle:
                        currentFigure = new Rectangle(x, y, width, height, fillColor, Color.Black);

                        break;
                    case FigureType.Ellipse:
                        currentFigure = new Ellipse(x, y, width, height, fillColor, Color.Black);
                        break;
                    case FigureType.Triangle:
                        currentFigure = new Triangle(x, y, width, height, fillColor, Color.Black);
                        break;
                }

                _figures.Add(currentFigure);

                if (isReadyToMove && selectedFigure != null && e.Button == MouseButtons.Left)
                {
                    undoStack.Push(CreateAppStateSnapshot());

                    undoStack.Push(prevState);
                }

                Invalidate();
            }
            else if (fillReady && e.Button == MouseButtons.Left)
            {
                foreach (var figure in _figures)
                {
                    if (figure.Contains(e.Location))
                    {
                        figure.FillColor = fillColor;
                        figure.IsFilled = true;

                        undoStack.Push(CreateAppStateSnapshot());
                        redoStack.Clear();

                        Invalidate();
                        break;
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                 foreach (var figure in _figures)
                 {
                    if (figure.Contains(e.Location))
                    {
                        using (ColorDialog colorDialog = new ColorDialog())
                        {
                            if (colorDialog.ShowDialog() == DialogResult.OK)
                            {
                                outlineColor = colorDialog.Color;
                                figure.OutlineColor = outlineColor;


                                undoStack.Push(CreateAppStateSnapshot());
                                redoStack.Clear();

                                Invalidate();
                            }
                        }
                        break;
                    }
                 }
            }
            else if (isErasable && e.Button == MouseButtons.Left)
            {
                foreach (var figure in _figures.ToList())
                {
                    if(figure.Contains(e.Location))
                    {
                        RemoveFigure(figure);
                    }
                }
                undoStack.Push(CreateAppStateSnapshot());
                redoStack.Clear();

                Invalidate();
            }

            startPoint = Point.Empty;
        }


        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);

            if (e.Button == MouseButtons.Left)
            {
                foreach (var figure in _figures)
                {
                    if (figure.Contains(e.Location))
                    {
                        getArea = true;
                        figure.CalculateArea();

                        // Convert area to square centimeters using DPI
                        double areaInSquareCentimeters = (figure.Area / (dpiX * dpiY)) * Math.Pow(2.54, 2);

                        MessageBox.Show($"The area of the {figure.GetType().Name} is {areaInSquareCentimeters:0.00} cm2", "Area calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    }
                }
            }
            if(e.Button == MouseButtons.Middle)
            {
                foreach (var figure in _figures)
                {
                    if(figure.Contains(e.Location))
                    {
                        ResizeFigure(figure);
                        break;
                    }
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (var figure in _figures)
            {
                figure.Fill(e.Graphics, new SolidBrush(figure.FillColor));
                figure.Draw(e.Graphics);
            }

            dpiX = e.Graphics.DpiX;
            dpiY = e.Graphics.DpiY;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isReadyToMove = false;
            selectedFigure = null;
            fillReady = false;
            isErasable = false;
            isDrawingAllowed = true;
            rectangleButton.Text = isDrawingAllowed ? "Drawing Enabled" : "Drawing Disabled";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

            var prevState = CreateAppStateSnapshot();

            fillReady = false;
            isDrawingAllowed = true;
            isReadyToMove = false;
            isErasable = false;
            fillColor = Color.Transparent;
            outlineColor = Color.Black;
            _figures.Clear();

            undoStack.Push(prevState);
            redoStack.Clear();

            Invalidate();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.Control && e.KeyCode == Keys.Z)
            {
                Undo();
            }
            if (e.Control && e.KeyCode == Keys.Y)
            {
                Redo();
            }
        }

        private void bucketTool_Click(object sender, EventArgs e)
        {
            isErasable = false;

            var prevState = CreateAppStateSnapshot();

            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {

                    //outlineColor = colorDialog.Color;
                    fillColor = colorDialog.Color;
                    //bucketTool.Text = "Bucket tool enabled - Color: " + fillColor.ToString();
                    fillReady = true;
                }
            }

            undoStack.Push(prevState);
            redoStack.Clear();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            isErasable = false;
            isDrawingAllowed = false;
            isReadyToMove = true;
            fillReady = false;

            if (isReadyToMove)
            {
                selectedFigure = null;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentFigureType = (FigureType)comboBox1.SelectedItem;
        }

        private List<Figure> CreateAppStateSnapshot()
        {
            List<Figure> snapshot = new List<Figure>();

            foreach (var figure in _figures)
            {
                snapshot.Add(figure.Clone());
            }
            redoStack.Clear();
            return snapshot;
        }

        private void RestoreAppStateSnapshot(List<Figure> snapshot)
        {
            _figures.Clear();
            foreach (var figure in snapshot)
            {
                _figures.Add(figure.Clone());
            }
            Invalidate();
        }

        private void Undo()
        {
            if (undoStack.Count > 0)
            {
                var currentState = CreateAppStateSnapshot();
                redoStack.Push(currentState);
                var previousState = undoStack.Pop();
                RestoreAppStateSnapshot(previousState);
            }
        }

        private void Redo()
        {
            if (redoStack.Count > 0)
            {
                var currentState = new List<Figure>(_figures);
                undoStack.Push(currentState);
                var nextState = redoStack.Pop();
                RestoreAppStateSnapshot(nextState);
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redo();
        }


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstructionsForm instructionsForm = new InstructionsForm();

            instructionsForm.Show();
        }

        private void RemoveFigure(Figure figure)
        {
            _figures.Remove(figure);
            
        }

        private void EraseButton_Click(object sender, EventArgs e)
        {
            fillReady = false;
            isDrawingAllowed = false;
            isErasable = true;
        }


        private void ResizeFigure(Figure figure)
        {
            // Open the ResizeForm with the current dimensions of the selected figure
            using (Resize resizeForm = new Resize(figure.Width, figure.Height))
            {
                if (resizeForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the dimensions of the selected figure
                    figure.Width = resizeForm.NewWidth;
                    figure.Height = resizeForm.NewHeight;

                    // Redraw the figure with the new dimensions
                    Invalidate();
                }
            }
        }


    }
}
