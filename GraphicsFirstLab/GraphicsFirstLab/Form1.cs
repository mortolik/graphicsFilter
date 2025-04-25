using CG;
using Filters;
using System.ComponentModel;

namespace GraphicsFirstLab
{
    public partial class Form1 : Form
    {
        Bitmap image;
        private Stack<Bitmap> returnBack = new Stack<Bitmap>();
        private Stack<Bitmap> returnForward = new Stack<Bitmap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ÓÚÍ˚Ú¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *.bmp | All files (*.*) | *.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void ËÌ‚ÂÒËˇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ‡ÁÏ˚ÚËÂToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }
        private void SaveCondition()
        {
            if (image != null)
            {
                returnBack.Push(new Bitmap(image));
                if (returnForward.Count != 0)
                {
                    returnForward.Clear();
                }

            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters.Filters)e.Argument).processImage(image, backgroundWorker1);
            if (!backgroundWorker1.CancellationPending)
            {
                e.Result = newImage;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                SaveCondition();

                image = (Bitmap)e.Result;
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void ÒÂÔËˇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ˜¡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ÒÓ·ÂÎˇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new SobelFilter(true); // true - „ÓËÁÓÌÚ‡Î¸ÌÓÂ ˇ‰Ó
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ÂÁÍÓÒÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new SharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ˇÍÓÒÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new BrightnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ÚËÒÌÂÌËÂToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new EmbossFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ÏÂ‰Ë‡ÌÌ˚ÈToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new MedianFilter();
            backgroundWorker1.RunWorkerAsync(filter);

        }

        private void ˘‡‡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void „ÓËÁÓÌÚ‡Î¸Ì˚ÈToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new BorderSharra(true);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ‚ÂÚËÍ‡Î¸Ì˚ÈToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new BorderSharra(false);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private StructElement currentStructElement = StructElement.Rectangle3x3();
        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new DilationFilter(currentStructElement);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new ErosionFilter(currentStructElement);
            backgroundWorker1.RunWorkerAsync(filter);

        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new OpeningFilter(currentStructElement);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new ClosingFilter(currentStructElement);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new TopHatFilter(currentStructElement);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ÒÂ˚ÈÃËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new GrayWorldFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void „‡‰ËÂÌÚToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new GradientFilter(currentStructElement);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ÒÚÂÍÎÓToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new GlassFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void motionBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new MotionBlur();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (returnBack.Count > 0)
            {
                returnForward.Push(new Bitmap(pictureBox1.Image));
                image = returnBack.Pop();
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (returnForward.Count > 0)
            {
                returnBack.Push(new Bitmap(pictureBox1.Image));
                image = returnForward.Pop();
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void ‚ÓÎÌ‡1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new Waves1();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ‚ÓÎÌ‡2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new Waves2();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ÔÓ‚ÓÓÚToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new RotationFilter(-45.0f, image);
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}
