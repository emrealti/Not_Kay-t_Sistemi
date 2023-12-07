using System;
using System.Linq;
using System.Windows.Forms;


namespace Not_Kayıt_Sistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOgrenciDetay frm = new FrmOgrenciDetay();
            frm.numara = maskedTextBox1.Text;
            frm.Show();
        }

        //private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        //{
        //    if(maskedTextBox1.Text=="1111")
        //    {
        //        FrmOgretmenDetay fr= new FrmOgretmenDetay();
        //        fr.Show();
        //    }
        //}

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                FrmOgretmenDetay fr = new FrmOgretmenDetay();
                fr.Show();
            }
        }

}    
}
