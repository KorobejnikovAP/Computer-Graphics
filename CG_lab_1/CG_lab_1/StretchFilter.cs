using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CG_lab_1
{
    class StretchFilter : Filters
    {
        int Rmax = 0;
        int Gmax = 0;
        int Bmax = 0;

        int Rmin = 256;
        int Gmin = 256;
        int Bmin = 256;
        override public Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int i = 0; i < sourceImage.Width; ++i)
                for (int j = 0; j < sourceImage.Height; ++j)
                {
                    Color sourceColor = sourceImage.GetPixel(i, j);
                    if (sourceColor.R > Rmax)
                        Rmax = sourceColor.R;
                    if (sourceColor.G > Gmax)
                        Gmax = sourceColor.G;
                    if (sourceColor.B > Bmax)
                        Bmax = sourceColor.B;

                    if (sourceColor.R < Rmin)
                        Rmin = sourceColor.R;
                    if (sourceColor.G < Gmin)
                        Gmin = sourceColor.G;
                    if (sourceColor.B < Bmin)
                        Bmin = sourceColor.B;
                }
            resultImage = base.processImage(sourceImage, worker);
            return resultImage;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);

            Color resultColor = Color.FromArgb(clamp((sourceColor.R - Rmin) * 255 / (Rmax - Rmin), 0, 255),
                                               clamp((sourceColor.G - Gmin) * 255 / (Gmax - Gmin), 0, 255),
                                               clamp((sourceColor.B - Bmin) * 255 / (Bmax - Bmin), 0, 255));

            return resultColor;
        }
    }
}
