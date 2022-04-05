namespace Formos
{
    public partial class Form1 : Form
    {
        private int ticks;
        private int kiek = 10;
        private int n = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void sudedam_Click(object sender, EventArgs e)
        {
            double rez_a;
            double rez_b;
            bool success1 = double.TryParse(skaicius1.Text, out rez_a);
            bool success2 = double.TryParse(skaicius2.Text, out rez_b);

            double rez;
            rez = rez_a + rez_b;
            ats.Text = rez.ToString();
        }

        private void atimam_Click(object sender, EventArgs e)
        {
            double rez_a;
            double rez_b;
            bool success1 = double.TryParse(skaicius1.Text, out rez_a);
            bool success2 = double.TryParse(skaicius2.Text, out rez_b);

            double rez;
            rez = rez_a - rez_b;
            ats.Text = rez.ToString();
        }

        private void dalinam_Click(object sender, EventArgs e)
        {
            double rez_a;
            double rez_b;
            bool success1 = double.TryParse(skaicius1.Text, out rez_a);
            bool success2 = double.TryParse(skaicius2.Text, out rez_b);

            double rez;
            rez = rez_a / rez_b;
            ats.Text = rez.ToString();
        }

        private void dauginam_Click(object sender, EventArgs e)
        {
            double rez_a;
            double rez_b;
            bool success1 = double.TryParse(skaicius1.Text, out rez_a);
            bool success2 = double.TryParse(skaicius2.Text, out rez_b);

            double rez;
            rez = rez_a * rez_b;
            ats.Text = rez.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            if (laikas.Value == kiek)
            {
                timer1.Enabled = false;
                MessageBox.Show("TAVO LAIKAS PASIBAIGĖ!", "Kas dabar bus?");
            }else
            {
                laikas.Value = ticks;
                ticks++;
                laikoText.Text = n.ToString();
                n--;                               
            }          
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            laikas.Value = 0;  //nuanuliuojami esami rezultatai
            ticks = 0;
            n = kiek;
            laikoText.Clear();
            timer1.Enabled = false; //sustabdomas laikas
        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false; //sustabdomas laikas
        }
    }
}