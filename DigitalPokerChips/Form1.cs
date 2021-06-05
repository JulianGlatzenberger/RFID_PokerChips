using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DigitalPokerChips
{
    public partial class mainWindow : Form
    {
        SqlConnection sqlConnection;

        public mainWindow()
        {

            InitializeComponent();

            //Datenbank Verbindung erstellen      
            string connectionString = ConfigurationManager.ConnectionStrings["DigitalPokerChips.Properties.Settings.PokerChipsConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();



        }

        public void showChips()
        {
            string chipID = chipIdBox.Text;
            string query = "SELECT Chip_Anzahl FROM chipTable WHERE Chip_ID = '3765171';";
            using (sqlConnection)
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandText = query;

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while(dataReader.Read())
                {
                   ;
                    standLable.Text = String.Format("Du hast aktuell {0} Chips", (dataReader.GetInt32(0)));
                    //MessageBox.Show("Du hast aktuell {0} Chips!",(dataReader.GetInt32(0)).ToString());
                }
                dataReader.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showChips();
        }
    }
}