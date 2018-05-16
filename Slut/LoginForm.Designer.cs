namespace Slut
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btn_reg = new System.Windows.Forms.Button();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.tbx_person_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(42, 178);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(139, 23);
            this.btn_reg.TabIndex = 0;
            this.btn_reg.Text = "Register";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(42, 63);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(139, 20);
            this.tbx_name.TabIndex = 1;
            // 
            // tbx_person_id
            // 
            this.tbx_person_id.Location = new System.Drawing.Point(42, 107);
            this.tbx_person_id.Name = "tbx_person_id";
            this.tbx_person_id.Size = new System.Drawing.Size(139, 20);
            this.tbx_person_id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Person ID";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(42, 149);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(139, 23);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 248);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_person_id);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.btn_reg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Norbae";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.TextBox tbx_person_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
    }
}

