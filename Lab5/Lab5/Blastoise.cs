using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Blastoise
    {
        private Bitmap _image =
          global::Lab5.Properties.Resources._002;

        public Blastoise() { }

        public Bitmap getImage()
        {
            return this._image;
        }
    } 
}
