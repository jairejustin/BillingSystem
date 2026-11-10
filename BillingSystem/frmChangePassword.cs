using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using MySql.Data.MySqlClient;
using BillingSystem.Database;
using BillingSystem.Utils;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check 0: none of the three fields may be empty
            if (string.IsNullOrEmpty(txtCurrentPassword.Text) ||
                string.IsNullOrEmpty(txtNewPassword.Text) ||
                string.IsNullOrEmpty(txtRetypePassword.Text))
            {
                MessageBox.Show("Please fill in all three password fields.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Check 1: current password must match the database
                if (!VerifyCurrentPassword(txtCurrentPassword.Text))
                {
                    MessageBox.Show("The current password is incorrect.",
                        "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCurrentPassword.Clear();
                    txtCurrentPassword.Focus();
                    return;
                }

                // Check 2: New and Retype must match exactly
                if (txtNewPassword.Text != txtRetypePassword.Text)
                {
                    MessageBox.Show("The new password and the retyped password do not match.",
                        "Passwords Do Not Match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                // All checks passed: save to the database
                if (UpdatePassword(txtNewPassword.Text))
                {
                    MessageBox.Show("Your password was changed successfully.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The password could not be updated. Please try again.",
                        "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Returns true only if the typed password exactly matches
        // the one stored for the logged-in user.
        private bool VerifyCurrentPassword(string enteredPassword)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string sql = "SELECT Password FROM Users WHERE UserID = @UserID;";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", AppSession.CurrentUserID);

                    object result = cmd.ExecuteScalar();

                    if (result == null)
                        return false;

                    string storedPassword = result.ToString();
                    return storedPassword == enteredPassword;
                }
            }
        }

        // Saves the new password for the logged-in user only.
        // Returns true if exactly one row was updated.
        private bool UpdatePassword(string newPassword)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string sql = "UPDATE Users SET Password = @NewPassword WHERE UserID = @UserID;";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                    cmd.Parameters.AddWithValue("@UserID", AppSession.CurrentUserID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected == 1;
                }
            }
        }


    }
}
