using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorPop
{
    public partial class FrmAnak : Form
    {
        public delegate void CreateUpdateEventHandler(Berhitung ber);
        public event FrmAnak.CreateUpdateEventHandler OnCreate;
        private Berhitung ber;

        public FrmAnak()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            ber = new Berhitung();
            ber.Nama = this.cmbOperasi.Text.ToLower();
            ber.Operasi = string.Empty;
            ber.Hasil = 0;
            ber.Nilai_A = Double.Parse(this.textBox1.Text);
            ber.Nilai_B = Double.Parse(this.textBox2.Text);


           if (this.cmbOperasi.SelectedIndex == 0)
            {
                ber.Hasil = ber.Nilai_A + ber.Nilai_B;
                ber.Operasi = "+";

            }
            else if (this.cmbOperasi.SelectedIndex == 1)
            {
                ber.Hasil = ber.Nilai_A - ber.Nilai_B;
                ber.Operasi = "-";
            }
            else if (this.cmbOperasi.SelectedIndex == 2)
            {
                ber.Hasil = ber.Nilai_A * ber.Nilai_B;
                ber.Operasi = "*";
            }
            else if (this.cmbOperasi.SelectedIndex == 3)
            {
                ber.Hasil = ber.Nilai_A / ber.Nilai_B;
                ber.Operasi = "/";
            }

            this.OnCreate(ber);
        }

        private void FrmAnak_Load(object sender, EventArgs e)
        {

        }
    }
}
