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

        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void èíâåðñèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ðàçìûòèåToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ñåïèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ÷ÁToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñîáåëÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new SobelFilter(true); // true - ãîðèçîíòàëüíîå ÿäðî
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ðåçêîñòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new SharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ÿðêîñòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new BrightnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void òèñíåíèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new EmbossFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ìåäèàííûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new MedianFilter();
            backgroundWorker1.RunWorkerAsync(filter);

        }

        private void ùàððàToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ãîðèçîíòàëüíûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new BorderSharra(true);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void âåðòèêàëüíûéToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ñåðûéÌèðToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new GrayWorldFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ãðàäèåíòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new GradientFilter(currentStructElement);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñòåêëîToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
