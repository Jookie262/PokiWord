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

        // Clicking the Ok Button
        private void ok_box_Click(object sender, EventArgs e)
        {
            displayMessageBox();
        }

        // Clicking the Ok Button
        private void ok_text_Click(object sender, EventArgs e)
        {
            displayMessageBox();
        }

        // Display Pokemon in the Card
        public void viewPokemon()
        {
            pokemon = new Pokemon();

            string[] pokemon_data = pokemon.getRandomPokemon();
            name = new StringBuilder(pokemon_data[0]);
            image = new StringBuilder(pokemon_data[1]);
            desc = new StringBuilder(pokemon_data[2]);

            poke_name.Text = name.ToString();
            poke_image.Image = (Image)Properties.Resources.ResourceManager.GetObject(image.ToString());
            poke_description.Text = desc.ToString();

            answer.Text = null;
        }

        // When Clicking Enter
        private void answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                displayMessageBox();
            }
        }

        // Check if the answer is correct
        public string checkAnswer()
        {
            if (answer.Text.Equals(image.ToString().ToUpper()))
                return "Correct";
            else
                return "Wrong";
        }

        // Display the Message box if correct or not
        public void displayMessageBox()
        {
            DialogResult result = MessageBox.Show("Want to Guess Again?", 
                checkAnswer(), MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                viewPokemon();
            else
                this.Close();
        }
    }
}
