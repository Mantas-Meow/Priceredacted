using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Priceredacted.Tesseract_Ocr
{
    class ImagePreProcessing
    {
        public Bitmap ResizeImage(Bitmap image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }

        public Bitmap AdaptiveBinarization(string imageSavePath, int sizeOfNbPixels, int subFromMean)
        {
            Mat img = CvInvoke.Imread(imageSavePath, 0);

            Mat output = new Mat();
            CvInvoke.AdaptiveThreshold(img, output, 255,
                AdaptiveThresholdType.GaussianC, ThresholdType.Binary, sizeOfNbPixels, subFromMean);

            CvInvoke.Imshow("src", img);
            CvInvoke.Imshow("Gaussian", output);

            Bitmap newMap = output.ToBitmap();
            newMap.Save("./Tesseract Ocr/testImage111.png");
            return newMap;
        }

        public Bitmap SetBlackWhite(Bitmap img)
        {

            Bitmap temp = (Bitmap)img;
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            float avgDarkness = 100;

            /*for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    avgDarkness += (float)(c.R * 0.299 + c.G * 0.578 + c.B * 0.114);
                }
            }
            avgDarkness /= (bmap.Width * bmap.Height);*/

            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    //int color = (int)(c.R + c.G  + c.B);
                    int color = (int)(c.R * 0.299 + c.G * 0.578 + c.B * 0.114);

                    if (color > avgDarkness)
                    {
                        color = 255;
                    }
                    else
                    {
                        color = 0;
                    }
                    bmap.SetPixel(i, j, Color.FromArgb(color, color, color));
                }
            }
            return (Bitmap)bmap.Clone();

        }
        public Bitmap SetContrast(Bitmap original, int value)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            Graphics g = Graphics.FromImage(newBitmap);
            float F = (259 * (value + 255)) / (255 * (259 - value));

            /*
                R' = F(R - 0.5f) + 0.5f
                R' = FR + (-0.5f * F + 0.5f)
                q = (-0.5f * F + 0.5f)
            */

            float q = (-0.5f * F + 0.5f);


            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                     new float[] {F, 0, 0, 0, 0},
                     new float[] {0, F, 0, 0, 0},
                     new float[] {0, 0, F, 0, 0},
                     new float[] {0, 0, 0, 1, 0},
                     new float[] {q, q, q, 0, 1}
               });

            ImageAttributes attributes = new ImageAttributes();

            attributes.SetColorMatrix(colorMatrix);

            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            g.Dispose();
            return newBitmap;
        }
        public Bitmap SetGrayscale(Bitmap original)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            Graphics g = Graphics.FromImage(newBitmap);

            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                     new float[] { .3f,  .3f,  .3f, 0, 0},
                     new float[] {.59f, .59f, .59f, 0, 0},
                     new float[] {.11f, .11f, .11f, 0, 0},
                     new float[] {   0,    0,    0, 1, 0},
                     new float[] {   0,    0,    0, 0, 1}
               });

            ImageAttributes attributes = new ImageAttributes();

            attributes.SetColorMatrix(colorMatrix);

            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            g.Dispose();
            return newBitmap;
        }
        public Bitmap InvertColors(Bitmap original)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            Graphics g = Graphics.FromImage(newBitmap);

            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                     new float[] {-1, 0, 0, 0, 0},
                     new float[] {0, -1, 0, 0, 0},
                     new float[] {0, 0, -1, 0, 0},
                     new float[] {0, 0, 0, 1, 0},
                     new float[] {1, 1, 1, 0, 1}
               });

            ImageAttributes attributes = new ImageAttributes();

            attributes.SetColorMatrix(colorMatrix);

            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            g.Dispose();
            return newBitmap;
        }
    }
}
