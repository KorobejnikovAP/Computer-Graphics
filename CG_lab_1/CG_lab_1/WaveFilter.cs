using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_lab_1
{
    class WaveFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color resultColor = new Color();

            resultColor = sourceImage.GetPixel(clamp((int)(x + 20 * Math.Sin(2 * Math.PI * x / 30)), 0, sourceImage.Width-1), y);

            return resultColor;
        }
    }
}
