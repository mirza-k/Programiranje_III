using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Februarski_3
{
    public class BazaPodataka:DbContext
    {
        public BazaPodataka():base("KonekcijaNaBazu")
        {
        }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<Spol> Spolovi { get; set; }
    }
    [Table("Studenti")]
    public class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojIndeksa { get; set; }
        public byte[] Slika { get; set; }
        public virtual Spol Spol { get; set; }
        public virtual List<StudentPredmet> Uspjeh { get; set; } = new List<StudentPredmet>();
        public float IzracunajProsjek()
        {
            float pr = 0;
            for (int i = 0; i <Uspjeh.Count(); i++)
            {
                pr += Uspjeh[i].Ocjena;
            }
            if (pr == 0)
                return pr;
            else
                return pr / Uspjeh.Count();
        }
        public bool JelPolozen(Predmet p)
        {
            for (int i = 0; i < Uspjeh.Count(); i++)
            {
                if (p == Uspjeh[i].Predmet)
                    return true;
            }
            return false;
        }
    }
    [Table("Spolovi")]
    public class Spol
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
    [Table("Predmeti")]
    public class Predmet
    {
        public int Id { get; set;}
        public string Naziv { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
    [Table("StudentiPredmeti")]
    public class StudentPredmet
    {
        public int Id { get; set; }
        public virtual Predmet Predmet { get; set; }
        public virtual Student Student { get; set; }
        public int Ocjena { get; set; }
        public string Datum { get; set; }
    }
}
