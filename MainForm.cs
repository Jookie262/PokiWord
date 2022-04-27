using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokiWord
{
    public partial class MainForm : Form
    {
        // Initialize Needed Variables
        Pokemon pokemon;
        StringBuilder name, image, desc;

        public MainForm()
        {
            InitializeComponent();
            doubleBuffer(MainPanel);
            doubleBuffer(PlayPanel);
        }

        // Click Play Button
        private void play_Click(object sender, EventArgs e)
        {
            doubleBuffer(answer_box);
            doubleBuffer(ok_box);
            viewPokemon();
            PlayPanel.BringToFront();
        }

        // Method to Avoid Flickering of Images
        public void doubleBuffer(Panel panel)
        {
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
           | BindingFlags.Instance | BindingFlags.NonPublic, null,
           panel, new object[] { true });
        }
        
        // Display Pokemon in the Card
        public void viewPokemon()
        {
            pokemon = new Pokemon();

            string[] pokemonArray = pokemon.getRandomPokemon();
            name = new StringBuilder(pokemonArray[0]);
            image = new StringBuilder(pokemonArray[1]);
            desc = new StringBuilder(pokemonArray[2]);

            poke_name.Text = name.ToString();
            poke_image.Image = (Image)Properties.Resources.ResourceManager.GetObject(image.ToString());
            poke_description.Text = desc.ToString();
        }
    }
}
