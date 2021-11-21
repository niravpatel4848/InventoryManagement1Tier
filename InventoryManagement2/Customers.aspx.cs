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
    public partial class Customers : System.Web.UI.Page
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                BindGridView();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int custId = Convert.ToInt32(customerID.Text);
            string name = firstName.Text + " " + lastName.Text;
            string custCity = city.Text;
            int custGrade = Convert.ToInt32(grade.Text);
            int saleId = Convert.ToInt32(salesmanID.Text);

            string query = $"INSERT INTO Customer (Customer_id, Cust_name, City, grade, Salesman_id)" +
                $"VALUES ({custId},'{name}','{custCity}',{custGrade},{saleId})";

            SqlConnection connection = new SqlConnection(_connectionString);

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable DT = new DataTable();
                adapter.Fill(DT);

                BindGridView();

                customerID.Text = "";
                firstName.Text = "";
                lastName.Text = "";
                city.Text = "";
                grade.Text = "";
                salesmanID.Text = "";
                customerID.Focus();

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
                string query = "select * from Customer";
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(DT);

                if (DT.Rows.Count > 0)
                {
                    GVCustomers.DataSource = DT;
                    GVCustomers.DataBind();
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