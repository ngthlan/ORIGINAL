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
    public partial class VIEWMAN : Form
    {
        public VIEWMAN()
        {
            InitializeComponent();
        }

        MANBORROW frmBORROW;
        MANRETURN frmRETURN;
        bool openMANBORROW = false;
        bool openMANRETURN = false;

        #region Local Methods
        public void RegisClosing(string apptype)
        { 
            if (apptype.Equals("MANBORROW"))                // nhan tin hieu tat tu form CON : MANBORROW
                openMANBORROW = false;
            if (apptype.Equals("MANRETURN"))                // nhan tin hieu tat tu form CON : MANRETURN
                openMANRETURN = false;
        }

        private void VIEWMAN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn thật sự muốn tắt ứng dụng?", "MƯỢN / TRẢ THIẾT BỊ", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)       // neu muon tat thi tat luon ca form CON
                {
                    e.Cancel = false;
                    if (openMANBORROW)
                        frmBORROW.exit();
                    if (openMANRETURN)
                        frmRETURN.exit();
                }
                else if (result == DialogResult.No)
                {                                               // Gui yeu cau tat form CON truoc khi tat form
                    if (!openMANBORROW && !openMANRETURN)     // neu form MANBORROW va MANRETURN da tat thi tat form nay
                        e.Cancel = false;
                    else
                    {
                        e.Cancel = true;
                        if (openMANBORROW)
                            frmBORROW.requesttoclose();
                        if (openMANRETURN)
                            frmRETURN.requesttoclose();
                        if (!openMANBORROW && !openMANRETURN)     // neu form MANBORROW va MANRETURN da tat thi tat form nay
                            e.Cancel = false;
                    }

                    //else Console.WriteLine("Cannot Close MANBORROW!");             
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
        private void button_BORROW_Click(object sender, EventArgs e)
        {
            if (!openMANBORROW)
            {
                frmBORROW = new MANBORROW();
                openMANBORROW = true;
                frmBORROW.setVIEWMAN(this);
                frmBORROW.Show();
            }
            else
                MessageBox.Show(this, "\"MƯỢN THIẾT BỊ\" vẫn còn mở!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button_RETURN_Click(object sender, EventArgs e)
        {
            if (!openMANRETURN)
            {
                frmRETURN = new MANRETURN();
                openMANRETURN = true;
                frmRETURN.setVIEWMAN(this);
                frmRETURN.Show();
            }
            else
                MessageBox.Show(this, "\"TRẢ THIẾT BỊ\" vẫn còn mở!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion Button Clicks
    }
}
