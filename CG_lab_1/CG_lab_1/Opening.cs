using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;

namespace CG_lab_1
{
    class Opening : MathMorphology
    {
        public Opening()
        {
            this.mask = new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
        }

        public Opening(int[,] mask)
        {
            this.mask = mask;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = sourceImage;
            Filters filter = new Erosion();
            resultImage = filter.processImage(resultImage, worker);
            filter = new Dilation();
            resultImage = filter.processImage(resultImage, worker);
            return resultImage;
        }
    }
}
