using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Tesseract;

namespace Priceredacted.Tesseract_Ocr
{
    static class ImageRecognition
    {
        public static string GetTextFromImage(string imagePath)
        {
            string text;
            try
            {
                Bitmap tempImage = new Bitmap(imagePath);

                string imageSavePath = "./Tesseract Ocr/testImage11.png";

                // improving image quality
                ProcessImage(tempImage, imageSavePath);



                var imga = Pix.LoadFromFile(imageSavePath);

                // read text from the image
                TesseractEngine engine = new TesseractEngine("./Tesseract Ocr/tessdata", "lit", EngineMode.Default);
                //engine.SetVariable("load_system_dawg", false);
                //engine.SetVariable("load_freq_dawg", false);


                Page page = engine.Process(imga, PageSegMode.Auto);
                //File.Delete(imageSavePath);
                text = page.GetText();
            }
            catch (Exception)
            {
                return null;
            }
            return text;
        }

        private static void ProcessImage(Bitmap img, string imageSavePath)
        {
            ImagePreProcessing proccessImage = new ImagePreProcessing();
            img = proccessImage.ResizeImage(img, img.Width * 3, img.Height * 2);
            //img = proccessImage.SetContrast(img, 128);
            //img = proccessImage.SetGrayscale(img);
            //img = proccessImage.SetBlackWhite(img);

            img.Save(imageSavePath);
        }
    }
}
