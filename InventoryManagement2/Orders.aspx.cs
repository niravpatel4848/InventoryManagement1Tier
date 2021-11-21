using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagement2
{
    public partial class Orders : System.Web.UI.Page
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGridView();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int orderNum = Convert.ToInt32(orderNo.Text);
            float amount = float.Parse(purchaseAmount.Text);
            string date = orderDate.Text;
            int custId = Convert.ToInt32(customerID.Text);
            int Salesmanid = Convert.ToInt32(salesmanID.Text);

            string query = $"INSERT INTO Orders (Order_no, Purch_amt, Ord_date, Customer_id, Salesman_id) " +
                $"VALUES " + $"({orderNum},'{amount}','{date}',{custId},{Salesmanid});";


            SqlConnection connection = new SqlConnection(_connectionString);

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable DT = new DataTable();
                adapter.Fill(DT);

                BindGridView();

                orderNo.Text = "";
                purchaseAmount.Text = "";
                orderDate.Text = "";
                customerID.Text = "";
                salesmanID.Text = "";
                orderNo.Focus();

            }
            catch (SqlException ex)
            {
                string msg = "Error: ";
                msg += ex.Message;
                throw new Exception(msg);
            }
            finally
            {
                connection.Close();
            }

        }
        private void BindGridView()
        {
            DataTable DT = new DataTable();
            SqlConnection connection = new SqlConnection(_connectionString);

            try
            {
                connection.Open();
                string query = "select * from Orders";
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(DT);

                if (DT.Rows.Count > 0)
                {
                    GVOrders.DataSource = DT;
                    GVOrders.DataBind();
                }
            }
            catch (SqlException ex)
            {
                string msg = "Error: ";
                msg += ex.Message;
                throw new Exception(msg);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}