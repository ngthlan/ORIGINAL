namespace CSELABMAN.VIEW
{
    partial class DEVREGISMORE
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
            this.groupBox_infor = new System.Windows.Forms.GroupBox();
            this.textBox_RFID = new System.Windows.Forms.TextBox();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Quanity = new System.Windows.Forms.TextBox();
            this.label_Quanity = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label_DEVName = new System.Windows.Forms.Label();
            this.label_RFID = new System.Windows.Forms.Label();
            this.but_reset = new System.Windows.Forms.Button();
            this.group_SETTINGS = new System.Windows.Forms.GroupBox();
            this.cmB_Parity = new System.Windows.Forms.ComboBox();
            this.label_Parity = new System.Windows.Forms.Label();
            this.cmB_Baud = new System.Windows.Forms.ComboBox();
            this.label_Baud = new System.Windows.Forms.Label();
            this.cmB_COMport = new System.Windows.Forms.ComboBox();
            this.label_COMport = new System.Windows.Forms.Label();
            this.but_OpenPort = new System.Windows.Forms.Button();
            this.group_STT = new System.Windows.Forms.GroupBox();
            this.textBox_sttCOM = new System.Windows.Forms.TextBox();
            this.label_sttServer = new System.Windows.Forms.Label();
            this.richtex_sttServer = new System.Windows.Forms.RichTextBox();
            this.label_sttCOM = new System.Windows.Forms.Label();
            this.but_Regis = new System.Windows.Forms.Button();
            this.textBox_Att = new System.Windows.Forms.TextBox();
            this.label_Att = new System.Windows.Forms.Label();
            this.groupBox_infor.SuspendLayout();
            this.group_SETTINGS.SuspendLayout();
            this.group_STT.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_infor
            // 
            this.groupBox_infor.Controls.Add(this.textBox_Att);
            this.groupBox_infor.Controls.Add(this.label_Att);
            this.groupBox_infor.Controls.Add(this.textBox_RFID);
            this.groupBox_infor.Controls.Add(this.textBox_Type);
            this.groupBox_infor.Controls.Add(this.label1);
            this.groupBox_infor.Controls.Add(this.textBox_Quanity);
            this.groupBox_infor.Controls.Add(this.label_Quanity);
            this.groupBox_infor.Controls.Add(this.textBox_UserName);
            this.groupBox_infor.Controls.Add(this.label_DEVName);
            this.groupBox_infor.Controls.Add(this.label_RFID);
            this.groupBox_infor.Location = new System.Drawing.Point(12, 12);
            this.groupBox_infor.Name = "groupBox_infor";
            this.groupBox_infor.Size = new System.Drawing.Size(198, 157);
            this.groupBox_infor.TabIndex = 26;
            this.groupBox_infor.TabStop = false;
            this.groupBox_infor.Text = "THÔNG TIN THIẾT BỊ";
            // 
            // textBox_RFID
            // 
            this.textBox_RFID.Location = new System.Drawing.Point(95, 126);
            this.textBox_RFID.Name = "textBox_RFID";
            this.textBox_RFID.Size = new System.Drawing.Size(82, 20);
            this.textBox_RFID.TabIndex = 39;
            // 
            // textBox_Type
            // 
            this.textBox_Type.Location = new System.Drawing.Point(80, 21);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(97, 20);
            this.textBox_Type.TabIndex = 38;
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
            // textBox_Quanity
            // 
            this.textBox_Quanity.Location = new System.Drawing.Point(95, 75);
            this.textBox_Quanity.Name = "textBox_Quanity";
            this.textBox_Quanity.ReadOnly = true;
            this.textBox_Quanity.Size = new System.Drawing.Size(82, 20);
            this.textBox_Quanity.TabIndex = 25;
            // 
            // label_Quanity
            // 
            this.label_Quanity.AutoSize = true;
            this.label_Quanity.Location = new System.Drawing.Point(9, 78);
            this.label_Quanity.Name = "label_Quanity";
            this.label_Quanity.Size = new System.Drawing.Size(49, 13);
            this.label_Quanity.TabIndex = 24;
            this.label_Quanity.Text = "Số lượng";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(95, 100);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(82, 20);
            this.textBox_UserName.TabIndex = 23;
            // 
            // label_DEVName
            // 
            this.label_DEVName.AutoSize = true;
            this.label_DEVName.Location = new System.Drawing.Point(9, 103);
            this.label_DEVName.Name = "label_DEVName";
            this.label_DEVName.Size = new System.Drawing.Size(60, 13);
            this.label_DEVName.TabIndex = 4;
            this.label_DEVName.Text = "Tên thiết bị";
            this.label_DEVName.Click += new System.EventHandler(this.label_DEVName_Click);
            // 
            // label_RFID
            // 
            this.label_RFID.AutoSize = true;
            this.label_RFID.Location = new System.Drawing.Point(9, 129);
            this.label_RFID.Name = "label_RFID";
            this.label_RFID.Size = new System.Drawing.Size(56, 13);
            this.label_RFID.TabIndex = 6;
            this.label_RFID.Text = "RFIDcode";
            // 
            // but_reset
            // 
            this.but_reset.Location = new System.Drawing.Point(66, 181);
            this.but_reset.Name = "but_reset";
            this.but_reset.Size = new System.Drawing.Size(95, 22);
            this.but_reset.TabIndex = 16;
            this.but_reset.Text = "Xóa thông tin";
            this.but_reset.UseVisualStyleBackColor = true;
            this.but_reset.Click += new System.EventHandler(this.but_reset_Click);
            // 
            // group_SETTINGS
            // 
            this.group_SETTINGS.Controls.Add(this.cmB_Parity);
            this.group_SETTINGS.Controls.Add(this.label_Parity);
            this.group_SETTINGS.Controls.Add(this.cmB_Baud);
            this.group_SETTINGS.Controls.Add(this.label_Baud);
            this.group_SETTINGS.Controls.Add(this.cmB_COMport);
            this.group_SETTINGS.Controls.Add(this.label_COMport);
            this.group_SETTINGS.Location = new System.Drawing.Point(216, 12);
            this.group_SETTINGS.Name = "group_SETTINGS";
            this.group_SETTINGS.Size = new System.Drawing.Size(198, 104);
            this.group_SETTINGS.TabIndex = 33;
            this.group_SETTINGS.TabStop = false;
            this.group_SETTINGS.Text = "THIẾT LẬP CỔNG COM";
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
            // but_OpenPort
            // 
            this.but_OpenPort.Location = new System.Drawing.Point(24, 209);
            this.but_OpenPort.Name = "but_OpenPort";
            this.but_OpenPort.Size = new System.Drawing.Size(71, 22);
            this.but_OpenPort.TabIndex = 25;
            this.but_OpenPort.Text = "Open Port";
            this.but_OpenPort.UseVisualStyleBackColor = true;
            this.but_OpenPort.Click += new System.EventHandler(this.but_OpenPort_Click);
            // 
            // group_STT
            // 
            this.group_STT.Controls.Add(this.textBox_sttCOM);
            this.group_STT.Controls.Add(this.label_sttServer);
            this.group_STT.Controls.Add(this.richtex_sttServer);
            this.group_STT.Controls.Add(this.label_sttCOM);
            this.group_STT.Location = new System.Drawing.Point(216, 122);
            this.group_STT.Name = "group_STT";
            this.group_STT.Size = new System.Drawing.Size(197, 119);
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
            this.richtex_sttServer.Size = new System.Drawing.Size(135, 60);
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
            this.but_Regis.Location = new System.Drawing.Point(107, 209);
            this.but_Regis.Name = "but_Regis";
            this.but_Regis.Size = new System.Drawing.Size(82, 22);
            this.but_Regis.TabIndex = 34;
            this.but_Regis.Text = "ĐĂNG KÝ";
            this.but_Regis.UseVisualStyleBackColor = true;
            this.but_Regis.Click += new System.EventHandler(this.but_Regis_Click);
            // 
            // textBox_Att
            // 
            this.textBox_Att.Location = new System.Drawing.Point(95, 47);
            this.textBox_Att.Name = "textBox_Att";
            this.textBox_Att.ReadOnly = true;
            this.textBox_Att.Size = new System.Drawing.Size(82, 20);
            this.textBox_Att.TabIndex = 41;
            // 
            // label_Att
            // 
            this.label_Att.AutoSize = true;
            this.label_Att.Location = new System.Drawing.Point(9, 50);
            this.label_Att.Name = "label_Att";
            this.label_Att.Size = new System.Drawing.Size(46, 13);
            this.label_Att.TabIndex = 40;
            this.label_Att.Text = "Attribute";
            // 
            // DEVREGISMORE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 252);
            this.Controls.Add(this.group_STT);
            this.Controls.Add(this.but_OpenPort);
            this.Controls.Add(this.but_reset);
            this.Controls.Add(this.but_Regis);
            this.Controls.Add(this.group_SETTINGS);
            this.Controls.Add(this.groupBox_infor);
            this.Name = "DEVREGISMORE";
            this.Text = "ĐĂNG KÝ MÃ THẺ NHIỀU THIẾT BỊ";
            this.groupBox_infor.ResumeLayout(false);
            this.groupBox_infor.PerformLayout();
            this.group_SETTINGS.ResumeLayout(false);
            this.group_SETTINGS.PerformLayout();
            this.group_STT.ResumeLayout(false);
            this.group_STT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_infor;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Button but_reset;
        private System.Windows.Forms.Label label_DEVName;
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
        private System.Windows.Forms.TextBox textBox_Quanity;
        private System.Windows.Forms.Label label_Quanity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.TextBox textBox_RFID;
        private System.Windows.Forms.TextBox textBox_Att;
        private System.Windows.Forms.Label label_Att;
    }
}