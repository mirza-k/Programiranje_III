using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Februarski_3
{
    public partial class Visenitno : Form
    {
        public Visenitno()
        {
            InitializeComponent(); 
        }

        private void Visenitno_Load(object sender, EventArgs e)
        {

        }

        private void ProvjeriPrivilegije()
        {
            Thread.Sleep(1000);
            Action action = () => txtIspis.Text += "Privilegije OK..." + Environment.NewLine;
            BeginInvoke(action);
        }

        private void ProvjeriBazu()
        {
            Thread.Sleep(2000);
            Action action = () => txtIspis.Text += "Baza OK..." + Environment.NewLine;
            BeginInvoke(action);
        }

        private void ProvjeriKonekciju()
        {
            Thread.Sleep(3000);
            Action action = () => txtIspis.Text += "Konekcija OK..." + Environment.NewLine;
            BeginInvoke(action);
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(ProvjeriKonekciju);
            Thread t2 = new Thread(ProvjeriBazu);
            Thread t3 = new Thread(ProvjeriPrivilegije);
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
