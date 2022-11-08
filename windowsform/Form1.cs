using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace windowsform
{
    public partial class tagdij : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
       

        public tagdij()
        {
            InitializeComponent();
        }

        private void tagdij_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "tagdij";
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                connection.Open();
                command = connection.CreateCommand();

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll");
                Environment.Exit(0);
               
            }
            Tagok_Update();
        }

        /// <summary>
        /// A listbox_Klubtagokat frissíti az adatbázis tartalma alapján
        /// </summary>
      

         private void Tagok_Update()
        {
            
            listBox_Klubtagok.Items.Clear();

            try
            {
                command.CommandText="SELECT `azon`,`nev`,`szulev`,`irszam`,`orsz` FROM `ugyfel` WHERE 1";
                using (MySqlDataReader dr=command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        //-- aktuálisan kiolvasott rekord feldolgozása
                        Tag beolvasott = new Tag(dr.GetInt32("azon"), dr.GetString("nev"), dr.GetInt32("szulev"),dr.GetString("irszam"),dr.GetString("orsz"));

                        listBox_Klubtagok.Items.Add(beolvasott);

                    }

                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void listBox_Klubtagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Klubtagok.SelectedIndex<0)
            {
                return;
            }
            //-- Biztosan kattintott a felhasználó
            Tag kivalasztottTag = (Tag)listBox_Klubtagok.SelectedItem;
            Text_Box_Azon.Text=kivalasztottTag.Azon.ToString();
            Text_Box_Nev.Text=kivalasztottTag.Nev;
            textBox_orszag.Text = kivalasztottTag.Orsz;
            numericUpDown_iranyitoszam.Value = decimal.Parse(kivalasztottTag.Irszam);
            numericUpDown_szulev.Value = kivalasztottTag.Szulev;

        }
    }
}
