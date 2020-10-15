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
    
    public partial class Stock : Form
    {
        private MySqlConnection connection;
        private string server = "sql7.freemysqlhosting.net";
        private string database = "sql7368973";
        private string uid = "sql7368973";
        private string password = "1lFxsKtjXr";
        string connectionstring;

        public Stock()
        {
            InitializeComponent();
        }

        public void CheckExpire()
        {
            string query = "SELECT * FROM STOCK ";
            DateTime warningDAte = new DateTime();
            DateTime currentDAte = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                if (DateTime.Parse(dataR["Expiration Date"]+"") > warningDAte)
                {
                    listBoxExpire.Items.Add(dataR["StockID"] + " " + dataR["Name"]+" Expires soon" );
                }
            }



            // close data reader
            dataR.Close();
            // close connection


        }

        public void InsertStock(string name , int cost,string expire,int quant )
        {
            // date added , get the current date 
            string date = "";
            
          string query= "INSERT INTO Stock (Name,Cost,Date Added,Expiration Date,Quintity) VALUES ('"+name+ "','" + cost + "','" + date + "','" + expire + "','" + quant + "')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();


        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string query = "UPDATE  Stock SET Name='"+textBoxUpName.Text+ "' ,Cost='" + int.Parse(textBoxUpCost.Text )+ "',Expriration Date='" + textBoxUpExpire.Text + "' , Quantity='" + int.Parse(textBoxUpQuant.Text) + "'  WHERE Name = '"+int.Parse(comboBoxStockID.SelectedItem.ToString())+"'";

            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string query = "Insert(textBoxName.Text, int.Parse(textBoxCost.Text), textBoxExpire.Text, int.Parse(textBoxQuant.Text))";

            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void Stock_Load(object sender, EventArgs e)
        {

            this.BackColor = System.Drawing.Color.SlateBlue;
            lblStockHeading.ForeColor = System.Drawing.Color.White;
            
            // ADD 
            
            lblAddCost.ForeColor = System.Drawing.Color.White;
            lblAddExpire.ForeColor = System.Drawing.Color.White;
            lblAddHeading.ForeColor = System.Drawing.Color.White;
            lblAddName.ForeColor = System.Drawing.Color.White;
            lblAddQuantity.ForeColor = System.Drawing.Color.White;

            btnConfirmAdd.ForeColor = System.Drawing.Color.White;

            btnConfirmAdd.BackColor = System.Drawing.Color.MidnightBlue;

            // LOW/EX
            lblExpireHeading.ForeColor = System.Drawing.Color.White;
            lblLowHeading.ForeColor = System.Drawing.Color.White;
            

            //Delete
            lblSubHeadingDelete.ForeColor = System.Drawing.Color.White;
            lblDeleteHeading.ForeColor = System.Drawing.Color.White;
            comboBoxDelete.ForeColor = System.Drawing.Color.White;
            btnConfirmDelete.ForeColor = System.Drawing.Color.White;

            btnConfirmDelete.BackColor = System.Drawing.Color.MidnightBlue;

            //update 
            lblStockID.ForeColor = System.Drawing.Color.White;
            lblCostUp.ForeColor = System.Drawing.Color.White;
            lblExpireUp.ForeColor = System.Drawing.Color.White;
            lblNameStockUp.ForeColor = System.Drawing.Color.White;
            lblUpdateHeading.ForeColor = System.Drawing.Color.White;
            lblQuantityUp.ForeColor = System.Drawing.Color.White;
            comboBoxStockID.ForeColor = System.Drawing.Color.White;
            btnConfirmUp.ForeColor = System.Drawing.Color.White;

            btnConfirmUp.BackColor = System.Drawing.Color.MidnightBlue;

            connectionstring = "SERVE=" + server + ";" + "DATABASE=" + database + ";" + "UID" + uid
                + ";" + "PASSWORD" + password + ";";
            connection = new MySqlConnection(connectionstring);


        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            int recipeID = 0;
            int stockID = 0;
            int recipeQuant = 0;
            int stockQuant = 0;
            string menuItem = "";

            // display stock in  list boxes 
            // query
            string expiredateMin = "";
            int minQaunt = 0;
            string query1 = "SELECT * FROM Stock WHERE Expriredate <'"+ expiredateMin+"'";
 
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query1, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                listBoxExpire.Items.Add(dataR["StockID"] + ""+dataR["Name"] + "" + dataR["Expiration Date"]);
            }



            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();

            connection.Open();
            //put in comand
            string query2 = "SELECT * FROM Menu Item ";

            cmd = new MySqlCommand(query2, connection);
            MySqlDataReader dataR2 = cmd.ExecuteReader();
            // data reader
            while (dataR2.Read())

            {
                menuItem = dataR2["Name"]+"";
                recipeID = int.Parse(dataR2["RecipeID"] + "");
                //open connection
                connection.Open();
                //put in comand
                query2 = "SELECT * FROM Recipe Stock link WHERE RecipeID ='"+recipeID+"' ";
                cmd = new MySqlCommand(query1, connection);
                MySqlDataReader dataR3 = cmd.ExecuteReader();
                // data reader
                while (dataR3.Read())
                {
                    stockID = int.Parse(dataR3["StockID"]+"");
                    recipeQuant = int.Parse(dataR["Quantity"]+"") * 5;
                    //open connection
                    connection.Open();
                    //put in comand
                    string query = "SELECT * FROM Stock WHERE StockID ='" + stockID + "' ";
                     cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataR4 = cmd.ExecuteReader();
                    // data reader
                    while (dataR4.Read())
                    {
                        stockQuant = int.Parse(dataR4["Quantity"]+"");

                        if (stockQuant<recipeQuant)
                        {
                            listBoxLow.Items.Add(stockID.ToString() + dataR["Name"] + " found in " + menuItem);
                        }
                    }
                }
            }


            listBoxLow.Items.Add(dataR["StockID"] + "" + dataR["Name"] + "" + dataR["Qauntity"]);
            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Stock ";
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                comboBoxDelete.Items.Add(dataR["StockID"] );
            }
            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int stockid = int.Parse(comboBoxDelete.SelectedItem.ToString());
            string query = "DELETE FROM Stock WHERE StockID ='"+stockid+"'";

            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void comboBoxDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stockid = int.Parse(comboBoxStockID.SelectedItem.ToString());
            string query = "SELECT * FROM Stock WHERE '"+stockid+"' ";
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                textBoxUpName.Text= dataR["Name"]+"";
                textBoxUpCost.Text = dataR["Cost"] + "";// must be string 
                textBoxUpExpire.Text = dataR["Expiration Date"] + "";
                textBoxUpQuant.Text = dataR["Quantity"] + "";
            }
            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Stock ";
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                comboBoxDelete.Items.Add(dataR["StockID"]);
            }
            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Logout logoutForm = new Logout();
            logoutForm.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Orders ordersform = new Orders();
            ordersform.ShowDialog();
            this.Close();
        }
    }
}
