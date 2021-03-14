using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_lab_1
{
    class ShiftFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int k = 50;
            Color resultColor = new Color();
            if (x + k < sourceImage.Width)
                resultColor = sourceImage.GetPixel(x + k, y);
            else
            {
                resultColor = Color.FromArgb(0, 0, 0);
            }

            return resultColor;
        }
    }
}
