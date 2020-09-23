using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Februarski_3
{
    public partial class PrikazPredmeta : Form
    {
        Student s;
        public PrikazPredmeta()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
            UcitajSvePredmete();
            UcitajOcjene();
        }

        private void UcitajOcjene()
        {
            List<int> tempOcjene = new List<int>();
            tempOcjene.Add(6);
            tempOcjene.Add(7);
            tempOcjene.Add(8);
            tempOcjene.Add(9);
            tempOcjene.Add(10);
            cmbOcjena.DataSource = tempOcjene;
        }

        private void UcitajSvePredmete()
        {
            try
            {
                cmbPredmeti.DataSource = null;
                cmbPredmeti.DataSource = DLWMS.Bazza.Predmeti.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException?.Message);
            }
        }

        public PrikazPredmeta(Student st):this()
        {
            s = st;
        }
        private void PrikazPredmeta_Load(object sender, EventArgs e)
        {
            UcitajPolozene();
        }

        private void UcitajPolozene()
        {
            try
            {
                dgvPolozeniPredmeti.DataSource = null;
                dgvPolozeniPredmeti.DataSource = s.Uspjeh;
                lblProsjekPredmeta.Text = "Prosjek je: " + s.IzracunajProsjek();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException?.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                int ocjena = int.Parse(cmbOcjena.SelectedItem.ToString());
                Predmet p = cmbPredmeti.SelectedItem as Predmet;
                string datum = dateTimePolaganje.Value.ToShortDateString();
                if(!s.JelPolozen(p))
                {
                    StudentPredmet sp = new StudentPredmet();
                    sp.Ocjena = ocjena;
                    sp.Datum = datum;
                    sp.Predmet = p;
                    s.Uspjeh.Add(sp);
                    DLWMS.Bazza.SaveChanges();
                    MessageBox.Show("Uspjesno dodan.");
                    chbPolozeni.Checked = false;
                    UcitajPolozene();
                }
                else
                    MessageBox.Show("Vec polozen.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException?.Message);
            }
        }
        
        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            Izvjestaj izv = new Izvjestaj(s);
            izv.ShowDialog();
        }

        void Dodaj100Predmeta(Predmet p, int ocj, string datum)
        {
            for (int i = 0; i < 500; i++)
            {
                StudentPredmet sp = new StudentPredmet();
                sp.Predmet = p;
                sp.Ocjena = ocj;
                sp.Datum = datum;
                s.Uspjeh.Add(sp);
            }
            DLWMS.Bazza.SaveChanges();
        }
        async void AsinhronoDodavanje(Predmet p, int ocjena, string d)
        {
            await Task.Run(() =>
            {
                Dodaj100Predmeta(p, ocjena, d);
            });
                MessageBox.Show("Uspjesno dodano 100 predmeta");
                UcitajPolozene();
        }
        void AsinhroniProsjek()
        {
            float prosjek = 0;
            var kon=Task.Run(()=>
            {
                prosjek = s.IzracunajProsjek();
            });
            var cek = kon.GetAwaiter();
            cek.OnCompleted(() =>
            {
                MessageBox.Show("Prosjek je: "+prosjek);
            });
        }
        private void btnAsync_Click(object sender, EventArgs e)
        {
            Predmet p = cmbPredmeti.SelectedItem as Predmet;
            int ocjena = int.Parse(cmbOcjena.SelectedItem.ToString());
            string d = dateTimePolaganje.Value.ToShortDateString();
            AsinhronoDodavanje(p, ocjena, d);
            //AsinhroniProsjek();
        }

        private void chbPolozeni_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPolozeni.Checked == false)
                UcitajSvePredmete();
            else
                UcitajNepolozene();
        }

        private void UcitajNepolozene()
        {
            List<Predmet> SviPredmeti = DLWMS.Bazza.Predmeti.ToList();
            List<Predmet> Nepolozeni = new List<Predmet>();
            for (int i = 0; i < SviPredmeti.Count(); i++)
            {
                if (!s.JelPolozen(SviPredmeti[i]))
                    Nepolozeni.Add(SviPredmeti[i]);
            }
            cmbPredmeti.DataSource = null;
            cmbPredmeti.DataSource = Nepolozeni;
        }
    }
}
