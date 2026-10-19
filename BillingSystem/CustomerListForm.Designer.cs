namespace BillingSystem
{
    partial class CustomerListForm
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
            dgvCustomers = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            Fullname = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            ContactNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnDelete = new Button();
            btnLogout = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAnalytics = new Button();
            btnExportExcel = new Button();
            btnExportPdf = new Button();
            btnAuditLog = new Button();
            btnManagePermissions = new Button();
            StatusStrip1 = new StatusStrip();
            lblStatusUser = new ToolStripStatusLabel();
            lblStatusSep = new ToolStripStatusLabel();
            lblStatusTime = new ToolStripStatusLabel();
            statusTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            StatusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Beige;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(26, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(161, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Customer List";
            // 
            // dgvCustomers
            // 
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { CustomerID, Fullname, Address, ContactNumber, Email, Balance });
            dgvCustomers.Location = new Point(26, 107);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(698, 274);
            dgvCustomers.TabIndex = 1;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            dgvCustomers.CellDoubleClick += dgvCustomers_CellDoubleClick;
            dgvCustomers.CellFormatting += dgvCustomers_CellFormatting;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "ID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            // 
            // Fullname
            // 
            Fullname.HeaderText = "Full name";
            Fullname.MinimumWidth = 6;
            Fullname.Name = "Fullname";
            Fullname.ReadOnly = true;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // ContactNumber
            // 
            ContactNumber.HeaderText = "Contact No.";
            ContactNumber.MinimumWidth = 6;
            ContactNumber.Name = "ContactNumber";
            ContactNumber.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Balance
            // 
            Balance.HeaderText = "Balance";
            Balance.MinimumWidth = 6;
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.YellowGreen;
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(26, 411);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 44);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Customer";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.YellowGreen;
            btnDelete.Location = new Point(203, 411);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 44);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.YellowGreen;
            btnLogout.Location = new Point(784, 411);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 44);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(143, 60);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(581, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.YellowGreen;
            btnSearch.Location = new Point(26, 53);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 41);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAnalytics
            // 
            btnAnalytics.BackColor = Color.YellowGreen;
            btnAnalytics.Location = new Point(752, 53);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Size = new Size(126, 44);
            btnAnalytics.TabIndex = 4;
            btnAnalytics.Text = "Analytics";
            btnAnalytics.UseVisualStyleBackColor = false;
            btnAnalytics.Click += btnAnalytics_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.YellowGreen;
            btnExportExcel.Location = new Point(752, 153);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(126, 44);
            btnExportExcel.TabIndex = 5;
            btnExportExcel.Text = "Export to Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = Color.YellowGreen;
            btnExportPdf.Location = new Point(752, 103);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(126, 44);
            btnExportPdf.TabIndex = 6;
            btnExportPdf.Text = "Export to PDF";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // btnAuditLog
            // 
            btnAuditLog.BackColor = Color.YellowGreen;
            btnAuditLog.Location = new Point(505, 411);
            btnAuditLog.Name = "btnAuditLog";
            btnAuditLog.Size = new Size(126, 44);
            btnAuditLog.TabIndex = 7;
            btnAuditLog.Text = "Audit Log";
            btnAuditLog.UseVisualStyleBackColor = false;
            btnAuditLog.Click += btnAuditLog_Click;
            // 
            // btnManagePermissions
            // 
            btnManagePermissions.BackColor = Color.YellowGreen;
            btnManagePermissions.Location = new Point(335, 411);
            btnManagePermissions.Name = "btnManagePermissions";
            btnManagePermissions.Size = new Size(164, 44);
            btnManagePermissions.TabIndex = 8;
            btnManagePermissions.Text = "Manage Permissions";
            btnManagePermissions.UseVisualStyleBackColor = false;
            btnManagePermissions.Click += btnManagePermissions_Click;
            // 
            // StatusStrip1
            // 
            StatusStrip1.ImageScalingSize = new Size(20, 20);
            StatusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusUser, lblStatusSep, lblStatusTime });
            StatusStrip1.Location = new Point(0, 459);
            StatusStrip1.Name = "StatusStrip1";
            StatusStrip1.Size = new Size(903, 26);
            StatusStrip1.TabIndex = 9;
            StatusStrip1.Text = "statusStrip1";
            // 
            // lblStatusUser
            // 
            lblStatusUser.Name = "lblStatusUser";
            lblStatusUser.Size = new Size(151, 20);
            lblStatusUser.Text = "toolStripStatusLabel1";
            // 
            // lblStatusSep
            // 
            lblStatusSep.Name = "lblStatusSep";
            lblStatusSep.Size = new Size(586, 20);
            lblStatusSep.Spring = true;
            lblStatusSep.Text = "toolStripStatusLabel2";
            // 
            // lblStatusTime
            // 
            lblStatusTime.Name = "lblStatusTime";
            lblStatusTime.Size = new Size(151, 20);
            lblStatusTime.Text = "toolStripStatusLabel3";
            // 
            // statusTimer
            // 
            statusTimer.Enabled = true;
            statusTimer.Interval = 1000;
            statusTimer.Tick += statusTimer_Tick;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(903, 485);
            Controls.Add(StatusStrip1);
            Controls.Add(btnManagePermissions);
            Controls.Add(btnAuditLog);
            Controls.Add(btnExportPdf);
            Controls.Add(btnExportExcel);
            Controls.Add(btnAnalytics);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnLogout);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvCustomers);
            Controls.Add(lblTitle);
            Name = "CustomerListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing Systemv1.0 - Customer List(C.B)";
            Load += CustomerListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            StatusStrip1.ResumeLayout(false);
            StatusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvCustomers;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnLogout;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn Fullname;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn ContactNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Balance;
        private Button btnAnalytics;
        private Button btnExportExcel;
        private Button btnExportPdf;
        private Button btnAuditLog;
        private Button btnManagePermissions;
        private StatusStrip StatusStrip1;
        private ToolStripStatusLabel lblStatusUser;
        private ToolStripStatusLabel lblStatusSep;
        private ToolStripStatusLabel lblStatusTime;
        private System.Windows.Forms.Timer statusTimer;
    }
}