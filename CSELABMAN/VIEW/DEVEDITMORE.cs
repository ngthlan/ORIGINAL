using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSELABMAN.VIEW
{
    public partial class DEVEDITMORE : Form
    {
        public DEVEDITMORE()
        {
            InitializeComponent();
            textBox_Quanity.ReadOnly = true;
        }

        public void setType(string data)
        {
            textBox_Type.Text = data;
        }

        public void setQuantity(string num)
        {
            textBox_Quanity.Text = num;
        }

        private void but_reset_Click(object sender, EventArgs e)
        {

        }

        private void but_OpenPort_Click(object sender, EventArgs e)
        {

        }

        private void but_Regis_Click(object sender, EventArgs e)
        {

        }

        private void label_DEVName_Click(object sender, EventArgs e)
        {

        }
    }
}
