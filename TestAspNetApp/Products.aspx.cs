using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestAspNetApp
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //  Create a connection to the "pubs" database located 
            // on the local computer.

            var cs =
                WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

            SqlConnection myConnection = new SqlConnection(cs);
            // Connect to the SQL database using a SQL SELECT query to get 
            // all the data from the "Titles" table.
            SqlDataAdapter myCommand = 
                new SqlDataAdapter("SELECT * FROM Products", myConnection);
            // Create and fill a DataSet.
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            // Bind MyRepeater to the  DataSet. MyRepeater is the ID of the
            // Repeater control in the HTML section of the page.
            MyRepeater.DataSource = ds;
            MyRepeater.DataBind();
        }
    }
}