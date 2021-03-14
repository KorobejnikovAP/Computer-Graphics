using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CG_lab_1
{
    class Erosion : Filters
    {
        int[,] kernel = null;

        public Erosion()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new int[sizeX, sizeY];
            for(int i = 0; i < sizeX; ++i)
                for (int j = 0; j < sizeY; ++j)
                kernel[i, j] = 1;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;

            float resultR = 255;
            float resultG = 255;
            float resultB = 255;

            for (int l = -radiusY; l <= radiusY; ++l)
                for (int k = -radiusX; k <= radiusX; ++k)
                {
                    int idX = clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    if ((kernel[k + radiusX, l + radiusY] == 1) && (neighborColor.R < resultR))
                        resultR = neighborColor.R ;
                    if ((kernel[k + radiusX, l + radiusY] == 1) && (neighborColor.G < resultG))
                        resultG = neighborColor.G ;
                    if ((kernel[k + radiusX, l + radiusY] == 1) && (neighborColor.B < resultB))
                        resultB = neighborColor.B ;
                }
            return Color.FromArgb(clamp((int)resultR, 0, 255),
                                  clamp((int)resultG, 0, 255),
                                  clamp((int)resultB, 0, 255));
        }
    }
}
