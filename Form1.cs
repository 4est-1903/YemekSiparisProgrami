namespace stajornek4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstAd.Items.Add(txtadsoyad.Text);
            lstTelefon.Items.Add(txttelefon.Text);
            lstAdres.Items.Add(txtadres.Text);

            lstBoy.Items.Add(comboBoy.Text);
            lstIcecek.Items.Add(comboIcecek.Text);
            lstAd.Visible = true;
            lstTelefon.Visible = true;
            lstAdres.Visible = true;
            lstBoy.Visible = true;
            lstIcecek.Visible = true;
            lstCesit.Visible = true;



            lstCesit.Items.Add(label7.Text + " " + label8.Text + " " + label9.Text + " " + label10.Text + " " + label11.Text + " " + label12.Text);




        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = checkBox1.Text;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = checkBox2.Text;

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = checkBox3.Text;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = checkBox4.Text;

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = checkBox5.Text;

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = checkBox6.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtadsoyad.Clear();
            txtadres.Clear();
            txttelefon.Clear();
            comboBoy.Text = " ";
            comboIcecek.Text = "w ";

            lstAd.Items.Clear();
            lstAdres.Items.Clear();
            lstTelefon.Items.Clear();
            lstBoy.Items.Clear();
            lstIcecek.Items.Clear();
            lstCesit.Items.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

            lstAd.Visible = false;
            lstTelefon.Visible = false;
            lstAdres.Visible = false;
            lstBoy.Visible = false;
            lstIcecek.Visible = false;
            lstCesit.Visible = false;
        }
    }
}