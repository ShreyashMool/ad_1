namespace Coursework1
{
    partial class Form4
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
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_sortPrice = new System.Windows.Forms.Button();
            this.btn_sortItem = new System.Windows.Forms.Button();
            this.sortBy = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clearAll = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.importTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Bill = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add_items = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextbox = new System.Windows.Forms.TextBox();
            this.item_category = new System.Windows.Forms.Label();
            this.item_price = new System.Windows.Forms.Label();
            this.item_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(427, 10);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(93, 32);
            this.btn_import.TabIndex = 1;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            // 
            // btn_sortPrice
            // 
            this.btn_sortPrice.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_sortPrice.ForeColor = System.Drawing.Color.White;
            this.btn_sortPrice.Location = new System.Drawing.Point(182, 42);
            this.btn_sortPrice.Name = "btn_sortPrice";
            this.btn_sortPrice.Size = new System.Drawing.Size(94, 33);
            this.btn_sortPrice.TabIndex = 6;
            this.btn_sortPrice.Text = "Price";
            this.btn_sortPrice.UseVisualStyleBackColor = false;
            // 
            // btn_sortItem
            // 
            this.btn_sortItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_sortItem.ForeColor = System.Drawing.Color.White;
            this.btn_sortItem.Location = new System.Drawing.Point(86, 42);
            this.btn_sortItem.Name = "btn_sortItem";
            this.btn_sortItem.Size = new System.Drawing.Size(90, 33);
            this.btn_sortItem.TabIndex = 5;
            this.btn_sortItem.Text = "Item";
            this.btn_sortItem.UseVisualStyleBackColor = false;
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
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(168, 362);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 35);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_clearAll
            // 
            this.btn_clearAll.Location = new System.Drawing.Point(86, 362);
            this.btn_clearAll.Name = "btn_clearAll";
            this.btn_clearAll.Size = new System.Drawing.Size(76, 34);
            this.btn_clearAll.TabIndex = 2;
            this.btn_clearAll.Text = "Clear All";
            this.btn_clearAll.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(4, 362);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(76, 33);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_import);
            this.panel3.Controls.Add(this.importTextBox);
            this.panel3.Location = new System.Drawing.Point(373, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 62);
            this.panel3.TabIndex = 8;
            // 
            // importTextBox
            // 
            this.importTextBox.Location = new System.Drawing.Point(4, 8);
            this.importTextBox.Multiline = true;
            this.importTextBox.Name = "importTextBox";
            this.importTextBox.Size = new System.Drawing.Size(417, 34);
            this.importTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Amount:";
            // 
            // btn_Bill
            // 
            this.btn_Bill.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Bill.ForeColor = System.Drawing.Color.White;
            this.btn_Bill.Location = new System.Drawing.Point(427, 353);
            this.btn_Bill.Name = "btn_Bill";
            this.btn_Bill.Size = new System.Drawing.Size(179, 42);
            this.btn_Bill.TabIndex = 1;
            this.btn_Bill.Text = "Bill";
            this.btn_Bill.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView2.Location = new System.Drawing.Point(-3, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(609, 342);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Item Name";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Category";
            this.Column6.Name = "Column6";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(-34, 169);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1925, 54);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btn_Bill);
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Location = new System.Drawing.Point(560, 425);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(609, 456);
            this.panel4.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chart";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
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
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.Name = "Column2";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(1208, 230);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(683, 651);
            this.panel6.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btn_sortPrice);
            this.panel2.Controls.Add(this.btn_sortItem);
            this.panel2.Controls.Add(this.sortBy);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_clearAll);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(-34, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 456);
            this.panel2.TabIndex = 7;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(221, 138);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(72, 33);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_add_items
            // 
            this.btn_add_items.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_add_items.ForeColor = System.Drawing.Color.White;
            this.btn_add_items.Location = new System.Drawing.Point(121, 138);
            this.btn_add_items.Name = "btn_add_items";
            this.btn_add_items.Size = new System.Drawing.Size(82, 33);
            this.btn_add_items.TabIndex = 6;
            this.btn_add_items.Text = "Add";
            this.btn_add_items.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fast Food",
            "Dinner",
            "Lunch",
            "Breakfast",
            "Drinks"});
            this.comboBox1.Location = new System.Drawing.Point(121, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(121, 48);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(172, 26);
            this.priceTextBox.TabIndex = 4;
            // 
            // itemNameTextbox
            // 
            this.itemNameTextbox.Location = new System.Drawing.Point(121, 6);
            this.itemNameTextbox.Name = "itemNameTextbox";
            this.itemNameTextbox.Size = new System.Drawing.Size(172, 26);
            this.itemNameTextbox.TabIndex = 3;
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
            // item_price
            // 
            this.item_price.AutoSize = true;
            this.item_price.Location = new System.Drawing.Point(17, 48);
            this.item_price.Name = "item_price";
            this.item_price.Size = new System.Drawing.Size(44, 20);
            this.item_price.TabIndex = 1;
            this.item_price.Text = "Price";
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
            this.panel1.Location = new System.Drawing.Point(-34, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 190);
            this.panel1.TabIndex = 6;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1856, 1050);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_sortPrice;
        private System.Windows.Forms.Button btn_sortItem;
        private System.Windows.Forms.Label sortBy;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clearAll;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox importTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Bill;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add_items;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox itemNameTextbox;
        private System.Windows.Forms.Label item_category;
        private System.Windows.Forms.Label item_price;
        private System.Windows.Forms.Label item_name;
        private System.Windows.Forms.Panel panel1;

    }
}