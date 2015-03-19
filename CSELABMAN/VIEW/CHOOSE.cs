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
            /*if (apptype.Equals("DEVREGISLIT") || apptype.Equals("DEVEDITLIT"))
            {
                textBox_Need.Enabled = false;
                textBox_Available.Enabled = false;
                comboBox_att.Enabled = false;
            }*/
            if (apptype.Equals("DEVREGISMORE"))
            {
                //comboBox_att.Enabled = false;
                textBox_FORM.Text = "ĐĂNG KÝ MÃ THẺ NHIỀU THIẾT BỊ";
            }
            else if (apptype.Equals("DEVEDITMORE"))
            { 
                //comboBox_att.Enabled = false;
                textBox_FORM.Text = "SỬA MÃ THẺ NHIỀU THIẾT BỊ";
            }
            
        }

        DEVREGISMORE frmREGISMORE;
        DEVEDITMORE frmEDITMORE;
        bool openDEVREGISMORE = false;
        bool openDEVEDITMORE = false;

        public VIEWDEV parentVIEWDEV;                   // tham chieu tu form CHA
        public void setVIEWDEV(VIEWDEV tmp)
        {
            parentVIEWDEV = tmp;
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

        #region Local Methods

        public void exit(string apptype, ref bool newstt)
        {
            if (apptype.Equals("DEVREGISMORE") && openDEVREGISMORE)
            {
                newstt = false;
                this.Close();
            }
            else if (apptype.Equals("DEVEDITMORE") && openDEVEDITMORE)
            {
                newstt = false;
                this.Close();
            }
        }

        public void requesttoclose(string apptype, ref bool newstt)
        {   // lay tin hieu tat tu form CHA : neu dung thi tat, khong dung thi van mo 

            if (apptype.Equals("DEVREGISMORE") && !openDEVREGISMORE)
            {
                DialogResult result = MessageBox.Show("Bạn thật sự muốn tắt ứng dụng?", "CHỌN ĐĂNG KÝ THẺ NHIỀU THIẾT BỊ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    newstt = false;
                    this.Close();
                }
            }
            else if (apptype.Equals("DEVEDITMORE") && !openDEVEDITMORE)
            {
                DialogResult result = MessageBox.Show("Bạn thật sự muốn tắt ứng dụng?", "CHỌN SỬA MÃ THẺ NHIỀU THIẾT BỊ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    newstt = false;
                    this.Close();
                }
            }
        }

        private void CHOOSE_FormClosing(object sender, FormClosingEventArgs e)
        {   // truoc khi tat gui tin hieu ve form CHA
          //if (!openDEVEDITMORE && !openDEVREGISMORE)
            if (apptype.Equals("DEVREGISMORE"))
            {
                parentVIEWDEV.ClosingCHOOSE("chooseREGIS", false);
            }
            else if (apptype.Equals("DEVEDITMORE"))
            {
                parentVIEWDEV.ClosingCHOOSE("chooseEDIT", false);
            }
        }
        
        #endregion Local Methods

        #region Button Clicks
        private void but_Find_Click(object sender, EventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (apptype.Equals("DEVREGISMORE"))
            {   // tra ve ket qua cho DEVREGISMORE voi danh sach Type, attribute, va So luong
                    openDEVEDITMORE = true;
                    frmREGISMORE = new DEVREGISMORE();
                    frmREGISMORE.setVIEWDEV(parentVIEWDEV);
                    frmREGISMORE.setType("OLD TYPE");
                    frmREGISMORE.setAtt("OLD ATT");
                    frmREGISMORE.setQuantity("20");
                    parentVIEWDEV.receiveDEVREGISMORE(frmREGISMORE,true);
                    frmREGISMORE.Show();
            }
            else if (apptype.Equals("DEVEDITMORE"))
            {   // tra ve ket qua cho DEVEDITMORE voi danh sach Type va so luong
                    frmEDITMORE = new DEVEDITMORE();
                    openDEVEDITMORE = true;
                    frmEDITMORE.setType("OLD TYPE");
                    frmEDITMORE.setATT("OLD ATT");
                    frmEDITMORE.setQuantity("20");
                    frmEDITMORE.setVIEWDEV(parentVIEWDEV);
                    parentVIEWDEV.receiveDEVEDITMORE(frmEDITMORE, true);
                    frmEDITMORE.Show();
            }
            else if (apptype.Equals("DEVEDITLIT"))          
            {   // tra ve ket qua cho DEVEDITLIT voi danh sach Type
                //parentDEVEDITLIT.setType("THE TYPE HERE");
            }
            else if (apptype.Equals("DEVREGISLIT"))
            {   // tra ve ket qua cho DEVREGISLIT voi danh sach Type va Attribute
                //parentDEVREGISLIT.setType("THE TYPE HERE");
                //parentDEVREGISLIT.setAtt("THE ATT HERE");
            }
            this.Close();
        }
        #endregion Button Clicks
    }
}
