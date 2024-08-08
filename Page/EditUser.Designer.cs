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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 111);
            label1.Name = "label1";
            label1.Size = new Size(129, 27);
            label1.TabIndex = 19;
            label1.Text = "User Type";
            // 
            // button1
            // 
            button1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(306, 371);
            button1.Name = "button1";
            button1.Size = new Size(113, 36);
            button1.TabIndex = 18;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Staff" });
            comboBox1.Location = new Point(181, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(238, 40);
            comboBox1.TabIndex = 17;
            comboBox1.Tag = "";
            // 
            // TbPassword
            // 
            TbPassword.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbPassword.Location = new Point(46, 317);
            TbPassword.Name = "TbPassword";
            TbPassword.PlaceholderText = "Password";
            TbPassword.Size = new Size(373, 39);
            TbPassword.TabIndex = 16;
            // 
            // TbUsername
            // 
            TbUsername.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbUsername.Location = new Point(46, 263);
            TbUsername.Name = "TbUsername";
            TbUsername.PlaceholderText = "Username";
            TbUsername.Size = new Size(373, 39);
            TbUsername.TabIndex = 15;
            // 
            // TbPhoneNumber
            // 
            TbPhoneNumber.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbPhoneNumber.Location = new Point(46, 209);
            TbPhoneNumber.Name = "TbPhoneNumber";
            TbPhoneNumber.PlaceholderText = "Phone Number";
            TbPhoneNumber.Size = new Size(373, 39);
            TbPhoneNumber.TabIndex = 14;
            // 
            // TbAddress
            // 
            TbAddress.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbAddress.Location = new Point(46, 155);
            TbAddress.Name = "TbAddress";
            TbAddress.PlaceholderText = "Address";
            TbAddress.Size = new Size(373, 39);
            TbAddress.TabIndex = 13;
            // 
            // TbName
            // 
            TbName.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbName.Location = new Point(46, 43);
            TbName.Name = "TbName";
            TbName.PlaceholderText = "Name";
            TbName.Size = new Size(373, 39);
            TbName.TabIndex = 12;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 433);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(TbPassword);
            Controls.Add(TbUsername);
            Controls.Add(TbPhoneNumber);
            Controls.Add(TbAddress);
            Controls.Add(TbName);
            MaximumSize = new Size(480, 480);
            MinimumSize = new Size(480, 480);
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
    }
}