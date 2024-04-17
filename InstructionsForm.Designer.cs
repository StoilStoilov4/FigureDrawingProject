namespace FigureDrawingApp
{
    partial class InstructionsForm
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
            CloseHelpButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // CloseHelpButton
            // 
            CloseHelpButton.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseHelpButton.Location = new Point(440, 581);
            CloseHelpButton.Name = "CloseHelpButton";
            CloseHelpButton.Size = new Size(138, 48);
            CloseHelpButton.TabIndex = 0;
            CloseHelpButton.Text = "Close";
            CloseHelpButton.UseVisualStyleBackColor = true;
            CloseHelpButton.Click += CloseHelpButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(120, 35);
            label1.TabIndex = 1;
            label1.Text = "Drawing: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(391, 57);
            label2.TabIndex = 2;
            label2.Text = "1. Choose what figure you want to draw from the dropdown menu.\r\n2. Click on \"Enable Drawing\".\r\n3. Enoy!\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(121, 35);
            label3.TabIndex = 3;
            label3.Text = "Coloring: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 182);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 4;
            label4.Text = "Outline Color: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(53, 205);
            label5.Name = "label5";
            label5.Size = new Size(199, 38);
            label5.TabIndex = 5;
            label5.Text = "1. Hover over the figure.\r\n2. Right Click and choose a color.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 252);
            label6.Name = "label6";
            label6.Size = new Size(113, 23);
            label6.TabIndex = 6;
            label6.Text = "Outline Color: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(53, 291);
            label7.Name = "label7";
            label7.Size = new Size(418, 57);
            label7.TabIndex = 7;
            label7.Text = "1. Click the \"Bucket Tool\" button to select what color to fill your figure.\r\n2. Left Click over the figure you want to fill.\r\n3. Repeat for other figures.\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 382);
            label8.Name = "label8";
            label8.Size = new Size(149, 35);
            label8.TabIndex = 8;
            label8.Text = "Undo/Redo: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 432);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(29, 432);
            label10.Name = "label10";
            label10.Size = new Size(454, 92);
            label10.TabIndex = 10;
            label10.Text = "1. Click on File\r\n2. Choose Undo/Redo\r\nor \r\n3. Use the keyboard shortcuts CTRL+Z (Undo)/CTRL+Y (Redo)";
            // 
            // InstructionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 643);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CloseHelpButton);
            Name = "InstructionsForm";
            Text = "InstructionsForm";
            Load += InstructionsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseHelpButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}