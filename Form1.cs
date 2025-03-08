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
            this.displayPokemon(pikachu, GetV(pikachu));
        }

        private string GetV(Pokemon pokemon)
        {
            return pokemon.Total.ToString();
        }

        private void displayPokemon(Pokemon pokemon, string totalValue)
        {
            this.pictureBox1.Text = pokemon.Name;
            using (var ms = new MemoryStream(pokemon.getImage()))
            {
                this.pictureBox1.Image = Image.FromStream(ms);
            }
            if (pokemon.Type2 == PokemonType.None)
            {
                this.Type2_dis.Visible = false;
            }
            else
            {
                this.Type2_dis.Visible = true;
            }
            this.Name_dis.Text = pokemon.Name;
            this.Type_dis.Text = pokemon.Type.ToString();
            this.Type2_dis.Text = pokemon.Type2.ToString();
            this.Hp_dis.Text = pokemon.HP.ToString();
            this.At_dis.Text = pokemon.Attack.ToString();
            this.Df_dis.Text = pokemon.Defense.ToString();
            this.SPAt_dis.Text = pokemon.SpecialAttack.ToString();
            this.SPDf_dis.Text = pokemon.SpecialDefense.ToString();
            this.Speed_dis.Text = pokemon.Speed.ToString();
            this.Total_dis.Text = totalValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pikachu pikachu = new Pikachu();
            this.pokemonsList.Add(pikachu);
            this.displayPokemon(pikachu, GetV(pikachu));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tentacool tentacool = new Tentacool();
            this.pokemonsList.Add(tentacool);
            this.displayPokemon(tentacool, GetV(tentacool));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Staryu staryu = new Staryu();
            this.pokemonsList.Add(staryu);
            this.displayPokemon(staryu, GetV(staryu));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Goldeen goldeen = new Goldeen();
            this.pokemonsList.Add(goldeen);
            this.displayPokemon(goldeen, GetV(goldeen));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ditto ditto = new Ditto();
            this.pokemonsList.Add(ditto);
            this.displayPokemon(ditto, GetV(ditto));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Gardevoir gardevoir = new Gardevoir();
            this.pokemonsList.Add(gardevoir);
            this.displayPokemon(gardevoir, GetV(gardevoir));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Wailmer wailmer = new Wailmer();
            this.pokemonsList.Add(wailmer);
            this.displayPokemon(wailmer, GetV(wailmer));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Arceus arceus = new Arceus();
            this.pokemonsList.Add(arceus);
            this.displayPokemon(arceus, GetV(arceus));
        }
    }

    public class Pikachu : Pokemon
    {
        // Implementation of Pikachu class
    }

    public class Tentacool : Pokemon
    {
        // Implementation of Tentacool class
    }

    public class Staryu : Pokemon
    {
        // Implementation of Staryu class
    }

    public class Goldeen : Pokemon
    {
        // Implementation of Goldeen class
    }

    public class Ditto : Pokemon
    {
        // Implementation of Ditto class
    }

    public class Gardevoir : Pokemon
    {
        // Implementation of Gardevoir class
    }

    public class Wailmer : Pokemon
    {
        // Implementation of Wailmer class
    }

    public class Arceus : Pokemon
    {
        // Implementation of Arceus class
    }
}
