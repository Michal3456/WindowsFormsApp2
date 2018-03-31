using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            LoadData2();
        }
        //usuwanie
        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            var sqlQuery = "";
            if (KlJesliProduktJest.IfProduktistnieje2(sqlCon, textBox1.Text))
            {
                sqlCon.Open();
                sqlQuery = @"DELETE FROM [StosStos] WHERE [KodProduktu] = '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlCon);
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Usunieto z koszyka.");
            }
            else
            {
                MessageBox.Show("Rekord nie istnieje.", "bład");
            }

            LoadData2();


        }
        public void LoadData2()
        {
            //Czytanie danych
            // string connectionString = @"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;";
            SqlConnection sqlCon3 = new SqlConnection(@"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;");
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP (1000) [KodProduktu],[NazwaProduktu],[Status],[Koszt],[Ilosc]FROM[RejestracjaUzytkownika].[dbo].[StosStos]", sqlCon3);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            dataGridView2.Rows.Clear();
            foreach (DataRow item in dt1.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item["KodProduktu"].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item["NazwaProduktu"].ToString();
                if ((bool)item["Status"])
                {
                    dataGridView2.Rows[n].Cells[2].Value = "Dostepny";
                }
                else
                {
                    dataGridView2.Rows[n].Cells[2].Value = "Niedostepny";
                }
                //1
                dataGridView2.Rows[n].Cells[3].Value = item["Koszt"].ToString();
                dataGridView2.Rows[n].Cells[4].Value = item["Ilosc"].ToString();

            }
            //   decimal x = (decimal)dt1.Compute("Sum(Koszt)","");
            int x = 0;
            

            MessageBox.Show($"bfbbf{x}");

        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            if ((comboBox1.SelectedText = dataGridView2.SelectedRows[0].Cells[2].Value.ToString()) == "Dostepny")
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.SelectedIndex = 1;
            }
            //1
            textBox3.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            ////////////////////////////////////////////////////////2
           // textBox5.Text = 
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.button2, "Aby usunac produkt z koszyka kliknij dwa razy na rekord produktu.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {          
            string connectionString = @"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
                var sqlQuery = "";
            if(KlJesliProduktJest.IfProduktistnieje2(sqlCon, textBox1.Text))
                {
                    sqlQuery = @"UPDATE [dbo].[StosStos]
   SET [Ilosc]='"+textBox4.Text+"' WHERE [KodProduktu] = '" + textBox1.Text + "'";
                }
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlCon);
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                LoadData2();
            }

        }
    }

