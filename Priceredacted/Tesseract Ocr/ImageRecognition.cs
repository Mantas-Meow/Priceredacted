using System;
using System.Collections.Generic;
using System.Drawing;
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
                Bitmap newImage = (Bitmap)Image.FromFile(imagePath);
                
                string testImagePath = "./Tesseract Ocr/testImage.png";

                
                // - improving image quality

                newImage.Save(testImagePath);

                var img = Pix.LoadFromFile(testImagePath);

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
    }
}
