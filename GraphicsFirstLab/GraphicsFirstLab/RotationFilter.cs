using System;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    class RotationFilter : Filters
    {
        private float angle; // Угол поворота в радианах
        private PointF center; // Центр поворота

        public RotationFilter(float angleInDegrees, Bitmap sourceImage = null)
        {
            this.angle = angleInDegrees * (float)Math.PI / 180f; 
            this.center = sourceImage != null ?
                new PointF(sourceImage.Width / 2f, sourceImage.Height / 2f) :
                PointF.Empty;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            if (center == PointF.Empty)
                center = new PointF(sourceImage.Width / 2f, sourceImage.Height / 2f);

            float xRel = x - center.X;
            float yRel = y - center.Y;

            int newX = (int)(xRel * Math.Cos(angle) - yRel * Math.Sin(angle) + center.X);
            int newY = (int)(xRel * Math.Sin(angle) + yRel * Math.Cos(angle) + center.Y);

            if (newX >= 0 && newX < sourceImage.Width && newY >= 0 && newY < sourceImage.Height)
                return sourceImage.GetPixel(newX, newY);

            return Color.Black; 
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            if (center == PointF.Empty)
                center = new PointF(sourceImage.Width / 2f, sourceImage.Height / 2f);

            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / sourceImage.Width * 100));
                if (worker.CancellationPending)
                    return null;

                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
            }

            return resultImage;
        }
    }
}