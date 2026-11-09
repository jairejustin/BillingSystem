using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace BillingSystem
{
    public partial class frmChangePassword : Form
    {   
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Returns a list of every rule the password breaks.
        // An empty list means the password passed all 5 rules.
        private List<string> GetPasswordProblems(string password)
        {
            List<string> problems = new List<string>();

            if (password.Length < 8)
                problems.Add("At least 8 characters long");

            if (!password.Any(char.IsUpper))
                problems.Add("At least one uppercase letter (A-Z)");

            if (!password.Any(char.IsLower))
                problems.Add("At least one lowercase letter (a-z)");

            if (!password.Any(char.IsDigit))
                problems.Add("At least one number (0-9)");

            if (!password.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
                problems.Add("At least one special character (e.g. !@#$%^&*)");

            return problems;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            //Check 0: nonw of the three textboxes are empty
            if (string.IsNullOrEmpty(txtCurrentPassword.Text) ||
                string.IsNullOrEmpty(txtNewPassword.Text) ||
                string.IsNullOrEmpty(txtRetypePassword.Text))
            {
                MessageBox.Show("Please fill in all threee fields",
                "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check 1 (Stage 3): current password must match the database

            // Check 2: New and Retype must match exactly
            if (txtNewPassword.Text != txtRetypePassword.Text)
            {
                MessageBox.Show("The new password and retyped passowrd do not match",
                "Passwords Do not match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRetypePassword.Clear();
                txtRetypePassword.Focus();
                return;
            }

            // Check 3: New password must meet all 5 rules
            List<string> problems = GetPasswordProblems(txtNewPassword.Text);
            if (problems.Count > 0)
            {
                MessageBox.Show("The new password is missing:\n\n- " + string.Join("\n- ", problems),
                    "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            // Stage 3 will save to the database here
            MessageBox.Show("All checks passed (test only, nothing saved yet).");
        }
    }
}
