using Filters;
using System.ComponentModel;

namespace Filters
{ 
public class TopHatFilter : Filters
{
    private StructElement structElement;

    public TopHatFilter(StructElement se)
    {
        structElement = se;
    }

    protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
        throw new NotImplementedException();
    }

    public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
    {
        // 1. Применяем открытие (эрозия + дилатация)
        var openingFilter = new OpeningFilter(structElement);
        Bitmap openedImage = openingFilter.processImage(sourceImage, worker);

        // 2. Вычисляем разницу с нормализацией
        Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

        // Найдем минимальное и максимальное значения для нормализации
        int minDiff = 255, maxDiff = 0;
        int[,] diffs = new int[sourceImage.Width, sourceImage.Height];

        // Первый проход: вычисляем разницы и находим диапазон
        for (int x = 0; x < sourceImage.Width; x++)
        {
            worker.ReportProgress((int)((float)x / sourceImage.Width * 50)); // 50% прогресса

            for (int y = 0; y < sourceImage.Height; y++)
            {
                Color orig = sourceImage.GetPixel(x, y);
                Color opened = openedImage.GetPixel(x, y);

                int diff = (orig.R + orig.G + orig.B) - (opened.R + opened.G + opened.B);
                diffs[x, y] = diff;

                if (diff < minDiff) minDiff = diff;
                if (diff > maxDiff) maxDiff = diff;
            }
        }

        // Второй проход: нормализуем и применяем
        int range = maxDiff - minDiff;
        if (range == 0) range = 1; // Защита от деления на 0

        for (int x = 0; x < sourceImage.Width; x++)
        {
            worker.ReportProgress(50 + (int)((float)x / sourceImage.Width * 50)); // 50-100% прогресса

            for (int y = 0; y < sourceImage.Height; y++)
            {
                int normalized = 255 * (diffs[x, y] - minDiff) / range;
                resultImage.SetPixel(x, y, Color.FromArgb(normalized, normalized, normalized));
            }
        }

        openedImage.Dispose();
        return resultImage;
    }
}
}