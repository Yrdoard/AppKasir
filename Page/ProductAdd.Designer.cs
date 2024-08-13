namespace Kasir.Page
{
    partial class ProductAdd
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
            AddBtn = new Button();
            TbQuantity = new TextBox();
            TbName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(302, 182);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(110, 32);
            AddBtn.TabIndex = 8;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // TbQuantity
            // 
            TbQuantity.Font = new Font("Consolas", 13.8F);
            TbQuantity.Location = new Point(51, 126);
            TbQuantity.Name = "TbQuantity";
            TbQuantity.PlaceholderText = "Quantity";
            TbQuantity.Size = new Size(361, 34);
            TbQuantity.TabIndex = 6;
            // 
            // TbName
            // 
            TbName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TbName.Font = new Font("Consolas", 13.8F);
            TbName.Location = new Point(51, 86);
            TbName.Name = "TbName";
            TbName.PlaceholderText = "Name";
            TbName.Size = new Size(361, 34);
            TbName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 31);
            label1.Name = "label1";
            label1.Size = new Size(225, 33);
            label1.TabIndex = 9;
            label1.Text = "Select Product";
            // 
            // ProductAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 254);
            Controls.Add(label1);
            Controls.Add(AddBtn);
            Controls.Add(TbQuantity);
            Controls.Add(TbName);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximumSize = new Size(480, 301);
            MinimumSize = new Size(480, 301);
            Name = "ProductAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private TextBox TbQuantity;
        private TextBox TbName;
        private Label label1;
    }
}