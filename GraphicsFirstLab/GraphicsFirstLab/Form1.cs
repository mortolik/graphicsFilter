using CG;
using Filters;
using System.ComponentModel;

namespace GraphicsFirstLab
{
    public partial class Form1 : Form
    {
        Bitmap image;

        public Form1()
        {
            InitializeComponent();
        }

        private void îòêğûòüToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void èíâåğñèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ğàçìûòèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
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
            Filters.Filters filter = new SobelFilter(true); // true - ãîğèçîíòàëüíîå ÿäğî
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ğåçêîñòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new SharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ÿğêîñòüToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ùàğğàToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ãîğèçîíòàëüíûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Filters filter = new BorderSharra(true);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void âåğòèêàëüíûéToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
