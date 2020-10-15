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

namespace KitchenStaff
{
    public partial class Login : Form

    {
        public string username { get; set; }
        private MySqlConnection connection;
        private string server = "sql7.freemysqlhosting.net";
        private string database = "sql7368973";
        private string uid = "sql7368973";
        private string password = "1lFxsKtjXr";
        string connectionstring;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             bool varify = false;
            // run input through data base to check if they are a staff member

            string inputusername = textBoxUsername.Text;
            string inputpassword = textBoxPassword.Text;

            string query = "SELECT * FROM Staff";

            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                if ((dataR["Username"] == inputusername)&& (dataR["Password"] == inputpassword)) 
                {
                    varify = true;
                }
                else 
                {
                    varify = false;
                }
                
            }

            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();

            if (varify)
            { 
               // take to next form 
            }
            else
            {
                // show message input is wrong 
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblHeading.ForeColor = System.Drawing.Color.White ;
            lblPassword.ForeColor = System.Drawing.Color.White;
            lblUsername.ForeColor = System.Drawing.Color.White;

            this.BackColor = System.Drawing.Color.SlateBlue;
            btnConfirmlogin.ForeColor = System.Drawing.Color.White;

            btnConfirmlogin.BackColor = System.Drawing.Color.MidnightBlue;


            connectionstring = "SERVE=" + server + ";" + "DATABASE=" + database + ";" + "UID" + uid
                + ";" + "PASSWORD" + password + ";";
            connection = new MySqlConnection(connectionstring);
        }
    }
}
