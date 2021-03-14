using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_lab_1
{
    class BrightnessFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {

            Color sourceColor = sourceImage.GetPixel(x, y);
            int k = 50;
            Color resultColor = Color.FromArgb(clamp(sourceColor.R + k, 0, 255),
                                               clamp(sourceColor.G + k, 0, 255),
                                               clamp(sourceColor.B + k, 0, 255));

            return resultColor;
        }
    }
}
