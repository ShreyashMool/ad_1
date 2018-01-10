namespace Coursework1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_Bill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_clear_datagridview2 = new System.Windows.Forms.Button();
            this.total_amount = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_generateSalesReport = new System.Windows.Forms.Button();
            this.importTextBox = new System.Windows.Forms.TextBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clearAll = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.sortBy = new System.Windows.Forms.Label();
            this.btn_sortItem = new System.Windows.Forms.Button();
            this.btn_sortPrice = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.item_name = new System.Windows.Forms.Label();
            this.item_price = new System.Windows.Forms.Label();
            this.item_category = new System.Windows.Forms.Label();
            this.itemNameTextbox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_add_items = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dailySales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailySales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(12, 76);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(571, 175);
            this.dataGridView2.TabIndex = 0;
            // 
            // btn_Bill
            // 
            this.btn_Bill.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Bill.ForeColor = System.Drawing.Color.White;
            this.btn_Bill.Location = new System.Drawing.Point(459, 257);
            this.btn_Bill.Name = "btn_Bill";
            this.btn_Bill.Size = new System.Drawing.Size(120, 41);
            this.btn_Bill.TabIndex = 1;
            this.btn_Bill.Text = "Bill";
            this.btn_Bill.UseVisualStyleBackColor = false;
            this.btn_Bill.Click += new System.EventHandler(this.btn_Bill_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Amount:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btn_clear_datagridview2);
            this.panel4.Controls.Add(this.total_amount);
            this.panel4.Controls.Add(this.btn_remove);
            this.panel4.Controls.Add(this.btn_generateSalesReport);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btn_Bill);
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Location = new System.Drawing.Point(4, 667);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(717, 390);
            this.panel4.TabIndex = 3;
            // 
            // btn_clear_datagridview2
            // 
            this.btn_clear_datagridview2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_clear_datagridview2.ForeColor = System.Drawing.Color.White;
            this.btn_clear_datagridview2.Location = new System.Drawing.Point(459, 304);
            this.btn_clear_datagridview2.Name = "btn_clear_datagridview2";
            this.btn_clear_datagridview2.Size = new System.Drawing.Size(120, 41);
            this.btn_clear_datagridview2.TabIndex = 6;
            this.btn_clear_datagridview2.Text = "Clear ";
            this.btn_clear_datagridview2.UseVisualStyleBackColor = false;
            this.btn_clear_datagridview2.Click += new System.EventHandler(this.btn_clear_datagridview2_Click);
            // 
            // total_amount
            // 
            this.total_amount.AutoSize = true;
            this.total_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_amount.Location = new System.Drawing.Point(135, 263);
            this.total_amount.Name = "total_amount";
            this.total_amount.Size = new System.Drawing.Size(36, 25);
            this.total_amount.TabIndex = 5;
            this.total_amount.Text = "---";
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(333, 257);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(120, 41);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_generateSalesReport
            // 
            this.btn_generateSalesReport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_generateSalesReport.ForeColor = System.Drawing.Color.White;
            this.btn_generateSalesReport.Location = new System.Drawing.Point(8, 304);
            this.btn_generateSalesReport.Name = "btn_generateSalesReport";
            this.btn_generateSalesReport.Size = new System.Drawing.Size(176, 44);
            this.btn_generateSalesReport.TabIndex = 3;
            this.btn_generateSalesReport.Text = "Generate Chart";
            this.btn_generateSalesReport.UseVisualStyleBackColor = false;
            this.btn_generateSalesReport.Click += new System.EventHandler(this.btn_generateSalesReport_Click);
            // 
            // importTextBox
            // 
            this.importTextBox.Location = new System.Drawing.Point(3, 6);
            this.importTextBox.Multiline = true;
            this.importTextBox.Name = "importTextBox";
            this.importTextBox.ReadOnly = true;
            this.importTextBox.Size = new System.Drawing.Size(837, 34);
            this.importTextBox.TabIndex = 0;
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_import.ForeColor = System.Drawing.Color.White;
            this.btn_import.Location = new System.Drawing.Point(846, 6);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(120, 41);
            this.btn_import.TabIndex = 1;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_import);
            this.panel3.Controls.Add(this.importTextBox);
            this.panel3.Location = new System.Drawing.Point(809, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 62);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(4, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(579, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.Width = 123;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 79;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Check";
            this.Column7.Name = "Column7";
            this.Column7.Width = 60;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(14, 362);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 41);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clearAll
            // 
            this.btn_clearAll.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_clearAll.ForeColor = System.Drawing.Color.White;
            this.btn_clearAll.Location = new System.Drawing.Point(121, 362);
            this.btn_clearAll.Name = "btn_clearAll";
            this.btn_clearAll.Size = new System.Drawing.Size(111, 41);
            this.btn_clearAll.TabIndex = 2;
            this.btn_clearAll.Text = "Clear All";
            this.btn_clearAll.UseVisualStyleBackColor = false;
            this.btn_clearAll.Click += new System.EventHandler(this.btn_clearAll_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(245, 362);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(109, 41);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // sortBy
            // 
            this.sortBy.AutoSize = true;
            this.sortBy.Location = new System.Drawing.Point(4, 48);
            this.sortBy.Name = "sortBy";
            this.sortBy.Size = new System.Drawing.Size(61, 20);
            this.sortBy.TabIndex = 4;
            this.sortBy.Text = "Sort By";
            // 
            // btn_sortItem
            // 
            this.btn_sortItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_sortItem.ForeColor = System.Drawing.Color.White;
            this.btn_sortItem.Location = new System.Drawing.Point(86, 42);
            this.btn_sortItem.Name = "btn_sortItem";
            this.btn_sortItem.Size = new System.Drawing.Size(120, 41);
            this.btn_sortItem.TabIndex = 5;
            this.btn_sortItem.Text = "Item";
            this.btn_sortItem.UseVisualStyleBackColor = false;
            this.btn_sortItem.Click += new System.EventHandler(this.btn_sortItem_Click);
            // 
            // btn_sortPrice
            // 
            this.btn_sortPrice.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_sortPrice.ForeColor = System.Drawing.Color.White;
            this.btn_sortPrice.Location = new System.Drawing.Point(182, 42);
            this.btn_sortPrice.Name = "btn_sortPrice";
            this.btn_sortPrice.Size = new System.Drawing.Size(120, 41);
            this.btn_sortPrice.TabIndex = 6;
            this.btn_sortPrice.Text = "Price";
            this.btn_sortPrice.UseVisualStyleBackColor = false;
            this.btn_sortPrice.Click += new System.EventHandler(this.btn_sortPrice_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_sortPrice);
            this.panel2.Controls.Add(this.btn_sortItem);
            this.panel2.Controls.Add(this.sortBy);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_clearAll);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(0, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 410);
            this.panel2.TabIndex = 1;
            // 
            // item_name
            // 
            this.item_name.AutoSize = true;
            this.item_name.Location = new System.Drawing.Point(17, 13);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(87, 20);
            this.item_name.TabIndex = 0;
            this.item_name.Text = "Item Name";
            // 
            // item_price
            // 
            this.item_price.AutoSize = true;
            this.item_price.Location = new System.Drawing.Point(17, 48);
            this.item_price.Name = "item_price";
            this.item_price.Size = new System.Drawing.Size(44, 20);
            this.item_price.TabIndex = 1;
            this.item_price.Text = "Price";
            // 
            // item_category
            // 
            this.item_category.AutoSize = true;
            this.item_category.Location = new System.Drawing.Point(17, 90);
            this.item_category.Name = "item_category";
            this.item_category.Size = new System.Drawing.Size(73, 20);
            this.item_category.TabIndex = 2;
            this.item_category.Text = "Category";
            // 
            // itemNameTextbox
            // 
            this.itemNameTextbox.Location = new System.Drawing.Point(121, 6);
            this.itemNameTextbox.Name = "itemNameTextbox";
            this.itemNameTextbox.Size = new System.Drawing.Size(457, 26);
            this.itemNameTextbox.TabIndex = 3;
            this.itemNameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemNameTextbox_KeyPress);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(121, 45);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(457, 26);
            this.priceTextBox.TabIndex = 4;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Momo",
            "Meal",
            "Chowmin",
            "Refreshment",
            "Drinks",
            "Noodles"});
            this.comboBox1.Location = new System.Drawing.Point(121, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(457, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // btn_add_items
            // 
            this.btn_add_items.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_add_items.ForeColor = System.Drawing.Color.White;
            this.btn_add_items.Location = new System.Drawing.Point(323, 138);
            this.btn_add_items.Name = "btn_add_items";
            this.btn_add_items.Size = new System.Drawing.Size(120, 41);
            this.btn_add_items.TabIndex = 6;
            this.btn_add_items.Text = "Add";
            this.btn_add_items.UseVisualStyleBackColor = false;
            this.btn_add_items.Click += new System.EventHandler(this.btn_add_items_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(458, 138);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(120, 41);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_add_items);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Controls.Add(this.itemNameTextbox);
            this.panel1.Controls.Add(this.item_category);
            this.panel1.Controls.Add(this.item_price);
            this.panel1.Controls.Add(this.item_name);
            this.panel1.Location = new System.Drawing.Point(4, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 190);
            this.panel1.TabIndex = 0;
            // 
            // dailySales
            // 
            this.dailySales.BorderlineColor = System.Drawing.Color.Gainsboro;
            chartArea3.Name = "ChartArea1";
            this.dailySales.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.dailySales.Legends.Add(legend3);
            this.dailySales.Location = new System.Drawing.Point(809, 173);
            this.dailySales.Name = "dailySales";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.LabelForeColor = System.Drawing.Color.DimGray;
            series3.Legend = "Legend1";
            series3.Name = "DailySales";
            this.dailySales.Series.Add(series3);
            this.dailySales.Size = new System.Drawing.Size(986, 730);
            this.dailySales.TabIndex = 5;
            this.dailySales.Text = "chart1";
            this.dailySales.Click += new System.EventHandler(this.dailySales_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "User Sales";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1411, 1050);
            this.Controls.Add(this.dailySales);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailySales)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_Bill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox importTextBox;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clearAll;
        private System.Windows.Forms.Label sortBy;
        private System.Windows.Forms.Button btn_sortItem;
        private System.Windows.Forms.Button btn_sortPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label item_name;
        private System.Windows.Forms.Label item_price;
        private System.Windows.Forms.Label item_category;
        private System.Windows.Forms.TextBox itemNameTextbox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_add_items;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_generateSalesReport;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label total_amount;
        private System.Windows.Forms.DataVisualization.Charting.Chart dailySales;
        private System.Windows.Forms.Button btn_clear_datagridview2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;


    }
}

