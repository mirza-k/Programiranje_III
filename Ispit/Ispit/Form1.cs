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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UcitajSveStudente();
        }

        private void UcitajSveStudente(List<Student> temp = null)
        {
            dgvStudenti.DataSource = null;
            if (temp == null)
            {
                dgvStudenti.DataSource = DLWMS.Bazza.Studenti.ToList();
                UcitajProsjekStudenata();
                UcitajBrojStudenata();
            }
            else
            {
                dgvStudenti.DataSource = temp;
                UcitajProsjekStudenata(temp);
                UcitajBrojStudenata(temp);
            }
        }

        private void UcitajProsjekStudenata(List<Student> temp = null)
        {
            if (temp == null)
                temp = DLWMS.Bazza.Studenti.ToList();
            float pr = 0;
            for (int i = 0; i < temp.Count(); i++)
            {
                pr += temp[i].IzracunajProsjek();
            }
            if (pr == 0)
                lblProsjekSvih.Text = "Prosjek je: " + 0;
            else
                lblProsjekSvih.Text = "Prosjek je: " + pr/temp.Count();
        }

        private void UcitajBrojStudenata(List<Student> temp = null)
        {
            if(temp == null)
                lblBrojStudenata.Text = "Trenutno je: " + DLWMS.Bazza.Studenti.Count().ToString() + " studenata." ;
            else
                lblBrojStudenata.Text = "Trenutno je: " + temp.Count().ToString() + " studenata.";
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            string vrijednost = txtPretraga.Text.ToLower();
            List<Student> temp =
                DLWMS.Bazza.Studenti.Where(s => s.Ime.ToLower().Contains(vrijednost) || s.Prezime.ToLower().Contains(vrijednost)).ToList();
            if (string.IsNullOrEmpty(vrijednost))
                UcitajSveStudente();
            else
                UcitajSveStudente(temp);
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Registracija reg = new Registracija();
            if(reg.ShowDialog()==DialogResult.OK)
            {
                UcitajSveStudente();
            }
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgvStudenti.RowCount.ToString());
            if (dgvStudenti.RowCount>0)
            {
                Student s = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
                Registracija reg = new Registracija(s);
                if(reg.ShowDialog()==DialogResult.OK)
                {
                    MessageBox.Show("Edit uspjesan.");
                    UcitajSveStudente();
                }
            }
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Student s = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
                PrikazPredmeta pr = new PrikazPredmeta(s);
                pr.ShowDialog();
            }
        }
    }
}
