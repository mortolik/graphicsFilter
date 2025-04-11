using Filters;

public class DilationFilter : MorphologyFilter
{
    public DilationFilter(StructElement se) : base(se) { }

    protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
        int maxR = 0, maxG = 0, maxB = 0;

        for (int i = 0; i < structElement.Width; i++)
        {
            for (int j = 0; j < structElement.Height; j++)
            {
                if (structElement.Kernel[i, j] == 1)
                {
                    int idX = x + i - structElement.Anchor.X;
                    int idY = y + j - structElement.Anchor.Y;

                    if (idX >= 0 && idX < sourceImage.Width &&
                        idY >= 0 && idY < sourceImage.Height)
                    {
                        Color pixel = sourceImage.GetPixel(idX, idY);
                        maxR = Math.Max(maxR, pixel.R);
                        maxG = Math.Max(maxG, pixel.G);
                        maxB = Math.Max(maxB, pixel.B);
                    }
                }
            }
        }

        return Color.FromArgb(maxR, maxG, maxB);
    }
}