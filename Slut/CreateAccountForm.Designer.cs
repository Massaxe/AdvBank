namespace Slut
{
    partial class CreateAccountForm
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
            this.tbx_initBalance = new System.Windows.Forms.TextBox();
            this.rb_salaryAccount = new System.Windows.Forms.RadioButton();
            this.rb_savingsAccount = new System.Windows.Forms.RadioButton();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.btn_createAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_initBalance
            // 
            this.tbx_initBalance.Location = new System.Drawing.Point(15, 38);
            this.tbx_initBalance.Name = "tbx_initBalance";
            this.tbx_initBalance.Size = new System.Drawing.Size(100, 20);
            this.tbx_initBalance.TabIndex = 0;
            // 
            // rb_salaryAccount
            // 
            this.rb_salaryAccount.AutoSize = true;
            this.rb_salaryAccount.Location = new System.Drawing.Point(15, 95);
            this.rb_salaryAccount.Name = "rb_salaryAccount";
            this.rb_salaryAccount.Size = new System.Drawing.Size(96, 17);
            this.rb_salaryAccount.TabIndex = 1;
            this.rb_salaryAccount.TabStop = true;
            this.rb_salaryAccount.Text = "Salary account";
            this.rb_salaryAccount.UseVisualStyleBackColor = true;
            this.rb_salaryAccount.CheckedChanged += new System.EventHandler(this.rb_salaryAccount_CheckedChanged);
            // 
            // rb_savingsAccount
            // 
            this.rb_savingsAccount.AutoSize = true;
            this.rb_savingsAccount.Location = new System.Drawing.Point(15, 118);
            this.rb_savingsAccount.Name = "rb_savingsAccount";
            this.rb_savingsAccount.Size = new System.Drawing.Size(105, 17);
            this.rb_savingsAccount.TabIndex = 2;
            this.rb_savingsAccount.TabStop = true;
            this.rb_savingsAccount.Text = "Savings account";
            this.rb_savingsAccount.UseVisualStyleBackColor = true;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(12, 79);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(70, 13);
            this.lbl_type.TabIndex = 3;
            this.lbl_type.Text = "Account type";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Location = new System.Drawing.Point(12, 22);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(72, 13);
            this.lbl_balance.TabIndex = 4;
            this.lbl_balance.Text = "Initial balance";
            // 
            // btn_createAccount
            // 
            this.btn_createAccount.Location = new System.Drawing.Point(12, 150);
            this.btn_createAccount.Name = "btn_createAccount";
            this.btn_createAccount.Size = new System.Drawing.Size(103, 23);
            this.btn_createAccount.TabIndex = 5;
            this.btn_createAccount.Text = "Create Account";
            this.btn_createAccount.UseVisualStyleBackColor = true;
            this.btn_createAccount.Click += new System.EventHandler(this.btn_createAccount_Click);
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 185);
            this.Controls.Add(this.btn_createAccount);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.rb_savingsAccount);
            this.Controls.Add(this.rb_salaryAccount);
            this.Controls.Add(this.tbx_initBalance);
            this.Name = "CreateAccountForm";
            this.Text = "t";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_initBalance;
        private System.Windows.Forms.RadioButton rb_salaryAccount;
        private System.Windows.Forms.RadioButton rb_savingsAccount;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Button btn_createAccount;
    }
}