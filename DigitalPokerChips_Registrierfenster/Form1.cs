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
using System.Configuration;


namespace DigitalPokerChips_Registrierfenster
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        string connectionString = ConfigurationManager.ConnectionStrings["DigitalPokerChips_Registrierfenster.Properties.Settings.PokerChipsConnectionString"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
            uidTextbox.Select();
        }

        private void registerChip()
        {
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
                    //sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void registrierButton_Click(object sender, EventArgs e)
        {          
            registerChip();

            MessageBox.Show(String.Format("Registrierung erfolgreich!" + Environment.NewLine + Environment.NewLine +
            "ChipID = {0}" + Environment.NewLine + "Name = {1}", uidTextbox.Text, nameTextbox.Text));
            
        }

        private void abbrechenButton_Click(object sender, EventArgs e)
        {
            uidTextbox.Clear();
            nameTextbox.Clear();
        }
    }
}
