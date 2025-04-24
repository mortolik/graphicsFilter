using System.ComponentModel;

namespace Filters
{
    public class ClosingFilter : Filters
    {
        private StructElement structElement;

        public ClosingFilter(StructElement se)
        {
            structElement = se;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            throw new NotImplementedException("Closing requires full image processing");
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap dilated = new DilationFilter(structElement).processImage(sourceImage, worker);
            Bitmap result = new ErosionFilter(structElement).processImage(dilated, worker);
            dilated.Dispose();
            return result;
        }
    }
}