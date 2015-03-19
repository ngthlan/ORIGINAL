namespace CSELABMAN.VIEW
{
    partial class MANRETURN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.group_STT = new System.Windows.Forms.GroupBox();
            this.textBox_sttCOM = new System.Windows.Forms.TextBox();
            this.label_sttServer = new System.Windows.Forms.Label();
            this.richtex_sttServer = new System.Windows.Forms.RichTextBox();
            this.label_sttCOM = new System.Windows.Forms.Label();
            this.group_SETTINGS = new System.Windows.Forms.GroupBox();
            this.but_OpenPort = new System.Windows.Forms.Button();
            this.cmB_Parity = new System.Windows.Forms.ComboBox();
            this.label_Parity = new System.Windows.Forms.Label();
            this.cmB_Baud = new System.Windows.Forms.ComboBox();
            this.label_Baud = new System.Windows.Forms.Label();
            this.cmB_COMport = new System.Windows.Forms.ComboBox();
            this.label_COMport = new System.Windows.Forms.Label();
            this.label_RFIDUser = new System.Windows.Forms.Label();
            this.label_UserName = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.groupBox_USER = new System.Windows.Forms.GroupBox();
            this.but_checkUSER = new System.Windows.Forms.Button();
            this.textBox_RFIDUser = new System.Windows.Forms.TextBox();
            this.groupBox_DEV = new System.Windows.Forms.GroupBox();
            this.textBox_RFIDDEV = new System.Windows.Forms.TextBox();
            this.textBox_DEVName = new System.Windows.Forms.TextBox();
            this.label_DEVName = new System.Windows.Forms.Label();
            this.label_RFIDDEV = new System.Windows.Forms.Label();
            this.checkBox_RFID = new System.Windows.Forms.CheckBox();
            this.checkBox_User = new System.Windows.Forms.CheckBox();
            this.button_Return = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.serialPortRFID = new System.IO.Ports.SerialPort(this.components);
            this.button_ScanCOM = new System.Windows.Forms.Button();
            this.group_STT.SuspendLayout();
            this.group_SETTINGS.SuspendLayout();
            this.groupBox_USER.SuspendLayout();
            this.groupBox_DEV.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.Location = new System.Drawing.Point(0, 0);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(121, 21);
            this.cmbStopBits.TabIndex = 0;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.Location = new System.Drawing.Point(0, 0);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(121, 21);
            this.cmbDataBits.TabIndex = 0;
            // 
            // group_STT
            // 
            this.group_STT.Controls.Add(this.textBox_sttCOM);
            this.group_STT.Controls.Add(this.label_sttServer);
            this.group_STT.Controls.Add(this.richtex_sttServer);
            this.group_STT.Controls.Add(this.label_sttCOM);
            this.group_STT.Location = new System.Drawing.Point(210, 143);
            this.group_STT.Name = "group_STT";
            this.group_STT.Size = new System.Drawing.Size(197, 133);
            this.group_STT.TabIndex = 37;
            this.group_STT.TabStop = false;
            this.group_STT.Text = "TRẠNG THÁI PHẢN HỒI";
            // 
            // textBox_sttCOM
            // 
            this.textBox_sttCOM.Location = new System.Drawing.Point(66, 18);
            this.textBox_sttCOM.Name = "textBox_sttCOM";
            this.textBox_sttCOM.ReadOnly = true;
            this.textBox_sttCOM.Size = new System.Drawing.Size(106, 20);
            this.textBox_sttCOM.TabIndex = 25;
            // 
            // label_sttServer
            // 
            this.label_sttServer.AutoSize = true;
            this.label_sttServer.Location = new System.Drawing.Point(6, 64);
            this.label_sttServer.Name = "label_sttServer";
            this.label_sttServer.Size = new System.Drawing.Size(38, 13);
            this.label_sttServer.TabIndex = 21;
            this.label_sttServer.Text = "Server";
            // 
            // richtex_sttServer
            // 
            this.richtex_sttServer.Location = new System.Drawing.Point(48, 46);
            this.richtex_sttServer.Name = "richtex_sttServer";
            this.richtex_sttServer.ReadOnly = true;
            this.richtex_sttServer.Size = new System.Drawing.Size(135, 74);
            this.richtex_sttServer.TabIndex = 22;
            this.richtex_sttServer.Text = "";
            // 
            // label_sttCOM
            // 
            this.label_sttCOM.AutoSize = true;
            this.label_sttCOM.Location = new System.Drawing.Point(12, 21);
            this.label_sttCOM.Name = "label_sttCOM";
            this.label_sttCOM.Size = new System.Drawing.Size(31, 13);
            this.label_sttCOM.TabIndex = 21;
            this.label_sttCOM.Text = "COM";
            // 
            // group_SETTINGS
            // 
            this.group_SETTINGS.Controls.Add(this.button_ScanCOM);
            this.group_SETTINGS.Controls.Add(this.but_OpenPort);
            this.group_SETTINGS.Controls.Add(this.cmB_Parity);
            this.group_SETTINGS.Controls.Add(this.label_Parity);
            this.group_SETTINGS.Controls.Add(this.cmB_Baud);
            this.group_SETTINGS.Controls.Add(this.label_Baud);
            this.group_SETTINGS.Controls.Add(this.cmB_COMport);
            this.group_SETTINGS.Controls.Add(this.label_COMport);
            this.group_SETTINGS.Location = new System.Drawing.Point(209, 12);
            this.group_SETTINGS.Name = "group_SETTINGS";
            this.group_SETTINGS.Size = new System.Drawing.Size(198, 125);
            this.group_SETTINGS.TabIndex = 36;
            this.group_SETTINGS.TabStop = false;
            this.group_SETTINGS.Text = "THIẾT LẬP CỔNG COM";
            // 
            // but_OpenPort
            // 
            this.but_OpenPort.Location = new System.Drawing.Point(102, 97);
            this.but_OpenPort.Name = "but_OpenPort";
            this.but_OpenPort.Size = new System.Drawing.Size(71, 22);
            this.but_OpenPort.TabIndex = 26;
            this.but_OpenPort.Text = "Open Port";
            this.but_OpenPort.UseVisualStyleBackColor = true;
            this.but_OpenPort.Click += new System.EventHandler(this.but_OpenPort_Click);
            // 
            // cmB_Parity
            // 
            this.cmB_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_Parity.FormattingEnabled = true;
            this.cmB_Parity.Location = new System.Drawing.Point(85, 71);
            this.cmB_Parity.Name = "cmB_Parity";
            this.cmB_Parity.Size = new System.Drawing.Size(92, 21);
            this.cmB_Parity.TabIndex = 3;
            // 
            // label_Parity
            // 
            this.label_Parity.AutoSize = true;
            this.label_Parity.Location = new System.Drawing.Point(22, 75);
            this.label_Parity.Name = "label_Parity";
            this.label_Parity.Size = new System.Drawing.Size(33, 13);
            this.label_Parity.TabIndex = 7;
            this.label_Parity.Text = "Parity";
            // 
            // cmB_Baud
            // 
            this.cmB_Baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_Baud.FormattingEnabled = true;
            this.cmB_Baud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115000"});
            this.cmB_Baud.Location = new System.Drawing.Point(85, 45);
            this.cmB_Baud.Name = "cmB_Baud";
            this.cmB_Baud.Size = new System.Drawing.Size(92, 21);
            this.cmB_Baud.TabIndex = 11;
            // 
            // label_Baud
            // 
            this.label_Baud.AutoSize = true;
            this.label_Baud.Location = new System.Drawing.Point(22, 48);
            this.label_Baud.Name = "label_Baud";
            this.label_Baud.Size = new System.Drawing.Size(32, 13);
            this.label_Baud.TabIndex = 5;
            this.label_Baud.Text = "Baud";
            // 
            // cmB_COMport
            // 
            this.cmB_COMport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_COMport.FormattingEnabled = true;
            this.cmB_COMport.Location = new System.Drawing.Point(85, 19);
            this.cmB_COMport.Name = "cmB_COMport";
            this.cmB_COMport.Size = new System.Drawing.Size(92, 21);
            this.cmB_COMport.TabIndex = 4;
            // 
            // label_COMport
            // 
            this.label_COMport.AutoSize = true;
            this.label_COMport.Location = new System.Drawing.Point(22, 21);
            this.label_COMport.Name = "label_COMport";
            this.label_COMport.Size = new System.Drawing.Size(49, 13);
            this.label_COMport.TabIndex = 1;
            this.label_COMport.Text = "COMport";
            // 
            // label_RFIDUser
            // 
            this.label_RFIDUser.AutoSize = true;
            this.label_RFIDUser.Location = new System.Drawing.Point(22, 23);
            this.label_RFIDUser.Name = "label_RFIDUser";
            this.label_RFIDUser.Size = new System.Drawing.Size(32, 13);
            this.label_RFIDUser.TabIndex = 37;
            this.label_RFIDUser.Text = "RFID";
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(19, 53);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(57, 13);
            this.label_UserName.TabIndex = 42;
            this.label_UserName.Text = "UserName";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(95, 50);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(82, 20);
            this.textBox_UserName.TabIndex = 43;
            // 
            // groupBox_USER
            // 
            this.groupBox_USER.Controls.Add(this.but_checkUSER);
            this.groupBox_USER.Controls.Add(this.textBox_RFIDUser);
            this.groupBox_USER.Controls.Add(this.textBox_UserName);
            this.groupBox_USER.Controls.Add(this.label_UserName);
            this.groupBox_USER.Controls.Add(this.label_RFIDUser);
            this.groupBox_USER.Location = new System.Drawing.Point(12, 12);
            this.groupBox_USER.Name = "groupBox_USER";
            this.groupBox_USER.Size = new System.Drawing.Size(191, 104);
            this.groupBox_USER.TabIndex = 38;
            this.groupBox_USER.TabStop = false;
            this.groupBox_USER.Text = "THÔNG TIN NGƯỜI DÙNG";
            // 
            // but_checkUSER
            // 
            this.but_checkUSER.Location = new System.Drawing.Point(60, 76);
            this.but_checkUSER.Name = "but_checkUSER";
            this.but_checkUSER.Size = new System.Drawing.Size(117, 22);
            this.but_checkUSER.TabIndex = 45;
            this.but_checkUSER.Text = "Xác thực người dùng";
            this.but_checkUSER.UseVisualStyleBackColor = true;
            this.but_checkUSER.Click += new System.EventHandler(this.but_checkUSER_Click);
            // 
            // textBox_RFIDUser
            // 
            this.textBox_RFIDUser.Location = new System.Drawing.Point(95, 18);
            this.textBox_RFIDUser.Name = "textBox_RFIDUser";
            this.textBox_RFIDUser.Size = new System.Drawing.Size(82, 20);
            this.textBox_RFIDUser.TabIndex = 44;
            // 
            // groupBox_DEV
            // 
            this.groupBox_DEV.Controls.Add(this.textBox_RFIDDEV);
            this.groupBox_DEV.Controls.Add(this.textBox_DEVName);
            this.groupBox_DEV.Controls.Add(this.label_DEVName);
            this.groupBox_DEV.Controls.Add(this.label_RFIDDEV);
            this.groupBox_DEV.Location = new System.Drawing.Point(12, 122);
            this.groupBox_DEV.Name = "groupBox_DEV";
            this.groupBox_DEV.Size = new System.Drawing.Size(191, 83);
            this.groupBox_DEV.TabIndex = 46;
            this.groupBox_DEV.TabStop = false;
            this.groupBox_DEV.Text = "THÔNG TIN THIẾT BỊ";
            // 
            // textBox_RFIDDEV
            // 
            this.textBox_RFIDDEV.Location = new System.Drawing.Point(95, 18);
            this.textBox_RFIDDEV.Name = "textBox_RFIDDEV";
            this.textBox_RFIDDEV.Size = new System.Drawing.Size(82, 20);
            this.textBox_RFIDDEV.TabIndex = 44;
            // 
            // textBox_DEVName
            // 
            this.textBox_DEVName.Location = new System.Drawing.Point(95, 50);
            this.textBox_DEVName.Name = "textBox_DEVName";
            this.textBox_DEVName.Size = new System.Drawing.Size(82, 20);
            this.textBox_DEVName.TabIndex = 43;
            // 
            // label_DEVName
            // 
            this.label_DEVName.AutoSize = true;
            this.label_DEVName.Location = new System.Drawing.Point(17, 53);
            this.label_DEVName.Name = "label_DEVName";
            this.label_DEVName.Size = new System.Drawing.Size(72, 13);
            this.label_DEVName.TabIndex = 42;
            this.label_DEVName.Text = "Device Name";
            // 
            // label_RFIDDEV
            // 
            this.label_RFIDDEV.AutoSize = true;
            this.label_RFIDDEV.Location = new System.Drawing.Point(22, 23);
            this.label_RFIDDEV.Name = "label_RFIDDEV";
            this.label_RFIDDEV.Size = new System.Drawing.Size(32, 13);
            this.label_RFIDDEV.TabIndex = 37;
            this.label_RFIDDEV.Text = "RFID";
            // 
            // checkBox_RFID
            // 
            this.checkBox_RFID.AutoSize = true;
            this.checkBox_RFID.Checked = true;
            this.checkBox_RFID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RFID.Location = new System.Drawing.Point(37, 211);
            this.checkBox_RFID.Name = "checkBox_RFID";
            this.checkBox_RFID.Size = new System.Drawing.Size(51, 17);
            this.checkBox_RFID.TabIndex = 47;
            this.checkBox_RFID.Text = "RFID";
            this.checkBox_RFID.UseVisualStyleBackColor = true;
            this.checkBox_RFID.CheckedChanged += new System.EventHandler(this.checkBox_RFID_CheckedChanged);
            // 
            // checkBox_User
            // 
            this.checkBox_User.AutoSize = true;
            this.checkBox_User.Checked = true;
            this.checkBox_User.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_User.Location = new System.Drawing.Point(124, 211);
            this.checkBox_User.Name = "checkBox_User";
            this.checkBox_User.Size = new System.Drawing.Size(48, 17);
            this.checkBox_User.TabIndex = 48;
            this.checkBox_User.Text = "User";
            this.checkBox_User.UseVisualStyleBackColor = true;
            this.checkBox_User.CheckedChanged += new System.EventHandler(this.checkBox_User_CheckedChanged);
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(16, 241);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(72, 22);
            this.button_Return.TabIndex = 49;
            this.button_Return.Text = "Trả thiết bị";
            this.button_Return.UseVisualStyleBackColor = true;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(107, 241);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(96, 22);
            this.button_OK.TabIndex = 51;
            this.button_OK.Text = "ĐÓNG PHIÊN";
            this.button_OK.UseVisualStyleBackColor = true;
            // 
            // serialPortRFID
            // 
            this.serialPortRFID.PortName = "COM4";
            this.serialPortRFID.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortRFID_DataReceived);
            // 
            // button_ScanCOM
            // 
            this.button_ScanCOM.Location = new System.Drawing.Point(25, 98);
            this.button_ScanCOM.Name = "button_ScanCOM";
            this.button_ScanCOM.Size = new System.Drawing.Size(58, 22);
            this.button_ScanCOM.TabIndex = 57;
            this.button_ScanCOM.Text = "Scan";
            this.button_ScanCOM.UseVisualStyleBackColor = true;
            this.button_ScanCOM.Click += new System.EventHandler(this.button_ScanCOM_Click);
            // 
            // MANRETURN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 288);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.checkBox_User);
            this.Controls.Add(this.checkBox_RFID);
            this.Controls.Add(this.groupBox_DEV);
            this.Controls.Add(this.groupBox_USER);
            this.Controls.Add(this.group_STT);
            this.Controls.Add(this.group_SETTINGS);
            this.Name = "MANRETURN";
            this.Text = "TRẢ THIẾT BỊ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MANRETURN_FormClosing);
            this.group_STT.ResumeLayout(false);
            this.group_STT.PerformLayout();
            this.group_SETTINGS.ResumeLayout(false);
            this.group_SETTINGS.PerformLayout();
            this.groupBox_USER.ResumeLayout(false);
            this.groupBox_USER.PerformLayout();
            this.groupBox_DEV.ResumeLayout(false);
            this.groupBox_DEV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.GroupBox group_STT;
        private System.Windows.Forms.TextBox textBox_sttCOM;
        private System.Windows.Forms.Label label_sttServer;
        private System.Windows.Forms.RichTextBox richtex_sttServer;
        private System.Windows.Forms.Label label_sttCOM;
        private System.Windows.Forms.GroupBox group_SETTINGS;
        private System.Windows.Forms.ComboBox cmB_Parity;
        private System.Windows.Forms.Label label_Parity;
        private System.Windows.Forms.ComboBox cmB_Baud;
        private System.Windows.Forms.Label label_Baud;
        private System.Windows.Forms.ComboBox cmB_COMport;
        private System.Windows.Forms.Label label_COMport;
        private System.Windows.Forms.Label label_RFIDUser;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.GroupBox groupBox_USER;
        private System.Windows.Forms.TextBox textBox_RFIDUser;
        private System.Windows.Forms.Button but_checkUSER;
        private System.Windows.Forms.Button but_OpenPort;
        private System.Windows.Forms.GroupBox groupBox_DEV;
        private System.Windows.Forms.TextBox textBox_RFIDDEV;
        private System.Windows.Forms.TextBox textBox_DEVName;
        private System.Windows.Forms.Label label_DEVName;
        private System.Windows.Forms.Label label_RFIDDEV;
        private System.Windows.Forms.CheckBox checkBox_RFID;
        private System.Windows.Forms.CheckBox checkBox_User;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Button button_OK;
        private System.IO.Ports.SerialPort serialPortRFID;
        private System.Windows.Forms.Button button_ScanCOM;
    }
}