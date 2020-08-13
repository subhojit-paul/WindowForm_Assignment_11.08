using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalLib;

namespace WindowsFormAssignmnt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculator obj;
        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                obj = new Calculator();
                obj.num1 = Convert.ToDouble(txtNum1.Text);
                txtNum2.Enabled = true;
                //obj.num2 = Convert.ToInt32(txtNum2.Text);
                //lblRes.Text = obj.Addition().ToString();
            }
            catch(Exception ex)
            {
                lblRes.Text = ex.Message;
            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            obj.num2 = Convert.ToDouble(txtNum2.Text);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNum2.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblRes.Text = obj.Addition().ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            lblRes.Text = obj.Substraction().ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblRes.Text = obj.Multiplication().ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lblRes.Text = obj.Divide().ToString();
        }
    }
}
