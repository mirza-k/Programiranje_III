using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Februarski_3
{
    public partial class Izvjestaj : Form
    {
        Student student;
        public Izvjestaj()
        {
            InitializeComponent();
        }
        public Izvjestaj(Student s):this()
        {
            student = s;
        }
        private void Izvjestaj_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rps = new ReportParameterCollection();
            rps.Add(new ReportParameter("BrojIndeksa", student.BrojIndeksa));
            rps.Add(new ReportParameter("Ime", student.Ime));
            rps.Add(new ReportParameter("Prezime", student.Prezime));

            PolozeniDataSet.PolozeniTabelaDataTable tblPolozeni = new PolozeniDataSet.PolozeniTabelaDataTable();
            NepolozeniDataSet.NepolozeniTabelaDataTable tblNepolozeni = new NepolozeniDataSet.NepolozeniTabelaDataTable();

            for (int i = 0; i < student.Uspjeh.Count(); i++)
            {
                PolozeniDataSet.PolozeniTabelaRow red = tblPolozeni.NewPolozeniTabelaRow();
                red.Rb = i + 1;
                red.Naziv = student.Uspjeh[i].Predmet.Naziv;
                red.Ocjena = student.Uspjeh[i].Ocjena.ToString();
                red.Datum = student.Uspjeh[i].Datum;
                tblPolozeni.Rows.Add(red);
            }
            List<Predmet> SviPredmeti = DLWMS.Bazza.Predmeti.ToList();
            for (int i = 0; i < SviPredmeti.Count(); i++)
            {
                if (!student.JelPolozen(SviPredmeti[i]))
                {
                    NepolozeniDataSet.NepolozeniTabelaRow red = tblNepolozeni.NewNepolozeniTabelaRow();
                    red.Rb = i + 1;
                    red.Naziv = SviPredmeti[i].Naziv;
                    red.Ocjena = "NIJE POLOŽEN.";
                    red.Datum = "NIJE POLOŽEN";
                    tblNepolozeni.Rows.Add(red);
                }
            }

            ReportDataSource rdsPol = new ReportDataSource();
            rdsPol.Name = "Polozeni";
            rdsPol.Value = tblPolozeni;

            ReportDataSource rdsNepol = new ReportDataSource();
            rdsNepol.Name = "Nepolozeni";
            rdsNepol.Value = tblNepolozeni;


            reportViewer1.LocalReport.DataSources.Add(rdsPol);
            reportViewer1.LocalReport.DataSources.Add(rdsNepol);
            reportViewer1.LocalReport.SetParameters(rps);
            this.reportViewer1.RefreshReport();
        }
    }
}
