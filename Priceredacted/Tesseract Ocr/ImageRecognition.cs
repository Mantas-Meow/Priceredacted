using System;
using System.Collections.Generic;
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
                var img = Pix.LoadFromFile(image);

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
