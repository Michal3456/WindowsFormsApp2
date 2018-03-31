using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp2
{
    class KlJesliProduktJest
    {
        public static bool IfProduktistnieje1(SqlConnection sqlCon, string KodProduktu)
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
        public static bool IfProduktistnieje2(SqlConnection sqlCon, string KodProduktu)
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
    }
}
