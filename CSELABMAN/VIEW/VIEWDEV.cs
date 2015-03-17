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

        #region Local Methods

        private void VIEWDEV_FormClosing(object sender, FormClosingEventArgs e)
        { 
            
        }
        #endregion Local Methods

        #region Button Clicks
        private void button_REGIS_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Đăng ký nhiều thẻ thiết bị mới ?", "ĐĂNG KÝ THẺ THIẾT BỊ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                //MessageBox.Show(this, "Function is under construction!", "Đăng ký nhiều thiết bị", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CHOOSE frmchoose = new CHOOSE("DEVREGISMORE");
                frmchoose.Show();
            }
            else
            {
                //MessageBox.Show(this, "Function is under construction!", "Đăng ký ít thiết bị", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DEVREGISLIT frmREGISLIT = new DEVREGISLIT();
                frmREGISLIT.Show();
            }
        }

        private void button_EDIT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this,"Sửa mã thẻ của nhiều thiết bị ?","SỬA MÃ THẺ THIẾT BỊ",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                CHOOSE frmchoose = new CHOOSE("DEVEDITMORE");
                frmchoose.Show();
            }
            else
            {
                //MessageBox.Show(this, "Function is under construction!", "Sửa mã thẻ thiết bị", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DEVEDITLIT frmEDITLIT = new DEVEDITLIT();
                frmEDITLIT.Show();
            }
        }
        #endregion Button Clicks
    }
}
