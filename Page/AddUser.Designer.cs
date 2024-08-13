namespace Kasir.Page
{
    partial class AddUser
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
            TbName = new TextBox();
            TbAddress = new TextBox();
            TbPhoneNumber = new TextBox();
            TbUsername = new TextBox();
            TbPassword = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // TbName
            // 
            TbName.Font = new Font("Consolas", 13.8F);
            TbName.Location = new Point(57, 92);
            TbName.Name = "TbName";
            TbName.PlaceholderText = "Name";
            TbName.Size = new Size(465, 34);
            TbName.TabIndex = 4;
            // 
            // TbAddress
            // 
            TbAddress.Font = new Font("Consolas", 13.8F);
            TbAddress.Location = new Point(57, 177);
            TbAddress.Name = "TbAddress";
            TbAddress.PlaceholderText = "Address";
            TbAddress.Size = new Size(465, 34);
            TbAddress.TabIndex = 5;
            // 
            // TbPhoneNumber
            // 
            TbPhoneNumber.Font = new Font("Consolas", 13.8F);
            TbPhoneNumber.Location = new Point(58, 219);
            TbPhoneNumber.Name = "TbPhoneNumber";
            TbPhoneNumber.PlaceholderText = "Phone Number";
            TbPhoneNumber.Size = new Size(465, 34);
            TbPhoneNumber.TabIndex = 6;
            // 
            // TbUsername
            // 
            TbUsername.Font = new Font("Consolas", 13.8F);
            TbUsername.Location = new Point(58, 261);
            TbUsername.Name = "TbUsername";
            TbUsername.PlaceholderText = "Username";
            TbUsername.Size = new Size(465, 34);
            TbUsername.TabIndex = 7;
            // 
            // TbPassword
            // 
            TbPassword.Font = new Font("Consolas", 13.8F);
            TbPassword.Location = new Point(58, 303);
            TbPassword.Name = "TbPassword";
            TbPassword.PlaceholderText = "Password";
            TbPassword.Size = new Size(465, 34);
            TbPassword.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Consolas", 13.8F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Staff" });
            comboBox1.Location = new Point(195, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(330, 35);
            comboBox1.TabIndex = 9;
            comboBox1.Tag = "";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(382, 363);
            button1.Name = "button1";
            button1.Size = new Size(141, 39);
            button1.TabIndex = 10;
            button1.Text = "Add User";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddBtn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 137);
            label1.Name = "label1";
            label1.Size = new Size(129, 27);
            label1.TabIndex = 11;
            label1.Text = "User Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(214, 33);
            label2.Name = "label2";
            label2.Size = new Size(135, 33);
            label2.TabIndex = 21;
            label2.Text = "Add User";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 429);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(TbPassword);
            Controls.Add(TbUsername);
            Controls.Add(TbPhoneNumber);
            Controls.Add(TbAddress);
            Controls.Add(TbName);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximumSize = new Size(596, 476);
            MinimumSize = new Size(596, 476);
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TbName;
        private TextBox TbAddress;
        private TextBox TbPhoneNumber;
        private TextBox TbUsername;
        private TextBox TbPassword;
        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}