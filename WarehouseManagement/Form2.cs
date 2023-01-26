using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using ClosedXML.Excel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using WarehouseManagement.warehousemanagementDataSetTableAdapters;
using dataGridClassLibrary;

namespace WarehouseManagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Close();
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehousemanagementDataSet.warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.warehousemanagementDataSet.warehouse);
            // TODO: This line of code loads data into the 'warehousemanagementDataSet.reception' table. You can move, or remove it, as needed.
            this.receptionTableAdapter.Fill(this.warehousemanagementDataSet.reception);
            // TODO: This line of code loads data into the 'warehousemanagementDataSet.outboundorder' table. You can move, or remove it, as needed.
            this.outboundorderTableAdapter.Fill(this.warehousemanagementDataSet.outboundorder);
            // TODO: This line of code loads data into the 'warehousemanagementDataSet.inboundorder' table. You can move, or remove it, as needed.
            this.inboundorderTableAdapter.Fill(this.warehousemanagementDataSet.inboundorder);
            // TODO: This line of code loads data into the 'warehousemanagementDataSet.box' table. You can move, or remove it, as needed.
            this.boxTableAdapter.Fill(this.warehousemanagementDataSet.box);
            // TODO: This line of code loads data into the 'warehousemanagementDataSet.transfer' table. You can move, or remove it, as needed.
            this.transferTableAdapter.Fill(this.warehousemanagementDataSet.transfer);
            // TODO: This line of code loads data into the 'warehousemanagementDataSet.vendor' table. You can move, or remove it, as needed.
            this.vendorTableAdapter.Fill(this.warehousemanagementDataSet.vendor);
            // TODO: This line of code loads data into the 'warehousemanagementDataSet.finiteproduct' table. You can move, or remove it, as needed.
            this.finiteproductTableAdapter.Fill(this.warehousemanagementDataSet.finiteproduct);
            // TODO: This line of code loads data into the 'warehousemanagementDataSet.rawmaterial' table. You can move, or remove it, as needed.
            this.rawmaterialTableAdapter.Fill(this.warehousemanagementDataSet.rawmaterial);
            // TODO: This line of code loads data into the 'warehousemanagementDataSet.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.warehousemanagementDataSet.client);
            dataGridView1.Hide();
            button2.Hide();
            button1.Hide();
            button3.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
        }

        private void resetGridData()
        {
            button3.ResetText();
            button3.Hide();
            label1.ResetText();
            label2.ResetText();
            label3.ResetText();
            label4.ResetText();
            label5.ResetText();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
        }
        private void rawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGridData();
            dataGridView1.DataSource= this.warehousemanagementDataSet.rawmaterial;
            dataGridView1.Refresh();
            dataGridView1.Show();
            DataGridResizer.AutoResize(dataGridView1);
            button1.Show();   
            button2.Show();
        }

        private void finToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGridData();
            dataGridView1.DataSource = this.warehousemanagementDataSet.finiteproduct;
            dataGridView1.Refresh();
            DataGridResizer.AutoResize(dataGridView1);
            dataGridView1.Show();
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGridData();
            dataGridView1.DataSource = this.warehousemanagementDataSet.inboundorder; 
            dataGridView1.Refresh();
            DataGridResizer.AutoResize(dataGridView1);
            dataGridView1.Show();
        }

        private void outToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGridData();
            dataGridView1.DataSource = this.warehousemanagementDataSet.outboundorder; 
            dataGridView1.Refresh();
            DataGridResizer.AutoResize(dataGridView1);
            dataGridView1.Show();
        }

        private void transfersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGridData();
            dataGridView1.DataSource = this.warehousemanagementDataSet.transfer;
            dataGridView1.Refresh();
            DataGridResizer.AutoResize(dataGridView1);
            dataGridView1.Show();
        }

        private void deliveriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGridData();
            dataGridView1.DataSource = this.warehousemanagementDataSet.delivery;
            dataGridView1.Refresh();
            DataGridResizer.AutoResize(dataGridView1);
            dataGridView1.Show();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGridData();
            dataGridView1.DataSource = this.warehousemanagementDataSet.client;
            dataGridView1.Refresh();
            dataGridView1.Show();
            DataGridResizer.AutoResize(dataGridView1);
        }

        private void vendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGridData();
            dataGridView1.DataSource = this.warehousemanagementDataSet.vendor;
            dataGridView1.Refresh();
            dataGridView1.Show();
            DataGridResizer.AutoResize(dataGridView1);
        }

        private void boxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGridData();
            dataGridView1.DataSource = this.warehousemanagementDataSet.box;
            dataGridView1.Refresh();
            dataGridView1.Show();
            DataGridResizer.AutoResize(dataGridView1);
        }

        private void warehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGridData();
            dataGridView1.DataSource = this.warehousemanagementDataSet.warehouse; 
            dataGridView1.Refresh();
            dataGridView1.Show();
            DataGridResizer.AutoResize(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = excelWorkbook.ActiveSheet;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                excelWorksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    excelWorksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            excelWorkbook.SaveAs("D:\\Excell\\export.xlsx");
            Marshal.ReleaseComObject(excelWorksheet);
            excelWorkbook.Close();
            Marshal.ReleaseComObject(excelWorkbook);
            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Visible)
            dataGridView1.Hide();
            else dataGridView1.Show();
        }

        private void rawToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            resetGridData();
            label1.Text = "Material name:";
            label1.Show();
            textBox1.Show();
            label2.Text = "Package quantity:";
            label2.Show();
            textBox2.Show();
            label3.Hide();
            textBox3.Hide();
            label4.Hide();
            textBox4.Hide();
            button3.Text = "Insert Raw Material";
            button3.Show();
        }

        private void finToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            resetGridData();
            label1.Text = "Material name:";
            label1.Show();
            textBox1.Show();
            label2.Text = "Material Life:";
            label2.Show();
            textBox2.Show();
            label3.Show();
            textBox3.Show();
            label4.Hide();
            textBox4.Hide();
            button3.Text = "Insert Fin Material";
            button3.Show();
        }
        private void inToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            resetGridData();
            label1.Text = "Vendor ID:";
            label1.Show();
            textBox1.Show();
            label2.Text = "Material ID:";
            label2.Show();
            textBox2.Show();
            label3.Text = "Quantity";
            label3.Show();
            textBox3.Show();
            label4.Hide(); 
            textBox4.Hide();
            label5.Hide();
            textBox5.Hide();
            button3.Text = "Insert Inbound Order";
            button3.Show();
        }
        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGridData();
            label1.Text = "Client Name:";
            label1.Show();
            textBox1.Show();
            label2.Text = "Address:";
            label2.Show();
            textBox2.Show();
            label3.Hide();
            textBox3.Hide();
            label4.Hide();
            textBox4.Hide();
            label5.Hide();
            textBox5.Hide();
            button3.Text = "Insert Client";
            button3.Show();
        } 
        private void vendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGridData();
            label1.Text = "Vendor Name:";
            label1.Show();
            textBox1.Show();
            label2.Text = "Address:";
            label2.Show();
            textBox2.Show();
            label3.Hide();
            textBox3.Hide();
            label4.Hide();
            textBox4.Hide();
            label5.Hide();
            textBox5.Hide();
            button3.Text = "Insert Vendor";
            button3.Show();
        }
        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGridData();
            label1.Text = "Material Name:";
            label1.Show();
            textBox1.Show();
            label2.Text = "Quantity:";
            label2.Show();
            textBox2.Show();
            label3.Hide();
            textBox3.Hide();
            label4.Hide();
            textBox4.Hide();
            label5.Hide();
            textBox5.Hide();
            button3.Text = "Insert Transfer";
            button3.Show();
        } 
        private void receptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGridData();
            label1.Text = "Vendor ID:";
            label1.Show();
            textBox1.Show();
            label2.Text = "Material ID:";
            label2.Show();
            textBox2.Show();
            label3.Text = "Order ID:";
            label3.Show();
            textBox3.Show();
            label4.Text = "Quantity:";
            label4.Show();
            textBox4.Show();
            label5.Hide();
            textBox5.Hide();
            button3.Text = "Insert Reception";
            button3.Show();
        } 
        private void warehouseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            resetGridData();
            label1.Text = "Location:";
            label1.Show();
            textBox1.Show();
            label2.Text = "Material name:";
            label2.Show();
            textBox2.Show();
            label3.Text = "Quantity:";
            label3.Show();
            textBox3.Show();
            label4.Text = "Bin:";
            label4.Show();
            textBox4.Show();
            label5.Hide();
            textBox5.Hide();
            button3.Text = "Insert Warehouse";
            button3.Show();
        } 
        private void boxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGridData();
            label1.Text = "Material Name:";
            label1.Show();
            textBox1.Show();
            label2.Hide();
            textBox2.Hide();
            label3.Hide();
            textBox3.Hide();
            label4.Hide();
            textBox4.Hide();
            label5.Hide();
            textBox5.Hide();
            button3.Text = "Insert Box";
            button3.Show();
        }  
        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Client ID:";
            label1.Show();
            textBox1.Show();
            label2.Text = "Material ID:";
            label2.Show();
            textBox2.Show();
            label3.Text = "Quantity:";
            label3.Show();
            textBox3.Show();
            label4.Text = "Order ID:";
            label4.Show();
            textBox4.Show();
            label5.Hide();
            textBox5.Hide();
            button3.Text = "Insert Delivery";
            button3.Show();
        }
        private void rawToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            resetGridData();
            label1.Text = "Material ID";
            label1.Show();
            textBox1.Show();
            button3.Text = "Delete Raw Material";
            button3.Show();
            label2.Text = "Material Name:";
            label2.Show();
            label3.Text = "Package Quantity:";
            label3.Show();           
            textBox2.Show();
            textBox3.Show();

            label4.Hide();
            label5.Hide();
            textBox4.Hide();
            textBox5.Hide();
        } 
        private void finToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            resetGridData();
            label1.Text = "Material ID";
            label1.Show();
            textBox1.Show();
            button3.Text = "Delete Fin Material";
            button3.Show();
            label2.Text = "Material Name:";
            label2.Show();
            label3.Text = "Material Life:";
            label3.Show();
            textBox2.Show();
            textBox3.Show();
            label4.Text = "Package Quantity:";
            label4.Show();
            label5.Hide();
            textBox4.Show();
            textBox5.Hide();
        }       
        private void clientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            resetGridData();
            label1.Text = "Client ID";
            label1.Show();
            textBox1.Show();
            button3.Text = "Delete Client";
            button3.Show();
            label2.Text = "Client Name:";
            label2.Show();
            label3.Text = "Address:";
            label3.Show();
            textBox2.Show();
            textBox3.Show();

            label4.Hide();
            label5.Hide();
            textBox4.Hide();
            textBox5.Hide();
        }  
        private void vendorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            resetGridData();
            label1.Text = "Vendor ID";
            label1.Show();
            textBox1.Show();
            button3.Text = "Delete Vendor";
            button3.Show();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
        }
        private void inToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            resetGridData();
            label1.Text = "Order ID";
            label1.Show();
            textBox1.Show();
            button3.Text = "Delete Order";
            button3.Show();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
        }
            private void outToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            resetGridData();
            label1.Text = "Order ID";
            label1.Show();
            textBox1.Show();
            button3.Text = "Delete Order";
            button3.Show();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            //int value;
            if (button3.Text == "Insert Raw Material")
            {
                try { rawmaterialTableAdapter.Insert(textBox1.Text, Convert.ToInt32(textBox2.Text));
                    rawmaterialTableAdapter.Fill(warehousemanagementDataSet.rawmaterial);
                    MessageBox.Show("Success!");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                    
            }
            else if(button3.Text == "Insert Fin Material")
            {
                try
                {
                    finiteproductTableAdapter.Insert(textBox1.Text, Convert.ToInt32(textBox2.Text),Convert.ToInt32(textBox3.Text));
                    finiteproductTableAdapter.Fill(warehousemanagementDataSet.finiteproduct);
                    MessageBox.Show("Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(button3.Text == "Insert Client")
            {
                try
                {
                    clientTableAdapter.Insert(textBox1.Text, textBox2.Text);
                    clientTableAdapter.Fill(warehousemanagementDataSet.client);
                    MessageBox.Show("Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (button3.Text == "Insert Vendor")
            {
                try
                {
                    vendorTableAdapter.Insert(textBox1.Text, textBox2.Text);
                    vendorTableAdapter.Fill(warehousemanagementDataSet.vendor);
                    MessageBox.Show("Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (button3.Text == "Insert Box")
            {
                try
                {
                    boxTableAdapter.Insert(textBox1.Text);
                    boxTableAdapter.Fill(warehousemanagementDataSet.box);
                    MessageBox.Show("Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (button3.Text == "Insert Delivery")
            {
                try
                {
                    DateTime currentDateTime = DateTime.Now;
                    deliveryTableAdapter livrari = new deliveryTableAdapter();
                    livrari.Insert(Convert.ToInt32(textBox1.Text),
                        Convert.ToInt32(textBox2.Text),
                        Convert.ToInt32(textBox3.Text),
                        currentDateTime,
                        Convert.ToInt32(textBox4.Text));
                    livrari.Fill(warehousemanagementDataSet.delivery);
                    MessageBox.Show("Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (button3.Text == "Insert Inbound Order")
            {
                try
                {
                    DateTime currentDateTime = DateTime.Now;
                    inboundorderTableAdapter.Insert(Convert.ToInt32(textBox1.Text),
                        Convert.ToInt32(textBox2.Text),
                        textBox3.Text,
                        currentDateTime);
                    inboundorderTableAdapter.Fill(warehousemanagementDataSet.inboundorder);
                    MessageBox.Show("Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (button3.Text == "Insert Reception")
            {
                try
                {
                    DateTime currentDateTime = DateTime.Now;
                    receptionTableAdapter.Insert(Convert.ToInt32(textBox1.Text),
                        Convert.ToInt32(textBox2.Text),
                        Convert.ToInt32(textBox3.Text),
                        Convert.ToInt32(textBox4.Text),
                        currentDateTime);
                    receptionTableAdapter.Fill(warehousemanagementDataSet.reception);
                    MessageBox.Show("Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (button3.Text == "Insert Transfer")
            {
                try
                {
                    transferTableAdapter.Insert(textBox1.Text,
                        textBox2.Text,
                        Convert.ToDateTime(textBox3.Text));
                    transferTableAdapter.Fill(warehousemanagementDataSet.transfer);
                    MessageBox.Show("Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (button3.Text == "Insert Warehouse")
            {
                try
                {
                    warehouseTableAdapter.Insert(Convert.ToInt32(textBox1.Text),
                        textBox2.Text,
                        textBox3.Text,
                        Convert.ToInt32(textBox4.Text),
                        textBox5.Text);
                    warehouseTableAdapter.Fill(warehousemanagementDataSet.warehouse);
                    MessageBox.Show("Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (button3.Text == "Delete Raw Material")
            {
                try
                {
                    rawmaterialTableAdapter.Delete(Convert.ToInt32(textBox2.Text),
                        textBox1.Text, 
                        Convert.ToInt32(textBox3.Text));
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select action first!");
            }
        }


    }
}
