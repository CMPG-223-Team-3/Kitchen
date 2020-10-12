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
    public partial class Logout : Form
    {
        private MySqlConnection connection;
        private string server = "sql7.freemysqlhosting.net";
        private string database = "sql7368973";
        private string uid = "sql7368973";
        private string password = "1lFxsKtjXr";
        string connectionstring
        public Logout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add time in and time out of staff meber into worklog table with all informtion 
            DateTime logout = new DateTime();
            DateTime login = new DateTime();
            DateTime current = new DateTime();
            int staffID = 0;


            string query = "INSERT INTO Worklog (StaffID,TimeIN,TiemOUT,Date) VALUES ('" + staffID + "','" + login + "','" + logout + "','" + current + "')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();

            
            // close and go to log in form
            Login logForm = new Login();
                logForm.Show();
            this.Close();

        }

        private void Logout_Load(object sender, EventArgs e)
        {
            connectionstring = "SERVE=" + server + ";" + "DATABASE=" + database + ";" + "UID" + uid
                + ";" + "PASSWORD" + password + ";";
            connection = new MySqlConnection(connectionstring);
        }
    }
}
