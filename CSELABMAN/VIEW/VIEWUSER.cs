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
    public partial class VIEWUSER : Form
    {
        public VIEWUSER()
        {
            InitializeComponent();
        }

        USERREGIS frmREGIS ;
        USEREDIT frmEDIT ;
        bool openUSERREGIS = false;
        bool openUSEREDIT = false;

        #region Local Methods
        public void RegisClosing(string apptype)
        { // nhan tin hieu tat tu form CON : USERREGIS
            if (apptype.Equals("USERREGIS"))
                openUSERREGIS = false;
            if (apptype.Equals("USEREDIT"))
                openUSEREDIT = false;
        }

        private void VIEWUSER_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn thật sự muốn tắt ứng dụng?", "QUẢN LÝ NGƯỜI DÙNG", MessageBoxButtons.AbortRetryIgnore);
                if (result == DialogResult.Abort)       // neu muon tat thi tat luon ca form CON
                {
                    e.Cancel = false;
                    if (openUSERREGIS)
                        frmREGIS.exit();
                    if (openUSEREDIT)
                        frmEDIT.exit();
                }
                else if (result == DialogResult.Retry)
                {                                               // Gui yeu cau tat form CON truoc khi tat form
                    if (!openUSERREGIS && !openUSEREDIT)     // neu form USERREGIS va USEREDIT da tat thi tat form nay
                        e.Cancel = false;
                    else
                    {
                        e.Cancel = true;
                        if (openUSERREGIS)
                            frmREGIS.requesttoclose();
                        if (openUSEREDIT)
                            frmEDIT.requesttoclose();
                        if (!openUSERREGIS && !openUSEREDIT)     // neu form USERREGIS va USEREDIT da tat thi tat form nay
                            e.Cancel = false;
                    }
                    
                    //else Console.WriteLine("Cannot Close USERREGIS!");             
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
            if (!openUSERREGIS)
            {
                frmREGIS = new USERREGIS();
                openUSERREGIS = true;
                frmREGIS.setVIEWUSER(this);
                frmREGIS.Show();
            }
            else
                MessageBox.Show(this,"\"ĐĂNG KÝ NGƯỜI DÙNG\" vẫn còn mở!","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void button_EDIT_Click(object sender, EventArgs e)
        {
            if (!openUSEREDIT)
            {
                frmEDIT = new USEREDIT();
                openUSEREDIT = true;
                frmEDIT.setVIEWUSER(this);
                frmEDIT.Show();
            }
            else
                MessageBox.Show(this, "\"SỬA MÃ THẺ NGƯỜI DÙNG\" vẫn còn mở!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion Button Clicks
    }
}
