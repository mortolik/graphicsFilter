using System;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    public class GradientFilter : Filters
    {
        private StructElement structElement;

        public GradientFilter(StructElement element)
        {
            structElement = element;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            // Не используется, так как требуется обработка всего изображения
            throw new NotImplementedException();
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            // 1. Применяем дилатацию
            var dilationFilter = new DilationFilter(structElement);
            Bitmap dilatedImage = dilationFilter.processImage(sourceImage, worker);

            if (worker.CancellationPending || dilatedImage == null)
                return null;

            // 2. Применяем эрозию
            var erosionFilter = new ErosionFilter(structElement);
            Bitmap erodedImage = erosionFilter.processImage(sourceImage, worker);

            if (worker.CancellationPending || erodedImage == null)
            {
                dilatedImage.Dispose();
                return null;
            }

            // 3. Вычисляем разницу
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / sourceImage.Width * 100));
                if (worker.CancellationPending)
                {
                    dilatedImage.Dispose();
                    erodedImage.Dispose();
                    return null;
                }

                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color dilated = dilatedImage.GetPixel(i, j);
                    Color eroded = erodedImage.GetPixel(i, j);

                    int r = Clamp(dilated.R - eroded.R, 0, 255);
                    int g = Clamp(dilated.G - eroded.G, 0, 255);
                    int b = Clamp(dilated.B - eroded.B, 0, 255);

                    resultImage.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            dilatedImage.Dispose();
            erodedImage.Dispose();
            return resultImage;
        }
    }
}