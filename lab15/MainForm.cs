using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab15
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click_Click(object sender, EventArgs e)
        {
            double a = double.Parse(AInput.Text);
            double b = double.Parse(BInput.Text);

            double hypotenuse = TriangleCalculator.CalculateHypotenuse(a, b);
            double area = TriangleCalculator.CalculateArea(a, b);

            HypotenuseOutput.Text = hypotenuse.ToString();
            AreaOutput.Text = area.ToString();
        }
    }
}
