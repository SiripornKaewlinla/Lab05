using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Squirtle
    {
        private Bitmap _image =
          global::Lab5.Properties.Resources._2;
        public Squirtle() { }

        public Bitmap getImage()
        {
            return this._image;
        }
    }
}
