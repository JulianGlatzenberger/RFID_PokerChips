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
        string connectionString = "Server=192.168.2.119,1433; Database=PokerChips; User Id=SA; Password=Server.123;";

        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
            uidTextbox.Select();
        }

        private void registerChip() // TODO: Nach Ausführung Textbox clear
        {
            string uid = uidTextbox.Text;
            string name = nameTextbox.Text;
            int chipAnzahl = 5000;
            string query = String.Format("SELECT COUNT(*) FROM chipTable WHERE Chip_ID = '{0}';", uid);
            string query1 = String.Format("IF NOT EXISTS " +
                "(SELECT 1 FROM chipTable WHERE Chip_ID = {0})" +
                "BEGIN INSERT INTO chipTable (Chip_ID, Chip_Anzahl, Name) " +
                "VALUES ('{1}', '{2}', '{3}') END;", uid, uid, chipAnzahl, name);

            if (string.IsNullOrWhiteSpace(uid) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Keines der Felder darf leer sein!");
            }
            else
            {
                try
                {
                    using(SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {                          
                            Int32 count = (Int32)command.ExecuteScalar();
                            connection.Close();

                            if(count == 0)
                            {
                                using (SqlCommand command1 = new SqlCommand(query1, connection))
                                {
                                    connection.Open();
                                    command1.ExecuteNonQuery();
                                    connection.Close();

                                    MessageBox.Show(String.Format("Registrierung erfolgreich!" + Environment.NewLine + Environment.NewLine +
                                    "ChipID = {0}" + Environment.NewLine + "Name = {1}", uidTextbox.Text, nameTextbox.Text));
                                }
                            }
                            else
                            {
                                MessageBox.Show("Registrierung nicht erfolgreich!" + Environment.NewLine + Environment.NewLine + "Der Chip wurde bereits Registriert.");
                            }
                        }   
                    }
                    
                    uidTextbox.Clear();
                    nameTextbox.Clear();
                    uidTextbox.Select();
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
        }

        private void abbrechenButton_Click(object sender, EventArgs e)
        {
            uidTextbox.Clear();
            nameTextbox.Clear();
            uidTextbox.Select();
        }

        private void uidTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '0')
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Return)
            {
                nameTextbox.Select();
            }
        }

        private void nameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                registerChip();
            }
        }
    }
}
