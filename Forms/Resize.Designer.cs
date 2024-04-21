namespace FigureDrawingApp
{
    partial class Resize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtHeight = new TextBox();
            label3 = new Label();
            txtWidth = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 70);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 50);
            label2.Name = "label2";
            label2.Size = new Size(94, 35);
            label2.TabIndex = 1;
            label2.Text = "Width: ";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(150, 62);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(156, 23);
            txtHeight.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 123);
            label3.Name = "label3";
            label3.Size = new Size(102, 35);
            label3.TabIndex = 3;
            label3.Text = "Height: ";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(150, 135);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(156, 23);
            txtWidth.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(190, 238);
            button1.Name = "button1";
            button1.Size = new Size(116, 47);
            button1.TabIndex = 5;
            button1.Text = "Resize";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(46, 238);
            button2.Name = "button2";
            button2.Size = new Size(116, 47);
            button2.TabIndex = 6;
            button2.Text = "Close: ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Resize
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 402);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtWidth);
            Controls.Add(label3);
            Controls.Add(txtHeight);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Resize";
            Text = "Resize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHeight;
        private Label label3;
        private TextBox txtWidth;
        private Button button1;
        private Button button2;
    }
}