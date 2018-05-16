namespace Slut
{
    partial class User
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.tbx_person_id = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(28, 20);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(16, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "---";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // tbx_person_id
            // 
            this.tbx_person_id.AutoSize = true;
            this.tbx_person_id.Location = new System.Drawing.Point(28, 48);
            this.tbx_person_id.Name = "tbx_person_id";
            this.tbx_person_id.Size = new System.Drawing.Size(31, 13);
            this.tbx_person_id.TabIndex = 1;
            this.tbx_person_id.Text = "--------";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Location = new System.Drawing.Point(28, 78);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(31, 13);
            this.lbl_balance.TabIndex = 2;
            this.lbl_balance.Text = "--------";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 209);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.tbx_person_id);
            this.Controls.Add(this.lbl_name);
            this.Name = "User";
            this.Text = "v";
            this.Load += new System.EventHandler(this.user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label tbx_person_id;
        private System.Windows.Forms.Label lbl_balance;
    }
}