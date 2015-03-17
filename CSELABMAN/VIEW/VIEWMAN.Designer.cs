namespace CSELABMAN.VIEW
{
    partial class VIEWMAN
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
            this.button_RETURN = new System.Windows.Forms.Button();
            this.button_BORROW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_RETURN
            // 
            this.button_RETURN.BackColor = System.Drawing.Color.PaleGreen;
            this.button_RETURN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_RETURN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_RETURN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_RETURN.Location = new System.Drawing.Point(255, 39);
            this.button_RETURN.Name = "button_RETURN";
            this.button_RETURN.Size = new System.Drawing.Size(211, 155);
            this.button_RETURN.TabIndex = 5;
            this.button_RETURN.Text = "TRẢ THIẾT BỊ";
            this.button_RETURN.UseVisualStyleBackColor = false;
            this.button_RETURN.Click += new System.EventHandler(this.button_RETURN_Click);
            // 
            // button_BORROW
            // 
            this.button_BORROW.BackColor = System.Drawing.Color.Bisque;
            this.button_BORROW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_BORROW.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_BORROW.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_BORROW.Location = new System.Drawing.Point(17, 39);
            this.button_BORROW.Name = "button_BORROW";
            this.button_BORROW.Size = new System.Drawing.Size(211, 155);
            this.button_BORROW.TabIndex = 4;
            this.button_BORROW.Text = "MƯỢN THIẾT BỊ";
            this.button_BORROW.UseVisualStyleBackColor = false;
            this.button_BORROW.Click += new System.EventHandler(this.button_BORROW_Click);
            // 
            // VIEWMAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 206);
            this.Controls.Add(this.button_RETURN);
            this.Controls.Add(this.button_BORROW);
            this.Name = "VIEWMAN";
            this.Text = "MƯỢN / TRẢ THIẾT BỊ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VIEWMAN_FormClosing);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button_RETURN;
        private System.Windows.Forms.Button button_BORROW;
    }
}