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
    public partial class Grupe : Form
    {
        public Grupe()
        {
            InitializeComponent();
            kliknutaGrupa= null;
        }
        Models.GrupeModel kliknutaGrupa = new Models.GrupeModel();
        
        
        private void Izlistaj_Click(object sender, EventArgs e)
        {
            dataGridViewGrupa.DataSource = Servisi.GetGrupe();
        }

        private void Unesi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxImeGrupe.Text) || String.IsNullOrEmpty(textBoxBrojPolaznika.Text) || String.IsNullOrEmpty(comboBoxVaspitaci.Text))
            {
                MessageBox.Show("Za unos u bazu potrebno je popuniti sva polja!");
                return;
            }            
            if (kliknutaGrupa!=null)
            {
                DialogResult potvrda = MessageBox.Show("Da li želite ažurirati podatke za ID_Grupa="+kliknutaGrupa.ID_Grupa+"?", "Potvrdi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (potvrda == DialogResult.Yes)
                {
                    if (textBoxImeGrupe.Text != kliknutaGrupa.Ime_Grupe || textBoxBrojPolaznika.Text != kliknutaGrupa.Broj_Polaznika.ToString() || comboBoxVaspitaci.SelectedValue.ToString() != kliknutaGrupa.ID_Zaposleni.ToString())
                    {
                        Models.GrupeModel grupeModel = new Models.GrupeModel();
                        grupeModel.ID_Grupa = kliknutaGrupa.ID_Grupa;
                        grupeModel.Ime_Grupe = textBoxImeGrupe.Text;
                        grupeModel.Broj_Polaznika = Convert.ToInt32(textBoxBrojPolaznika.Text);
                        grupeModel.ID_Zaposleni = Convert.ToInt32(comboBoxVaspitaci.SelectedValue.ToString());
                        Servisi.UpdateGrupe(grupeModel);
                    }
                    
                }
                kliknutaGrupa = null;
                
            }
            else
            {
                DialogResult potvrda = MessageBox.Show("Da li ste sigurni da želite unijeti podatke?", "Potvrdi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (potvrda == DialogResult.Yes)
                {
                    Models.GrupeModel grupeModel = new Models.GrupeModel();
                    grupeModel.Ime_Grupe = textBoxImeGrupe.Text;
                    grupeModel.Broj_Polaznika = Convert.ToInt32(textBoxBrojPolaznika.Text);
                    grupeModel.ID_Zaposleni = Convert.ToInt32(comboBoxVaspitaci.SelectedValue.ToString());
                    Servisi.InsertGrupe(grupeModel);
                }
            }
            dataGridViewGrupa.DataSource = Servisi.GetGrupe();

        }
        
        private void dataGridViewGrupa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var kliknutiRed = dataGridViewGrupa.Rows[e.RowIndex];
            kliknutaGrupa = (Models.GrupeModel)kliknutiRed.DataBoundItem;
            textBoxImeGrupe.Text = kliknutaGrupa.Ime_Grupe;
            textBoxBrojPolaznika.Text = Convert.ToString(kliknutaGrupa.Broj_Polaznika);
            comboBoxVaspitaci.SelectedValue = kliknutaGrupa.ID_Zaposleni;
            
        }


        private void Izbrisi_Click(object sender, EventArgs e)
        {
            if (kliknutaGrupa.ID_Grupa != -1)
            {
                DialogResult potvrda = MessageBox.Show("Da li ste sigurni da želite izbrisati podatke za ID_Grupa=" + kliknutaGrupa.ID_Grupa + "?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (potvrda == DialogResult.Yes)
                {
                    Servisi.DeleteGrupeById(kliknutaGrupa.ID_Grupa);
                    dataGridViewGrupa.DataSource = Servisi.GetGrupe();
                }
            }
            else
                MessageBox.Show("Za brisanje je potrebno selektovati grupu!");
            kliknutaGrupa = null;
            
        }

        private void Grupe_Load(object sender, EventArgs e)
        {
            comboBoxVaspitaci.DataSource = Servisi.GetVaspitace();
            comboBoxVaspitaci.DisplayMember = "Punoime";
            comboBoxVaspitaci.ValueMember = "ID_Zaposleni";
        }

        private void Pretrazi_Click(object sender, EventArgs e)
        {
            dataGridViewGrupa.DataSource = Servisi.GetGrupeByIdVaspitac(Convert.ToInt32(comboBoxVaspitaci.SelectedValue.ToString()));
        }
    }
}
