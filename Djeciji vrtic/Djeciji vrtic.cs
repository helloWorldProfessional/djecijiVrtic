using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Djeciji_vrtic.Models;

namespace Djeciji_vrtic
{
    
    public partial class Djeciji_vrtic : Form
    {
        string conn = "Server=DESKTOP-0IO9IPQ; Database=Vrtic; Integrated Security=true";
        private Form trenutnoOtvorenaForma;
        
        public Djeciji_vrtic()
        {
            InitializeComponent();
        }

        private void MetodaZaOtvaranje(Form Form)
        {
            if(trenutnoOtvorenaForma!=null)
            {
                if (trenutnoOtvorenaForma.Name == Form.Name)
                    return;
                trenutnoOtvorenaForma.Close();
            }
            trenutnoOtvorenaForma = Form;
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            ChildForm.Controls.Add(Form);
            ChildForm.Tag = Form;
            Form.BringToFront();
            Form.Show();
           
            
        }
        private void Polaznici_Click(object sender, EventArgs e)
        {
            MetodaZaOtvaranje(new PolaznikModel());
            
        }

        private void Zaposleni_Click(object sender, EventArgs e)
        {
            MetodaZaOtvaranje(new Zaposleni());
        }

        private void Grupe_Click(object sender, EventArgs e)
        {
            MetodaZaOtvaranje(new Grupe());
        }

        private void Uplate_Click(object sender, EventArgs e)
        {
            MetodaZaOtvaranje(new Uplate());
           
        }
        //public string upit { get; set; }


        // metoda za popunjavanje datagridview

        public void popuniDataGridView(string upit, DataGridView dataGridView)
        {


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
