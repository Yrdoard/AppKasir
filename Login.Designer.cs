namespace Kasir
{
    partial class Login
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
            label1 = new Label();
            TbUsername = new TextBox();
            TbPassword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 51);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // TbUsername
            // 
            TbUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TbUsername.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbUsername.Location = new Point(48, 103);
            TbUsername.Name = "TbUsername";
            TbUsername.PlaceholderText = "Username";
            TbUsername.Size = new Size(307, 43);
            TbUsername.TabIndex = 1;
            // 
            // TbPassword
            // 
            TbPassword.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbPassword.Location = new Point(48, 182);
            TbPassword.Name = "TbPassword";
            TbPassword.PasswordChar = '*';
            TbPassword.PlaceholderText = "Password";
            TbPassword.Size = new Size(305, 43);
            TbPassword.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(245, 277);
            button1.Name = "button1";
            button1.Size = new Size(108, 42);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 353);
            Controls.Add(button1);
            Controls.Add(TbPassword);
            Controls.Add(TbUsername);
            Controls.Add(label1);
            MaximumSize = new Size(420, 400);
            MinimumSize = new Size(420, 400);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TbUsername;
        private TextBox TbPassword;
        private Button button1;
    }
}