using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace _0814sqlconnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string connstring = null;
            SqlConnection sqlcon;
            connstring = "Data Source=PL13\\MTCDB;Initial Catalog=AdventureWorks2012; User ID=ahronec;Password=ahronec18";
            sqlcon = new SqlConnection(connstring);
            
            try
            {
                sqlcon.Open();
                label1.Text = "Connection is good";
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                label1.Text = "No connection";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string connstring = ("Data Source=PL13\\MTCDB;Initial Catalog=AdventureWorks2012; User ID=ahronec;Password=ahronec18");




                SqlConnection sqlcon = new SqlConnection(connstring);


                DataTable dt = new DataTable();
                SqlCommand sqlcmd = new SqlCommand();
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlcon.Open();

                sqlda.SelectCommand = sqlcmd;
                sqlcmd.CommandText = Qrytextbox.Text;
                sqlcmd.Connection = sqlcon;
                sqlda.Fill(dt);

                dataGridView1.DataSource = dt;

            }
            catch
            {
                MessageBox.Show("could not load");
            }
                     
              

            }
        }
    }

