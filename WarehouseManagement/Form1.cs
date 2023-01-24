using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
namespace WarehouseManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string uid = textBox1.Text;
                string connstring = "server=localhost;uid=" + uid + ";database=warehousemanagement";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                label3.Text = "Connected!";
                Form2 frm2 = new Form2();
                frm2.Show(); // Launch Form2
                Hide(); //Hide Form1.
            }
            catch(MySqlException ex) 
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please fill in your sign-in details!");
                }
                else if (ex.ToString().Substring(0, 66) == "MySqlConnector.MySqlException (0x80004005): Access denied for user")
                    MessageBox.Show("Wrong username or password!");
                else
                    MessageBox.Show(ex.ToString());
            }
        }

    }
}
