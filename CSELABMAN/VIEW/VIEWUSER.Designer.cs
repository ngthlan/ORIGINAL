namespace CSELABMAN.VIEW
{
    partial class VIEWUSER
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
            this.button_EDIT = new System.Windows.Forms.Button();
            this.button_REGIS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_EDIT
            // 
            this.button_EDIT.BackColor = System.Drawing.SystemColors.Control;
            this.button_EDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_EDIT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_EDIT.Image = global::CSELABMAN.Properties.Resources.edit_;
            this.button_EDIT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_EDIT.Location = new System.Drawing.Point(264, 35);
            this.button_EDIT.Name = "button_EDIT";
            this.button_EDIT.Size = new System.Drawing.Size(211, 155);
            this.button_EDIT.TabIndex = 3;
            this.button_EDIT.Text = "SỬA THẺ NGƯỜI DÙNG";
            this.button_EDIT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_EDIT.UseVisualStyleBackColor = false;
            this.button_EDIT.Click += new System.EventHandler(this.button_EDIT_Click);
            // 
            // button_REGIS
            // 
            this.button_REGIS.BackColor = System.Drawing.SystemColors.Control;
            this.button_REGIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_REGIS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_REGIS.Image = global::CSELABMAN.Properties.Resources.registration_;
            this.button_REGIS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_REGIS.Location = new System.Drawing.Point(26, 35);
            this.button_REGIS.Name = "button_REGIS";
            this.button_REGIS.Size = new System.Drawing.Size(211, 155);
            this.button_REGIS.TabIndex = 2;
            this.button_REGIS.Text = "ĐĂNG KÝ NGƯỜI DÙNG ";
            this.button_REGIS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_REGIS.UseVisualStyleBackColor = false;
            this.button_REGIS.Click += new System.EventHandler(this.button_REGIS_Click);
            // 
            // USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 214);
            this.Controls.Add(this.button_EDIT);
            this.Controls.Add(this.button_REGIS);
            this.Name = "USER";
            this.Text = "QUẢN LÝ NGƯỜI DÙNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VIEWUSER_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_REGIS;
        private System.Windows.Forms.Button button_EDIT;

    }
}