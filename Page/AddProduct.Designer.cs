namespace Kasir.Page
{
    partial class AddProduct
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
            TbStock = new TextBox();
            TbPrice = new TextBox();
            AddBtn = new Button();
            SuspendLayout();
            // 
            // TbName
            // 
            TbName.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbName.Location = new Point(45, 38);
            TbName.Name = "TbName";
            TbName.PlaceholderText = "Name Product";
            TbName.Size = new Size(361, 39);
            TbName.TabIndex = 0;
            // 
            // TbStock
            // 
            TbStock.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbStock.Location = new Point(45, 90);
            TbStock.Name = "TbStock";
            TbStock.PlaceholderText = "Stock";
            TbStock.Size = new Size(361, 39);
            TbStock.TabIndex = 1;
            TbStock.TextChanged += TbStock_TextChanged;
            // 
            // TbPrice
            // 
            TbPrice.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbPrice.Location = new Point(45, 141);
            TbPrice.Name = "TbPrice";
            TbPrice.PlaceholderText = "Price";
            TbPrice.Size = new Size(361, 39);
            TbPrice.TabIndex = 2;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(296, 213);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(110, 35);
            AddBtn.TabIndex = 4;
            AddBtn.Text = "Add Product";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click_1;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 282);
            Controls.Add(AddBtn);
            Controls.Add(TbPrice);
            Controls.Add(TbStock);
            Controls.Add(TbName);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximumSize = new Size(480, 329);
            MinimumSize = new Size(480, 329);
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbName;
        private TextBox TbStock;
        private TextBox TbPrice;
        private Button AddBtn;
    }
}