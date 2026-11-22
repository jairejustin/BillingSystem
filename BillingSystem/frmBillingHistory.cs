using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BillingSystem.Database;

namespace BillingSystem
{
    public partial class frmBillingHistory : Form
    {
        
        private readonly int _customerId;

        public frmBillingHistory(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
        }

        private void frmBillingHistory_Load(object sender, EventArgs e)
        {
            try
            {
                
                string? customerName = GetCustomerName(_customerId);

                if (customerName == null)
                {
                    MessageBox.Show("The selected customer could not be found in the database.",
                        "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                lblCustomerName.Text = "Billing History - " + customerName;
                LoadBillingRecords(_customerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Returns the customer's full name, or null if no such customer exists
        private string? GetCustomerName(int customerId)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string sql = "SELECT FullName FROM Customers WHERE CustomerID = @CustomerID;";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);

                    object? result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

        // Loads ONLY this customer's billing records into the grid
        private void LoadBillingRecords(int customerId)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT BillingMonth, PreviousReading, PresentReading,
                                      Consumption, RatePerCubic, TotalAmount, Status
                               FROM   Billing
                               WHERE  CustomerID = @CustomerID
                               ORDER  BY BillingDate ASC;";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvBilling.DataSource = dt;

                        
                        dgvBilling.Columns["BillingMonth"].HeaderText = "Billing Month";
                        dgvBilling.Columns["PreviousReading"].HeaderText = "Previous Reading";
                        dgvBilling.Columns["PresentReading"].HeaderText = "Present Reading";
                        dgvBilling.Columns["RatePerCubic"].HeaderText = "Rate Per Cubic";
                        dgvBilling.Columns["TotalAmount"].HeaderText = "Total Amount";

                        // Show money with 2 decimals
                        dgvBilling.Columns["RatePerCubic"].DefaultCellStyle.Format = "N2";
                        dgvBilling.Columns["TotalAmount"].DefaultCellStyle.Format = "N2";

                        // Popup 2: this customer has no billing records
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No billing records found for this customer.",
                                "No Records Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}