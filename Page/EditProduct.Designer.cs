namespace Kasir.Page
{
    partial class EditProduct
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
            EditBtn = new Button();
            TbPrice = new TextBox();
            TbStock = new TextBox();
            TbName = new TextBox();
            SuspendLayout();
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(278, 216);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(123, 35);
            EditBtn.TabIndex = 8;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // TbPrice
            // 
            TbPrice.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbPrice.Location = new Point(40, 143);
            TbPrice.Name = "TbPrice";
            TbPrice.PlaceholderText = "Price";
            TbPrice.Size = new Size(361, 39);
            TbPrice.TabIndex = 7;
            // 
            // TbStock
            // 
            TbStock.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbStock.Location = new Point(40, 93);
            TbStock.Name = "TbStock";
            TbStock.PlaceholderText = "Stock";
            TbStock.Size = new Size(361, 39);
            TbStock.TabIndex = 6;
            // 
            // TbName
            // 
            TbName.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbName.Location = new Point(40, 40);
            TbName.Name = "TbName";
            TbName.PlaceholderText = "Name";
            TbName.Size = new Size(361, 39);
            TbName.TabIndex = 5;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 282);
            Controls.Add(EditBtn);
            Controls.Add(TbPrice);
            Controls.Add(TbStock);
            Controls.Add(TbName);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            MaximumSize = new Size(480, 329);
            MinimumSize = new Size(480, 329);
            Name = "EditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditBtn;
        private TextBox TbPrice;
        private TextBox TbStock;
        private TextBox TbName;
    }
}