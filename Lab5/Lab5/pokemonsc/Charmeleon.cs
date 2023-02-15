using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.pokemonsc
{
    public class Charmeleon
    {
        private Bitmap _image =
            global::Lab5.Properties.Resources._1;

        public  Charmeleon() { }

        public Bitmap getImage()
        {
            return this._image;
        }
    }
}
