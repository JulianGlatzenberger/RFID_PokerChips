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
    public partial class mainWindow : Form //Codeoptimierung: Standartzugriff auf Datenbank in Methode
    {
        SqlConnection sqlConnection;
        //string connectionString = "Server=192.168.2.119,1433; Database=PokerChips; User Id=SA; Password=Server.123;";
        string connectionString = "Server=192.168.2.115,63725; Database=PokerChips; User Id=NeuerBenutzer; Password=User1;";
        int bookCounter = -1;

        public mainWindow()
        {
            InitializeComponent();
            chipIdBox.Select();

            panel4.Update();

            sqlConnection = new SqlConnection(connectionString);
        }

        public void showChips() //Chipanzahl auslesen, in Lable schreiben
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);

                string chipID = chipIdBox.Text;
                string query = String.Format("SELECT Chip_Anzahl, Name FROM chipTable WHERE Chip_ID = '{0}';", chipID);
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
                        standLable.Text = String.Format("du hast aktuell {0} Chips", (dataReader.GetInt32(0)));
                        nameLabel.Text = String.Format("{0},", (dataReader.GetString(1)));
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

        private void bookOnChip(string query)   //Buchungsquery ausführen
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                //MessageBox.Show("Buchung erfolgreich!");
            }

            catch (Exception E)
            {

                MessageBox.Show(E.ToString());
            }

            showChips();
            betragTextbox.Clear();
            chipIdBox.Clear();
            chipIdBox.Select();
            
        }

        private void bookquery1()   //SQL Query für Aufbuchen
        {
            int anzahl = 0;
            bool rechenArt = true;
            string uid = chipIdBox.Text;
            string userName = "";
            string betrag = betragTextbox.Text;
            int betragInt = Int32.Parse(betrag);
            string query1 = string.Format("SELECT Chip_Anzahl, Name FROM chipTable WHERE Chip_ID = '{0}';", uid);

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
                    userName = dataReader.GetString(1);
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
            showTransaktion(uid, betrag, anzahl, userName, rechenArt);
        }

        private void bookquery2()   //SQL Query für Abbuchen
        {
            int anzahl = 0;
            bool rechenArt = false;
            string uid = chipIdBox.Text;
            string userName = "";
            string betrag = betragTextbox.Text;
            int betragInt = Int32.Parse(betrag);
            string query1 = string.Format("SELECT Chip_Anzahl, Name FROM chipTable WHERE Chip_ID = '{0}';", uid);

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
                    userName = dataReader.GetString(1);
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
            showTransaktion(uid, betrag, anzahl, userName, rechenArt);
        }

        private void showTransaktion(string ChipID, string betrag, int startAnzahl, string Name, bool vorzeichen) //Anzeigen der letzten Buchungen in listView
        {
            Random random = new Random();
            int num = random.Next(); 
            string hexString = num.ToString("X");

            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToString("T");
 
            ListViewItem lvItem = new ListViewItem(Name);

            lvItem.SubItems.Add(ChipID);

            if(vorzeichen == true)
            {
                lvItem.SubItems.Add("+ " + betrag);
            }
            else if(vorzeichen != true) 
            {
                lvItem.SubItems.Add("- " + betrag);
            }

            lvItem.SubItems.Add(startAnzahl.ToString());
            lvItem.SubItems.Add(date);
            listView1.Items.Add(lvItem);

            label1.Hide();
            bookCounter++;
        }

        private void resetBook(string anzahl, string chipId)    //Ausgewählte Buchung aus listView zurück buchen
        {
            string query = String.Format("UPDATE chipTable SET Chip_Anzahl = '{0}' WHERE Chip_ID = '{1}';", anzahl, chipId);
            bookOnChip(query);
        }

        private void abbrechen()    //Clearen aller Textboxen und Lables
        {
            chipIdBox.Clear();
            betragTextbox.Clear();
            standLable.Text = "du hast aktuell --- Chips!";
            nameLabel.ResetText();
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

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string chipID = listView1.Items[bookCounter].SubItems[1].Text; 
            string alteAnzahl = listView1.Items[bookCounter].SubItems[3].Text;

            DialogResult result = MessageBox.Show("Möchtest du die Buchung rückgangig machen?", "Achtung!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK) // TODO: Rework
            {
                resetBook(alteAnzahl, chipID);
                chipIdBox.Text = chipID;
                showChips();
            }
        }

        private void mainWindow_Load(object sender, EventArgs e)  //Tooltips
        {
            ToolTip toolTip = new ToolTip();

            toolTip.ShowAlways = true;

            toolTip.SetToolTip(this.chipIdBox, "Eingabe der KartenID");
            toolTip.SetToolTip(this.betragTextbox, "Eingabe des Betrags");
            toolTip.SetToolTip(this.aufbuchButton, "Eingegebenen Betrag addieren");
            toolTip.SetToolTip(this.abbuchButton, "Eingegebenen Betrag subtrahieren");
            toolTip.SetToolTip(this.listView1, "Hier kannst du die letzte Buchung rückgängig machen");
            toolTip.SetToolTip(this.ausleseButton, "Auslesen der Anzahl an Chips");

        }
    }      
}