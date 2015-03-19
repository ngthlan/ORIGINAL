namespace CSELABMAN.VIEW
{
    partial class DEVEDITMORE
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
            this.but_Edit = new System.Windows.Forms.Button();
            this.label_sttCOM = new System.Windows.Forms.Label();
            this.richtex_sttServer = new System.Windows.Forms.RichTextBox();
            this.label_sttServer = new System.Windows.Forms.Label();
            this.textBox_sttCOM = new System.Windows.Forms.TextBox();
            this.group_STT = new System.Windows.Forms.GroupBox();
            this.label_COMport = new System.Windows.Forms.Label();
            this.cmB_COMport = new System.Windows.Forms.ComboBox();
            this.label_Baud = new System.Windows.Forms.Label();
            this.cmB_Baud = new System.Windows.Forms.ComboBox();
            this.label_Parity = new System.Windows.Forms.Label();
            this.but_OpenPort = new System.Windows.Forms.Button();
            this.cmB_Parity = new System.Windows.Forms.ComboBox();
            this.button_ScanCOM = new System.Windows.Forms.Button();
            this.group_SETTINGS = new System.Windows.Forms.GroupBox();
            this.but_reset = new System.Windows.Forms.Button();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.label_RFID = new System.Windows.Forms.Label();
            this.label_DEVName = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label_Quanity = new System.Windows.Forms.Label();
            this.textBox_Quanity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_RFID = new System.Windows.Forms.TextBox();
            this.checkBox_new = new System.Windows.Forms.CheckBox();
            this.label_att = new System.Windows.Forms.Label();
            this.comboBox_Att = new System.Windows.Forms.ComboBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.groupBox_infor = new System.Windows.Forms.GroupBox();
            this.serialPortRFID = new System.IO.Ports.SerialPort(this.components);
            this.group_STT.SuspendLayout();
            this.group_SETTINGS.SuspendLayout();
            this.groupBox_infor.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_Edit
            // 
            this.but_Edit.Location = new System.Drawing.Point(130, 217);
            this.but_Edit.Name = "but_Edit";
            this.but_Edit.Size = new System.Drawing.Size(59, 22);
            this.but_Edit.TabIndex = 34;
            this.but_Edit.Text = "SỬA";
            this.but_Edit.UseVisualStyleBackColor = true;
            this.but_Edit.Click += new System.EventHandler(this.but_Edit_Click);
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
            // richtex_sttServer
            // 
            this.richtex_sttServer.Location = new System.Drawing.Point(48, 46);
            this.richtex_sttServer.Name = "richtex_sttServer";
            this.richtex_sttServer.ReadOnly = true;
            this.richtex_sttServer.Size = new System.Drawing.Size(135, 60);
            this.richtex_sttServer.TabIndex = 22;
            this.richtex_sttServer.Text = "";
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
            // textBox_sttCOM
            // 
            this.textBox_sttCOM.Location = new System.Drawing.Point(66, 18);
            this.textBox_sttCOM.Name = "textBox_sttCOM";
            this.textBox_sttCOM.ReadOnly = true;
            this.textBox_sttCOM.Size = new System.Drawing.Size(106, 20);
            this.textBox_sttCOM.TabIndex = 25;
            // 
            // group_STT
            // 
            this.group_STT.Controls.Add(this.textBox_sttCOM);
            this.group_STT.Controls.Add(this.label_sttServer);
            this.group_STT.Controls.Add(this.richtex_sttServer);
            this.group_STT.Controls.Add(this.label_sttCOM);
            this.group_STT.Location = new System.Drawing.Point(216, 143);
            this.group_STT.Name = "group_STT";
            this.group_STT.Size = new System.Drawing.Size(197, 119);
            this.group_STT.TabIndex = 35;
            this.group_STT.TabStop = false;
            this.group_STT.Text = "TRẠNG THÁI PHẢN HỒI";
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
            // cmB_COMport
            // 
            this.cmB_COMport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_COMport.FormattingEnabled = true;
            this.cmB_COMport.Location = new System.Drawing.Point(85, 19);
            this.cmB_COMport.Name = "cmB_COMport";
            this.cmB_COMport.Size = new System.Drawing.Size(92, 21);
            this.cmB_COMport.TabIndex = 4;
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
            // label_Parity
            // 
            this.label_Parity.AutoSize = true;
            this.label_Parity.Location = new System.Drawing.Point(22, 75);
            this.label_Parity.Name = "label_Parity";
            this.label_Parity.Size = new System.Drawing.Size(33, 13);
            this.label_Parity.TabIndex = 7;
            this.label_Parity.Text = "Parity";
            // 
            // but_OpenPort
            // 
            this.but_OpenPort.Location = new System.Drawing.Point(106, 98);
            this.but_OpenPort.Name = "but_OpenPort";
            this.but_OpenPort.Size = new System.Drawing.Size(71, 22);
            this.but_OpenPort.TabIndex = 25;
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
            // button_ScanCOM
            // 
            this.button_ScanCOM.Location = new System.Drawing.Point(25, 97);
            this.button_ScanCOM.Name = "button_ScanCOM";
            this.button_ScanCOM.Size = new System.Drawing.Size(58, 22);
            this.button_ScanCOM.TabIndex = 56;
            this.button_ScanCOM.Text = "Scan";
            this.button_ScanCOM.UseVisualStyleBackColor = true;
            this.button_ScanCOM.Click += new System.EventHandler(this.button_ScanCOM_Click);
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
            this.group_SETTINGS.Location = new System.Drawing.Point(216, 12);
            this.group_SETTINGS.Name = "group_SETTINGS";
            this.group_SETTINGS.Size = new System.Drawing.Size(198, 125);
            this.group_SETTINGS.TabIndex = 33;
            this.group_SETTINGS.TabStop = false;
            this.group_SETTINGS.Text = "THIẾT LẬP CỔNG COM";
            // 
            // but_reset
            // 
            this.but_reset.Location = new System.Drawing.Point(23, 217);
            this.but_reset.Name = "but_reset";
            this.but_reset.Size = new System.Drawing.Size(84, 22);
            this.but_reset.TabIndex = 16;
            this.but_reset.Text = "Xóa thông tin";
            this.but_reset.UseVisualStyleBackColor = true;
            this.but_reset.Click += new System.EventHandler(this.but_reset_Click);
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.Location = new System.Drawing.Point(0, 0);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(121, 21);
            this.cmbDataBits.TabIndex = 0;
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.Location = new System.Drawing.Point(0, 0);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(121, 21);
            this.cmbStopBits.TabIndex = 0;
            // 
            // label_RFID
            // 
            this.label_RFID.AutoSize = true;
            this.label_RFID.Location = new System.Drawing.Point(9, 148);
            this.label_RFID.Name = "label_RFID";
            this.label_RFID.Size = new System.Drawing.Size(56, 13);
            this.label_RFID.TabIndex = 6;
            this.label_RFID.Text = "RFIDcode";
            // 
            // label_DEVName
            // 
            this.label_DEVName.AutoSize = true;
            this.label_DEVName.Location = new System.Drawing.Point(9, 117);
            this.label_DEVName.Name = "label_DEVName";
            this.label_DEVName.Size = new System.Drawing.Size(60, 13);
            this.label_DEVName.TabIndex = 4;
            this.label_DEVName.Text = "Tên thiết bị";
            this.label_DEVName.Click += new System.EventHandler(this.label_DEVName_Click);
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(85, 114);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(92, 20);
            this.textBox_UserName.TabIndex = 23;
            // 
            // label_Quanity
            // 
            this.label_Quanity.AutoSize = true;
            this.label_Quanity.Location = new System.Drawing.Point(9, 87);
            this.label_Quanity.Name = "label_Quanity";
            this.label_Quanity.Size = new System.Drawing.Size(49, 13);
            this.label_Quanity.TabIndex = 24;
            this.label_Quanity.Text = "Số lượng";
            // 
            // textBox_Quanity
            // 
            this.textBox_Quanity.Location = new System.Drawing.Point(85, 84);
            this.textBox_Quanity.Name = "textBox_Quanity";
            this.textBox_Quanity.ReadOnly = true;
            this.textBox_Quanity.Size = new System.Drawing.Size(92, 20);
            this.textBox_Quanity.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tên loại";
            // 
            // textBox_RFID
            // 
            this.textBox_RFID.Location = new System.Drawing.Point(85, 145);
            this.textBox_RFID.Name = "textBox_RFID";
            this.textBox_RFID.Size = new System.Drawing.Size(92, 20);
            this.textBox_RFID.TabIndex = 39;
            // 
            // checkBox_new
            // 
            this.checkBox_new.AutoSize = true;
            this.checkBox_new.Checked = true;
            this.checkBox_new.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_new.Location = new System.Drawing.Point(11, 176);
            this.checkBox_new.Name = "checkBox_new";
            this.checkBox_new.Size = new System.Drawing.Size(64, 17);
            this.checkBox_new.TabIndex = 39;
            this.checkBox_new.Text = "Sửa mới";
            this.checkBox_new.UseVisualStyleBackColor = true;
            // 
            // label_att
            // 
            this.label_att.AutoSize = true;
            this.label_att.Location = new System.Drawing.Point(8, 56);
            this.label_att.Name = "label_att";
            this.label_att.Size = new System.Drawing.Size(46, 13);
            this.label_att.TabIndex = 44;
            this.label_att.Text = "Attribute";
            // 
            // comboBox_Att
            // 
            this.comboBox_Att.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Att.FormattingEnabled = true;
            this.comboBox_Att.Location = new System.Drawing.Point(85, 52);
            this.comboBox_Att.Name = "comboBox_Att";
            this.comboBox_Att.Size = new System.Drawing.Size(92, 21);
            this.comboBox_Att.TabIndex = 45;
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(85, 21);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(92, 21);
            this.comboBox_Type.TabIndex = 46;
            // 
            // groupBox_infor
            // 
            this.groupBox_infor.Controls.Add(this.comboBox_Type);
            this.groupBox_infor.Controls.Add(this.comboBox_Att);
            this.groupBox_infor.Controls.Add(this.label_att);
            this.groupBox_infor.Controls.Add(this.checkBox_new);
            this.groupBox_infor.Controls.Add(this.textBox_RFID);
            this.groupBox_infor.Controls.Add(this.label1);
            this.groupBox_infor.Controls.Add(this.textBox_Quanity);
            this.groupBox_infor.Controls.Add(this.label_Quanity);
            this.groupBox_infor.Controls.Add(this.textBox_UserName);
            this.groupBox_infor.Controls.Add(this.label_DEVName);
            this.groupBox_infor.Controls.Add(this.label_RFID);
            this.groupBox_infor.Location = new System.Drawing.Point(12, 12);
            this.groupBox_infor.Name = "groupBox_infor";
            this.groupBox_infor.Size = new System.Drawing.Size(198, 199);
            this.groupBox_infor.TabIndex = 26;
            this.groupBox_infor.TabStop = false;
            this.groupBox_infor.Text = "THÔNG TIN THIẾT BỊ";
            // 
            // serialPortRFID
            // 
            this.serialPortRFID.PortName = "COM4";
            this.serialPortRFID.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortRFID_DataReceived);
            // 
            // DEVEDITMORE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 276);
            this.Controls.Add(this.group_STT);
            this.Controls.Add(this.but_reset);
            this.Controls.Add(this.but_Edit);
            this.Controls.Add(this.group_SETTINGS);
            this.Controls.Add(this.groupBox_infor);
            this.Name = "DEVEDITMORE";
            this.Text = "SỬA MÃ THẺ NHIỀU THIẾT BỊ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DEVEDITMORE_FormClosing);
            this.group_STT.ResumeLayout(false);
            this.group_STT.PerformLayout();
            this.group_SETTINGS.ResumeLayout(false);
            this.group_SETTINGS.PerformLayout();
            this.groupBox_infor.ResumeLayout(false);
            this.groupBox_infor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_Edit;
        private System.Windows.Forms.Label label_sttCOM;
        private System.Windows.Forms.RichTextBox richtex_sttServer;
        private System.Windows.Forms.Label label_sttServer;
        private System.Windows.Forms.TextBox textBox_sttCOM;
        private System.Windows.Forms.GroupBox group_STT;
        private System.Windows.Forms.Label label_COMport;
        private System.Windows.Forms.ComboBox cmB_COMport;
        private System.Windows.Forms.Label label_Baud;
        private System.Windows.Forms.ComboBox cmB_Baud;
        private System.Windows.Forms.Label label_Parity;
        private System.Windows.Forms.Button but_OpenPort;
        private System.Windows.Forms.ComboBox cmB_Parity;
        private System.Windows.Forms.Button button_ScanCOM;
        private System.Windows.Forms.GroupBox group_SETTINGS;
        private System.Windows.Forms.Button but_reset;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.Label label_RFID;
        private System.Windows.Forms.Label label_DEVName;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label_Quanity;
        private System.Windows.Forms.TextBox textBox_Quanity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_RFID;
        private System.Windows.Forms.CheckBox checkBox_new;
        private System.Windows.Forms.Label label_att;
        private System.Windows.Forms.ComboBox comboBox_Att;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.GroupBox groupBox_infor;
        private System.IO.Ports.SerialPort serialPortRFID;
    }
}