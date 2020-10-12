﻿using System;
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

            string inputusername = textBox1.Text;
            string inputpassword = textBox2.Text;

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
            
            connectionstring = "SERVE=" + server + ";" + "DATABASE=" + database + ";" + "UID" + uid
                + ";" + "PASSWORD" + password + ";";
            connection = new MySqlConnection(connectionstring);
        }
    }
}