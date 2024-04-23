namespace FigureDrawingApp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rectangleButton = new Button();
            clearButton = new Button();
            colorDialog1 = new ColorDialog();
            bucketTool = new Button();
            buttonMove = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            EraseButton = new Button();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rectangleButton
            // 
            rectangleButton.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rectangleButton.Location = new Point(66, 145);
            rectangleButton.Name = "rectangleButton";
            rectangleButton.Size = new Size(136, 34);
            rectangleButton.TabIndex = 0;
            rectangleButton.Text = "Enable Drawing";
            rectangleButton.UseVisualStyleBackColor = true;
            rectangleButton.Click += button1_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(66, 185);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(136, 31);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear Board";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // colorDialog1
            // 
            colorDialog1.FullOpen = true;
            // 
            // bucketTool
            // 
            bucketTool.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bucketTool.Location = new Point(66, 102);
            bucketTool.Name = "bucketTool";
            bucketTool.Size = new Size(136, 37);
            bucketTool.TabIndex = 3;
            bucketTool.Text = "bucket tool";
            bucketTool.UseVisualStyleBackColor = true;
            bucketTool.Click += bucketTool_Click;
            // 
            // buttonMove
            // 
            buttonMove.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMove.Location = new Point(66, 222);
            buttonMove.Name = "buttonMove";
            buttonMove.Size = new Size(136, 32);
            buttonMove.TabIndex = 4;
            buttonMove.Text = "Enable Moving";
            buttonMove.UseVisualStyleBackColor = true;
            buttonMove.Click += buttonMove_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(66, 313);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 453);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(882, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, saveAsToolStripMenuItem, openToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(180, 22);
            undoToolStripMenuItem.Text = "Undo (CTRL + Z)";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(180, 22);
            redoToolStripMenuItem.Text = "Redo (CTRL + Y)";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // EraseButton
            // 
            EraseButton.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EraseButton.Location = new Point(66, 260);
            EraseButton.Name = "EraseButton";
            EraseButton.Size = new Size(136, 34);
            EraseButton.TabIndex = 8;
            EraseButton.Text = "Erase";
            EraseButton.UseVisualStyleBackColor = true;
            EraseButton.Click += EraseButton_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 536);
            Controls.Add(EraseButton);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(buttonMove);
            Controls.Add(bucketTool);
            Controls.Add(clearButton);
            Controls.Add(rectangleButton);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button rectangleButton;
        private Button clearButton;
        private ColorDialog colorDialog1;
        private Button bucketTool;
        private Button buttonMove;
        private ComboBox comboBox1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Button EraseButton;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
    }
}
