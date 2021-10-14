using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DigitalPokerChips_Registrierfenster
{
    public partial class Registerwindow : Form
    {
        SqlConnection sqlConnection;
        //string connectionString = "Server=192.168.2.119,1433; Database=PokerChips; User Id=SA; Password=Server.123;";
        //string connectionString = "Server=192.168.2.115,63725; Database=PokerChips; User Id=NeuerBenutzer; Password=User1;";
        string connectionString = "Server=10.105.1.191,1433; Database=PokerChips; User Id=CasinoDealer; Password=PokerAbend.15;";
        
        

        public Registerwindow()
        {
            InitializeComponent();
            uidTextbox.Select();

            sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RegisterChip()
        {
            string chipAnzahl = "5000";
            string uid = uidTextbox.Text;
            string name = nameTextbox.Text;
            string query = "SELECT COUNT(*) FROM chipTable WHERE Chip_ID = @uID;";
            string query1 = string.Format(("IF NOT EXISTS " +
                "(SELECT 1 FROM chipTable WHERE Chip_ID = '{0}')" +
                "BEGIN INSERT INTO chipTable (Chip_ID, Chip_Anzahl, Name) " +
                "VALUES ('{1}', '{2}', '{3}') END;"), uid, uid, chipAnzahl, name);

            if (string.IsNullOrWhiteSpace(uidTextbox.Text) || string.IsNullOrWhiteSpace(nameTextbox.Text))
            {
                MessageBox.Show("Keines der Felder darf leer sein!");
            }
            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlcommand = new SqlCommand(query, sqlConnection);
                sqlcommand.Parameters.AddWithValue("@uID", uid);

                Int32 count = (Int32)sqlcommand.ExecuteScalar();


                if (count == 0)
                {
                    SqlCommand command = new SqlCommand(query1, sqlConnection);
           
                    command.ExecuteNonQuery();

                    MessageBox.Show(String.Format("Registrierung erfolgreich!" + Environment.NewLine + Environment.NewLine +
                    "ChipID = {0}" + Environment.NewLine + "Name = {1}", uidTextbox.Text, nameTextbox.Text));

                }
                else
                {
                    MessageBox.Show("Registrierung nicht erfolgreich!" + Environment.NewLine + Environment.NewLine + "Der Chip wurde bereits Registriert.");
                }
            }

            sqlConnection.Close();
            uidTextbox.Clear();
            nameTextbox.Clear();
            uidTextbox.Select();
        }

        private void RegistrierButton_Click(object sender, EventArgs e)
        {
            RegisterChip();
        }

        private void AbbrechenButton_Click(object sender, EventArgs e)
        {
            uidTextbox.Clear();
            nameTextbox.Clear();
            uidTextbox.Select();
        }

        private void UidTextbox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void NameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                RegisterChip();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //sqlConnection.Close();
            //sqlConnection.Dispose();
        }
    }
}
