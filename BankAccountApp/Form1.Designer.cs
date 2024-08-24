namespace BankAccountApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtInitialBalance = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(80, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(270, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Initial Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(472, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAccountNumber.Location = new System.Drawing.Point(60, 143);
            this.txtAccountNumber.Multiline = true;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(127, 31);
            this.txtAccountNumber.TabIndex = 3;
            // 
            // txtInitialBalance
            // 
            this.txtInitialBalance.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtInitialBalance.Location = new System.Drawing.Point(242, 143);
            this.txtInitialBalance.Multiline = true;
            this.txtInitialBalance.Name = "txtInitialBalance";
            this.txtInitialBalance.Size = new System.Drawing.Size(127, 31);
            this.txtInitialBalance.TabIndex = 4;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAmount.Location = new System.Drawing.Point(427, 143);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(127, 31);
            this.txtAmount.TabIndex = 5;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(60, 218);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(127, 29);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click_1);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(242, 218);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(127, 29);
            this.btnDeposit.TabIndex = 7;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click_1);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(427, 218);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(127, 29);
            this.btnWithdraw.TabIndex = 8;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click_1);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblResult.Location = new System.Drawing.Point(124, 271);
            this.lblResult.Multiline = true;
            this.lblResult.Name = "lblResult";
            this.lblResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblResult.Size = new System.Drawing.Size(361, 118);
            this.lblResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::BankAccountApp.Properties.Resources.background183640;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtInitialBalance);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BankAccount";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtInitialBalance;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox lblResult;
    }
}

