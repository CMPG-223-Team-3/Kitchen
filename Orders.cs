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
    public partial class Orders : Form
    {

        private MySqlConnection connection;
        private string server = "sql7.freemysqlhosting.net";
        private string database = "sql7368973";
        private string uid = "sql7368973";
        private string password = "1lFxsKtjXr";
        string connectionstring;

        public Orders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int menuID=0;
            int recipeID = 0;
            int stockID =0;
            

            // make stock less 
            string query = "SELECT * FROM ORDERS WHERE OrderID ='" + checkedListBoxOrders.CheckedItems.ToString() + "'";

            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                menuID = int.Parse(dataR["Menu Item ID"]+"");
            }
            

            query = "SELECT * FROM  Menu Item  WHERE Menu Item ID ='" + menuID + "'";
            cmd = new MySqlCommand(query, connection);
            dataR = cmd.ExecuteReader();
            while (dataR.Read())
            {
                recipeID = int.Parse(dataR["RecipeID"]+"");
            }


            query = "SELECT * FROM  Recipe Stock link  WHERE RecipeID ='" + recipeID + "'";
            cmd = new MySqlCommand(query, connection);
            dataR = cmd.ExecuteReader();
            while (dataR.Read())
            {
                    stockID = int.Parse(dataR["StockID"]+"");
                    query = "DELETE FROM Stock WHERE StockID ='" + stockID + "'";
                    connection.Open();
                     cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();

                

            }

           

            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();




            //comfirms order is done 
            // update ready status 
            query = "UPDATE  Orders SET Ready='true' WHERE  OrderID ='"+ checkedListBoxOrders.CheckedItems.ToString() + "'";

            connection.Open();
            cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();


            // when order is checked it must be deleted from the list 



            checkedListBoxOrders.Items.Clear();
            listBoxOrders.Items.Clear();
            // load again to get rid of ready orders on checkboxs list 
            loadOrders();

        }

        private void loadOrders()
        {
            int menuID = 0;
            int recipeID = 0;
            // display orders iDs  in checkbox list 
            bool ready = false;
            string query = "SELECT * FROM ORDERS WHERE READY ='"+ready+"'";
            
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {

                checkedListBoxOrders.Items.Add(dataR["OrderID"] + "" ,false);
                // display orders with menue item name 
                int orderID = int.Parse(dataR["OrderID"]+"");

                query = "SELECT * FROM Order Menu Item link WHERE Order ID ='" + orderID+ "'";
                cmd = new MySqlCommand(query, connection);
                dataR = cmd.ExecuteReader();
                while (dataR.Read())
                {
                     menuID = int.Parse(dataR["Menu Item ID"]+"");
                }
               

                 query = "SELECT * FROM  Menu Item  WHERE Menu Item ID ='" + menuID + "'";
                cmd = new MySqlCommand(query, connection);
                dataR = cmd.ExecuteReader();
                while (dataR.Read())
                {
                    recipeID = int.Parse(dataR["RecipeID"]+"");
                    listBoxOrders.Items.Add(orderID.ToString() + " " + dataR["Name"] + ", " + recipeID.ToString());
                }
                


            }

            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();

            
        }
        
        private void Orders_Load(object sender, EventArgs e)
        {
            checkedListBoxOrders.BackColor = System.Drawing.Color.SlateBlue;
            listBoxOrders.BackColor = System.Drawing.Color.SlateBlue;
            this.BackColor = System.Drawing.Color.SlateBlue;

            lblConfirm.ForeColor = System.Drawing.Color.White;
            lblHeading.ForeColor = System.Drawing.Color.White;

            checkedListBoxOrders.ForeColor = System.Drawing.Color.White;
            listBoxOrders.ForeColor = System.Drawing.Color.White;

            btnConfirm.ForeColor = System.Drawing.Color.White;

            btnConfirm.BackColor = System.Drawing.Color.MidnightBlue;




            connectionstring = "SERVE="+server+";"+"DATABASE="+database+";"+"UID"+uid
                +";"+"PASSWORD"+password+";";
            connection = new MySqlConnection(connectionstring);
            loadOrders();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comfrim it is done 
            // multible can be selected before confriming 
            // make lable and button visible 

            lblConfirm.Visible = true;
            btnConfirm.Visible = true;
            lblConfirm.Text = " Confirm below that these orders are complete";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Logout logoutForm = new Logout();
            logoutForm.ShowDialog();
            this.Close();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Stock stockform = new Stock();
            stockform.ShowDialog();
            this.Close();
        }
    }
}
