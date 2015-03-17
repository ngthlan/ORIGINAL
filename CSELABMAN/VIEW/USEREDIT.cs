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
    public partial class USEREDIT : Form
    {
        public USEREDIT()
        {
            InitializeComponent();
        }

        private VIEWUSER parentVIEWUSER;                   // tham chieu tu form CHA
        public void setVIEWUSER(VIEWUSER tmp)
        {
            parentVIEWUSER = tmp;
        }

        #region Local Methods
        public void exit()
        {
            this.Close();
        }

        public void requesttoclose()
        {   // lay tin hieu tat tu form CHA : neu dung thi tat, khong dung thi van mo 
            DialogResult result = MessageBox.Show("Bạn thật sự muốn tắt ứng dụng?", "CHỈNH SỬA NGƯỜI DÙNG", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {   // Neu Yes thi tat form nay
                parentVIEWUSER.RegisClosing("USEREDIT");
                this.Close();
            }
        }

        private void USEREDIT_FormClosing(object sender, FormClosingEventArgs e)
        {   // truoc khi tat gui tin hieu ve form CHA
            parentVIEWUSER.RegisClosing("USEREDIT");
        }

        #endregion Local Methods

        #region Button Clicks
        private void but_reset_Click(object sender, EventArgs e)
        {

        }

        private void but_OpenPort_Click(object sender, EventArgs e)
        {

        }

        private void but_Regis_Click(object sender, EventArgs e)
        {

        }

        #endregion Button Clicks
    }
}
