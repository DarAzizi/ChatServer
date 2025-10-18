namespace ChatServer   // ✅ au lieu de ChatClient
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblUser = new Label();
            lblPassword = new Label();
            lblStatus = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnLoginLogout = new Button();

            // lblUser
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(216, 84);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(131, 21);
            lblUser.TabIndex = 0;
            lblUser.Text = "Nom d’utilisateur";

            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(245, 142);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(102, 21);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Mot de passe";

            // lblStatus
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(267, 282);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(142, 25);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "🔴 Déconnecté.";

            // txtUser
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(394, 76);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(242, 29);
            txtUser.TabIndex = 3;

            // txtPassword
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(394, 132);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(242, 29);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;

            // btnLoginLogout
            btnLoginLogout.BackColor = Color.Green;
            btnLoginLogout.ForeColor = Color.White;
            btnLoginLogout.Location = new Point(394, 195);
            btnLoginLogout.Name = "btnLoginLogout";
            btnLoginLogout.Size = new Size(127, 44);
            btnLoginLogout.TabIndex = 5;
            btnLoginLogout.Text = "Connexion";
            btnLoginLogout.UseVisualStyleBackColor = false;
            btnLoginLogout.Click += btnLoginLogout_Click;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 450);
            Controls.Add(btnLoginLogout);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(lblStatus);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPassword;
        private Label lblStatus;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnLoginLogout;
    }
}