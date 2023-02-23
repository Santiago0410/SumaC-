using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            int num1, num2, res;

            num1 = Convert.ToInt32(txtnum1.Text);
            num2 = Convert.ToInt32(txtnum2.Text);

            res = num1 + num2;

            txtresult.Text = res.ToString();
        }
    }
}
