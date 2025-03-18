namespace Pokemon
{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemonsList;

        public Form1()
        {
            InitializeComponent();
            pokemonsList = new List<Pokemon>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pikachu pikachu = new Pikachu();
            this.pokemonsList.Add(pikachu);
            this.displayPokemon(pikachu);
        }

        private void displayPokemon(Pokemon pokemon)
        {
            this.Name_dis.Text = pokemon.Name;
            this.Type_dis.Text = pokemon.Type;
            this.Hp_dis.Text = pokemon.HP.ToString();
            this.At_dis.Text = pokemon.Attack.ToString();
            this.Df_dis.Text = pokemon.Defense.ToString();
            this.Speed_dis.Text = pokemon.Speed.ToString();

            // โหลดและแสดงรูปภาพ
            Image pokemonImage = pokemon.GetImage();
            if (pokemonImage != null)
            {
                this.pictureBox1.Image = pokemonImage;
            }
            else
            {
                this.pictureBox1.Image = null; // ถ้าไม่มีรูป
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tentacool tentacool = new Tentacool();
            this.displayPokemon(new Tentacool());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Staryu staryu = new Staryu();
            this.displayPokemon(new Staryu());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Goldeen goldeen = new Goldeen();
            this.displayPokemon(new Goldeen());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ditto ditto = new Ditto();
            this.displayPokemon(new Ditto());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Wailmer wailmer = new Wailmer();
            this.displayPokemon(new Wailmer());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pikachu pikachu = new Pikachu();
            this.displayPokemon(pikachu);
        }
    }
}
