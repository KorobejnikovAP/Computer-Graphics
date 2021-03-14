using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_lab_1
{
    class StampingFilter : MatrixFilter
    {
        public StampingFilter()
        {
            kernel = new float[3, 3] { { 0, 1, 0 }, { 1, 0, -1 }, { 0, -1, 0 } };
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = sourceImage;
            Filters filter = new GrayScaleFilter();

            resultImage = filter.processImage(resultImage, worker);
            resultImage = base.processImage(resultImage, worker);

            for (int i = 0; i < resultImage.Width; ++i)
                for (int j = 0; j < resultImage.Height; ++j)
                {
                    Color color = resultImage.GetPixel(i, j);
                    color = Color.FromArgb((color.R + 255) / 2, (color.G + 255) / 2, (color.B + 255) / 2);
                    resultImage.SetPixel(i, j, color);
                }

            return resultImage;
        }
    }
}
