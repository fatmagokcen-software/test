namespace pratik_örnek_öğrenci_sınav_durumu_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, sinav3, ortalama;
            string durum;

            sinav1= Convert.ToDouble(this.textBox1.Text);
            sinav2= Convert.ToDouble(this.textBox2.Text);
            sinav3= Convert.ToDouble(this.textBox3.Text);

            ortalama = (sinav1+sinav2+sinav3) / 3;
            if (ortalama >= 50)
            {
                durum = "geçtiiiiii";
            }
            else
            {
                durum = "kaldı:(";
            }
            textBox4.Text = "öğrencinin ortalaması: " + ortalama +  "  /  "  + "sonuç: "  +  durum;
        }
    }
}
