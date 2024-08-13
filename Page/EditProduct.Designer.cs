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
            label1 = new Label();
            SuspendLayout();
            // 
            // EditBtn
            // 
            EditBtn.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditBtn.Location = new Point(314, 220);
            EditBtn.Margin = new Padding(4);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(116, 35);
            EditBtn.TabIndex = 8;
            EditBtn.Text = "Edit Product";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // TbPrice
            // 
            TbPrice.Font = new Font("Consolas", 13.8F);
            TbPrice.Location = new Point(45, 166);
            TbPrice.Margin = new Padding(4);
            TbPrice.Name = "TbPrice";
            TbPrice.PlaceholderText = "Price";
            TbPrice.Size = new Size(361, 34);
            TbPrice.TabIndex = 7;
            // 
            // TbStock
            // 
            TbStock.Font = new Font("Consolas", 13.8F);
            TbStock.Location = new Point(45, 114);
            TbStock.Margin = new Padding(4);
            TbStock.Name = "TbStock";
            TbStock.PlaceholderText = "Stock";
            TbStock.Size = new Size(361, 34);
            TbStock.TabIndex = 6;
            // 
            // TbName
            // 
            TbName.Font = new Font("Consolas", 13.8F);
            TbName.Location = new Point(45, 65);
            TbName.Margin = new Padding(4);
            TbName.Name = "TbName";
            TbName.PlaceholderText = "Name Product";
            TbName.Size = new Size(361, 34);
            TbName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 18);
            label1.Name = "label1";
            label1.Size = new Size(195, 33);
            label1.TabIndex = 9;
            label1.Text = "Edit Product";
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 282);
            Controls.Add(label1);
            Controls.Add(EditBtn);
            Controls.Add(TbPrice);
            Controls.Add(TbStock);
            Controls.Add(TbName);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(4);
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
        private Label label1;
    }
}