namespace HarfNotu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbArasinav.Items.Add("Se�iniz..");
            cmbFinal.Items.Add("Se�iniz..");

            cmbArasinav.SelectedIndex = 0;
            cmbFinal.SelectedIndex = 0;

            for (int i = 0; i <= 100; i++)
            {
                cmbArasinav.Items.Add(i);
                cmbFinal.Items.Add(i);
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (cmbArasinav.SelectedIndex == 0 || cmbFinal.SelectedIndex == 0)
            {
                MessageBox.Show("L�tfen ge�erli bir harf notu se�iniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double not = (Convert.ToDouble(cmbArasinav.Text) * 0.4) + (Convert.ToDouble(cmbFinal.Text) * 0.6);
            MessageBox.Show("Son not: " + not + "\n" + "Harf Notu: " + (not >= 90 ? "AA" : not >= 80 ? "BA" : not >= 70 ? "BB" : not >= 60 ? "CB" : not >= 50 ? "CC" : "FF"), "Hesaplama Tamamland�", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}