using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Djeciji_vrtic
{
    public partial class Uplate : Form
    {
        public Uplate()
        {
            InitializeComponent();
            kliknutaUplata = null;
        }
        Models.UplateModel kliknutaUplata = new Models.UplateModel();

        private void Izlistaj_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Servisi.GetUplate();
        }
        
        private void Uplate_Load(object sender, EventArgs e)
        {
            comboBoxPolaznik.DataSource = Servisi.GetPolaznike();
            comboBoxPolaznik.DisplayMember = "Punoime";
            comboBoxPolaznik.ValueMember = "ID_Polaznik";
            
        }
        /////// provjeri sta je pisac htio reci
        private void comboBoxPolaznik_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Servisi.GetUplateById(Convert.ToInt32(comboBoxPolaznik.SelectedValue.ToString()));
            textBoxIznos.Text = "";
            dateTimePickerUplate.Value = DateTime.UtcNow;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var kliknutiRed = dataGridView1.Rows[e.RowIndex];
            kliknutaUplata = (Models.UplateModel)kliknutiRed.DataBoundItem;
            comboBoxPolaznik.SelectedValue = kliknutaUplata.ID_Polaznik;
            textBoxIznos.Text = kliknutaUplata.Iznos.ToString();
            dateTimePickerUplate.Value = kliknutaUplata.Datum_Uplate;
            
        }

        private void ObrisiUplatu_Click(object sender, EventArgs e)
        {
            if (kliknutaUplata!= null)
            {
                DialogResult potvrda = MessageBox.Show("Da li ste sigurni da želite izbrisati podatke za ID_Uplata=" + kliknutaUplata.ID_Uplata + "?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (potvrda == DialogResult.Yes)
                {
                    Servisi.DeleteUplataById(kliknutaUplata.ID_Uplata);
                    dataGridView1.DataSource = Servisi.GetUplate();
                }
            }
            else
                MessageBox.Show("Za brisanje je potrebno selektovati uplatu!");
            kliknutaUplata = null;
        }

        private void Unos_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxIznos.Text) || String.IsNullOrEmpty(comboBoxPolaznik.Text) || String.IsNullOrEmpty(dateTimePickerUplate.Text))
            {
                MessageBox.Show("Za unos u bazu potrebno je popuniti sva polja!");
                return;
            }
            if (kliknutaUplata != null)
            {
                DialogResult potvrda = MessageBox.Show("Da li želite ažurirati podatke za ID_Uplata=" + kliknutaUplata.ID_Uplata + "?", "Potvrdi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (potvrda == DialogResult.Yes)
                {
                    if (textBoxIznos.Text != kliknutaUplata.Iznos.ToString() || comboBoxPolaznik.SelectedValue.ToString() != kliknutaUplata.ID_Polaznik.ToString() || dateTimePickerUplate.Value!=kliknutaUplata.Datum_Uplate)
                    {
                        Models.UplateModel uplate = new Models.UplateModel();
                        uplate.ID_Uplata = kliknutaUplata.ID_Uplata;
                        uplate.ID_Polaznik = Convert.ToInt32(comboBoxPolaznik.SelectedValue.ToString());
                        uplate.Iznos = Convert.ToInt32(textBoxIznos.Text);
                        uplate.Datum_Uplate = dateTimePickerUplate.Value;
                        Servisi.UpdateUplate(uplate);
                    }

                }
                kliknutaUplata = null;

            }
            else
            {
                DialogResult potvrda = MessageBox.Show("Da li ste sigurni da želite unijeti podatke?", "Potvrdi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (potvrda == DialogResult.Yes)
                {
                    Models.UplateModel uplate = new Models.UplateModel();
                    uplate.ID_Polaznik = Convert.ToInt32(comboBoxPolaznik.SelectedValue.ToString());
                    uplate.Iznos = Convert.ToInt32(textBoxIznos.Text);
                    uplate.Datum_Uplate = dateTimePickerUplate.Value;
                    Servisi.InsertUplate(uplate);
                }
            }
            dataGridView1.DataSource = Servisi.GetUplate();

        }
    }
}
