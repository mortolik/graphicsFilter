using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    class BrightnessFilter : Filters
    {
        private int brightness = 50; // Значение регулировки яркости

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color color = sourceImage.GetPixel(x, y);
            return Color.FromArgb(
                Clamp(color.R + brightness, 0, 255),
                Clamp(color.G + brightness, 0, 255),
                Clamp(color.B + brightness, 0, 255)
            );
        }
    }
}
