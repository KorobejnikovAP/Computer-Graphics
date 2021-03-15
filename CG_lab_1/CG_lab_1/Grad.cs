using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;

namespace CG_lab_1
{
    class Grad : MathMorphology
    {
        public Grad()
        {
            this.mask = new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
        }

        public Grad(int[,] mask)
        {
            this.mask = mask;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = sourceImage;
            Bitmap tmp1 = sourceImage;
            Bitmap tmp2 = sourceImage;
            Filters filter = new Dilation();
            tmp1 = filter.processImage(tmp1, worker);
            filter = new Erosion();
            tmp2 = filter.processImage(tmp2, worker);

            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    int r = clamp(tmp1.GetPixel(i, j).R - tmp2.GetPixel(i, j).R, 0, 255);
                    int g = clamp(tmp1.GetPixel(i, j).G - tmp2.GetPixel(i, j).G, 0, 255);
                    int b = clamp(tmp1.GetPixel(i, j).B - tmp2.GetPixel(i, j).B, 0, 255);

                    resultImage.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            return resultImage;
        }
    }
}
