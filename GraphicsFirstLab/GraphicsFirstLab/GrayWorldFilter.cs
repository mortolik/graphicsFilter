using System;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    public class GrayWorldFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            // Не используется, так как требуется обработка всего изображения
            throw new NotImplementedException();
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            // 1. Вычисляем средние значения каналов
            double avgR = 0, avgG = 0, avgB = 0;
            int totalPixels = sourceImage.Width * sourceImage.Height;

            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color pixel = sourceImage.GetPixel(i, j);
                    avgR += pixel.R;
                    avgG += pixel.G;
                    avgB += pixel.B;
                }
                worker.ReportProgress((int)((float)i / sourceImage.Width * 30));
                if (worker.CancellationPending) return null;
            }

            avgR /= totalPixels;
            avgG /= totalPixels;
            avgB /= totalPixels;

            // 2. Среднее арифметическое трех каналов
            double avg = (avgR + avgG + avgB) / 3.0;

            // 3. Корректируем изображение
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color pixel = sourceImage.GetPixel(i, j);

                    int newR = Clamp((int)(pixel.R * avg / avgR), 0, 255);
                    int newG = Clamp((int)(pixel.G * avg / avgG), 0, 255);
                    int newB = Clamp((int)(pixel.B * avg / avgB), 0, 255);

                    resultImage.SetPixel(i, j, Color.FromArgb(newR, newG, newB));
                }
                worker.ReportProgress(30 + (int)((float)i / sourceImage.Width * 70));
                if (worker.CancellationPending) return null;
            }

            return resultImage;
        }
    }
}