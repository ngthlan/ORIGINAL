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
    public partial class MANRETURN : Form
    {
        public MANRETURN()
        {
            InitializeComponent();
            textBox_UserName.Enabled = false;
            textBox_DEVName.Enabled = false;
            textBox_RFIDDEV.Enabled = false;
        }

        private VIEWMAN parentVIEWMAN;                   // tham chieu tu form CHA
        public void setVIEWMAN(VIEWMAN tmp)
        {
            parentVIEWMAN = tmp;
        }

        #region Local Methods
        public void exit()
        {
            this.Close();
        }

        public void requesttoclose()
        {   // lay tin hieu tat tu form CHA : neu dung thi tat, khong dung thi van mo 
            DialogResult result = MessageBox.Show("Bạn thật sự muốn tắt ứng dụng?", "TRẢ THIẾT BỊ", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                parentVIEWMAN.RegisClosing("MANRETURN");
                this.Close();
            }
        }

        #endregion Local Methods

        #region Button Clicks
        private void but_checkUSER_Click(object sender, EventArgs e)
        {

        }

        private void but_OpenPort_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_RFID_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_RFID.Checked)
            {
                if (checkBox_User.Checked)
                {
                    textBox_RFIDUser.Enabled = true;
                    textBox_RFIDDEV.Enabled = false;
                    textBox_UserName.Enabled = false;
                    textBox_DEVName.Enabled = false;
                }
                else
                {
                    textBox_RFIDUser.Enabled = false;
                    textBox_RFIDDEV.Enabled = true;
                    textBox_UserName.Enabled = false;
                    textBox_DEVName.Enabled = false;
                }
            }
            else
            {
                if (checkBox_User.Checked)
                {
                    textBox_RFIDUser.Enabled = false;
                    textBox_RFIDDEV.Enabled = false;
                    textBox_UserName.Enabled = true;
                    textBox_DEVName.Enabled = false;
                }
                else
                {
                    textBox_RFIDUser.Enabled = false;
                    textBox_RFIDDEV.Enabled = false;
                    textBox_UserName.Enabled = false;
                    textBox_DEVName.Enabled = true;
                }
            }
        }

        private void checkBox_User_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_User.Checked)
            {
                if (checkBox_RFID.Checked)
                {
                    textBox_RFIDUser.Enabled = true;
                    textBox_RFIDDEV.Enabled = false;
                    textBox_UserName.Enabled = false;
                    textBox_DEVName.Enabled = false;
                }
                else
                {
                    textBox_RFIDUser.Enabled = false;
                    textBox_RFIDDEV.Enabled = false;
                    textBox_UserName.Enabled = true;
                    textBox_DEVName.Enabled = false;
                }
            }
            else
            {
                if (checkBox_RFID.Checked)
                {
                    textBox_RFIDUser.Enabled = false;
                    textBox_RFIDDEV.Enabled = true;
                    textBox_UserName.Enabled = false;
                    textBox_DEVName.Enabled = false;
                }
                else
                {
                    textBox_RFIDUser.Enabled = false;
                    textBox_RFIDDEV.Enabled = false;
                    textBox_UserName.Enabled = false;
                    textBox_DEVName.Enabled = true;
                }
            }
        }
        #endregion Button Clicks
    }
}
