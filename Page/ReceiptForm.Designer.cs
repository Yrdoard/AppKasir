namespace Kasir.Page
{
    partial class ReceiptForm
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
            textBoxReceipt = new TextBox();
            SuspendLayout();
            // 
            // textBoxReceipt
            // 
            textBoxReceipt.Dock = DockStyle.Fill;
            textBoxReceipt.Location = new Point(0, 0);
            textBoxReceipt.Multiline = true;
            textBoxReceipt.Name = "textBoxReceipt";
            textBoxReceipt.ReadOnly = true;
            textBoxReceipt.Size = new Size(289, 405);
            textBoxReceipt.TabIndex = 0;
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 405);
            Controls.Add(textBoxReceipt);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximumSize = new Size(307, 452);
            MinimumSize = new Size(307, 452);
            Name = "ReceiptForm";
            Text = "ReceiptForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxReceipt;
    }
}