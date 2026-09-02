namespace BillingSystem
{
    partial class AddCustomerForm
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblFullName = new Label();
            lblAddress = new Label();
            lblContact = new Label();
            lblEmail = new Label();
            lblBalance = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtFullname = new TextBox();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtBalance = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(119, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(195, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Customer";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10F);
            lblFullName.Location = new Point(48, 58);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(88, 23);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full name:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F);
            lblAddress.Location = new Point(48, 103);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(74, 23);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 10F);
            lblContact.Location = new Point(48, 150);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(106, 23);
            lblContact.TabIndex = 1;
            lblContact.Text = "Contact No.:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(48, 199);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 23);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 10F);
            lblBalance.Location = new Point(48, 242);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(73, 23);
            lblBalance.TabIndex = 1;
            lblBalance.Text = "Balance:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(186, 58);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(194, 27);
            txtFullname.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(186, 103);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(194, 27);
            txtAddress.TabIndex = 3;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(186, 150);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(194, 27);
            txtContact.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(186, 199);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(186, 242);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(194, 27);
            txtBalance.TabIndex = 3;
            txtBalance.Text = "0.00";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(20, 312);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 49);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(305, 312);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 49);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(162, 312);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 49);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 373);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtBalance);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(txtAddress);
            Controls.Add(txtFullname);
            Controls.Add(lblBalance);
            Controls.Add(lblEmail);
            Controls.Add(lblContact);
            Controls.Add(lblAddress);
            Controls.Add(lblFullName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System v3.0 - Add Customer (ML)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFullName;
        private Label lblAddress;
        private Label lblContact;
        private Label lblEmail;
        private Label lblBalance;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtFullname;
        private TextBox txtAddress;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtBalance;
        private Button btnSave;
        private Button btnClear;
        private Button btnBack;
    }
}