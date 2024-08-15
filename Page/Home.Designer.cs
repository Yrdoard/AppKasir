namespace Kasir.Page
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            button10 = new Button();
            button9 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            dataGridView3 = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            del = new DataGridViewButtonColumn();
            tabPage1 = new TabPage();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            userTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            TbSearchUser = new TextBox();
            button3 = new Button();
            button6 = new Button();
            tabPage3 = new TabPage();
            label4 = new Label();
            button4 = new Button();
            button5 = new Button();
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            TbSearch = new TextBox();
            BtnSearch = new Button();
            button7 = new Button();
            tabPage4 = new TabPage();
            dataGridView4 = new DataGridView();
            idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            saleDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costumerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleBindingSource = new BindingSource(components);
            button11 = new Button();
            TbMember = new TextBox();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(934, 533);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(TbMember);
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(dataGridView3);
            tabPage2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(926, 500);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Transaction";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(742, 450);
            button10.Name = "button10";
            button10.Size = new Size(176, 34);
            button10.TabIndex = 4;
            button10.Text = "Print Receipt";
            button10.UseVisualStyleBackColor = true;
            button10.Click += BtnPrint_Click;
            // 
            // button9
            // 
            button9.Location = new Point(744, 410);
            button9.Name = "button9";
            button9.Size = new Size(176, 34);
            button9.TabIndex = 3;
            button9.Text = "Select Product";
            button9.UseVisualStyleBackColor = true;
            button9.Click += BtnAddProduct_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(628, 304);
            label2.Name = "label2";
            label2.Size = new Size(25, 27);
            label2.TabIndex = 2;
            label2.Text = "$";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(625, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 124);
            panel1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(3, 59);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(263, 39);
            textBox2.TabIndex = 8;
            textBox2.Text = "$0.00";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 18);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 6;
            label1.Text = "Total Price";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(652, 297);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Nominal";
            textBox3.Size = new Size(239, 39);
            textBox3.TabIndex = 5;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToResizeColumns = false;
            dataGridView3.AllowUserToResizeRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Product, Quantity, Price, del });
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RightToLeft = RightToLeft.No;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(593, 498);
            dataGridView3.TabIndex = 0;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // Product
            // 
            Product.FillWeight = 126.203224F;
            Product.HeaderText = "Product";
            Product.MinimumWidth = 6;
            Product.Name = "Product";
            Product.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.FillWeight = 126.203224F;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Price
            // 
            dataGridViewCellStyle8.Format = "$.";
            dataGridViewCellStyle8.NullValue = null;
            Price.DefaultCellStyle = dataGridViewCellStyle8;
            Price.FillWeight = 126.203224F;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // del
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.Red;
            dataGridViewCellStyle9.Font = new Font("Consolas", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            del.DefaultCellStyle = dataGridViewCellStyle9;
            del.FillWeight = 21.3903751F;
            del.HeaderText = "-";
            del.MinimumWidth = 6;
            del.Name = "del";
            del.ReadOnly = true;
            del.Resizable = DataGridViewTriState.True;
            del.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(TbSearchUser);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button6);
            tabPage1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(926, 500);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "User";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(11, 16);
            label3.Name = "label3";
            label3.Size = new Size(216, 18);
            label3.TabIndex = 19;
            label3.Text = "*click user to edit/delete";
            // 
            // button1
            // 
            button1.Location = new Point(239, 37);
            button1.Name = "button1";
            button1.Size = new Size(109, 33);
            button1.TabIndex = 18;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += DeleteUser_Click;
            // 
            // button2
            // 
            button2.Location = new Point(124, 37);
            button2.Name = "button2";
            button2.Size = new Size(109, 33);
            button2.TabIndex = 17;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += EditUser_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, userTypeDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn1, addressDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn });
            dataGridView1.DataSource = userBindingSource;
            dataGridView1.Location = new Point(6, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(914, 414);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.FillWeight = 41.17647F;
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            userTypeDataGridViewTextBoxColumn.FillWeight = 109.803917F;
            userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            userTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            userTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.FillWeight = 109.803917F;
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.FillWeight = 109.803917F;
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.FillWeight = 109.803917F;
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.FillWeight = 109.803917F;
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.FillWeight = 109.803917F;
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Models.User);
            // 
            // TbSearchUser
            // 
            TbSearchUser.Location = new Point(608, 39);
            TbSearchUser.Name = "TbSearchUser";
            TbSearchUser.Size = new Size(195, 31);
            TbSearchUser.TabIndex = 15;
            // 
            // button3
            // 
            button3.Location = new Point(809, 37);
            button3.Name = "button3";
            button3.Size = new Size(109, 33);
            button3.TabIndex = 14;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += UserSearch_Click;
            // 
            // button6
            // 
            button6.Location = new Point(11, 37);
            button6.Name = "button6";
            button6.Size = new Size(109, 33);
            button6.TabIndex = 13;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            button6.Click += AddUser_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(TbSearch);
            tabPage3.Controls.Add(BtnSearch);
            tabPage3.Controls.Add(button7);
            tabPage3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(926, 500);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Product";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.IndianRed;
            label4.Location = new Point(11, 16);
            label4.Name = "label4";
            label4.Size = new Size(240, 18);
            label4.TabIndex = 20;
            label4.Text = "*click product to edit/delete";
            // 
            // button4
            // 
            button4.Location = new Point(239, 37);
            button4.Name = "button4";
            button4.Size = new Size(109, 33);
            button4.TabIndex = 12;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += DeleteProduct_Click;
            // 
            // button5
            // 
            button5.Location = new Point(124, 37);
            button5.Name = "button5";
            button5.Size = new Size(109, 33);
            button5.TabIndex = 11;
            button5.Text = "Edit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += EditProduct_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn });
            dataGridView2.DataSource = productBindingSource;
            dataGridView2.Location = new Point(6, 79);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(914, 414);
            dataGridView2.TabIndex = 10;
            dataGridView2.CellClick += DataGridView2_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle11.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            idDataGridViewTextBoxColumn.FillWeight = 23.5294113F;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MaxInputLength = 40000;
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle12.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            nameDataGridViewTextBoxColumn.FillWeight = 125.4902F;
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle13.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.Format = "$.";
            dataGridViewCellStyle13.NullValue = null;
            priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            priceDataGridViewTextBoxColumn.FillWeight = 125.4902F;
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            dataGridViewCellStyle14.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stockDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            stockDataGridViewTextBoxColumn.FillWeight = 125.4902F;
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // TbSearch
            // 
            TbSearch.Location = new Point(608, 39);
            TbSearch.Name = "TbSearch";
            TbSearch.Size = new Size(195, 31);
            TbSearch.TabIndex = 9;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(809, 37);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(109, 33);
            BtnSearch.TabIndex = 8;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += ProductSearch_Click;
            // 
            // button7
            // 
            button7.Location = new Point(11, 37);
            button7.Name = "button7";
            button7.Size = new Size(109, 33);
            button7.TabIndex = 7;
            button7.Text = "Add";
            button7.UseVisualStyleBackColor = true;
            button7.Click += AddProduct_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Font = new Font("Consolas", 12F);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(926, 500);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "History";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AllowUserToResizeColumns = false;
            dataGridView4.AllowUserToResizeRows = false;
            dataGridView4.AutoGenerateColumns = false;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, saleDateDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn, costumerDataGridViewTextBoxColumn });
            dataGridView4.DataSource = saleBindingSource;
            dataGridView4.Location = new Point(6, 79);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(914, 414);
            dataGridView4.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn2.FillWeight = 23.5294113F;
            idDataGridViewTextBoxColumn2.HeaderText = "Id";
            idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            saleDateDataGridViewTextBoxColumn.FillWeight = 125.4902F;
            saleDateDataGridViewTextBoxColumn.HeaderText = "SaleDate";
            saleDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            saleDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.FillWeight = 125.4902F;
            totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costumerDataGridViewTextBoxColumn
            // 
            costumerDataGridViewTextBoxColumn.DataPropertyName = "Costumer";
            costumerDataGridViewTextBoxColumn.FillWeight = 125.4902F;
            costumerDataGridViewTextBoxColumn.HeaderText = "Costumer";
            costumerDataGridViewTextBoxColumn.MinimumWidth = 6;
            costumerDataGridViewTextBoxColumn.Name = "costumerDataGridViewTextBoxColumn";
            costumerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleBindingSource
            // 
            saleBindingSource.DataSource = typeof(Models.Sale);
            // 
            // button11
            // 
            button11.BackColor = Color.Red;
            button11.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(845, 12);
            button11.Name = "button11";
            button11.Size = new Size(77, 29);
            button11.TabIndex = 6;
            button11.Text = "LogOut";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // TbMember
            // 
            TbMember.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbMember.Location = new Point(642, 111);
            TbMember.Name = "TbMember";
            TbMember.PlaceholderText = "Member";
            TbMember.Size = new Size(239, 39);
            TbMember.TabIndex = 6;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 532);
            Controls.Add(button11);
            Controls.Add(tabControl1);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimumSize = new Size(720, 437);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            FormClosed += Home_FormClosed;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView2;
        private TextBox TbSearch;
        private Button BtnSearch;
        private Button button7;
        private TabPage tabPage2;
        private Button button1;
        private Button button2;
        private TextBox TbSearchUser;
        private Button button3;
        private Button button6;
        private DataGridView dataGridView1;
        public DataGridView dataGridView3;
        private Panel panel1;
        private Label label2;
        private Button button10;
        private Button button9;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox2;
        private BindingSource userBindingSource;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private Button button11;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewButtonColumn del;
        private TabPage tabPage4;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costumerDataGridViewTextBoxColumn;
        private BindingSource saleBindingSource;
        private TextBox TbMember;
    }
}