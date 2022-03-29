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
    public partial class PolaznikModel : Form
    {
        public PolaznikModel()
        {
            InitializeComponent();
            kliknutiPolaznik = null;
        }
        Models.PolaznikModel kliknutiPolaznik = new Models.PolaznikModel();
        private void Izlistaj_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Servisi.GetPolaznike();  
        }
        
        private void Unesi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxIme.Text) || String.IsNullOrEmpty(textBoxPrezime.Text) || String.IsNullOrEmpty(textBoxImeRoditelja.Text) || String.IsNullOrEmpty(textBoxJMBG.Text) || String.IsNullOrEmpty(textBoxKontakt.Text) || String.IsNullOrEmpty(comboBoxGrupe.Text) || String.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("Za unos u bazu potrebno je popuniti sva polja!");
                return;
            }
            if (kliknutiPolaznik != null)
            {
                DialogResult potvrda = MessageBox.Show("Da li želite ažurirati podatke za ID_Polaznika=" + kliknutiPolaznik.ID_Polaznik + "?", "Potvrdi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (potvrda == DialogResult.Yes)
                {
                    if (textBoxIme.Text != kliknutiPolaznik.Ime || textBoxPrezime.Text != kliknutiPolaznik.Prezime || textBoxImeRoditelja.Text != kliknutiPolaznik.Ime_Roditelja || textBoxJMBG.Text != kliknutiPolaznik.JMBG || textBoxKontakt.Text != kliknutiPolaznik.Kontakt || comboBoxGrupe.SelectedValue.ToString() != kliknutiPolaznik.ID_Grupa.ToString() || dateTimePicker1.Value != kliknutiPolaznik.Datum_Rodjenja)
                    {
                        Models.PolaznikModel polaznik = new Models.PolaznikModel();
                        polaznik.ID_Polaznik = kliknutiPolaznik.ID_Polaznik;
                        polaznik.ID_Grupa = Convert.ToInt32(comboBoxGrupe.SelectedValue.ToString());
                        polaznik.Ime = textBoxIme.Text;
                        polaznik.Prezime = textBoxPrezime.Text;
                        polaznik.Ime_Roditelja = textBoxImeRoditelja.Text;
                        polaznik.Datum_Rodjenja = dateTimePicker1.Value;
                        polaznik.JMBG = textBoxJMBG.Text;
                        polaznik.Kontakt = textBoxKontakt.Text;
                        polaznik.Pol = comboBoxPol.Text;
                        if(comboBoxGrupe.SelectedValue.ToString() != kliknutiPolaznik.ID_Grupa.ToString())
                        {
                            Servisi.SmanjiBrPolaznika(kliknutiPolaznik.ID_Grupa);
                            Servisi.PovecajBrPolaznika(Convert.ToInt32(comboBoxGrupe.SelectedValue.ToString()));
                        }
                        Servisi.UpdatePolaznik(polaznik);
                    }

                }
                kliknutiPolaznik = null;

            }
            else
            {
                DialogResult potvrda = MessageBox.Show("Da li ste sigurni da želite unijeti podatke?", "Potvrdi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (potvrda == DialogResult.Yes)
                {
                    Models.PolaznikModel polaznik = new Models.PolaznikModel();
                    polaznik.ID_Grupa = Convert.ToInt32(comboBoxGrupe.SelectedValue.ToString());
                    polaznik.Ime = textBoxIme.Text;
                    polaznik.Prezime = textBoxPrezime.Text;
                    polaznik.Ime_Roditelja = textBoxImeRoditelja.Text;
                    polaznik.Datum_Rodjenja = dateTimePicker1.Value;
                    polaznik.JMBG = textBoxJMBG.Text;
                    polaznik.Kontakt = textBoxKontakt.Text;
                    polaznik.Pol = comboBoxPol.Text;
                    Servisi.InsertPolaznik(polaznik);
                    Servisi.PovecajBrPolaznika(polaznik.ID_Grupa);
                }
            }
            dataGridView1.DataSource = Servisi.GetPolaznike();
        }

        private void PretraziPolaznikePoGrupi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Servisi.GetPolaznikeByIDGrupe(Convert.ToInt32(comboBoxGrupe.SelectedValue.ToString()));
        }

        private void PolaznikModel_Load(object sender, EventArgs e)
        {
            comboBoxGrupe.DataSource = Servisi.GetGrupe();
            comboBoxGrupe.DisplayMember = "Ime_Grupe";
            comboBoxGrupe.ValueMember = "ID_Grupa";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var kliknutiRed = dataGridView1.Rows[e.RowIndex];
            kliknutiPolaznik = (Models.PolaznikModel)kliknutiRed.DataBoundItem;
            textBoxIme.Text=kliknutiPolaznik.Ime;
            textBoxPrezime.Text=kliknutiPolaznik.Prezime;
            textBoxImeRoditelja.Text=kliknutiPolaznik.Ime_Roditelja;
            dateTimePicker1.Value=kliknutiPolaznik.Datum_Rodjenja;
            textBoxJMBG.Text=kliknutiPolaznik.JMBG;
            textBoxKontakt.Text=kliknutiPolaznik.Kontakt;
            comboBoxPol.Text=kliknutiPolaznik.Pol;
            comboBoxGrupe.SelectedValue = kliknutiPolaznik.ID_Grupa;
            
        }

        private void Izbrisi_Click(object sender, EventArgs e)
        {
            if (kliknutiPolaznik != null)
            {
                DialogResult potvrda = MessageBox.Show("Da li ste sigurni da želite izbrisati podatke za ID_Polaznik=" + kliknutiPolaznik.ID_Polaznik+ "?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (potvrda == DialogResult.Yes)
                {
                    Servisi.DeletePolaznikById(kliknutiPolaznik.ID_Polaznik);
                    Servisi.SmanjiBrPolaznika(kliknutiPolaznik.ID_Grupa);
                    dataGridView1.DataSource = Servisi.GetPolaznike();
                }
            }
            else
                MessageBox.Show("Za brisanje je potrebno selektovati zaposlenog!");
            kliknutiPolaznik = null;
        }
    }
}
