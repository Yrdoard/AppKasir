using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir.Page
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm(DataGridViewRowCollection rows, decimal totalPrice, decimal amountPaid, decimal change, decimal discount)
        {
            InitializeComponent();
            DisplayReceipt(rows, totalPrice, amountPaid, change, discount);
        }

        private void DisplayReceipt(DataGridViewRowCollection rows, decimal totalPrice, decimal amountPaid, decimal change, decimal discount)
        {
            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine("Receipt");
            receipt.AppendLine("-------------------------------");

            foreach (DataGridViewRow row in rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
                    string productName = row.Cells[0].Value?.ToString() ?? "Unknown Product";
                    int quantity = Convert.ToInt32(row.Cells[1].Value);
                    decimal price = Convert.ToDecimal(row.Cells[2].Value);
                    receipt.AppendLine($"{productName} x{quantity} @ {price.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
                }
            }

            receipt.AppendLine("-------------------------------");
            if (discount > 0)
            {
                decimal discountAmount = totalPrice * discount;
                receipt.AppendLine($"Discount: {discountAmount.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
                totalPrice -= discountAmount;
            }
            receipt.AppendLine($"Total Price: {totalPrice.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
            receipt.AppendLine($"Amount Paid: {amountPaid.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
            receipt.AppendLine($"Change: {change.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");

            textBoxReceipt.Text = receipt.ToString();
        }
    }
}
