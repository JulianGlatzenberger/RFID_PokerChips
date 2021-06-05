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
        string connectionString = ConfigurationManager.ConnectionStrings["DigitalPokerChips.Properties.Settings.PokerChipsConnectionString"].ConnectionString;
        public mainWindow()
        {
            InitializeComponent();
            chipIdBox.Select();
     
            sqlConnection = new SqlConnection(connectionString);
            



        }

        public void showChips()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DigitalPokerChips.Properties.Settings.PokerChipsConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);

            string chipID = chipIdBox.Text;
            string query = String.Format("SELECT Chip_Anzahl FROM chipTable WHERE Chip_ID = '{0}';", chipID);
            using (sqlConnection)
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandText = query;
                sqlConnection.Open();

                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                
                while(dataReader.Read())
                {
                    standLable.Text = String.Format("Du hast aktuell {0} Chips", (dataReader.GetInt32(0)));
                }
                dataReader.Close();
                sqlConnection.Close();
            }
        }

        private void registrierButton_Click(object sender, EventArgs e)
        {
            //if(uid || name == null) erro
            string uid = uidTextbox.Text;
            string name = nameTextbox.Text;
            int chipAnzahl = 2950;
            string query = String.Format("INSERT INTO chipTable (Chip_ID, Chip_Anzahl, Name)VALUES ('{0}', '{1}', '{2}');", uid, chipAnzahl, name);

            if(string.IsNullOrWhiteSpace(uid) || string.IsNullOrWhiteSpace(name) )
            {
               MessageBox.Show("Keines der Felder darf leer sein!");
            }
            else
            {
                try
                {
                    sqlConnection = new SqlConnection(connectionString);
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            } 
        }

        private void ausleseButton_Click(object sender, EventArgs e)
        {
            showChips();
        }

        private void abbrechenButton_Click(object sender, EventArgs e)
        {
            uidTextbox.Clear();
            nameTextbox.Clear();
        }

        
    }
}