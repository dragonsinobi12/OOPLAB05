namespace LAB005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pk1_Click(object sender, EventArgs e)
        {
            ///yourpokemon///
            Pikachu pikachu = new Pikachu();
            pokemon.Text = pikachu.Name();
            pictureBox1.Image = pikachu.Picture();
            //enemy//
            Magikarp magikarp = new Magikarp();
            enemy.Text = magikarp.Name();
            pictureBox2.Image = magikarp.Picture();
        }

        private void pk2_Click(object sender, EventArgs e)
        {
            //yourpokemon///
            Raichu raichu = new Raichu();
            pokemon.Text = raichu.Name();
            pictureBox1.Image = raichu.Picture();
            //enemy//
            Magikarp magikarp = new Magikarp();
            enemy.Text = magikarp.Name();
            pictureBox2.Image = magikarp.Picture();
        }

        private void pk3_Click(object sender, EventArgs e)
        {
            //yourpokemon///
            Caterpie caterpie = new Caterpie();
            pokemon.Text = caterpie.Name();
            pictureBox1.Image = caterpie.Picture();
            //enemy//
            Magikarp magikarp = new Magikarp();
            enemy.Text = magikarp.Name();
            pictureBox2.Image = magikarp.Picture();
        }

        private void pk4_Click(object sender, EventArgs e)
        {
            //yourpokemon///
            Metapod metapod = new Metapod();
            pokemon.Text = metapod.Name();
            pictureBox1.Image = metapod.Picture();
            //enemy//
            Magikarp magikarp = new Magikarp();
            enemy.Text = magikarp.Name();
            pictureBox2.Image = magikarp.Picture();
        }

        private void pk5_Click(object sender, EventArgs e)
        {
            //yourpokemon///
            Horsea horsea = new Horsea();
            pokemon.Text = horsea.Name();
            pictureBox1.Image = horsea.Picture();
            //enemy//
            Magikarp magikarp = new Magikarp();
            enemy.Text = magikarp.Name();
            pictureBox2.Image = magikarp.Picture();
        }

        private void pk6_Click(object sender, EventArgs e)
        {
            //yourpokemon///
            Seadra seadra = new Seadra();
            pokemon.Text = seadra.Name();
            pictureBox1.Image = seadra.Picture();
            //enemy//
            Magikarp magikarp = new Magikarp();
            enemy.Text = magikarp.Name();
            pictureBox2.Image = magikarp.Picture();

        }
    }
}
