namespace Filters
{
    class SharpnessFilter : MatrixFilter
    {
        public SharpnessFilter()
        {
            kernel = new float[3, 3] {
                { 0, -1, 0 },
                { -1, 5, -1 },
                { 0, -1, 0 }
            };
        }
    }
}