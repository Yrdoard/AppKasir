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
            TbPrice = new TextBox();
            TbStock = new TextBox();
            TbName = new TextBox();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(302, 211);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(110, 35);
            AddBtn.TabIndex = 8;
            AddBtn.Text = "Add Product";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // TbPrice
            // 
            TbPrice.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbPrice.Location = new Point(51, 139);
            TbPrice.Name = "TbPrice";
            TbPrice.PlaceholderText = "Price";
            TbPrice.Size = new Size(361, 39);
            TbPrice.TabIndex = 7;
            // 
            // TbStock
            // 
            TbStock.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbStock.Location = new Point(51, 88);
            TbStock.Name = "TbStock";
            TbStock.PlaceholderText = "Stock";
            TbStock.Size = new Size(361, 39);
            TbStock.TabIndex = 6;
            // 
            // TbName
            // 
            TbName.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbName.Location = new Point(51, 36);
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
            Controls.Add(TbPrice);
            Controls.Add(TbStock);
            Controls.Add(TbName);
            MaximumSize = new Size(480, 329);
            MinimumSize = new Size(480, 329);
            Name = "ProductAdd";
            Text = "ProductAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private TextBox TbPrice;
        private TextBox TbStock;
        private TextBox TbName;
    }
}