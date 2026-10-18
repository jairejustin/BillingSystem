namespace BillingSystem
{
    partial class frmAnalytics
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
            lblTotalCustomers = new Label();
            lblTotalRevenue = new Label();
            lblTotalUnpaid = new Label();
            lblTop5Title = new Label();
            plotMonthlyRevenue = new ScottPlot.WinForms.FormsPlot();
            plotPaidUnpaid = new ScottPlot.WinForms.FormsPlot();
            dgvTop5 = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            TotalConsumption = new DataGridViewTextBoxColumn();
            TotalBilled = new DataGridViewTextBoxColumn();
            btnCloseAnalytics = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTop5).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(346, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(312, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Analytics Dashboard";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCustomers.Location = new Point(15, 60);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(176, 23);
            lblTotalCustomers.TabIndex = 1;
            lblTotalCustomers.Text = "Total Customers: 0";
            lblTotalCustomers.Click += lblTotalCustomers_Click;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Arial", 12F);
            lblTotalRevenue.Location = new Point(343, 60);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(198, 23);
            lblTotalRevenue.TabIndex = 2;
            lblTotalRevenue.Text = "Total Revenue: ₱0.00";
            // 
            // lblTotalUnpaid
            // 
            lblTotalUnpaid.AutoSize = true;
            lblTotalUnpaid.Font = new Font("Arial", 12F);
            lblTotalUnpaid.Location = new Point(729, 60);
            lblTotalUnpaid.Name = "lblTotalUnpaid";
            lblTotalUnpaid.Size = new Size(182, 23);
            lblTotalUnpaid.TabIndex = 3;
            lblTotalUnpaid.Text = "Total Unpaid: ₱0.00";
            // 
            // lblTop5Title
            // 
            lblTop5Title.AutoSize = true;
            lblTop5Title.Font = new Font("Arial", 12F);
            lblTop5Title.Location = new Point(12, 358);
            lblTop5Title.Name = "lblTop5Title";
            lblTop5Title.Size = new Size(306, 23);
            lblTop5Title.TabIndex = 4;
            lblTop5Title.Text = "Top 5 Customers by Consumption";
            // 
            // plotMonthlyRevenue
            // 
            plotMonthlyRevenue.Location = new Point(18, 104);
            plotMonthlyRevenue.Name = "plotMonthlyRevenue";
            plotMonthlyRevenue.Size = new Size(523, 236);
            plotMonthlyRevenue.TabIndex = 5;
            // 
            // plotPaidUnpaid
            // 
            plotPaidUnpaid.Location = new Point(566, 104);
            plotPaidUnpaid.Name = "plotPaidUnpaid";
            plotPaidUnpaid.Size = new Size(404, 236);
            plotPaidUnpaid.TabIndex = 6;
            // 
            // dgvTop5
            // 
            dgvTop5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTop5.Columns.AddRange(new DataGridViewColumn[] { FullName, TotalConsumption, TotalBilled });
            dgvTop5.Location = new Point(12, 384);
            dgvTop5.Name = "dgvTop5";
            dgvTop5.RowHeadersWidth = 51;
            dgvTop5.Size = new Size(958, 158);
            dgvTop5.TabIndex = 7;
            // 
            // FullName
            // 
            FullName.HeaderText = "Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.Width = 302;
            // 
            // TotalConsumption
            // 
            TotalConsumption.HeaderText = "Consumption";
            TotalConsumption.MinimumWidth = 6;
            TotalConsumption.Name = "TotalConsumption";
            TotalConsumption.Width = 301;
            // 
            // TotalBilled
            // 
            TotalBilled.HeaderText = "Total Bill";
            TotalBilled.MinimumWidth = 6;
            TotalBilled.Name = "TotalBilled";
            TotalBilled.Width = 302;
            // 
            // btnCloseAnalytics
            // 
            btnCloseAnalytics.BackColor = Color.YellowGreen;
            btnCloseAnalytics.Location = new Point(846, 548);
            btnCloseAnalytics.Name = "btnCloseAnalytics";
            btnCloseAnalytics.Size = new Size(109, 43);
            btnCloseAnalytics.TabIndex = 8;
            btnCloseAnalytics.Text = "Close";
            btnCloseAnalytics.UseVisualStyleBackColor = false;
            btnCloseAnalytics.Click += btnCloseAnalytics_Click;
            // 
            // frmAnalytics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(982, 603);
            Controls.Add(btnCloseAnalytics);
            Controls.Add(dgvTop5);
            Controls.Add(plotPaidUnpaid);
            Controls.Add(plotMonthlyRevenue);
            Controls.Add(lblTop5Title);
            Controls.Add(lblTotalUnpaid);
            Controls.Add(lblTotalRevenue);
            Controls.Add(lblTotalCustomers);
            Controls.Add(lblTitle);
            Name = "frmAnalytics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System - Analytics Dashboard";
            Load += frmAnalytics_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTop5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTotalCustomers;
        private Label lblTotalRevenue;
        private Label lblTotalUnpaid;
        private Label lblTop5Title;
        private ScottPlot.WinForms.FormsPlot plotMonthlyRevenue;
        private ScottPlot.WinForms.FormsPlot plotPaidUnpaid;
        private DataGridView dgvTop5;
        private Button btnCloseAnalytics;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn TotalConsumption;
        private DataGridViewTextBoxColumn TotalBilled;
    }
}