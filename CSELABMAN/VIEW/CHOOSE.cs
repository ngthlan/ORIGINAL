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
    public partial class CHOOSE : Form
    {
        public string apptype = null;
        public CHOOSE(string type)
        {
            InitializeComponent();
            apptype = type;
            if (apptype.Equals("DEVREGISLIT") || apptype.Equals("DEVEDITLIT"))
            {
                textBox_Need.Enabled = false;
                textBox_Available.Enabled = false;
                comboBox_att.Enabled = false;
            }
            if (apptype.Equals("DEVEDITMORE"))
                comboBox_att.Enabled = false;
            if (apptype.Equals("DEVREGISELIT"))
                checkBox_New.Enabled = false;
        }

        private DEVEDITLIT parentDEVEDITLIT;
        public void getDEVEDITLIT(DEVEDITLIT tmp)           // tham chieu tu DEVEDITLIT
        {
            parentDEVEDITLIT = tmp;
        }

        private DEVREGISLIT parentDEVREGISLIT;
        public void getDEVREGISLIT(DEVREGISLIT tmp)           // tham chieu tu DEVREGISLIT
        {
            parentDEVREGISLIT = tmp;
        }

        private void but_Find_Click(object sender, EventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (apptype.Equals("DEVREGISMORE"))
            {   // tra ve ket qua cho DEVREGISMORE voi danh sach Type, attribute, va So luong
                DEVREGISMORE frmREGISMORE = new DEVREGISMORE();
                frmREGISMORE.setType("THE TYPE HERE");
                frmREGISMORE.setAtt("THE ATT HERE");
                frmREGISMORE.setQuantity("20");
                frmREGISMORE.Show();
            }
            else if (apptype.Equals("DEVEDITMORE"))
            {   // tra ve ket qua cho DEVEDITMORE voi danh sach Type va so luong
                DEVEDITMORE frmEDITMORE = new DEVEDITMORE();
                frmEDITMORE.setType("THE TYPE HERE");
                frmEDITMORE.setQuantity("20");
                frmEDITMORE.Show(); 
            }
            else if (apptype.Equals("DEVEDITLIT"))          
            {   // tra ve ket qua cho DEVEDITLIT voi danh sach Type
                parentDEVEDITLIT.setType("THE TYPE HERE");
            }
            else if (apptype.Equals("DEVREGISLIT"))
            {   // tra ve ket qua cho DEVREGISLIT voi danh sach Type va Attribute
                parentDEVREGISLIT.setType("THE TYPE HERE");
                parentDEVREGISLIT.setAtt("THE ATT HERE");
            }
            this.Close();
        }
    }
}
