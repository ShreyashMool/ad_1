using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1
{
    public partial class Form1 : Form
    {
        bool status = false;
        int row = 0;
        Dictionary<string, int> category = new Dictionary<string, int>();
        
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            dataGridView2.AllowUserToAddRows = false;
            total_amount.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = true;
            MinimizeBox = true;
        }

        private void itemNameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
        }


        private void btn_add_items_Click(object sender, EventArgs e)
        {
            string item = itemNameTextbox.Text;
            string price = priceTextBox.Text;
            string category = comboBox1.Text;


            if (item != "" && price != "" && category != "")
            {
                if (this.status)
                {
                    dataGridView1.Rows[this.row].Cells[0].Value = item;
                    dataGridView1.Rows[this.row].Cells[1].Value = price;
                    dataGridView1.Rows[this.row].Cells[2].Value = category;
                    this.btn_add_items.Text = "Save";
                    dataGridView1.Rows[this.row].Selected = true;
                }
                else
                {
                    int count = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[count].Cells[0].Value = item;
                    dataGridView1.Rows[count].Cells[1].Value = price;
                    dataGridView1.Rows[count].Cells[2].Value = category;
                    dataGridView1.Rows[count].Selected = false;

                }
                itemNameTextbox.Text = "";
                priceTextBox.Text = "";


                this.status = false;
                this.row = 0;
            }
            else
            {
                MessageBox.Show("Fields are empty!!");
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            itemNameTextbox.Text = "";
            priceTextBox.Text = "";
            comboBox1.ResetText();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Files(*.txt,*.csv)|*.txt;*.csv|All files (*.*) | *.*";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                importTextBox.Text = dialog.FileName;
                string val = importTextBox.Text;
                importCSVFile(val);
            }

        }

        private void importCSVFile(string filepath)
        {
            try
            {
                TextFieldParser csvreader = new TextFieldParser(filepath);
                csvreader.SetDelimiters(new string[] { "," });
                csvreader.HasFieldsEnclosedInQuotes = true;
                csvreader.ReadFields();
                while (!csvreader.EndOfData)
                {
                    string[] fielddata = csvreader.ReadFields();
                    for (int i = 0; i < fielddata.Length; i++)
                    {
                        dataGridView1.Rows.Add(fielddata);
                        break;
                    }
                    Console.WriteLine("");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Import CSV File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ItemName");
            dt.Columns.Add("Price");
            dt.Columns.Add("Category");

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                dt.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value);
            }

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                bool ischeck = Convert.ToBoolean(item.Cells["Column7"].Value);
                if (ischeck)
                {
                    dt.Rows.Add(item.Cells[0].Value, item.Cells[1].Value, item.Cells[2].Value);
                    item.Cells[3].Value = false;
                }

            }
            dataGridView2.DataSource = dt;

        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            MessageBox.Show("All items cleared from Menu Table!!");
        }


        private void btn_Bill_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                int sum = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);

                }
                total_amount.Text = "Rs. " + sum.ToString() + "/-";
            }
            else
            {
                MessageBox.Show("Add items to calculate total amount!!");
            }

        }

        private void btn_sortItem_Click(object sender, EventArgs e)
        {
            int length = dataGridView1.Rows.Count;
            for (int a = 0; a < length; a++)
            {
                for (int b = 1; b < length - 1; b++)
                {
                    DataGridViewRow row1 = dataGridView1.Rows[b];
                    DataGridViewRow row2 = dataGridView1.Rows[b - 1];
                    string item1 = Convert.ToString(row1.Cells[0].Value);
                    string item2 = Convert.ToString(row2.Cells[0].Value);
                    if (string.Compare(item1, item2) < 0)
                    {
                        dataGridView1.Rows.Remove(row1);
                        dataGridView1.Rows.Remove(row2);
                        dataGridView1.Rows.Insert(b - 1, row1);
                        dataGridView1.Rows.Insert(b, row2);
                    }
                }
            }
        }
        private void btn_sortPrice_Click(object sender, EventArgs e)
        {
            int length = dataGridView1.Rows.Count;
            for (int a = 0; a < length; a++)
            {
                for (int b = 1; b < length - 1; b++)
                {
                    DataGridViewRow row1 = dataGridView1.Rows[b];
                    DataGridViewRow row2 = dataGridView1.Rows[b - 1];
                    int price1 = Convert.ToInt16(row1.Cells[1].Value);
                    int price2 = Convert.ToInt16(row2.Cells[1].Value);
                    if (price1 < price2)
                    {
                        dataGridView1.Rows.Remove(row1);
                        dataGridView1.Rows.Remove(row2);
                        dataGridView1.Rows.Insert(b - 1, row1);
                        dataGridView1.Rows.Insert(b, row2);
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1 && dataGridView1.Rows != null)
            {
                int selectedRow = dataGridView1.CurrentCell.RowIndex;

                if (selectedRow >= 0)
                {
                    dataGridView1.Rows.RemoveAt(selectedRow);
                    MessageBox.Show("Items Removed from Menu Table!!");
                }
            }

            else
            {
                MessageBox.Show("No data to delete!!");
            }
        }

        private void btn_generateSalesReport_Click(object sender, EventArgs e)
        {
            dailySales.Series["DailySales"].Points.Clear();
            sum();
            generateChart();

        }

        private void generateChart()
        {
            try
            {
                int len = 0;
                foreach (KeyValuePair<string, int> cat in category)
                {
                    dailySales.Series["DailySales"].Points.AddXY(cat.Key, cat.Value);
                    dailySales.Series["DailySales"].Points[len].LegendText = cat.Key;
                    this.dailySales.Series["DailySales"].Label = "#LEGENDTEXT " + "#PERCENT{P1}";
                    len++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void sum()
        {
            try
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    string Category = Convert.ToString(dataGridView2.Rows[i].Cells[2].Value);
                    int Price = Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);

                    if (category.ContainsKey(Category))
                    {
                        int value = category[Category];
                        int total = value + Price;
                        category[Category] = total;
                    }
                    else
                    {
                        category.Add(Category, Price);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count != 0 && dataGridView2.Rows != null)
            {
                int selectedRow = dataGridView2.CurrentCell.RowIndex;
                if (selectedRow >= 0)
                {

                    dataGridView2.Rows.RemoveAt(selectedRow);
                    MessageBox.Show("Item Removed from User Sales Table!!");

                }
            }
            else
            {
                MessageBox.Show("Empty!!");
            }

        }

        private void btn_clear_datagridview2_Click(object sender, EventArgs e)
        {

            int totalRows = dataGridView2.Rows.Count;
            if (totalRows >= 0)
            {
                dataGridView2.DataSource = "";
                dailySales.Series["DailySales"].Points.Clear();
                MessageBox.Show("All items cleared from User Sales Table!!");
                
               
            }
            total_amount.Text = "";

        }
    }
}
