using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using Tesseract;

namespace Priceredacted.Tesseract_Ocr
{
    class ImageRecognition
    {
        public static string GetTextFromImage(string imagePath)
        {
            string text = null;
            try
            {
                var image = imagePath;
                Bitmap tempImage = (Bitmap)Image.FromFile(imagePath);
                
                string imageSavePath = "./Tesseract Ocr/testImage.png";


                // improving image quality
                tempImage = ProcessImage(tempImage);


                tempImage.Save(imageSavePath);

                var img = Pix.LoadFromFile(imageSavePath);

                // read text from the image
                TesseractEngine engine = new TesseractEngine("./Tesseract Ocr/tessdata", "lit", EngineMode.Default);

                Page page = engine.Process(img, PageSegMode.Auto);
                text = page.GetText();
            }
            catch (Exception)
            {
                text = null;
                //throw new System.InvalidOperationException("file doesn't exist");
            }
            return text;
        }

        private static Bitmap ProcessImage(Bitmap img)
        {
            img = SetContrast(img, 128);
            return img;
        }

        private static Bitmap SetContrast(Bitmap original, int value)
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
    }
}
