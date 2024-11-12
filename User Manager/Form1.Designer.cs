namespace ActiveDirectoryManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtSearch = new TextBox();
            btnSearch = new Button();
            lvUsers = new ListView();
            colUsername = new ColumnHeader();
            colDisplayName = new ColumnHeader();
            colEmail = new ColumnHeader();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblDisplayName = new Label();
            txtDisplayName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            btnResetPassword = new Button();
            lblRole = new Label();
            txtRole = new TextBox();
            btnAddRole = new Button();
            tabControl = new TabControl();
            tabSearch = new TabPage();
            btnUnlockAccount = new Button();
            tabRoles = new TabPage();
            lvUserRoles = new ListView();
            colRoleName = new ColumnHeader();
            tabAllUsers = new TabPage();
            lvAllUsers = new ListView();
            colAllUsername = new ColumnHeader();
            colAllDisplayName = new ColumnHeader();
            colAllEmail = new ColumnHeader();
            this.btnOpenTimeTacForm = new System.Windows.Forms.Button();
            tabControl.SuspendLayout();
            tabSearch.SuspendLayout();
            tabRoles.SuspendLayout();
            tabAllUsers.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(212, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lvUsers
            // 
            lvUsers.Columns.AddRange(new ColumnHeader[] { colUsername, colDisplayName, colEmail });
            lvUsers.FullRowSelect = true;
            lvUsers.Location = new Point(6, 34);
            lvUsers.Name = "lvUsers";
            lvUsers.Size = new Size(580, 150);
            lvUsers.TabIndex = 2;
            lvUsers.UseCompatibleStateImageBehavior = false;
            lvUsers.View = View.Details;
            lvUsers.SelectedIndexChanged += lvUsers_SelectedIndexChanged;
            // 
            // colUsername
            // 
            colUsername.Text = "Username";
            colUsername.Width = 100;
            // 
            // colDisplayName
            // 
            colDisplayName.Text = "Display Name";
            colDisplayName.Width = 150;
            // 
            // colEmail
            // 
            colEmail.Text = "Email";
            colEmail.Width = 150;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(6, 190);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(96, 190);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 23);
            txtUsername.TabIndex = 4;
            // 
            // lblDisplayName
            // 
            lblDisplayName.AutoSize = true;
            lblDisplayName.Location = new Point(6, 220);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(80, 15);
            lblDisplayName.TabIndex = 5;
            lblDisplayName.Text = "Display Name";
            lblDisplayName.Click += lblDisplayName_Click;
            // 
            // txtDisplayName
            // 
            txtDisplayName.Location = new Point(96, 220);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new Size(150, 23);
            txtDisplayName.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(6, 250);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(96, 251);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 23);
            txtEmail.TabIndex = 8;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(6, 280);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(96, 280);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(150, 23);
            txtDescription.TabIndex = 10;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(6, 310);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(84, 15);
            lblNewPassword.TabIndex = 11;
            lblNewPassword.Text = "New Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(96, 310);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(150, 23);
            txtNewPassword.TabIndex = 12;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(269, 310);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(133, 23);
            btnResetPassword.TabIndex = 13;
            btnResetPassword.Text = "Reset Password";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(6, 340);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(30, 15);
            lblRole.TabIndex = 14;
            lblRole.Text = "Role";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(96, 339);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(150, 23);
            txtRole.TabIndex = 15;
            // 
            // btnAddRole
            // 
            btnAddRole.Location = new Point(269, 340);
            btnAddRole.Name = "btnAddRole";
            btnAddRole.Size = new Size(75, 23);
            btnAddRole.TabIndex = 16;
            btnAddRole.Text = "Add Role";
            btnAddRole.UseVisualStyleBackColor = true;
            btnAddRole.Click += btnAddRole_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabSearch);
            tabControl.Controls.Add(tabRoles);
            tabControl.Controls.Add(tabAllUsers);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(600, 400);
            tabControl.TabIndex = 0;
            // 
            // tabSearch
            // 
            tabSearch.Controls.Add(txtSearch);
            tabSearch.Controls.Add(btnSearch);
            tabSearch.Controls.Add(lvUsers);
            tabSearch.Controls.Add(lblUsername);
            tabSearch.Controls.Add(txtUsername);
            tabSearch.Controls.Add(lblDisplayName);
            tabSearch.Controls.Add(txtDisplayName);
            tabSearch.Controls.Add(lblEmail);
            tabSearch.Controls.Add(txtEmail);
            tabSearch.Controls.Add(lblDescription);
            tabSearch.Controls.Add(txtDescription);
            tabSearch.Controls.Add(lblNewPassword);
            tabSearch.Controls.Add(txtNewPassword);
            tabSearch.Controls.Add(btnResetPassword);
            tabSearch.Controls.Add(lblRole);
            tabSearch.Controls.Add(txtRole);
            tabSearch.Controls.Add(btnAddRole);
            tabSearch.Controls.Add(btnUnlockAccount);
            tabSearch.Location = new Point(4, 24);
            tabSearch.Name = "tabSearch";
            tabSearch.Padding = new Padding(3);
            tabSearch.Size = new Size(592, 372);
            tabSearch.TabIndex = 0;
            tabSearch.Text = "Search";
            tabSearch.UseVisualStyleBackColor = true;
            this.tabSearch.Controls.Add(this.btnOpenTimeTacForm);
            // 
            // btnUnlockAccount
            // 
            btnUnlockAccount.Location = new Point(350, 340);
            btnUnlockAccount.Name = "btnUnlockAccount";
            btnUnlockAccount.Size = new Size(120, 23);
            btnUnlockAccount.TabIndex = 17;
            btnUnlockAccount.Text = "Unlock Account";
            btnUnlockAccount.UseVisualStyleBackColor = true;
            btnUnlockAccount.Click += btnUnlockAccount_Click;
            // 
            // tabRoles
            // 
            tabRoles.Controls.Add(lvUserRoles);
            tabRoles.Location = new Point(4, 24);
            tabRoles.Name = "tabRoles";
            tabRoles.Padding = new Padding(3);
            tabRoles.Size = new Size(592, 372);
            tabRoles.TabIndex = 1;
            tabRoles.Text = "User Roles";
            tabRoles.UseVisualStyleBackColor = true;
            // 
            // lvUserRoles
            // 
            lvUserRoles.Columns.AddRange(new ColumnHeader[] { colRoleName });
            lvUserRoles.FullRowSelect = true;
            lvUserRoles.Location = new Point(6, 6);
            lvUserRoles.Name = "lvUserRoles";
            lvUserRoles.Size = new Size(580, 359);
            lvUserRoles.TabIndex = 0;
            lvUserRoles.UseCompatibleStateImageBehavior = false;
            lvUserRoles.View = View.Details;
            // 
            // colRoleName
            // 
            colRoleName.Text = "Role Name";
            colRoleName.Width = 200;
            // 
            // tabAllUsers
            // 
            tabAllUsers.Controls.Add(lvAllUsers);
            tabAllUsers.Location = new Point(4, 24);
            tabAllUsers.Name = "tabAllUsers";
            tabAllUsers.Padding = new Padding(3);
            tabAllUsers.Size = new Size(592, 372);
            tabAllUsers.TabIndex = 2;
            tabAllUsers.Text = "All Users";
            tabAllUsers.UseVisualStyleBackColor = true;
            // 
            // lvAllUsers
            // 
            lvAllUsers.Columns.AddRange(new ColumnHeader[] { colAllUsername, colAllDisplayName, colAllEmail });
            lvAllUsers.FullRowSelect = true;
            lvAllUsers.Location = new Point(6, 6);
            lvAllUsers.Name = "lvAllUsers";
            lvAllUsers.Size = new Size(580, 359);
            lvAllUsers.TabIndex = 0;
            lvAllUsers.UseCompatibleStateImageBehavior = false;
            lvAllUsers.View = View.Details;
            // 
            // colAllUsername
            // 
            colAllUsername.Text = "Username";
            colAllUsername.Width = 100;
            // 
            // colAllDisplayName
            // 
            colAllDisplayName.Text = "Display Name";
            colAllDisplayName.Width = 150;
            // 
            // colAllEmail
            // 
            colAllEmail.Text = "Email";
            colAllEmail.Width = 150;
            // 
            // btnOpenTimeTacForm
            // 
            this.btnOpenTimeTacForm.Location = new System.Drawing.Point(475, 6);
            this.btnOpenTimeTacForm.Name = "btnOpenTimeTacForm";
            this.btnOpenTimeTacForm.Size = new System.Drawing.Size(111, 23);
            this.btnOpenTimeTacForm.TabIndex = 18;
            this.btnOpenTimeTacForm.Text = "TimeTac Creation";
            this.btnOpenTimeTacForm.UseVisualStyleBackColor = true;
            this.btnOpenTimeTacForm.Click += new System.EventHandler(this.btnOpenTimeTacForm_Click);
            // 
            // Form1
            // 
            ClientSize = new Size(624, 421);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Active Directory Manager";
            tabControl.ResumeLayout(false);
            tabSearch.ResumeLayout(false);
            tabSearch.PerformLayout();
            tabRoles.ResumeLayout(false);
            tabAllUsers.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ColumnHeader colDisplayName;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabRoles;
        private System.Windows.Forms.ListView lvUserRoles;
        private System.Windows.Forms.ColumnHeader colRoleName;
        private System.Windows.Forms.TabPage tabAllUsers;
        private System.Windows.Forms.ListView lvAllUsers;
        private System.Windows.Forms.ColumnHeader colAllUsername;
        private System.Windows.Forms.ColumnHeader colAllDisplayName;
        private System.Windows.Forms.ColumnHeader colAllEmail;
        private System.Windows.Forms.Button btnUnlockAccount;
        private System.Windows.Forms.Button btnOpenTimeTacForm;
    }
}