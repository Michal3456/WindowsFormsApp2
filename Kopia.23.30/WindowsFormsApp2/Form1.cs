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
using System.Data.Sql;
using System.Data.SqlTypes;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();       
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNick.Text == "" || txtHaslo.Text == "")
                MessageBox.Show("Prosze wypelnic wszzytkie pola do rejestracji.");
            else if (txtHaslo.Text != txtPowtorz_haslo.Text)
                MessageBox.Show("Haslo nie jest  takie same.");
            else {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    // sqlCmd.Parameters.AddWithValue("@Imie",);
                    sqlCmd.Parameters.AddWithValue("@Imie", txtImie.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Nazwisko", txtNazwisko.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Kontakt", txtKontakt.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Adres", txtAdres.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Nick", txtNick.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Haslo", txtHaslo.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Zarejestrowano.");
                    Clear();
                }
            }



        }
        void Clear()
        {
            txtImie.Text = txtNazwisko.Text = txtKontakt.Text = txtAdres.Text = txtNick.Text = txtHaslo.Text = txtPowtorz_haslo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm2 = new Form2();
            fm2.Show();
        }
    }

}
