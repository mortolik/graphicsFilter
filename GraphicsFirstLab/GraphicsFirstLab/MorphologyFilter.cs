namespace Filters
{
    public abstract class MorphologyFilter : Filters
    {
        protected StructElement structElement;

        public MorphologyFilter(StructElement se)
        {
            structElement = se;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            // Реализуется в наследниках
            throw new NotImplementedException();
        }
    }
}