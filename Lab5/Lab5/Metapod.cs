using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Metapod
    {
        private Bitmap _image =
        global::Lab5.Properties.Resources._03;

        public Metapod() { }

        public Bitmap getImage()
        {
            return this._image;
        }
    }
}
