namespace CSELABMAN.VIEW
{
    partial class USERREGIS
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
            this.groupBox_infor = new System.Windows.Forms.GroupBox();
            this.textBox_RFID = new System.Windows.Forms.TextBox();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_FisrtName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_RFID = new System.Windows.Forms.Label();
            this.but_reset = new System.Windows.Forms.Button();
            this.group_SETTINGS = new System.Windows.Forms.GroupBox();
            this.button_ScanCOM = new System.Windows.Forms.Button();
            this.cmB_Parity = new System.Windows.Forms.ComboBox();
            this.but_OpenPort = new System.Windows.Forms.Button();
            this.label_Parity = new System.Windows.Forms.Label();
            this.cmB_Baud = new System.Windows.Forms.ComboBox();
            this.label_Baud = new System.Windows.Forms.Label();
            this.cmB_COMport = new System.Windows.Forms.ComboBox();
            this.label_COMport = new System.Windows.Forms.Label();
            this.group_STT = new System.Windows.Forms.GroupBox();
            this.textBox_sttCOM = new System.Windows.Forms.TextBox();
            this.label_sttServer = new System.Windows.Forms.Label();
            this.richtex_sttServer = new System.Windows.Forms.RichTextBox();
            this.label_sttCOM = new System.Windows.Forms.Label();
            this.but_Regis = new System.Windows.Forms.Button();
            this.serialPortRFID = new System.IO.Ports.SerialPort(this.components);
            this.groupBox_infor.SuspendLayout();
            this.group_SETTINGS.SuspendLayout();
            this.group_STT.SuspendLayout();
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
            // groupBox_infor
            // 
            this.groupBox_infor.Controls.Add(this.textBox_RFID);
            this.groupBox_infor.Controls.Add(this.textBox_UserName);
            this.groupBox_infor.Controls.Add(this.textBox_LastName);
            this.groupBox_infor.Controls.Add(this.textBox_FirstName);
            this.groupBox_infor.Controls.Add(this.textBox_password);
            this.groupBox_infor.Controls.Add(this.label_FisrtName);
            this.groupBox_infor.Controls.Add(this.label_LastName);
            this.groupBox_infor.Controls.Add(this.label_UserName);
            this.groupBox_infor.Controls.Add(this.label_Password);
            this.groupBox_infor.Controls.Add(this.label_RFID);
            this.groupBox_infor.Location = new System.Drawing.Point(12, 12);
            this.groupBox_infor.Name = "groupBox_infor";
            this.groupBox_infor.Size = new System.Drawing.Size(185, 182);
            this.groupBox_infor.TabIndex = 26;
            this.groupBox_infor.TabStop = false;
            this.groupBox_infor.Text = "THÔNG TIN NGƯỜI DÙNG";
            // 
            // textBox_RFID
            // 
            this.textBox_RFID.Location = new System.Drawing.Point(68, 144);
            this.textBox_RFID.Name = "textBox_RFID";
            this.textBox_RFID.Size = new System.Drawing.Size(106, 20);
            this.textBox_RFID.TabIndex = 24;
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(68, 83);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(106, 20);
            this.textBox_UserName.TabIndex = 23;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(68, 53);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(106, 20);
            this.textBox_LastName.TabIndex = 22;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(68, 18);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(106, 20);
            this.textBox_FirstName.TabIndex = 21;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(68, 112);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(106, 20);
            this.textBox_password.TabIndex = 20;
            // 
            // label_FisrtName
            // 
            this.label_FisrtName.AutoSize = true;
            this.label_FisrtName.Location = new System.Drawing.Point(6, 21);
            this.label_FisrtName.Name = "label_FisrtName";
            this.label_FisrtName.Size = new System.Drawing.Size(57, 13);
            this.label_FisrtName.TabIndex = 2;
            this.label_FisrtName.Text = "First Name";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(6, 55);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(58, 13);
            this.label_LastName.TabIndex = 3;
            this.label_LastName.Text = "Last Name";
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(6, 86);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(57, 13);
            this.label_UserName.TabIndex = 4;
            this.label_UserName.Text = "UserName";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(7, 115);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(53, 13);
            this.label_Password.TabIndex = 5;
            this.label_Password.Text = "Password";
            // 
            // label_RFID
            // 
            this.label_RFID.AutoSize = true;
            this.label_RFID.Location = new System.Drawing.Point(7, 146);
            this.label_RFID.Name = "label_RFID";
            this.label_RFID.Size = new System.Drawing.Size(56, 13);
            this.label_RFID.TabIndex = 6;
            this.label_RFID.Text = "RFIDcode";
            // 
            // but_reset
            // 
            this.but_reset.Location = new System.Drawing.Point(11, 223);
            this.but_reset.Name = "but_reset";
            this.but_reset.Size = new System.Drawing.Size(82, 22);
            this.but_reset.TabIndex = 16;
            this.but_reset.Text = "Xóa thông tin";
            this.but_reset.UseVisualStyleBackColor = true;
            this.but_reset.Click += new System.EventHandler(this.but_reset_Click);
            // 
            // group_SETTINGS
            // 
            this.group_SETTINGS.Controls.Add(this.button_ScanCOM);
            this.group_SETTINGS.Controls.Add(this.cmB_Parity);
            this.group_SETTINGS.Controls.Add(this.but_OpenPort);
            this.group_SETTINGS.Controls.Add(this.label_Parity);
            this.group_SETTINGS.Controls.Add(this.cmB_Baud);
            this.group_SETTINGS.Controls.Add(this.label_Baud);
            this.group_SETTINGS.Controls.Add(this.cmB_COMport);
            this.group_SETTINGS.Controls.Add(this.label_COMport);
            this.group_SETTINGS.Location = new System.Drawing.Point(203, 12);
            this.group_SETTINGS.Name = "group_SETTINGS";
            this.group_SETTINGS.Size = new System.Drawing.Size(213, 128);
            this.group_SETTINGS.TabIndex = 33;
            this.group_SETTINGS.TabStop = false;
            this.group_SETTINGS.Text = "THIẾT LẬP CỔNG COM";
            // 
            // button_ScanCOM
            // 
            this.button_ScanCOM.Location = new System.Drawing.Point(25, 98);
            this.button_ScanCOM.Name = "button_ScanCOM";
            this.button_ScanCOM.Size = new System.Drawing.Size(58, 22);
            this.button_ScanCOM.TabIndex = 54;
            this.button_ScanCOM.Text = "Scan";
            this.button_ScanCOM.UseVisualStyleBackColor = true;
            this.button_ScanCOM.Click += new System.EventHandler(this.button_ScanCOM_Click);
            // 
            // cmB_Parity
            // 
            this.cmB_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_Parity.FormattingEnabled = true;
            this.cmB_Parity.Location = new System.Drawing.Point(100, 71);
            this.cmB_Parity.Name = "cmB_Parity";
            this.cmB_Parity.Size = new System.Drawing.Size(92, 21);
            this.cmB_Parity.TabIndex = 3;
            // 
            // but_OpenPort
            // 
            this.but_OpenPort.Location = new System.Drawing.Point(121, 98);
            this.but_OpenPort.Name = "but_OpenPort";
            this.but_OpenPort.Size = new System.Drawing.Size(71, 22);
            this.but_OpenPort.TabIndex = 25;
            this.but_OpenPort.Text = "Open Port";
            this.but_OpenPort.UseVisualStyleBackColor = true;
            this.but_OpenPort.Click += new System.EventHandler(this.but_OpenPort_Click);
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
            this.cmB_Baud.Location = new System.Drawing.Point(100, 45);
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
            this.cmB_COMport.Location = new System.Drawing.Point(100, 19);
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
            // group_STT
            // 
            this.group_STT.Controls.Add(this.textBox_sttCOM);
            this.group_STT.Controls.Add(this.label_sttServer);
            this.group_STT.Controls.Add(this.richtex_sttServer);
            this.group_STT.Controls.Add(this.label_sttCOM);
            this.group_STT.Location = new System.Drawing.Point(203, 144);
            this.group_STT.Name = "group_STT";
            this.group_STT.Size = new System.Drawing.Size(213, 153);
            this.group_STT.TabIndex = 35;
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
            this.label_sttServer.Location = new System.Drawing.Point(6, 75);
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
            this.richtex_sttServer.Size = new System.Drawing.Size(142, 101);
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
            // but_Regis
            // 
            this.but_Regis.Location = new System.Drawing.Point(112, 223);
            this.but_Regis.Name = "but_Regis";
            this.but_Regis.Size = new System.Drawing.Size(85, 22);
            this.but_Regis.TabIndex = 34;
            this.but_Regis.Text = "ĐĂNG KÍ MỚI";
            this.but_Regis.UseVisualStyleBackColor = true;
            this.but_Regis.Click += new System.EventHandler(this.but_Regis_Click);
            // 
            // serialPortRFID
            // 
            this.serialPortRFID.PortName = "COM4";
            this.serialPortRFID.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortRFID_DataReceived);
            // 
            // USERREGIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 306);
            this.Controls.Add(this.group_STT);
            this.Controls.Add(this.but_Regis);
            this.Controls.Add(this.group_SETTINGS);
            this.Controls.Add(this.groupBox_infor);
            this.Controls.Add(this.but_reset);
            this.Name = "USERREGIS";
            this.Text = "ĐĂNG KÝ NGƯỜI DÙNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.USERREGIS_FormClosing);
            this.groupBox_infor.ResumeLayout(false);
            this.groupBox_infor.PerformLayout();
            this.group_SETTINGS.ResumeLayout(false);
            this.group_SETTINGS.PerformLayout();
            this.group_STT.ResumeLayout(false);
            this.group_STT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.GroupBox groupBox_infor;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_FisrtName;
        private System.Windows.Forms.Button but_reset;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_RFID;
        private System.Windows.Forms.GroupBox group_SETTINGS;
        private System.Windows.Forms.ComboBox cmB_Parity;
        private System.Windows.Forms.Button but_OpenPort;
        private System.Windows.Forms.Label label_Parity;
        private System.Windows.Forms.ComboBox cmB_Baud;
        private System.Windows.Forms.Label label_Baud;
        private System.Windows.Forms.ComboBox cmB_COMport;
        private System.Windows.Forms.Label label_COMport;
        private System.Windows.Forms.GroupBox group_STT;
        private System.Windows.Forms.TextBox textBox_sttCOM;
        private System.Windows.Forms.Label label_sttServer;
        private System.Windows.Forms.RichTextBox richtex_sttServer;
        private System.Windows.Forms.Label label_sttCOM;
        private System.Windows.Forms.Button but_Regis;
        private System.Windows.Forms.TextBox textBox_RFID;
        private System.IO.Ports.SerialPort serialPortRFID;
        private System.Windows.Forms.Button button_ScanCOM;
    }
}