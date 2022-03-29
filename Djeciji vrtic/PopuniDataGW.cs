using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Djeciji_vrtic
{
    public static class PopuniDataGW
    {
        
        public static void popuniDataGridView(string upit, DataGridView dataGridView)
        {

            string conn = "Server=LAPTOP-P6B79F54; Database=Vrtic; Integrated Security=true";
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                SqlCommand command = new SqlCommand(upit, sqlConnection);
                sqlConnection.Open();
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
                sqlConnection.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }


        }
    }
}
