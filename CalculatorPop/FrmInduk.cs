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
    public partial class FrmInduk : Form
    {
        public FrmInduk()
        {
            InitializeComponent();
        }

        private void FrmInduk_Load(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            FrmAnak f2 = new FrmAnak();
            f2.OnCreate += FrmEntry_OnCreate;
            f2.ShowDialog();
        }

        private void FrmAnak_OnCreate(Berhitung ber)
        {

        }

        private void FrmEntry_OnCreate(Berhitung ber)
        {
            HasilCal.Items.Add("Hasil " + ber.Nama + " " + ber.Nilai_A + " " + ber.Operasi + " " + ber.Nilai_B + " " + "=" + " " + ber.Hasil);
        }
        private void HasilCal_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }
    }
}
