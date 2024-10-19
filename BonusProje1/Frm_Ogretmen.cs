using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProje1
{
    public partial class Frm_Ogretmen : Form
    {
        public Frm_Ogretmen()
        {
            InitializeComponent();
        }

        private void Frm_Ogretmen_Load(object sender, EventArgs e)
        {

        }

        private void BtnKulupİslemler_Click(object sender, EventArgs e)
        {
            Frm_Kulup fr = new Frm_Kulup();
            fr.Show();
        }

        private void BtnDers_Click(object sender, EventArgs e)
        {
            Frm_Dersler fr = new Frm_Dersler();
            fr.Show();
        }

        private void BtnOgrenciİslemleri_Click(object sender, EventArgs e)
        {
            Frm_Ogrenci fr = new Frm_Ogrenci();
            fr.Show();
        }

        private void BtnSinavNotlar_Click(object sender, EventArgs e)
        {
            FrmSinavNotlar fr = new FrmSinavNotlar();
            fr.Show();
        }
    }
}
