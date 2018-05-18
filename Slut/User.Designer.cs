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
            this.lbl_person_id = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lb_accountListBox = new System.Windows.Forms.CheckedListBox();
            this.btn_createAccount = new System.Windows.Forms.Button();
            this.btn_sendMoney = new System.Windows.Forms.Button();
            this.tbx_sendMoneyId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_sendAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_removeAccount = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
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
            // lbl_person_id
            // 
            this.lbl_person_id.AutoSize = true;
            this.lbl_person_id.Location = new System.Drawing.Point(28, 48);
            this.lbl_person_id.Name = "lbl_person_id";
            this.lbl_person_id.Size = new System.Drawing.Size(31, 13);
            this.lbl_person_id.TabIndex = 1;
            this.lbl_person_id.Text = "--------";
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
            // lb_accountListBox
            // 
            this.lb_accountListBox.FormattingEnabled = true;
            this.lb_accountListBox.Location = new System.Drawing.Point(109, 20);
            this.lb_accountListBox.Name = "lb_accountListBox";
            this.lb_accountListBox.Size = new System.Drawing.Size(157, 94);
            this.lb_accountListBox.TabIndex = 3;
            // 
            // btn_createAccount
            // 
            this.btn_createAccount.Location = new System.Drawing.Point(31, 174);
            this.btn_createAccount.Name = "btn_createAccount";
            this.btn_createAccount.Size = new System.Drawing.Size(115, 23);
            this.btn_createAccount.TabIndex = 4;
            this.btn_createAccount.Text = "Create Account";
            this.btn_createAccount.UseVisualStyleBackColor = true;
            this.btn_createAccount.Click += new System.EventHandler(this.btn_createAccount_Click);
            // 
            // btn_sendMoney
            // 
            this.btn_sendMoney.Location = new System.Drawing.Point(31, 145);
            this.btn_sendMoney.Name = "btn_sendMoney";
            this.btn_sendMoney.Size = new System.Drawing.Size(44, 23);
            this.btn_sendMoney.TabIndex = 5;
            this.btn_sendMoney.Text = "Send Money";
            this.btn_sendMoney.UseVisualStyleBackColor = true;
            this.btn_sendMoney.Click += new System.EventHandler(this.btn_sendMoney_Click);
            // 
            // tbx_sendMoneyId
            // 
            this.tbx_sendMoneyId.Location = new System.Drawing.Point(81, 148);
            this.tbx_sendMoneyId.Name = "tbx_sendMoneyId";
            this.tbx_sendMoneyId.Size = new System.Drawing.Size(65, 20);
            this.tbx_sendMoneyId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Receiver ID";
            // 
            // tbx_sendAmount
            // 
            this.tbx_sendAmount.Location = new System.Drawing.Point(152, 148);
            this.tbx_sendAmount.Name = "tbx_sendAmount";
            this.tbx_sendAmount.Size = new System.Drawing.Size(114, 20);
            this.tbx_sendAmount.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Amount";
            // 
            // btn_removeAccount
            // 
            this.btn_removeAccount.Location = new System.Drawing.Point(152, 174);
            this.btn_removeAccount.Name = "btn_removeAccount";
            this.btn_removeAccount.Size = new System.Drawing.Size(114, 23);
            this.btn_removeAccount.TabIndex = 10;
            this.btn_removeAccount.Text = "Remove Selected";
            this.btn_removeAccount.UseVisualStyleBackColor = true;
            this.btn_removeAccount.Click += new System.EventHandler(this.btn_removeAccount_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(272, 20);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(49, 23);
            this.btn_refresh.TabIndex = 11;
            this.btn_refresh.Text = "refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 209);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_removeAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_sendAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_sendMoneyId);
            this.Controls.Add(this.btn_sendMoney);
            this.Controls.Add(this.btn_createAccount);
            this.Controls.Add(this.lb_accountListBox);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_person_id);
            this.Controls.Add(this.lbl_name);
            this.Name = "User";
            this.Text = "Bankia";
            this.Load += new System.EventHandler(this.user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_person_id;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.CheckedListBox lb_accountListBox;
        private System.Windows.Forms.Button btn_createAccount;
        private System.Windows.Forms.Button btn_sendMoney;
        private System.Windows.Forms.TextBox tbx_sendMoneyId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_sendAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_removeAccount;
        private System.Windows.Forms.Button btn_refresh;
    }
}