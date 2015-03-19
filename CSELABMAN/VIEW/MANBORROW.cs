﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace CSELABMAN.VIEW
{
    public partial class MANBORROW : Form
    {
        CONTROL.Services services = new CONTROL.Services();                     // dich vu ho tro
        public string resFirst = null;
        TextBox textboxtmp = new TextBox();

        public bool errReadFile = false;                        // kiem tra loi doc file
        public bool errWriteFile = false;                       // kiem ta loi ghi file
        public string responseReadFile = null;                  // phan hoi sau khi doc file
        public string responseWriteFile = null;                 // phan hoi sau khi ghi file
        public bool ckcadd = false;
        public bool ckchash = false;
        public bool errorCOM = false;      //kiem tra cong COM ngat bat thuong hay khong
        public bool errorCONN = false;     //kiem tra cong COM co bi chiem giu hay khong
        private CSELABMAN.Properties.Settings settings = CSELABMAN.Properties.Settings.Default;
        bool exist;

        public MANBORROW()
        {
            InitializeComponent();
            textBox_UserName.Enabled = false;
            textBox_DEVName.Enabled = false;
            textBox_RFIDDEV.Enabled = false;
            services.Local.InitializeControlValues(ref settings, ref cmB_COMport, ref cmB_Baud, ref cmB_Parity,
                                                    ref cmbDataBits, ref cmbStopBits, ref serialPortRFID,
                                                    ref errorCOM, ref errorCONN, ref resFirst, ref exist);
            textBox_RFIDUser.ReadOnly = true;
            textBox_RFIDUser.TextAlign = HorizontalAlignment.Center;
            textBox_RFIDDEV.ReadOnly = true;
            textBox_RFIDDEV.TextAlign = HorizontalAlignment.Center;
        }

        public const int maxlength = 7;
        private string txt_S;
        public string txt_D = "";
        //private string temp = "";
        public char[] temp = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        //private int num_temp;
        public string errorWEB;
        public bool errorW = false;
        public string res2, sttdes;

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
            DialogResult result = MessageBox.Show("Bạn thật sự muốn tắt ứng dụng?", "MƯỢN THIẾT BỊ", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                parentVIEWMAN.RegisClosing("MANBORROW");
                this.Close();
            }
        }

        private void MANBORROW_FormClosing(object sender, FormClosingEventArgs e)
        {   // truoc khi tat gui tin hieu ve form CHA
            parentVIEWMAN.RegisClosing("MANBORROW");
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            CONTROL.Services services = new CONTROL.Services();
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.

            if (this.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                byte[] buffer = new byte[serialPortRFID.BytesToRead];
                serialPortRFID.Read(buffer, 0, buffer.Length);
                txt_S = services.Local.ByteArrayToHexString(buffer);
                txt_S.CopyTo(3, temp, 0, 10 + 4);
                //Console.WriteLine("temp is : "+temp);
                txt_D = services.Local.CharArrayToString(temp);
                //Console.WriteLine("RFID is : " + txt_D);
                textboxtmp.Text = txt_D;
                textBox_RFIDUser.Text = textboxtmp.Text;
                textBox_RFIDDEV.Text = textboxtmp.Text;

                if (txt_S.Length > maxlength)
                {
                    txt_S = "";
                    txt_D = "";
                    buffer = new byte[14];
                }
                /*string mydocpath = @"C:\USERs\Public\Documents\";
                string mypath = mydocpath + @"CSELAB.txt";
                services.Local.writetofile(textBox_RFID.Text, mypath);*/

            }
        }

        #endregion Local Methods

        #region Events
        private void serialPortRFID_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPortRFID.BytesToRead >= maxlength)
                SetText("");
        }
        #endregion Events

        #region Button Clicks
        private void but_checkUSER_Click(object sender, EventArgs e)
        {

        }

        private void but_OpenPort_Click(object sender, EventArgs e)
        {
            // Change the state of the form's controls
            // If the port is open, send focus to the send data box
            string response = null;
            exist = false;
            int sttcode = 0;
            services.Local.openCOMport(ref settings, ref cmB_COMport, ref cmB_Baud, ref cmB_Parity,
                                       ref cmbDataBits, ref cmbStopBits,
                                       ref serialPortRFID, ref textboxtmp,
                                       ref errorCOM, ref errorCONN,
                                       ref response, but_OpenPort,
                                       ref txt_S, ref sttcode, ref exist);
            textBox_sttCOM.Text = response;
            switch (sttcode)
            {
                case 1:                // bi loi mat ket noi COM khi khong con port hien co
                    MessageBox.Show(this, "Vui lòng gắn thiết bị!", "LỖI THIẾT BỊ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case 2:                // bi loi trung COM
                    MessageBox.Show(this, "Không thể mở cổng COM đã chọn khi bị chiếm giữ bởi thiết bị khác!", "LỖI KẾT NỐI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 3:                // bi loi chua chon du cac thong tin cai dat cho COM
                    MessageBox.Show(this, "Vui lòng thiết lập các thông số còn thiếu", "THIẾU THÔNG SỐ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case 4:                // bi loi mat ket noi COM
                    MessageBox.Show(this, "Không thể mở cổng COM vì mất kết nối với thiết bị", "LỖI KẾT NỐI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case 5:                // bi loi khac
                    MessageBox.Show(this, "Không thể mở cổng COM. \n Có thể cổng COM bị chiếm giữ, hoặc được gỡ bỏ, hoặc chưa sẵn sàng.", "LỖI KHÔNG THỂ XÁC ĐỊNH", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                default:
                    break;
            }
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

        private void button_ScanCOM_Click(object sender, EventArgs e)
        {
            exist = true;
            serialPortRFID.Close();
            cmB_COMport.Items.Clear();
            cmB_Baud.Items.Clear();
            cmB_Parity.Items.Clear();
            cmB_COMport.Items.AddRange(new Object[] { " " });
            cmB_Baud.Items.AddRange(new Object[] { " " });
            cmB_Parity.Items.AddRange(new Object[] { " " });
            but_OpenPort.Text = "Open port";
            services.Local.InitializeControlValues(ref settings, ref cmB_COMport, ref cmB_Baud, ref cmB_Parity,
                                                    ref cmbDataBits, ref cmbStopBits, ref serialPortRFID,
                                                    ref errorCOM, ref errorCONN, ref resFirst, ref exist);
            textBox_sttCOM.Text = resFirst;
        }

        #endregion Button Clicks

    }
}
