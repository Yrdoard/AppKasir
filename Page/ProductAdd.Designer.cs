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
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(302, 211);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(110, 35);
            AddBtn.TabIndex = 8;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // TbQuantity
            // 
            TbQuantity.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbQuantity.Location = new Point(51, 131);
            TbQuantity.Name = "TbQuantity";
            TbQuantity.PlaceholderText = "Quantity";
            TbQuantity.Size = new Size(361, 39);
            TbQuantity.TabIndex = 6;
            // 
            // TbName
            // 
            TbName.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbName.Location = new Point(51, 79);
            TbName.Name = "TbName";
            TbName.PlaceholderText = "Name";
            TbName.Size = new Size(361, 39);
            TbName.TabIndex = 5;
            // 
            // ProductAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 282);
            Controls.Add(AddBtn);
            Controls.Add(TbQuantity);
            Controls.Add(TbName);
            MaximumSize = new Size(480, 329);
            MinimumSize = new Size(480, 329);
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
    }
}