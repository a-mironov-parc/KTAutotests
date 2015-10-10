using KeepTeamAutotests.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageMagick;
using KeepTeamAutotests.Pages;

namespace KeepTeamAutotests.AppLogic
{
    public class ImageHelper
    {
        private AppManager app;
        private PageManager pages;
        public ImageHelper(AppManager app)
            
        {
            this.app = app;
            this.pages = app.Pages;
        }

        

        public MagickImage readImage(string FilePath)
        {
            MagickImage image = new MagickImage(FilePath);
            return image;

        }

        public void saveResult(string FilePath1, string FilePath2, string outFilePath)
        {
            MagickImageCollection images = new MagickImageCollection();
            // Add the first image
            MagickImage first = new MagickImage(FilePath1);
          

         //   images.Add(first);

            // Add the second image
            MagickImage second = new MagickImage(FilePath2);
           // images.Add(second);

            
            /*
            first.Composite(second, 0, 0, CompositeOperator.ModulusAdd);
            first.Write(outFilePath + "compos.png");

            */
            MagickImage third = new MagickImage();
            first.Compare(second, ErrorMetric.Absolute, third);
            third.Write(outFilePath + "third.bmp");
            



        }

    }
}
