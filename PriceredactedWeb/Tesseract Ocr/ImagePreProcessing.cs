using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
using System.Text;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

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

        public void ProcessImageWithEMGU(Bitmap original)
        {
            string path = "D:/PhotosOfPreProcessing/";
            //Image<Bgr, byte> img = new Image<Bgr, byte>(filename);

            //int x = 299, y = -5; //x = 3, 5, 7, 9
                Mat mainImg;
                mainImg = CvInvoke.Imread("./Tesseract Ocr/testImage11.png", 0);


                //------------ Adaptive Binarization ---------------
                Mat binImage = new Mat();
                CvInvoke.AdaptiveThreshold(mainImg, binImage, 255,
                    AdaptiveThresholdType.GaussianC, ThresholdType.Binary, 221, 11); //11, 5

                //binImage.Save(path + "1_AdaptBinImage.png");


                //------------ Gradient Image ---------------
                Mat image = new Mat();
                CvInvoke.GaussianBlur(mainImg, image, new Size(3, 3), 0, 0, BorderType.Default);

                Mat grad_x = new Mat(), grad_y = new Mat();

                CvInvoke.Sobel(image, grad_x, DepthType.Cv8U, 1, 0, 3, 1, 0, BorderType.Default); //x - gradient image
                CvInvoke.Sobel(image, grad_y, DepthType.Cv8U, 0, 1, 3, 1, 0, BorderType.Default); //y - gradient image

                Mat img;
                img = grad_x + grad_y; // combined gradient image

                //img.Save(path + "2_GradientImage.png");

                //------------ Otsu Binarization ---------------
                Mat otsuImage = new Mat();
                CvInvoke.Threshold(img, otsuImage, 0, 255, ThresholdType.Binary | ThresholdType.Otsu);
                //otsuImage.Save(path + "3_OtsuImage.png");

                Mat dialImage = new Mat();

                Mat element = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));

                CvInvoke.Dilate(otsuImage, dialImage, element, new Point(-1, -1),
                    3, BorderType.Default, new MCvScalar(255, 255, 255));
                //dialImage.Save(path + "4_DialationImage.png");
                //CvInvoke.GaussianBlur(otsuImage, blurImage, new Size(3, 3), 0, 0, BorderType.Default);

                //------------ Merge Images ---------------
                Image<Bgr, byte> binImg = binImage.ToImage<Bgr, byte>();
                Image<Bgr, byte> dialImg = dialImage.ToImage<Bgr, byte>();
                Image<Bgr, byte> mergedImage = dialImage.ToImage<Bgr, byte>();

                for (int v = 0; v < binImage.Height; v++)
                {
                    for (int u = 0; u < binImage.Width; u++)
                    {
                        int a0 = binImg.Data[v, u, 0]; //Get Pixel Color | fast way
                        int a1 = binImg.Data[v, u, 1];
                        int a2 = binImg.Data[v, u, 2];

                        a0 = 255 - a0;
                        a1 = 255 - a1;
                        a2 = 255 - a2;

                        int b0 = dialImg.Data[v, u, 0];
                        int b1 = dialImg.Data[v, u, 1];
                        int b2 = dialImg.Data[v, u, 2];

                        mergedImage.Data[v, u, 0] = (byte)(255 - (a0 & b0));
                        mergedImage.Data[v, u, 1] = (byte)(255 - (a1 & b1));
                        mergedImage.Data[v, u, 2] = (byte)(255 - (a2 & b2));
                    }
                }

                //CvInvoke.GaussianBlur(mergedImage, mergedImage, new Size(3, 3), 0, 0, BorderType.Default);
                Bitmap contrast = SetContrast(mergedImage.ToBitmap(), 128);
                //Bitmap contrast = ResizeImage(mergedImage.ToBitmap(), mergedImage.Width * 3, mergedImage.Height * 2);

                //CvInvoke.FindContours()
                //Mat cannyImage = new Mat();
                //CvInvoke.Canny(image, cannyImage, 50, 150);
                //cannyImage.Save(path + "6_.png");

                //var contours = new VectorOfVectorOfPoint();
                //CvInvoke.FindContours(cannyImage, contours, null, RetrType.Tree, ChainApproxMethod.ChainApproxSimple);

                contrast.Save("./Tesseract Ocr/testImage11.png");
                //contrast.Save(path + "b" + x + "_" + y + "_lastImage.png");
            
        }

        public Mat detectLetters(Mat img)
        {
            List<Rectangle> rects = new List<Rectangle>();
            //Image<Gray, Single> img_sobel;
            //Image<Gray, Byte> img_gray, img_threshold;
            //img_gray = img.Convert<Gray, Byte>();
            //img_sobel = img_gray.Sobel(1, 0, 3);
            //img_threshold = new Image<Gray, byte>(img_sobel.Size);
            //CvInvoke.cvThreshold(img_sobel.Convert<Gray, Byte>(), img_threshold, 0, 255, Emgu.CV.CvEnum.THRESH.CV_THRESH_OTSU);
            Mat newMat = new Mat();
            Mat element = CvInvoke.GetStructuringElement(ElementShape.Rectangle,new Size(3, 17), new Point(1, 6));
            CvInvoke.MorphologyEx(img, newMat, MorphOp.Close, element, new Point(-1, -1), 1, BorderType.Default, new MCvScalar());
            //Mat cont = new Mat();
            VectorOfVectorOfPoint cont = new VectorOfVectorOfPoint();
            Mat hierarchy = new Mat();

            CvInvoke.FindContours(newMat, cont, hierarchy, RetrType.Ccomp, ChainApproxMethod.ChainApproxSimple);

            /*for (Contour<Point> contours = CvInvoke.FindContours(; contours != null; contours = contours.HNext)
            {
                if (contours.Area > 100)
                {
                    Contour<Point> contours_poly = contours.ApproxPoly(3);
                    rects.Add(new Rectangle(contours_poly.BoundingRectangle.X, contours_poly.BoundingRectangle.Y, contours_poly.BoundingRectangle.Width, contours_poly.BoundingRectangle.Height));
                }
            }*/
            /*int contCount = cont.Size;
            for (int i = 0; i < contCount; i++)
            {
                using (VectorOfPoint contour = cont[i])
                {
                    segmentRectangles.Add(CvInvoke.BoundingRectangle(contour));
                    if (debug)
                    {
                        finalCopy.Draw(CvInvoke.BoundingRectangle(contour), new Rgb(255, 0, 0), 5);
                    }
                }
            }*/
            return hierarchy;
        }

        public Bitmap SetBlackWhite(Bitmap img)
        {

            Bitmap temp = (Bitmap)img;
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            float avgDarkness = 110;

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
