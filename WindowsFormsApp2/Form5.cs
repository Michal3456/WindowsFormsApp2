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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load_1(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            LoadData1();
            LoadData2();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {


                string connectionString = @"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;";
                SqlConnection sqlCon = new SqlConnection(connectionString);
                sqlCon.Open();
                bool status = false;
                if (comboBox1.SelectedIndex == 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
                var sqlQuery = "";
                if (IfProduktistnieje2(sqlCon, textBox1.Text))
                {
                    sqlQuery = @"UPDATE [dbo].[StosStos]
   SET [NazwaProduktu] = '" + textBox2.Text + "' ,[Status] = '" + status + "',[Koszt]='" + textBox3.Text + "' WHERE [KodProduktu] = '" + textBox1.Text + "'";
                    MessageBox.Show("Produkt juz jest w koszyku.", "Wiadomosc");
                }
                else
                {
                    sqlQuery = @"INSERT INTO [StosStos] ([KodProduktu] ,[NazwaProduktu]  ,[Status],[Koszt]) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + status + "','" + textBox3.Text + "')";
                    MessageBox.Show("Dodano do koszyka.");
                }

                SqlCommand cmd = new SqlCommand(sqlQuery, sqlCon);
                cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Czytanie danych111
            // string connectionString = @"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;";
            SqlConnection sqlCon2 = new SqlConnection(@"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP (1000) [KodProduktu],[NazwaProduktu],[Status],[Koszt]FROM[RejestracjaUzytkownika].[dbo].[Produkty]", sqlCon2);
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
                //1
                dataGridView1.Rows[n].Cells[3].Value = item["Koszt"].ToString();
                //Czytanie danych
              //  LoadData1();
                LoadData2();
            }
        }

        private bool IfProduktistnieje1(SqlConnection sqlCon, string KodProduktu)
        {
            SqlConnection sqlCon2 = new SqlConnection(@"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT 1 FROM [dbo].[Produkty] WHERE [KodProduktu]='" + KodProduktu + "'", sqlCon2);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        private bool IfProduktistnieje2(SqlConnection sqlCon, string KodProduktu)
        {
            SqlConnection sqlCon2 = new SqlConnection(@"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT 1 FROM [dbo].[StosStos] WHERE [KodProduktu]='" + KodProduktu + "'", sqlCon2);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public void LoadData1()
        {
            //Czytanie danych
            // string connectionString = @"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;";
            SqlConnection sqlCon2 = new SqlConnection(@"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP (1000) [KodProduktu],[NazwaProduktu],[Status],[Koszt]FROM[RejestracjaUzytkownika].[dbo].[Produkty]", sqlCon2);
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
                //1
                dataGridView1.Rows[n].Cells[3].Value = item["Koszt"].ToString();

            }
        }
            public void LoadData2()
            {
                //Czytanie danych
                // string connectionString = @"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;";
                SqlConnection sqlCon3 = new SqlConnection(@"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;");
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TOP (1000) [KodProduktu],[NazwaProduktu],[Status],[Koszt]FROM[RejestracjaUzytkownika].[dbo].[StosStos]", sqlCon3);
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

                }
           // decimal x = (decimal)dt1.Compute("Sum(Koszt)","");

          //  MessageBox.Show("{0}", x.ToString()) ;
            }
            private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
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
                //1
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
            //usuwanie
            private void button2_Click(object sender, EventArgs e)
            {
                string connectionString = @"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;";
                SqlConnection sqlCon = new SqlConnection(connectionString);
                var sqlQuery = "";
                if (IfProduktistnieje2(sqlCon, textBox1.Text))
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


            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
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
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.button2, "Aby usunac produkt z koszyka kliknij dwa razy na rekord produktu.");
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.button1, "Aby dodac produkt do koszyka kliknij dwa razy na rekord produktu z listy produktow.");
        }
        //Filtr
        private void button3_Click(object sender, EventArgs e)
        {


            try
            {
                if (comboBox2.Text == "Nazwa Produktu")
                {
                   // dataGridView2.ClearSelection();
                    string connectionString = @"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;";
                    SqlConnection sqlCon = new SqlConnection(connectionString);
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT TOP (1000) [KodProduktu],[NazwaProduktu],[Status],[Koszt]FROM[RejestracjaUzytkownika].[dbo].[Produkty] WHERE [NazwaProduktu] like '%"  + txtSzukKod.Text +  "%'", sqlCon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    //dataGridView1.DataSource = dt;
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
                        //1
                        dataGridView1.Rows[n].Cells[3].Value = item["Koszt"].ToString();

                    }
                }


                /*
                sqlCon.Open();
                var sqlQuery = @"SELECT TOP (1000) [KodProduktu],[NazwaProduktu],[Status],[Koszt]FROM[RejestracjaUzytkownika].[dbo].[Produkty] WHERE [NazwaProduktu]= '" + txtSzukKod.Text + "'";
               // bool status = false;
                if (comboBox2.SelectedIndex == 1)
                {
                    sqlQuery = @"SELECT TOP (1000) [KodProduktu],[NazwaProduktu],[Status],[Koszt]FROM[RejestracjaUzytkownika].[dbo].[Produkty] WHERE [NazwaProduktu]= '" + txtSzukKod.Text + "'";
                }
               
                
                if (IfProduktistnieje2(sqlCon, textBox1.Text))
                {
                    sqlQuery = @"UPDATE [dbo].[StosStos]
   SET [NazwaProduktu] = '" + textBox2.Text + "' ,[Status] = '" + status + "',[Koszt]='" + textBox3.Text + "' WHERE [KodProduktu] = '" + textBox1.Text + "'";
                }
                else
                {
                    sqlQuery = @"INSERT INTO [StosStos] ([KodProduktu] ,[NazwaProduktu]  ,[Status],[Koszt]) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + status + "','" + textBox3.Text + "')";
                    MessageBox.Show("Dodano do koszyka.");
                }
                
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlCon);
                cmd.ExecuteNonQuery();
                //LoadData1();
                sqlCon.Close();
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    } 
