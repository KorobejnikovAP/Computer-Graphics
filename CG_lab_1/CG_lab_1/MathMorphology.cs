using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_lab_1
{
    class MathMorphology : Filters
    {
        protected int[,] mask;

        protected MathMorphology() { }
        public MathMorphology(int[,] mask) {
            this.mask = mask;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            throw new NotImplementedException();
        }
    }
}
