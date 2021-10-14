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
        //string connectionString = "Server=192.168.2.115,63725; Database=PokerChips; User Id=NeuerBenutzer; Password=User1;";
         string connectionString = "Server=10.105.1.191,1433; Database=PokerChips; User Id=CasinoDealer; Password=PokerAbend.15;";
        string name;
        string chip_Anzahl;

        public Leaderboard()
        {
            InitializeComponent();
            ShowTop5();
        }

        private void ShowTop5()
        {
            string query = "SELECT top 5 Chip_Anzahl, Name FROM chipTable ORDER BY Chip_Anzahl DESC";

            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                do
                {
                    while (reader.Read())
                    {
                        chip_Anzahl = reader.GetInt32(0).ToString();
                        name = reader.GetString(1);

                        ListViewItem lvItem = new ListViewItem(chip_Anzahl);
                        lvItem.SubItems.Add(name);
                        listView1.Items.Add(lvItem);
                    }             
                } 
                while (reader.NextResult());
            }

            

        }
    }
}
