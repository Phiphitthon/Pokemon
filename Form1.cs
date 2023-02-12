using System.Runtime.InteropServices;

namespace Pokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cubone cubone= new Cubone();
            this.pictureBox1.Image = cubone.getImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Marowak marowak= new Marowak();
            this.pictureBox1.Image = marowak.getImage();
        }
    }
}