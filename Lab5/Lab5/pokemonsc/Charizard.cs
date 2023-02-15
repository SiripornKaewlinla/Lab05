using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.pokemonsc
{
    public class Charizard
    {
        private Bitmap _image =
            global::Lab5.Properties.Resources._001;

        public Charizard() { }

        public Bitmap getImage()
        {
            return this. _image;
        }

    }
}
