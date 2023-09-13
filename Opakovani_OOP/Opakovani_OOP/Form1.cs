using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opakovani_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titul = textBox1.Text;
            string jmeno = textBox2.Text;
            int mesicniPlat = Convert.ToInt32(numericUpDown1.Value);
            DateTime datumNastupu = dateTimePicker1.Value;
            int osobniHodnoceni = Convert.ToInt32(numericUpDown2.Value);
            int pocetHodin = Convert.ToInt32(numericUpDown3.Value);
            Zaměstnanec zamestnanec = new Zaměstnanec(titul, jmeno, mesicniPlat, datumNastupu, osobniHodnoceni, pocetHodin);
            MessageBox.Show(zamestnanec.Titul);
            MessageBox.Show(zamestnanec.Jmeno);
            MessageBox.Show(zamestnanec.RocniPlat().ToString());
            MessageBox.Show(zamestnanec.PocetMesicu(datumNastupu).ToString());
            zamestnanec.ZvysOsobni(osobniHodnoceni);
            MessageBox.Show(zamestnanec.Titul);
        }
    }
}
