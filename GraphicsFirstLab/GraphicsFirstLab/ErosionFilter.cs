using Filters;

public class ErosionFilter : MorphologyFilter
{
    public ErosionFilter(StructElement se) : base(se) { }

    protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
        int minR = 255, minG = 255, minB = 255;

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
                        minR = Math.Min(minR, pixel.R);
                        minG = Math.Min(minG, pixel.G);
                        minB = Math.Min(minB, pixel.B);
                    }
                }
            }
        }

        return Color.FromArgb(minR, minG, minB);
    }
}