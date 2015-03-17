namespace CSELABMAN.VIEW
{
    partial class CHOOSE
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
            this.label_Type = new System.Windows.Forms.Label();
            this.cmB_COMport = new System.Windows.Forms.ComboBox();
            this.group_STT = new System.Windows.Forms.GroupBox();
            this.richtex_sttServer = new System.Windows.Forms.RichTextBox();
            this.groupBox_Type = new System.Windows.Forms.GroupBox();
            this.label_att = new System.Windows.Forms.Label();
            this.comboBox_att = new System.Windows.Forms.ComboBox();
            this.checkBox_New = new System.Windows.Forms.CheckBox();
            this.textBox_Need = new System.Windows.Forms.TextBox();
            this.label_Need = new System.Windows.Forms.Label();
            this.textBox_Available = new System.Windows.Forms.TextBox();
            this.label_Available = new System.Windows.Forms.Label();
            this.but_Find = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.group_STT.SuspendLayout();
            this.groupBox_Type.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Location = new System.Drawing.Point(19, 25);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(45, 13);
            this.label_Type.TabIndex = 2;
            this.label_Type.Text = "Tên loại";
            // 
            // cmB_COMport
            // 
            this.cmB_COMport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_COMport.FormattingEnabled = true;
            this.cmB_COMport.Location = new System.Drawing.Point(83, 22);
            this.cmB_COMport.Name = "cmB_COMport";
            this.cmB_COMport.Size = new System.Drawing.Size(92, 21);
            this.cmB_COMport.TabIndex = 5;
            // 
            // group_STT
            // 
            this.group_STT.Controls.Add(this.richtex_sttServer);
            this.group_STT.Location = new System.Drawing.Point(215, 12);
            this.group_STT.Name = "group_STT";
            this.group_STT.Size = new System.Drawing.Size(197, 92);
            this.group_STT.TabIndex = 36;
            this.group_STT.TabStop = false;
            this.group_STT.Text = "TRẠNG THÁI PHẢN HỒI";
            // 
            // richtex_sttServer
            // 
            this.richtex_sttServer.Location = new System.Drawing.Point(23, 19);
            this.richtex_sttServer.Name = "richtex_sttServer";
            this.richtex_sttServer.ReadOnly = true;
            this.richtex_sttServer.Size = new System.Drawing.Size(153, 60);
            this.richtex_sttServer.TabIndex = 22;
            this.richtex_sttServer.Text = "";
            // 
            // groupBox_Type
            // 
            this.groupBox_Type.Controls.Add(this.label_att);
            this.groupBox_Type.Controls.Add(this.comboBox_att);
            this.groupBox_Type.Controls.Add(this.checkBox_New);
            this.groupBox_Type.Controls.Add(this.textBox_Need);
            this.groupBox_Type.Controls.Add(this.label_Need);
            this.groupBox_Type.Controls.Add(this.textBox_Available);
            this.groupBox_Type.Controls.Add(this.label_Available);
            this.groupBox_Type.Controls.Add(this.label_Type);
            this.groupBox_Type.Controls.Add(this.cmB_COMport);
            this.groupBox_Type.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Type.Name = "groupBox_Type";
            this.groupBox_Type.Size = new System.Drawing.Size(197, 153);
            this.groupBox_Type.TabIndex = 37;
            this.groupBox_Type.TabStop = false;
            this.groupBox_Type.Text = "THÔNG TIN CẦN THIẾT";
            // 
            // label_att
            // 
            this.label_att.AutoSize = true;
            this.label_att.Location = new System.Drawing.Point(19, 52);
            this.label_att.Name = "label_att";
            this.label_att.Size = new System.Drawing.Size(46, 13);
            this.label_att.TabIndex = 30;
            this.label_att.Text = "Attribute";
            // 
            // comboBox_att
            // 
            this.comboBox_att.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_att.FormattingEnabled = true;
            this.comboBox_att.Location = new System.Drawing.Point(83, 49);
            this.comboBox_att.Name = "comboBox_att";
            this.comboBox_att.Size = new System.Drawing.Size(92, 21);
            this.comboBox_att.TabIndex = 31;
            // 
            // checkBox_New
            // 
            this.checkBox_New.AutoSize = true;
            this.checkBox_New.Checked = true;
            this.checkBox_New.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_New.Location = new System.Drawing.Point(56, 128);
            this.checkBox_New.Name = "checkBox_New";
            this.checkBox_New.Size = new System.Drawing.Size(71, 17);
            this.checkBox_New.TabIndex = 29;
            this.checkBox_New.Text = "Nhập mới";
            this.checkBox_New.UseVisualStyleBackColor = true;
            // 
            // textBox_Need
            // 
            this.textBox_Need.Location = new System.Drawing.Point(127, 102);
            this.textBox_Need.Name = "textBox_Need";
            this.textBox_Need.ReadOnly = true;
            this.textBox_Need.Size = new System.Drawing.Size(48, 20);
            this.textBox_Need.TabIndex = 28;
            // 
            // label_Need
            // 
            this.label_Need.AutoSize = true;
            this.label_Need.Location = new System.Drawing.Point(19, 105);
            this.label_Need.Name = "label_Need";
            this.label_Need.Size = new System.Drawing.Size(97, 13);
            this.label_Need.TabIndex = 27;
            this.label_Need.Text = "Số lượng cần nhập";
            // 
            // textBox_Available
            // 
            this.textBox_Available.Location = new System.Drawing.Point(127, 76);
            this.textBox_Available.Name = "textBox_Available";
            this.textBox_Available.ReadOnly = true;
            this.textBox_Available.Size = new System.Drawing.Size(48, 20);
            this.textBox_Available.TabIndex = 26;
            // 
            // label_Available
            // 
            this.label_Available.AutoSize = true;
            this.label_Available.Location = new System.Drawing.Point(19, 79);
            this.label_Available.Name = "label_Available";
            this.label_Available.Size = new System.Drawing.Size(87, 13);
            this.label_Available.TabIndex = 6;
            this.label_Available.Text = "Số lượng hiện có";
            // 
            // but_Find
            // 
            this.but_Find.Location = new System.Drawing.Point(266, 114);
            this.but_Find.Name = "but_Find";
            this.but_Find.Size = new System.Drawing.Size(85, 22);
            this.but_Find.TabIndex = 38;
            this.but_Find.Text = "Tìm loại thiết bị";
            this.but_Find.UseVisualStyleBackColor = true;
            this.but_Find.Click += new System.EventHandler(this.but_Find_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(238, 143);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(153, 22);
            this.button_start.TabIndex = 39;
            this.button_start.Text = "BẮT ĐẦU NHẬP";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // CHOOSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 198);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.but_Find);
            this.Controls.Add(this.groupBox_Type);
            this.Controls.Add(this.group_STT);
            this.Name = "CHOOSE";
            this.Text = "CHỌN LOẠI THIẾT BỊ ";
            this.group_STT.ResumeLayout(false);
            this.groupBox_Type.ResumeLayout(false);
            this.groupBox_Type.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.ComboBox cmB_COMport;
        private System.Windows.Forms.GroupBox group_STT;
        private System.Windows.Forms.RichTextBox richtex_sttServer;
        private System.Windows.Forms.GroupBox groupBox_Type;
        private System.Windows.Forms.Label label_Available;
        private System.Windows.Forms.TextBox textBox_Need;
        private System.Windows.Forms.Label label_Need;
        private System.Windows.Forms.TextBox textBox_Available;
        private System.Windows.Forms.CheckBox checkBox_New;
        private System.Windows.Forms.Button but_Find;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_att;
        private System.Windows.Forms.ComboBox comboBox_att;
    }
}