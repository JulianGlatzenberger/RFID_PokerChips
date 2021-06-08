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

        public void showChips() //TODO: Try Catch
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

                while (dataReader.Read())
                {
                    standLable.Text = String.Format("Du hast aktuell {0} Chips", (dataReader.GetInt32(0)));
                }
                dataReader.Close();
                sqlConnection.Close();
            }
        }

        public void registerChip()
        {
            //if(uid || name == null) erro
            string uid = uidTextbox.Text;
            string name = nameTextbox.Text;
            int chipAnzahl = 2950;
            string query = String.Format("INSERT INTO chipTable (Chip_ID, Chip_Anzahl, Name)VALUES ('{0}', '{1}', '{2}');", uid, chipAnzahl, name);

            if (string.IsNullOrWhiteSpace(uid) || string.IsNullOrWhiteSpace(name))
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

        private void bookOnChip(string query)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }

            catch (Exception E)
            {

                MessageBox.Show(E.ToString()) ;
            }
            
            showChips();
            //addTransaktion()
        }

        private void registrierButton_Click(object sender, EventArgs e)
        {
            registerChip();
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

        public void aufbuchButton_Click(object sender, EventArgs e)
        {
            int neuezahl;
            int anzahl;
            int betragInt;
            string uid = uidTextbox.Text;
            string betrag = betragTextbox.Text;
            string query;
            string query1 = string.Format("SELECT Chip_Anzahl FROM chipTable WHERE Chip_ID = '{0}';" ,uid);

            //Auslesen der Chips:
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCmd = new SqlCommand(query1, sqlConnection);
                sqlCmd.CommandText = query1;

                sqlConnection.Open();
                SqlDataReader dataReader = sqlCmd.ExecuteReader();

                while(dataReader.Read())
                {
                    anzahl = dataReader.GetInt32(0);
                }

                dataReader.Close();
                sqlConnection.Close();
            }
           
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
            

            betragInt = Int32.Parse(betrag);
            neuezahl = anzahl + betragInt;
            query = "";


            bookOnChip(query);
        }
        
        
        private void abbuchButton_Click(object sender, EventArgs e)
        {
            //string query = "UPDATE chipTableSET Chip_Anzahl = '2677'WHERE Chip_ID = '5011720'; ";
            //bookOnChip(query);
        }

        private void betragTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}