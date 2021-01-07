using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Priceredacted.Interfaces;

namespace Priceredacted.Processors
{
    class SQLdb : IDatabase
    {
       // SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mantas\source\repos\Mantas-Meow\Priceredacted\Priceredacted\DB\Items.mdf");


        void IDatabase.addData()
        {
           /* try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("AddData", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@add", "Add");
                sqlCmd.Parameters.AddWithValue("@id", 0);
                sqlCmd.Parameters.AddWithValue("@Product", ProductName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Price", Price.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Data saved");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                sqlCon.Close();
            }*/
        }
        
        void IDatabase.getData()
        {
            /*try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }*/
        }

        /*void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Search", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Product", SearchBox.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            SearchResults.DataSource = dtbl;
            sqlCon.Close();
        }*/


    }
}
