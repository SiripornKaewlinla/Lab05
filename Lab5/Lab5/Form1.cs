using Lab5.pokemonsc;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Charmander charmander= new Charmander();
            this.pictureBox1.Image = charmander.getImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Charmeleon charmeleon= new Charmeleon();
            this.pictureBox1.Image = charmeleon.getImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Charizard charizard = new Charizard();
            this.pictureBox1.Image = charizard.getImage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Squirtle squirtle = new Squirtle();
            this.pictureBox2.Image= squirtle.getImage();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Wartortle wartortle = new Wartortle();
            this.pictureBox2.Image= wartortle.getImage();   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Blastoise blastoise = new Blastoise();
            this.pictureBox2.Image= blastoise.getImage();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Caterpie caterpie = new Caterpie();
            this.pictureBox3.Image= caterpie.getImage();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Metapod metapod = new Metapod();
            this.pictureBox3.Image= metapod.getImage();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Butterfree butterfree = new Butterfree();
            this.pictureBox3.Image= butterfree.getImage();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Nidoran nidoran = new Nidoran();
            this.pictureBox4.Image= nidoran.getImage();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Nidorino nidorino = new Nidorino();
            this.pictureBox4.Image= nidorino.getImage();
    
            }

        private void button12_Click(object sender, EventArgs e)
        {

            Nidoking nidoking = new Nidoking(); 
            this.pictureBox4.Image= nidoking.getImage();
        }
    }
}