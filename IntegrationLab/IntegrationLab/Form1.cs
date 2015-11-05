using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegrationLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox1.Text) > 18)
            {
                MessageBox.Show("You're Old enough", "Validator");
            }
            else
            {
                MessageBox.Show("You're Too young", "Validator");
            }
        }
    }
}
