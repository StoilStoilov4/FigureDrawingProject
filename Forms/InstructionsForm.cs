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
    public partial class InstructionsForm : Form
    {
        public InstructionsForm()
        {
            InitializeComponent();
        }

        private void InstructionsForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseHelpButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
