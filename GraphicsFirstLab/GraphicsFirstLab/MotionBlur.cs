using System;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    class MotionBlur : MatrixFilter
    {
        public MotionBlur(int size = 6)
        {
            // Создаем диагональное ядро для эффекта размытия в движении
            kernel = new float[size, size];

            // Заполняем диагональ значениями 1/size
            for (int i = 0; i < size; i++)
            {
                kernel[i, i] = 1.0f / size;
            }
        }
    }
}