namespace Kasir.Page
{
    partial class EditUser
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            TbPassword = new TextBox();
            TbUsername = new TextBox();
            TbPhoneNumber = new TextBox();
            TbAddress = new TextBox();
            TbName = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 137);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 27);
            label1.TabIndex = 19;
            label1.Text = "User Type";
            // 
            // button1
            // 
            button1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(382, 363);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(141, 39);
            button1.TabIndex = 18;
            button1.Text = "Edit User";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Consolas", 13.8F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Staff" });
            comboBox1.Location = new Point(195, 134);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(327, 35);
            comboBox1.TabIndex = 17;
            comboBox1.Tag = "";
            // 
            // TbPassword
            // 
            TbPassword.Font = new Font("Consolas", 13.8F);
            TbPassword.Location = new Point(58, 303);
            TbPassword.Margin = new Padding(4);
            TbPassword.Name = "TbPassword";
            TbPassword.PlaceholderText = "Password";
            TbPassword.Size = new Size(465, 34);
            TbPassword.TabIndex = 16;
            // 
            // TbUsername
            // 
            TbUsername.Font = new Font("Consolas", 13.8F);
            TbUsername.Location = new Point(58, 261);
            TbUsername.Margin = new Padding(4);
            TbUsername.Name = "TbUsername";
            TbUsername.PlaceholderText = "Username";
            TbUsername.Size = new Size(465, 34);
            TbUsername.TabIndex = 15;
            // 
            // TbPhoneNumber
            // 
            TbPhoneNumber.Font = new Font("Consolas", 13.8F);
            TbPhoneNumber.Location = new Point(58, 219);
            TbPhoneNumber.Margin = new Padding(4);
            TbPhoneNumber.Name = "TbPhoneNumber";
            TbPhoneNumber.PlaceholderText = "Phone Number";
            TbPhoneNumber.Size = new Size(465, 34);
            TbPhoneNumber.TabIndex = 14;
            // 
            // TbAddress
            // 
            TbAddress.Font = new Font("Consolas", 13.8F);
            TbAddress.Location = new Point(57, 177);
            TbAddress.Margin = new Padding(4);
            TbAddress.Name = "TbAddress";
            TbAddress.PlaceholderText = "Address";
            TbAddress.Size = new Size(465, 34);
            TbAddress.TabIndex = 13;
            // 
            // TbName
            // 
            TbName.Font = new Font("Consolas", 13.8F);
            TbName.Location = new Point(57, 92);
            TbName.Margin = new Padding(4);
            TbName.Name = "TbName";
            TbName.PlaceholderText = "Name";
            TbName.Size = new Size(465, 34);
            TbName.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 34);
            label2.Name = "label2";
            label2.Size = new Size(150, 33);
            label2.TabIndex = 20;
            label2.Text = "Edit User";
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
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
            Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximumSize = new Size(596, 476);
            MinimumSize = new Size(596, 476);
            Name = "EditUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox TbPassword;
        private TextBox TbUsername;
        private TextBox TbPhoneNumber;
        private TextBox TbAddress;
        private TextBox TbName;
        private Label label2;
    }
}