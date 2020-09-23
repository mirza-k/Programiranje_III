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
    public partial class Registracija : Form
    {
        Student studentTemp = null;
        public Registracija()
        {
            InitializeComponent();
            UcitajSpolove();
        }

        private void UcitajSpolove()
        {
            try
            {
                cmbSpol.DataSource = DLWMS.Bazza.Spolovi.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException?.Message);
            }
        }

        public Registracija(Student ss):this()
        {
            studentTemp = ss;
            txtBrojIndeksa.Text = studentTemp.BrojIndeksa;
            txtIme.Text = studentTemp.Ime;
            txtPrezime.Text = studentTemp.Prezime;
            cmbSpol.SelectedItem = cmbSpol.SelectedItem as Spol;
            pbSlika.Image = ImageHelper.FromByteToImage(studentTemp.Slika);
        }
        private void Registracija_Load(object sender, EventArgs e)
        {
            if(studentTemp==null)
                UcitajIndeks();
        }

        private void UcitajIndeks()
        {
            int pocetniIndeks = 190001;
            if (DLWMS.Bazza.Studenti.Count() == 0)
            {
                txtBrojIndeksa.Text = "IB" + pocetniIndeks;
                return;
            }
            string brojZadnjeg = DLWMS.Bazza.Studenti.ToList()[DLWMS.Bazza.Studenti.Count() - 1].BrojIndeksa.Substring(2);
            int broj = int.Parse(brojZadnjeg);
            txtBrojIndeksa.Text = "IB" + (++broj);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            try
            {
                if(ofdSlika.ShowDialog() == DialogResult.OK)
                {
                    string putanja = ofdSlika.FileName;
                    pbSlika.Image = Image.FromFile(putanja);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ex.InnerException?.Message);
            }
        }
        bool ValidirajTxt(TextBox tekst)
        {
            if(string.IsNullOrEmpty(tekst.Text))
            {
                err.SetError(tekst, "Prazno polje.");
                return false;
            }
            else
            {
                err.Clear();
                return true;
            }
        }
        bool ValidirajCmb(ComboBox cmb)
        {
            if (cmb.SelectedIndex == -1)
            {
                err.SetError(cmb,"Nedozvoljena vrijednost.");
                return false;
            }
            else
            {
                err.Clear();
                return true;
            }
        }
        bool ValidirajPb(PictureBox slika)
        {
            if (slika.Image == null)
            {
                err.SetError(slika, "Slika je null.");
                return false;
            }
            else
            {
                err.Clear();
                return true;
            }
        }
        bool Validacija()
        {
            if (ValidirajTxt(txtBrojIndeksa) && ValidirajTxt(txtIme) && ValidirajTxt(txtPrezime) &&
                ValidirajCmb(cmbSpol) && ValidirajPb(pbSlika))
                return true;
            return false;
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    if(studentTemp == null)
                    {
                        Student s = new Student();
                        UcitajPodatkeStudentu(s);
                        DLWMS.Bazza.Studenti.Add(s);
                        DLWMS.Bazza.SaveChanges();
                    }
                    else
                    {
                        UcitajPodatkeStudentu(studentTemp);
                        DLWMS.Bazza.Entry(studentTemp).State = System.Data.Entity.EntityState.Modified;
                        DLWMS.Bazza.SaveChanges();
                    }
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ ex.InnerException?.Message);
            }
        }

        private void UcitajPodatkeStudentu(Student student)
        {
            student.Ime = txtIme.Text;
            student.Prezime = txtPrezime.Text;
            student.BrojIndeksa = txtBrojIndeksa.Text;
            student.Spol = cmbSpol.SelectedItem as Spol;
            student.Slika = ImageHelper.FromImageToByte(pbSlika.Image);
        }
    }
}
