namespace BillingSystem
{
    partial class frmChangePassword
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
            lblTitle = new Label();
            lblCurrent = new Label();
            lblNew = new Label();
            lblRetype = new Label();
            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtRetypePassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F);
            lblTitle.Location = new Point(119, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(161, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Change Password";
            // 
            // lblCurrent
            // 
            lblCurrent.AutoSize = true;
            lblCurrent.Font = new Font("Segoe UI", 10F);
            lblCurrent.Location = new Point(12, 80);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(147, 23);
            lblCurrent.TabIndex = 1;
            lblCurrent.Text = "Current Password:";
            // 
            // lblNew
            // 
            lblNew.AutoSize = true;
            lblNew.Font = new Font("Segoe UI", 10F);
            lblNew.Location = new Point(30, 146);
            lblNew.Name = "lblNew";
            lblNew.Size = new Size(123, 23);
            lblNew.TabIndex = 2;
            lblNew.Text = "New Password:";
            // 
            // lblRetype
            // 
            lblRetype.AutoSize = true;
            lblRetype.Font = new Font("Segoe UI", 10F);
            lblRetype.Location = new Point(12, 183);
            lblRetype.Name = "lblRetype";
            lblRetype.Size = new Size(141, 23);
            lblRetype.TabIndex = 3;
            lblRetype.Text = "Retype Password:";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(175, 79);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(125, 27);
            txtCurrentPassword.TabIndex = 4;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(175, 142);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(125, 27);
            txtNewPassword.TabIndex = 5;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtRetypePassword
            // 
            txtRetypePassword.Location = new Point(175, 182);
            txtRetypePassword.Name = "txtRetypePassword";
            txtRetypePassword.Size = new Size(125, 27);
            txtRetypePassword.TabIndex = 6;
            txtRetypePassword.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(106, 230);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(218, 230);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmChangePassword
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(402, 283);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtRetypePassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(lblRetype);
            Controls.Add(lblNew);
            Controls.Add(lblCurrent);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmChangePassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCurrent;
        private Label lblNew;
        private Label lblRetype;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private TextBox txtRetypePassword;
        private Button btnSave;
        private Button btnCancel;
    }
}