using System;
using System.Collections.Generic;
using System.Text;
using Tesseract;

namespace Priceredacted.Tesseract_Ocr
{
    static class ImageRecognition
    {
        static string GetTextFromImage(string imagePath)
        {
            string text = null;
            try
            {
                var image = imagePath;
                var img = Pix.LoadFromFile(image);

                TesseractEngine engine = new TesseractEngine("./tessdata", "lit", EngineMode.Default);


                Page page = engine.Process(img, PageSegMode.Auto);
                text = page.GetText();
            }
            catch (Exception)
            {
                throw new System.InvalidOperationException("file doesn't exist");
            }
            return text;
        }
    }
}
