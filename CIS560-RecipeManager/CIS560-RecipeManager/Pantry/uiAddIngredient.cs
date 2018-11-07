/*
 * uiAddIngredient.cs
 * Form to add a new ingredient to the database
 * 
 * Authors: Project Team 1 - CIS 560 KSU Fall 2018
 * edited by: David K. Hwang
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace CIS560_RecipeManager.Pantry
{
    public partial class uiAddIngredient : Form
    {
        private IQuery _queryRepository;
        private Query query; // temp query to check to see if data is actually being written/read


        public uiAddIngredient(IQuery queryArg)
        {
            InitializeComponent();
            _queryRepository = queryArg;
        }

        /// <summary>
        /// Click event for the "Add Ingredient" button on the Add Ingredient Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButton_AddIngredient_Click(object sender, EventArgs e)
        {
            try
            {
                Ingredient temp = query.AddIngredient(uxTextBox_IngredientName.Text, uxTextBox_UnitMeasurement.Text, (Convert.ToInt32(uxTextBox_PantryQuantity.Text)));
                MessageBox.Show("Successfully added " + uxTextBox_IngredientName.Text + " to Ingredients!");

                // update DataGridView in uiPantry to reflect changes
                uiPantry tempVar = (uiPantry)Application.OpenForms["uiPantry"]; // accesses the already open uiPantry Form
                tempVar.UpdateGridView(); // updates the DataGridView in that Form
                query.CloseConnection(); // then ends the transaction and closes the connection to the DB
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add ingredient to the database.\n" + "Error: " + ex.ToString());
            }
        }

        /// <summary>
        /// On Load, opens a new connection to the SQL server; Assumming this method of connection entry will be removed at a later date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiAddIngredient_Load(object sender, EventArgs e)
        {
            try
            {
                query = new Query();
                query.OpenConnection();
            }
            catch
            {
                MessageBox.Show("Could not establish connection to server. Please try again.");
                this.Close();
            }
        }
    }
}
