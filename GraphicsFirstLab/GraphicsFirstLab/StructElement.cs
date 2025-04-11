public class StructElement
{
    public int[,] Kernel { get; private set; }
    public int Width { get; private set; }
    public int Height { get; private set; }
    public Point Anchor { get; private set; } // Центр элемента

    public StructElement(int[,] kernel, Point anchor)
    {
        Kernel = kernel;
        Width = kernel.GetLength(0);
        Height = kernel.GetLength(1);
        Anchor = anchor;
    }

    // Пример: прямоугольный элемент 3x3
    public static StructElement Rectangle3x3()
    {
        int[,] kernel = {
            {1, 1, 1},
            {1, 1, 1},
            {1, 1, 1}
        };
        return new StructElement(kernel, new Point(1, 1));
    }
}