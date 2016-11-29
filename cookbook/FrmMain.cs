using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace cookbook
{
    public partial class FrmMain : Form
    {
        SqlConnection connection;
        string connectionstring;
        
        public FrmMain()
        {
            InitializeComponent();

            connectionstring = ConfigurationManager.ConnectionStrings["cookbook.Properties.Settings.cookbookConnectionString"].ConnectionString;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            populaterecipes();
            populateallingredients();


        }

        private void populaterecipes()
        {
            using (connection = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, Id FROM Recipe", connection))
            {

                DataTable recipetable = new DataTable();
                adapter.Fill(recipetable);

                lstrecipes.DataSource = recipetable;
                lstrecipes.DisplayMember = "Name";
                lstrecipes.ValueMember = "Id";
            }
        }

        private void populateallingredients()
        {
            using (connection = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, Id FROM Ingredient", connection))
            {

                DataTable recipetable = new DataTable();
                adapter.Fill(recipetable);

                lstallingredients.DataSource = recipetable;
                lstallingredients.DisplayMember = "Name";
                lstallingredients.ValueMember = "Id";
            }
        }

        private void populateingredients()
        { 

            string query = "SELECT a.Name FROM Ingredient a " +
                "INNER JOIN recipeingredient b on a.Id = b.ingredientid " +
                "WHERE b.recipeid = @recipeid";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@recipeid", lstrecipes.SelectedValue);

                DataTable ingredientstable = new DataTable();
                adapter.Fill(ingredientstable);

                
                lstingredients.DisplayMember = "Name";
                lstingredients.ValueMember = "Id";
                lstingredients.DataSource = ingredientstable;
            }
        }
        
        private void lstrecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var test = lstrecipes.SelectedValue.ToString();
            if (test != "System.Data.DataRowView")
            {
                populateingredients();
            }

        }

        private void btnaddrecipe_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Recipe VALUES (@recipename, 80, 'catch')";
            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@recipename", txtrecipename.Text);

                command.ExecuteScalar();
            }
            populaterecipes();
        }

        private void btnupdaterecipename_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Recipe SET Name = @recipename Where Id = @recipeid";
            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@recipename", txtrecipename.Text);
                command.Parameters.AddWithValue("@recipeid", lstrecipes.SelectedValue);

                command.ExecuteScalar();
            }
            populaterecipes();
        }

        private void btnaddtorecipe_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO recipeingredient VALUES (@recipeid, @ingredientid)";
            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@recipeid", lstrecipes.SelectedValue);
                command.Parameters.AddWithValue("@ingredientid", lstallingredients.SelectedValue);

                command.ExecuteScalar();
            }
            populaterecipes();
        }
    }
}
