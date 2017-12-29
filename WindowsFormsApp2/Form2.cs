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
    public partial class Form2 : Form
    {
        string connectionString = @"Data Source=DESKTOP-T2UI567\SQLEXPRESS;Initial Catalog=RejestracjaUzytkownika;Integrated Security=True;";
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            SqlConnection con = new SqlConnection(connectionString);
            //SqlDataAdapter sda = new SqlDataAdapter("Select * From RejestracjaUzytkownika where Nick='" + txtLogNick.Text+ "' and Haslo '" + txtLogHaslo.Text + "'",con);
            SqlCommand com = new SqlCommand("SELECT * FROM tblUser WHERE Imie = @Imie and Haslo = @Haslo", con);
            con.Open();
            com.Parameters.AddWithValue("@Imie", txtLogNick.Text);
            com.Parameters.AddWithValue("@Haslo", txtLogHaslo.Text);
            SqlDataReader Dr = com.ExecuteReader();
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            if (Dr.HasRows == true)
            {
                MessageBox.Show("Zalogowano.");
                    this.Hide();
                    StosMain fm2 = new StosMain();
                    fm2.Show();
                }
            else if(txtLogNick.Text == "" || txtLogHaslo.Text =="")
                    MessageBox.Show("Prosze wypelnic wszytkie pola.");

                else
            {
                MessageBox.Show("Zle haslo lub Nick.");
            }
        }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm2 = new Form1();
            fm2.Show();
        }
    }
}
