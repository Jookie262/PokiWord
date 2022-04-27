using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokiWord
{
    class Pokemon
    {
        // Name
        string[] name = { "Buzzwole", "Copperajah", "Eternatus", "Solgaleo", "Volcanion" };

        // Description
        string[] description = { "Although it’s alien to this world and a danger here, it’s apparently a common organism in the world where it normally lives.", "They came over from another region long ago and worked together with humans. Their green skin is resistant to water.", "The core on its chest absorbs energy emanating from the lands of the Galar region. This energy is what allows Eternatus to stay active.", "In writings from the distant past, it’s called by the name 'the beast that devours the sun.'", "It lets out billows of steam and disappears into the dense fog. It’s said to live in mountains where humans do not tread." };

        // Getter Name
        public string getName(int index)
        {
            return name[index];
        }

        // Getter Description
        public string getDescription(int index)
        {
            return description[index];
        }

        // Shuffle Pokemon Name
        public string shuffleName(int index)
        {
            return new string(getName(index).ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());
        }

        // Generate Random Index
        public int randomIndex(int total)
        {
            Random random = new Random();
            return random.Next(0, total);
        }

        // Get a Random Pokemon
        public string[] getRandomPokemon()
        {
            int rand = randomIndex(5);
            string[] randPoke = { shuffleName(rand).ToUpper(), getName(rand),getDescription(rand) };
            return randPoke;
        }
    }
}
