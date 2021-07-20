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
            try
            {
                sqlConnection = new SqlConnection(connectionString);

                string chipID = chipIdBox.Text;
                string query = String.Format("SELECT Chip_Anzahl FROM chipTable WHERE Chip_ID = '{0}';", chipID);
                using (sqlConnection)
                {
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection)
                    {
                        CommandText = query
                    };
                    sqlConnection.Open();

                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        standLable.Text = String.Format("Du hast aktuell {0} Chips", (dataReader.GetInt32(0)));
                    }

                    dataReader.Close();
                    sqlConnection.Close();
                }

                betragTextbox.Select();
            }
            catch (Exception ef)
            {
                if(ef is SqlException)
                {
                    MessageBox.Show("Chip wurde nicht erkannt oder noch nicht registriert!");
                    chipIdBox.Clear();
                    chipIdBox.Select();
                }
                else
                {
                    MessageBox.Show(ef.ToString());
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

                MessageBox.Show("Buchung erfolgreich!");
            }

            catch (Exception E)
            {

                MessageBox.Show(E.ToString());
            }

            showChips();
            betragTextbox.Clear();
            chipIdBox.Clear();
            chipIdBox.Select();
            //addTransaktion()
        }

        private void bookquery1()   //Addition Query
        {
            int anzahl = 0;
            string uid = chipIdBox.Text;
            string betrag = betragTextbox.Text;
            int betragInt = Int32.Parse(betrag);
            string query1 = string.Format("SELECT Chip_Anzahl FROM chipTable WHERE Chip_ID = '{0}';", uid);

            try
            {
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCmd = new SqlCommand(query1, sqlConnection);
                sqlCmd.CommandText = query1;

                sqlConnection.Open();
                SqlDataReader dataReader = sqlCmd.ExecuteReader();

                while (dataReader.Read())
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

            int neuezahl = anzahl + betragInt;
            string Chipanzahl = neuezahl.ToString();
            string query = string.Format("UPDATE chipTable SET Chip_Anzahl = '{0}' WHERE Chip_ID = '{1}';", Chipanzahl, uid);

          
            bookOnChip(query);
            showTransaktion(uid);
            //resetBook(betragInt, anzahl, uid);
        }

        private void bookquery2()   //Subraktion Query
        {
            int anzahl = 0;
            string uid = chipIdBox.Text;
            string betrag = betragTextbox.Text;
            int betragInt = Int32.Parse(betrag);
            string query1 = string.Format("SELECT Chip_Anzahl FROM chipTable WHERE Chip_ID = '{0}';", uid);

            //Auslesen der Chips:
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCmd = new SqlCommand(query1, sqlConnection);
                sqlCmd.CommandText = query1;

                sqlConnection.Open();
                SqlDataReader dataReader = sqlCmd.ExecuteReader();

                while (dataReader.Read())
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

            int neuezahl = anzahl - betragInt;

            if(neuezahl <= 0)
            {
                neuezahl = 0;
                MessageBox.Show("Du hast deine letzten Chips verloren!");
            }

            string query = string.Format("UPDATE chipTable SET Chip_Anzahl = '{0}' WHERE Chip_ID = '{1}';", neuezahl, uid);

            bookOnChip(query);
            showTransaktion(uid);
        }

        private void showTransaktion(string ChipID) //String Betrag
        {
            Random random = new Random();
            int num = random.Next(); 
            string hexString = num.ToString("X");

            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToString("T");
 
            ListViewItem lvItem = new ListViewItem(hexString);

            lvItem.SubItems.Add(ChipID);
            lvItem.SubItems.Add(date);
            //lvItem.SubItems.Add(startAnzahl); // optional: Betrag für bessere Verständlichkeit
            listView1.Items.Add(lvItem);

            label1.Hide();
        }

        private void resetBook(int betrag, int anzahl, string chipId)
        {
            string query = String.Format("UPDATE chipTable SET Chip_Anzahl = '{0}' WHERE Chip_ID = '{1}';", anzahl, chipId);
            bookOnChip(query);
        }

        private void abbrechen()
        {
            chipIdBox.Clear();
            betragTextbox.Clear();
            standLable.Text = "Du hast aktuell --- Chips!";
            chipIdBox.Select();
        }

        private void ausleseButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(chipIdBox.Text))
            {
                MessageBox.Show("Du musst zuerst deinen Chip scannen!");
            }
            else
            {
                showChips();
            }
        }

        public void aufbuchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(chipIdBox.Text) || string.IsNullOrWhiteSpace(betragTextbox.Text))
            {
                MessageBox.Show("Keines der beiden Felder darf leer sein.");
            }
            else
            {
                bookquery1();
            }
        }

        private void abbuchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(chipIdBox.Text) || string.IsNullOrWhiteSpace(betragTextbox.Text))
            {
                MessageBox.Show("Keines der beiden Felder darf leer sein.");
            }
            else
            {
                bookquery2();
            }
        }

        private void abbrechenButton_Click(object sender, EventArgs e)
        {
            abbrechen();
        }

        private void betragTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chipIdBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e) // New Window
        {
            string chipID = listView1.Items[0].SubItems[1].Text; // anzahl zu lv hinzufügen -> in methode abgreifen
            //resetBook(chipID)
            MessageBox.Show(chipID);
        }
    }
        
}