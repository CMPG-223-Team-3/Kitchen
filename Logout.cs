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
        private string server = "cmpg-223-db.ci6pbvbzz3x3.us-west-1.rds.amazonaws.comsql7.freemysqlhosting.net";
        private string database = "admin";
        private string uid = "admin";
        private string password = "cmpg22310";
        string connectionstring;
        public Logout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "";
            Login loginForm = new Login();
            username = loginForm.username;

            // get staff ID
            int staffID = 0;

            string query = "SELECT * FROM Staff WHERE Username ='"+username+"' ";
            
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                staffID = int.Parse(dataR["StaffID"] + "");
            }

            // add time in and time out of staff meber into worklog table with all informtion 
            DateTime logout = new DateTime();
            DateTime login = new DateTime();
            DateTime current = new DateTime();
            


            query = "INSERT INTO Worklog (StaffID,TimeIN,TiemOUT,Date) VALUES ('" + staffID + "','" + login + "','" + logout + "','" + current + "')";
            connection.Open();
            cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();

            
            // close and go to log in form
            Login logForm = new Login();
                logForm.Show();
            this.Close();

        }

        private void Logout_Load(object sender, EventArgs e)
        {
            
            lblHeading.ForeColor = System.Drawing.Color.White;
            lblIN.ForeColor = System.Drawing.Color.White;
            lblOUT.ForeColor = System.Drawing.Color.White;
            this.BackColor = System.Drawing.Color.SlateBlue;

            btnLogout.ForeColor = System.Drawing.Color.White;

            btnLogout.BackColor = System.Drawing.Color.MidnightBlue;



            connection = new MySqlConnection("SERVER=cmpg-223-db.ci6pbvbzz3x3.us-west-1.rds.amazonaws.com;DATABASE=sql17368973;UID=admin;PASSWORD=cmpg22310;");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Orders ordersform = new Orders();
            ordersform.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stock stockform = new Stock();
            stockform.ShowDialog();
            this.Close();
        }
    }
}
