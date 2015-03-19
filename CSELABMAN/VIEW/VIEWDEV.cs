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
    public partial class VIEWDEV : Form
    {
        public VIEWDEV()
        {
            InitializeComponent();
        }

        CHOOSE frmchoose;
        DEVREGISLIT frmREGISLIT;
        DEVEDITLIT frmEDITLIT;
        DEVREGISMORE frmREGISMORE;
        DEVEDITMORE frmEDITMORE;
        bool openDEVREGISMORE = false;
        bool openDEVREGISLIT = false;
        bool openDEVEDITMORE = false;
        bool openDEVEDITLIT = false;
        bool chooseREGISMORE = false;
        bool chooseEDITMORE = false;

        
        #region Local Methods
        public void RegisClosing(string apptype, bool newstt)
        { // nhan tin hieu tat tu form CON : USERREGIS
            if (apptype.Equals("DEVREGISMORE"))
            {
                openDEVREGISMORE = newstt;
                if (!newstt)
                    frmREGISMORE = null;
            }
            else if (apptype.Equals("DEVREGISLIT"))
                openDEVREGISLIT = newstt;
            else if (apptype.Equals("DEVEDITMORE"))
            {
                openDEVEDITMORE = newstt;
                if (!newstt)
                    frmEDITMORE = null;
            } 
            else if (apptype.Equals("DEVEDITLIT"))
                openDEVEDITLIT = newstt;
        }

        public void ClosingCHOOSE(string apptype, bool newstt)
        {
            if (apptype.Equals("chooseREGIS"))
                chooseREGISMORE = newstt;
            else if (apptype.Equals("chooseEDIT"))
                chooseEDITMORE = newstt;
        }

        public void receiveDEVREGISMORE(DEVREGISMORE tmp, bool newstt)                    // nhan lai DEVREGISMORE tu form CHOOSE
        {
            openDEVREGISMORE = newstt;
            if (openDEVREGISMORE)                                       // neu dang mo thi nhan lai
                frmREGISMORE = tmp;
        }

        public void receiveDEVEDITMORE(DEVEDITMORE tmp, bool newstt)                    // nhan lai DEVEDITMORE tu form CHOOSE
        {
            openDEVEDITMORE = newstt;
            if (openDEVEDITMORE)                                       // neu dang mo thi nhan lai
                frmEDITMORE = tmp;
        }

        private void VIEWDEV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn thật sự muốn tắt ứng dụng?", "QUẢN LÝ THIẾT BỊ", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)       // neu muon tat thi tat luon ca form CON
                {
                    e.Cancel = false;
                    if (chooseREGISMORE)
                        frmchoose.exit("DEVREGISMORE", ref chooseREGISMORE);
                    if (chooseEDITMORE)
                        frmchoose.exit("DEVEDITMORE", ref chooseEDITMORE);
                    if (openDEVREGISLIT)
                        frmREGISLIT.exit();
                    if (openDEVEDITLIT)
                        frmEDITLIT.exit();
                    
                    if (openDEVREGISMORE)
                        frmREGISMORE.exit();
                    if (openDEVEDITMORE)
                        frmEDITMORE.exit();

                }
                else if (result == DialogResult.No)
                {                                               // Gui yeu cau tat form CON truoc khi tat form
                    // neu cac form CON ve THIET BI da tat thi tat form nay
                    if (!openDEVEDITLIT && !openDEVREGISLIT
                     && !openDEVEDITMORE && !openDEVREGISMORE
                     && !chooseREGISMORE && !chooseEDITMORE)
                        e.Cancel = false;
                    else
                    {
                        e.Cancel = true;
                        if (openDEVREGISLIT)
                            frmREGISLIT.requesttoclose();
                        if (openDEVEDITLIT)
                            frmEDITLIT.requesttoclose();
                        if (openDEVREGISMORE)
                            frmREGISMORE.requesttoclose();
                        if (openDEVEDITMORE)
                            frmEDITMORE.requesttoclose();

                        if (chooseREGISMORE)
                            frmchoose.requesttoclose("DEVREGISMORE", ref chooseREGISMORE);
                        if (chooseEDITMORE)
                            frmchoose.requesttoclose("DEVEDITMORE", ref chooseEDITMORE);

                        // neu cac form CON ve THIET BI da tat thi tat form nay
                        if (!openDEVEDITLIT && !openDEVREGISLIT 
                         && !openDEVEDITMORE && !openDEVREGISMORE
                         && !chooseREGISMORE && !chooseEDITMORE)    
                            e.Cancel = false;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        #endregion Local Methods

        #region Button Clicks
        private void button_REGIS_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Đăng ký nhiều thẻ thiết bị mới ?", "ĐĂNG KÝ THẺ THIẾT BỊ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (!openDEVREGISMORE && !chooseREGISMORE && frmREGISMORE == null)
                {
                    frmchoose = new CHOOSE("DEVREGISMORE");
                    chooseREGISMORE = true;
                    frmchoose.setVIEWDEV(this);
                    frmchoose.Show();
                }
                else
                {
                    if (openDEVREGISMORE)
                        MessageBox.Show(this, "\"ĐĂNG KÝ MÃ THẺ NHIỀU THIẾT BỊ\" vẫn còn mở!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (chooseREGISMORE)
                        MessageBox.Show(this, "\"ĐĂNG KÝ MÃ THẺ NHIỀU THIẾT BỊ\" vẫn còn mở!", "CHỌN LOẠI THIẾT BỊ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (!openDEVREGISLIT)
                {
                    frmREGISLIT = new DEVREGISLIT();
                    openDEVREGISLIT = true;
                    frmREGISLIT.setVIEWDEV(this);
                    frmREGISLIT.Show();
                }
                else
                    MessageBox.Show(this, "\"ĐĂNG KÝ THẺ THIẾT BỊ\" vẫn còn mở!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_EDIT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this,"Sửa mã thẻ của nhiều thiết bị ?","SỬA MÃ THẺ THIẾT BỊ",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {

                if (!openDEVEDITMORE && !chooseEDITMORE && frmEDITMORE == null)
                {
                    frmchoose = new CHOOSE("DEVEDITMORE");
                    chooseEDITMORE = true;
                    frmchoose.setVIEWDEV(this);
                    frmchoose.Show();
                }
                else
                {
                    if (openDEVEDITMORE)
                        MessageBox.Show(this, "\"SỬA MÃ THẺ NHIỀU THIẾT BỊ\" vẫn còn mở!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if(chooseEDITMORE)
                        MessageBox.Show(this, "\"SỬA MÃ THẺ NHIỀU THIẾT BỊ\" vẫn còn mở!", "CHỌN LOẠI THIẾT BỊ", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
                }
            }
            else
            {
                if (!openDEVEDITLIT)
                {
                    frmEDITLIT = new DEVEDITLIT();
                    openDEVEDITLIT = true;
                    frmEDITLIT.setVIEWDEV(this);
                    frmEDITLIT.Show();
                }
                else
                    MessageBox.Show(this, "\"SỬA MÃ THẺ THIẾT BỊ\" vẫn còn mở!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                frmEDITLIT.Show();
            }
        }
        #endregion Button Clicks
    }
}
