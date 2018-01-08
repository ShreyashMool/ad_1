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
        private List<string> category = new List<string>();
        private List<int> itemPrice = new List<int>();  


        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            dataGridView2.AllowUserToAddRows = false;
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
                comboBox1.ResetText();

                this.status = false;
                this.row = 0;
            }
            else
            {
                MessageBox.Show("Fields are empty!!");
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {


            //    private void btn_clear_Click(object sender, EventArgs e)
            //    {
            //        item_text.Text = "";
            //        price_text.Text = "";
            //    }

            //    private void button2_Click(object sender, EventArgs e)
            //    {
            //        dataGridView1.Rows.Clear();

            //    }

            //    private void btn_import_Click(object sender, EventArgs e)
            //    {
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Files(*.txt,*.csv)|*.txt;*.csv|All files (*.*) | *.*";
            //DialogResult result = dialog.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    import_location.Text = dialog.FileName;
            //    string val = import_location.Text;
            //    importCSVFile(val);
            //}
            //    }

            //    private void importCSVFile(string filepath)
            //    {
            //try
            //{
            //    TextFieldParser csvreader = new TextFieldParser(filepath);
            //    csvreader.SetDelimiters(new string[] { "," });
            //    csvreader.HasFieldsEnclosedInQuotes = true;
            //    csvreader.ReadFields();
            //    while (!csvreader.EndOfData)
            //    {
            //        string[] fielddata = csvreader.ReadFields();
            //        for (int i = 0; i < fielddata.Length; i++)
            //        {
            //            dataGridView1.Rows.Add(fielddata);
            //            break;
            //            //Console.Write(fielddata[i] + "\t");
            //        }
            //        Console.WriteLine("");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Import CSV File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //    }

            //    private void item_text_KeyPress(object sender, KeyPressEventArgs e)
            //    {
            //if (char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
            //    }

            //    private void price_text_KeyPress(object sender, KeyPressEventArgs e)
            //    {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            //{
            //    e.Handled = true;
            //}
            //    }

            //    private void quantity_textbox_KeyPress(object sender, KeyPressEventArgs e)
            //    {
            //        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            //        {
            //            e.Handled = true;
            //        }
            //    }

            //    private void btn_biiling_Click(object sender, EventArgs e)
            //    {

            //for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            //{
            //    this.dataGridView2.Rows.Add(dataGridView1.Rows[i].Cells[0].Value, dataGridView1.Rows[i].Cells[1].Value, dataGridView1.Rows[i].Cells[2].Value);

            //}
            //    }

            //    private void button1_Click(object sender, EventArgs e)
            //    {
            //int sum = 0;
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);

            //}
            //label1.Text = sum.ToString();
            //    }



            //}
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
                bool ischeck= Convert.ToBoolean(item.Cells["Column7"].Value);
                if(ischeck)
                {
                    dt.Rows.Add(item.Cells[0].Value,item.Cells[1].Value,item.Cells[2].Value);
                    item.Cells[3].Value = false;
                }
            
            }
            dataGridView2.DataSource = dt;
            
      

            //try
            //{


            //    int s = dataGridView1.CurrentCell.RowIndex;
            //    int j = dataGridView2.Rows.Count - 1;
            //    //int b = dataGridView1.SelectedRows.Count;
            //    //b = s;

            //    //if (Convert.ToBoolean(dataGridView1.Rows[s].Cells[3].Value) == true)
            //    //{
            //    //    for (int i = 0; i >= dataGridView2.Rows.Count; i++)
            //    //    {
            //    //        dataGridView2.Rows.Add(dataGridView1.Rows[b].Cells[0].Value, dataGridView1.Rows[b].Cells[1].Value, dataGridView1.Rows[b].Cells[2].Value);
            //    //        dataGridView1.Rows[b].Cells[3].Value = false;
            //    //    }
            //    //}
            //    for (int i = s; i >= j; i++)
            //    {
            //        if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[3].Value) == true)
            //        {
            //            dataGridView2.Rows.Add(dataGridView1.Rows[i].Cells[0].Value, dataGridView1.Rows[i].Cells[1].Value, dataGridView1.Rows[i].Cells[2].Value);
            //            dataGridView1.Rows[i].Cells[3].Value = false;

            //        }

            //    }
            //}

            //catch (Exception) { }
            
         
        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }


        private void btn_Bill_Click_1(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);

            }
            total_amount.Text = "Rs. "+sum.ToString()+ "/-";
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
                    string item1  = Convert.ToString(row1.Cells[0].Value);
                    string item2 = Convert.ToString(row2.Cells[0].Value);
                    if (string.Compare(item1, item2)<0)
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
            int selectedRow = dataGridView1.CurrentCell.RowIndex;

            if (selectedRow >= 0)
            {
                dataGridView1.Rows.RemoveAt(selectedRow);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("No data to delete!!");
            }
        }

        private void btn_generateSalesReport_Click(object sender, EventArgs e)
        {
            dailySales.Series["DailySales"].Points.Clear();
            category.Clear();
            itemPrice.Clear();
            sum();
            generateChart();
        }

        private void generateChart()
        {
            for (int i = 0; i < this.category.Count; i++)
            {
                dailySales.Series["DailySales"].Points.Add(this.itemPrice[i]);
                dailySales.Series["DailySales"].Points[i].LegendText = this.category[i];
                this.dailySales.Series["DailySales"].Label = "#LEGENDTEXT " + "#PERCENT{P1}";
            }
        }

        private void sum()
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                string category1 = Convert.ToString(dataGridView2.Rows[i].Cells[2].Value);
                int price1 = Convert.ToInt16(dataGridView2.Rows[i].Cells[1].Value);

                if (i == 0)
                {
                    int sum = price1;
                    for (int j = 1; j < dataGridView2.Rows.Count - 1; j++)
                    {
                        string category2 = Convert.ToString(dataGridView2.Rows[i].Cells[2].Value);
                        int price2 = Convert.ToInt16(dataGridView2.Rows[i].Cells[1].Value);

                        if (category1 == category2)
                        {
                            sum += price1;
                        }
                    }
                    this.category.Add(category1);
                    this.itemPrice.Add(sum);
                }
                else if (!this.category.Contains(category1))
                {
                    int sum = price1;
                    for (int j = i + 1; j < dataGridView2.Rows.Count - 1; j++)
                    {
                        string category2 = Convert.ToString(dataGridView2.Rows[i].Cells[2].Value);
                        int price2 = Convert.ToInt16(dataGridView2.Rows[i].Cells[1].Value);
                        if (category1 == category2)
                        {
                            sum += price2;
                        }
                    }
                    this.category.Add(category1);
                    this.itemPrice.Add(sum);
                }
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView2.CurrentCell.RowIndex;
            if (selectedRow >= 0)
            {
            
                dataGridView2.Rows.RemoveAt(selectedRow);
                dataGridView2.Refresh();
            }
            else
            {
                MessageBox.Show("No data to delete!!");
            }
        }

        

        
        

        

                    
    }
}
