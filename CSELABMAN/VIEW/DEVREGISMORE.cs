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
    public partial class DEVREGISMORE : Form
    {
        public DEVREGISMORE()
        {
            InitializeComponent();
            textBox_Quanity.ReadOnly = true;
        }

        public void setType(string data)                    // lay danh sach cac loai thiet bi sau khi lay tu server
        {
            textBox_Type.Text = data;
        }

        public void setQuantity(string num)                 // lay so luong moi
        {
            textBox_Quanity.Text = num;
        }

        public void setAtt(string data)                         // lay danh sach cac ATTRIBUTE loai thiet bi sau khi lay tu server
        {
            textBox_Att.Text = data;
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
