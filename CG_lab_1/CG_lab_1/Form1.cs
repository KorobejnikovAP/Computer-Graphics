using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CG_lab_1
{
    public partial class Form1 : Form
    {
        Bitmap image;
        Stack<Bitmap> bitmaps;
        Form2 StructElem;
        public Form1()
        {
            InitializeComponent();
            StructElem = new Form2();
            bitmaps = new Stack<Bitmap>();
        }

       
        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                bitmaps.Push(image);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void ИнверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
            {
                image = newImage;
                bitmaps.Push(image);
            }
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void РазмытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ФильтрГауссаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ВОттенкахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void СепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ЯркостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BrightnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ФильтрСобеляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void РезкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image.Save(dialog.FileName);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (bitmaps.Count >= 2)
            {
                bitmaps.Pop();
                if (bitmaps.Count > 0)
                    image = bitmaps.Peek();
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void ИдеальныйОтражательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new ReflectorFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ЛинейноеРастяжениеГистограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new StretchFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }
        
        private void ПереносToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new ShiftFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ВолныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new WaveFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ТиснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new StampingFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

      
        private void СужениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new Erosion(StructElem.mask);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void РасширениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new Dilation(StructElem.mask);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ОткрытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Opening(StructElem.mask);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ЗакрытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Closing(StructElem.mask);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void GradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Grad(StructElem.mask);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ЗадатьСтруктурныйЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StructElem.Show();
        }

        private void МедианныйФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Median(1);
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}
