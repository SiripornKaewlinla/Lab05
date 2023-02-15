using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.pokemonsc
{
    internal class Charmander
    {
        private Bitmap _image =
           global::Lab5.Properties.Resources._01;
        public Charmander() { }

        public Bitmap getImage()
        {
            return this._image;
        }

    }
}
