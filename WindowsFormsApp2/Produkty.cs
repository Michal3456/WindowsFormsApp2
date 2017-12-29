using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Produkty : Form
    {
        public Produkty()
        {
            InitializeComponent();
        }

    
        private void Produkty_Load_1(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            LoadData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

            
            string connectionString = @"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            bool status = false;
            if(comboBox1.SelectedIndex ==0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
                var sqlQuery = "";
            if(IfProduktistnieje(sqlCon, textBox1.Text))
                {
                    sqlQuery = @"UPDATE [dbo].[Produkty]
   SET [NazwaProduktu] = '" + textBox2.Text + "' ,[Status] = '" + status + "' WHERE [KodProduktu] = '" + textBox1.Text + "'";
                }
                else
                {
                    sqlQuery = @"INSERT INTO[dbo].[Produkty] ([KodProduktu] ,[NazwaProduktu]  ,[Status]) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + status + "')";
                }

            SqlCommand cmd = new SqlCommand(sqlQuery, sqlCon);
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Czytanie danych
           // string connectionString = @"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;";
            SqlConnection sqlCon2 = new SqlConnection(@"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP (1000) [KodProduktu],[NazwaProduktu],[Status]FROM[RejestracjaUzytkownika].[dbo].[Produkty]", sqlCon2);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["KodProduktu"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["NazwaProduktu"].ToString();
                if ((bool)item["Status"])
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Dostepny";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Niedostepny";
                }
                //Czytanie danych
                LoadData();
              
            }
        }
        private bool IfProduktistnieje(SqlConnection sqlCon, string KodProduktu)
                {
            SqlConnection sqlCon2 = new SqlConnection(@"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT 1 FROM [Produkty] WHERE [KodProduktu]='" + KodProduktu+"'", sqlCon2);            
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
                }
        public void LoadData()
        {
            //Czytanie danych
            // string connectionString = @"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;";
            SqlConnection sqlCon2 = new SqlConnection(@"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP (1000) [KodProduktu],[NazwaProduktu],[Status]FROM[RejestracjaUzytkownika].[dbo].[Produkty]", sqlCon2);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["KodProduktu"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["NazwaProduktu"].ToString();
                if ((bool)item["Status"])
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Dostepny";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Niedostepny";
                }

            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if ((comboBox1.SelectedText = dataGridView1.SelectedRows[0].Cells[2].Value.ToString()) == "Dostepny")
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.SelectedIndex = 1;
            }
           
        }
    }
}
