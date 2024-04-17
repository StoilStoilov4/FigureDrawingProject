using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureDrawingApp
{
    public partial class Resize : Form
    {
        public int NewHeight { get; set; }

        public int NewWidth { get; set; }

        public Resize(int currentWidth, int currentHeight)
        {
            InitializeComponent();
            txtWidth.Text = currentWidth.ToString();
            txtHeight.Text = currentHeight.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtWidth.Text, out int newWidth) || !int.TryParse(txtHeight.Text, out int newHeight))
            {
                MessageBox.Show("Invalid input. Please enter valid integer values for width and height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the new dimensions
            NewWidth = newWidth;
            NewHeight = newHeight;

            // Close the form
            DialogResult = DialogResult.OK;
            //Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
