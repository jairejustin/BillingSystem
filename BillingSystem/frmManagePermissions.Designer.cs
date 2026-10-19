namespace BillingSystem
{
    partial class frmManagePermissions
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
            lblRole = new Label();
            cmbRole = new ComboBox();
            chkAddCustomer = new CheckBox();
            chkEditCustomer = new CheckBox();
            chkDeleteCustomer = new CheckBox();
            chkAnalytics = new CheckBox();
            chkExportExcel = new CheckBox();
            chkExportPdf = new CheckBox();
            chkAuditLogs = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(110, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(205, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Permissions";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblRole.Location = new Point(21, 64);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(98, 23);
            lblRole.TabIndex = 1;
            lblRole.Text = "Select Role:";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(124, 61);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(269, 28);
            cmbRole.TabIndex = 2;
            cmbRole.Text = "Dropdown: items = Admin, Cashier";
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // chkAddCustomer
            // 
            chkAddCustomer.AutoSize = true;
            chkAddCustomer.Font = new Font("Segoe UI", 10.2F);
            chkAddCustomer.Location = new Point(71, 110);
            chkAddCustomer.Name = "chkAddCustomer";
            chkAddCustomer.Size = new Size(142, 27);
            chkAddCustomer.TabIndex = 3;
            chkAddCustomer.Text = "Add Customer";
            chkAddCustomer.UseVisualStyleBackColor = true;
            // 
            // chkEditCustomer
            // 
            chkEditCustomer.AutoSize = true;
            chkEditCustomer.Font = new Font("Segoe UI", 10.2F);
            chkEditCustomer.Location = new Point(71, 140);
            chkEditCustomer.Name = "chkEditCustomer";
            chkEditCustomer.Size = new Size(140, 27);
            chkEditCustomer.TabIndex = 4;
            chkEditCustomer.Text = "Edit Customer";
            chkEditCustomer.UseVisualStyleBackColor = true;
            // 
            // chkDeleteCustomer
            // 
            chkDeleteCustomer.AutoSize = true;
            chkDeleteCustomer.Font = new Font("Segoe UI", 10.2F);
            chkDeleteCustomer.Location = new Point(71, 170);
            chkDeleteCustomer.Name = "chkDeleteCustomer";
            chkDeleteCustomer.Size = new Size(160, 27);
            chkDeleteCustomer.TabIndex = 5;
            chkDeleteCustomer.Text = "Delete Customer";
            chkDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // chkAnalytics
            // 
            chkAnalytics.AutoSize = true;
            chkAnalytics.Font = new Font("Segoe UI", 10.2F);
            chkAnalytics.Location = new Point(71, 200);
            chkAnalytics.Name = "chkAnalytics";
            chkAnalytics.Size = new Size(99, 27);
            chkAnalytics.TabIndex = 6;
            chkAnalytics.Text = "Analytics";
            chkAnalytics.UseVisualStyleBackColor = true;
            // 
            // chkExportExcel
            // 
            chkExportExcel.AutoSize = true;
            chkExportExcel.Font = new Font("Segoe UI", 10.2F);
            chkExportExcel.Location = new Point(71, 230);
            chkExportExcel.Name = "chkExportExcel";
            chkExportExcel.Size = new Size(145, 27);
            chkExportExcel.TabIndex = 7;
            chkExportExcel.Text = "Export to Excel";
            chkExportExcel.UseVisualStyleBackColor = true;
            // 
            // chkExportPdf
            // 
            chkExportPdf.AutoSize = true;
            chkExportPdf.Font = new Font("Segoe UI", 10.2F);
            chkExportPdf.Location = new Point(71, 260);
            chkExportPdf.Name = "chkExportPdf";
            chkExportPdf.Size = new Size(137, 27);
            chkExportPdf.TabIndex = 8;
            chkExportPdf.Text = "Export to PDF";
            chkExportPdf.UseVisualStyleBackColor = true;
            // 
            // chkAuditLogs
            // 
            chkAuditLogs.AutoSize = true;
            chkAuditLogs.Font = new Font("Segoe UI", 10.2F);
            chkAuditLogs.Location = new Point(71, 290);
            chkAuditLogs.Name = "chkAuditLogs";
            chkAuditLogs.Size = new Size(113, 27);
            chkAuditLogs.TabIndex = 9;
            chkAuditLogs.Text = "Audit Logs";
            chkAuditLogs.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Location = new Point(71, 342);
            button1.Name = "button1";
            button1.Size = new Size(149, 41);
            button1.TabIndex = 10;
            button1.Text = "Save Permissions";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnSave_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.YellowGreen;
            button2.Location = new Point(240, 342);
            button2.Name = "button2";
            button2.Size = new Size(93, 41);
            button2.TabIndex = 11;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnClose_Click;
            // 
            // frmManagePermissions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(432, 413);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkAuditLogs);
            Controls.Add(chkExportPdf);
            Controls.Add(chkExportExcel);
            Controls.Add(chkAnalytics);
            Controls.Add(chkDeleteCustomer);
            Controls.Add(chkEditCustomer);
            Controls.Add(chkAddCustomer);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmManagePermissions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Permissions";
            Load += frmManagePermissions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblRole;
        private ComboBox cmbRole;
        private CheckBox chkAddCustomer;
        private CheckBox chkEditCustomer;
        private CheckBox chkDeleteCustomer;
        private CheckBox chkAnalytics;
        private CheckBox chkExportExcel;
        private CheckBox chkExportPdf;
        private CheckBox chkAuditLogs;
        private Button button1;
        private Button button2;
    }
}