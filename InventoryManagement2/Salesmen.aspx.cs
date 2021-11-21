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
    public partial class Salesmen : System.Web.UI.Page
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
            int salesmanId = Convert.ToInt32(txtID.Text);
            string name = txtSalesmanName.Text;
            string city = txtCity.Text;
            float commission = float.Parse(txtCommission.Text);

            string query = $"INSERT INTO Salesman (Salesman_id,Name,City,Commission) VALUES ({salesmanId},'{name}','{city}',{commission});";


            SqlConnection connection = new SqlConnection(_connectionString);

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable DT = new DataTable();
                adapter.Fill(DT);

                BindGridView();

                txtSalesmanName.Text = "";
                txtID.Text = "";
                txtCommission.Text = "";
                txtCity.Text = "";
                txtID.Focus();

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
                string query = "select * from salesman";
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(DT);

                if (DT.Rows.Count > 0)
                {
                    GVSalesman.DataSource = DT;
                    GVSalesman.DataBind();
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