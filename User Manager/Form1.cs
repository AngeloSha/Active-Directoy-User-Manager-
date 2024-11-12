using System;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;

namespace ActiveDirectoryManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUsers(txtSearch.Text);
        }
        private void btnOpenTimeTacForm_Click(object sender, EventArgs e)
        {
            Form2 timeTacForm = new Form2();
            timeTacForm.Show();
        }
        private void SearchUsers(string username)
        {
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
            {
                UserPrincipal user = new UserPrincipal(context)
                {
                    SamAccountName = $"*{username}*"
                };

                PrincipalSearcher searcher = new PrincipalSearcher(user);
                lvUsers.Items.Clear();

                foreach (var result in searcher.FindAll())
                {
                    UserPrincipal foundUser = result as UserPrincipal;
                    if (foundUser != null)
                    {
                        ListViewItem item = new ListViewItem(new[]
                        {
                            foundUser.SamAccountName,
                            foundUser.DisplayName,
                            foundUser.EmailAddress
                        });
                        lvUsers.Items.Add(item);
                    }
                }
            }
        }

        private void lvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count > 0)
            {
                string selectedUser = lvUsers.SelectedItems[0].Text;
                DisplayUserInfo(selectedUser);
                LoadUserRoles(selectedUser);
            }
        }

        private void DisplayUserInfo(string username)
        {
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
            {
                UserPrincipal user = UserPrincipal.FindByIdentity(context, username);
                if (user != null)
                {
                    txtUsername.Text = user.SamAccountName ?? string.Empty;
                    txtDisplayName.Text = user.DisplayName ?? string.Empty;
                    txtEmail.Text = user.EmailAddress ?? string.Empty;
                    txtDescription.Text = user.Description ?? string.Empty;
                }
            }
        }

        private void LoadUserRoles(string username)
        {
            lvUserRoles.Items.Clear();
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
            {
                UserPrincipal user = UserPrincipal.FindByIdentity(context, username);
                if (user != null)
                {
                    foreach (var group in user.GetGroups())
                    {
                        lvUserRoles.Items.Add(new ListViewItem(group.Name));
                    }
                }
            }
        }

        private void LoadAllUsers()
        {
            lvAllUsers.Items.Clear();
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
            {
                UserPrincipal userPrincipal = new UserPrincipal(context);
                PrincipalSearcher searcher = new PrincipalSearcher(userPrincipal);
                foreach (var result in searcher.FindAll())
                {
                    UserPrincipal user = result as UserPrincipal;
                    if (user != null)
                    {
                        ListViewItem item = new ListViewItem(new[]
                        {
                            user.SamAccountName,
                            user.DisplayName,
                            user.EmailAddress
                        });
                        lvAllUsers.Items.Add(item);
                    }
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadAllUsers();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string newPassword = txtNewPassword.Text;

            using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
            {
                UserPrincipal user = UserPrincipal.FindByIdentity(context, username);
                if (user != null)
                {
                    user.SetPassword(newPassword);
                    MessageBox.Show("Password reset successfully.");
                }
            }
        }
        private void btnUnlockAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
            {
                UserPrincipal user = UserPrincipal.FindByIdentity(context, username);
                if (user != null)
                {
                    user.UnlockAccount();
                    MessageBox.Show("Account unlocked successfully.");
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
        }
        private void btnAddRole_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string roleName = txtRole.Text;

            if (string.IsNullOrWhiteSpace(roleName))
            {
                MessageBox.Show("Please enter a role name.");
                return;
            }

            using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
            {
                UserPrincipal user = UserPrincipal.FindByIdentity(context, username);
                GroupPrincipal group = GroupPrincipal.FindByIdentity(context, roleName);

                if (user != null && group != null)
                {
                    group.Members.Add(user);
                    group.Save();
                    MessageBox.Show("Role added successfully.");
                }
                else
                {
                    MessageBox.Show("User or role not found.");
                }
            }
        }

        private void lblDisplayName_Click(object sender, EventArgs e)
        {

        }
    }
}