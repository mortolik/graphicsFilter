using System.ComponentModel;

namespace Filters
{
    public class OpeningFilter : Filters
    {
        private StructElement structElement;

        public OpeningFilter(StructElement se)
        {
            structElement = se;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            throw new NotImplementedException("Opening requires full image processing");
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            // Эрозия -> Дилатация
            Bitmap eroded = new ErosionFilter(structElement).processImage(sourceImage, worker);
            Bitmap result = new DilationFilter(structElement).processImage(eroded, worker);
            eroded.Dispose();
            return result;
        }
    }
}