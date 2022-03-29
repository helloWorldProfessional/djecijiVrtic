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
    public partial class Zaposleni : Form
    {
        public Zaposleni()
        {
            InitializeComponent();
            kliknutiZaposleni = null;
        }
        Models.ZaposleniModel kliknutiZaposleni = new Models.ZaposleniModel();
        private void Izlistaj_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Servisi.GetZaposlene();
        }

        private void Zaposleni_Load(object sender, EventArgs e)
        {
            comboBoxRadnaPozicija.DataSource = Servisi.GetRadnePozicije();
            comboBoxRadnaPozicija.DisplayMember = "Radna_Pozicija";
            
        }

        private void PretraziRadnuPoziciju_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Servisi.GetZaposleneByRadnaPozicija(comboBoxRadnaPozicija.Text);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var kliknutiRed = dataGridView1.Rows[e.RowIndex];
            kliknutiZaposleni = (Models.ZaposleniModel)kliknutiRed.DataBoundItem;
            textBoxIme.Text = kliknutiZaposleni.Ime;
            textBoxPrezime.Text = kliknutiZaposleni.Prezime;
            textBoxImeRoditelja.Text = kliknutiZaposleni.Ime_Roditelja;
            dateTimePicker1.Value = kliknutiZaposleni.Datum_Rodjenja;
            textBoxJMBG.Text = kliknutiZaposleni.JMBG;
            textBoxKontakt.Text = kliknutiZaposleni.Kontakt;
            comboBoxRadnaPozicija.Text = kliknutiZaposleni.Radna_Pozicija;
        }

        private void Unesi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxIme.Text) || String.IsNullOrEmpty(textBoxPrezime.Text) || String.IsNullOrEmpty(textBoxImeRoditelja.Text) || String.IsNullOrEmpty(textBoxJMBG.Text) || String.IsNullOrEmpty(dateTimePicker1.Text)|| String.IsNullOrEmpty(textBoxKontakt.Text))
            {
                MessageBox.Show("Za unos u bazu potrebno je popuniti sva polja!");
                return;
            }
            if (kliknutiZaposleni != null)
            {
                DialogResult potvrda = MessageBox.Show("Da li želite ažurirati podatke za ID_Zaposleni=" + kliknutiZaposleni.ID_Zaposleni + "?", "Potvrdi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (potvrda == DialogResult.Yes)
                {
                    if (textBoxIme.Text != kliknutiZaposleni.Ime || textBoxPrezime.Text != kliknutiZaposleni.Prezime || textBoxImeRoditelja.Text != kliknutiZaposleni.Ime_Roditelja || textBoxJMBG.Text != kliknutiZaposleni.JMBG || textBoxKontakt.Text != kliknutiZaposleni.Kontakt|| dateTimePicker1.Value != kliknutiZaposleni.Datum_Rodjenja || comboBoxRadnaPozicija.Text!=kliknutiZaposleni.Radna_Pozicija)
                    {
                        Models.ZaposleniModel zaposleni = new Models.ZaposleniModel();
                        zaposleni.ID_Zaposleni = kliknutiZaposleni.ID_Zaposleni;
                        zaposleni.Ime = textBoxIme.Text;
                        zaposleni.Prezime = textBoxPrezime.Text;
                        zaposleni.Ime_Roditelja = textBoxImeRoditelja.Text;
                        zaposleni.Datum_Rodjenja = dateTimePicker1.Value;
                        zaposleni.JMBG = textBoxJMBG.Text;
                        zaposleni.Kontakt = textBoxKontakt.Text;
                        zaposleni.Radna_Pozicija = comboBoxRadnaPozicija.Text;
                        Servisi.UpdateZaposleni(zaposleni);
                    }

                }
                kliknutiZaposleni = null;

            }
            else
            {
                DialogResult potvrda = MessageBox.Show("Da li ste sigurni da želite unijeti podatke?", "Potvrdi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (potvrda == DialogResult.Yes)
                {
                    Models.ZaposleniModel zaposleni = new Models.ZaposleniModel();
                    zaposleni.Ime = textBoxIme.Text;
                    zaposleni.Prezime = textBoxPrezime.Text;
                    zaposleni.Ime_Roditelja = textBoxImeRoditelja.Text;
                    zaposleni.Datum_Rodjenja = dateTimePicker1.Value;
                    zaposleni.JMBG = textBoxJMBG.Text;
                    zaposleni.Kontakt = textBoxKontakt.Text;
                    zaposleni.Radna_Pozicija = comboBoxRadnaPozicija.Text;
                    Servisi.InsertZaposleni(zaposleni);
                }
            }
            dataGridView1.DataSource = Servisi.GetZaposlene();
        }

        private void Izbrisi_Click(object sender, EventArgs e)
        {
            if (kliknutiZaposleni != null)
            {
                DialogResult potvrda = MessageBox.Show("Da li ste sigurni da želite izbrisati podatke za ID_Zaposleni=" + kliknutiZaposleni.ID_Zaposleni+ "?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (potvrda == DialogResult.Yes)
                {
                    Servisi.DeleteZaposleniById(kliknutiZaposleni.ID_Zaposleni);
                    dataGridView1.DataSource = Servisi.GetZaposlene();
                }
            }
            else
                MessageBox.Show("Za brisanje je potrebno selektovati zaposlenog!");
            kliknutiZaposleni = null;
        }
    }
}
