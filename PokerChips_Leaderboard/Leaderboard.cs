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

namespace PokerChips_Leaderboard
{
    public partial class Leaderboard : Form
    {
        SqlConnection sqlConnection;
        string connectionString = "Server=192.168.2.115,63725; Database=PokerChips; User Id=NeuerBenutzer; Password=User1;";

        public Leaderboard()
        {
            InitializeComponent();
            ShowTop5();
        }

        private void ShowTop5()
        {
            string query = "SELECT top 5 Chip_Anzahl FROM chipTable ORDER BY Chip_Anzahl DESC";
            string name = "";
            int chip_Anzahl = 0;

            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while(reader.Read())
                {
                    chip_Anzahl = reader.GetInt32(0);
                }
                reader.Close();
            }
            MessageBox.Show(chip_Anzahl.ToString());

        }
    }
}
