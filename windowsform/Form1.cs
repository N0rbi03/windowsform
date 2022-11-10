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

        private void button_insert_Click(object sender, EventArgs e)
        {
            
            Tagok_Update2();
            Tagok_Update();
        }
        private void Tagok_Update2()
        {

            listBox_Klubtagok.Items.Clear();

            try
            {
                command.CommandText = $"INSERT INTO `ugyfel`(`azon`, `nev`, `szulev`, `irszam`, `orsz`) VALUES ('{Text_Box_Azon.Text}','{Text_Box_Nev.Text}','{numericUpDown_szulev.Value}','{numericUpDown_iranyitoszam.Value}','{textBox_orszag.Text}')";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        //-- aktuálisan kiolvasott rekord feldolgozása
                        Tag beolvasott = new Tag(dr.GetInt32("azon"), dr.GetString("nev"), dr.GetInt32("szulev"), dr.GetString("irszam"), dr.GetString("orsz"));

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

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Tagok_Update3();
            Tagok_Update();
        }
        private void Tagok_Update3()
        {

            listBox_Klubtagok.Items.Clear();

            
            try
            {
                if (Text_Box_Azon.Text!="")
                {
                    command.CommandText = $"DELETE FROM `ugyfel` WHERE azon={Text_Box_Azon.Text}  ";
                }
                else if (Text_Box_Nev.Text != "")
                {
                    command.CommandText = $"DELETE FROM `ugyfel` WHERE nev='{Text_Box_Nev.Text}'  ";
                }
                else if (textBox_orszag.Text != "")
                {
                    command.CommandText = $"DELETE FROM `ugyfel` WHERE orsz='{textBox_orszag.Text}'  ";
                }
                else if (numericUpDown_iranyitoszam.Value != 1000)
                {
                    command.CommandText = $"DELETE FROM `ugyfel` WHERE irszam={numericUpDown_iranyitoszam.Value}  ";
                }
                else if (numericUpDown_szulev.Value != 1900)
                {
                    command.CommandText = $"DELETE FROM `ugyfel` WHERE szulev={numericUpDown_szulev.Value}  ";
                }
               
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        //-- aktuálisan kiolvasott rekord feldolgozása
                        Tag beolvasott = new Tag(dr.GetInt32("azon"), dr.GetString("nev"), dr.GetInt32("szulev"), dr.GetString("irszam"), dr.GetString("orsz"));

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
    }
}

