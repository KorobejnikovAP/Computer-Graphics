using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_lab_1
{
    class SepiaFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {

            Color sourceColor = sourceImage.GetPixel(x, y);
            int intensity = (int)(0.299 * sourceColor.R + 0.587 * sourceColor.G + 0.114 * sourceColor.B);
            int k = 50;
            Color resultColor = Color.FromArgb(clamp((int)(intensity + 2 * k), 0, 255),
                                               clamp((int)(intensity + 0.5 * k), 0, 255),
                                               clamp((int)(intensity - 1 * k), 0, 255));

            return resultColor;
        }
    }
}
