using System;
using OpenQA.Selenium;
using System.IO;

namespace SeleniumWebDriver.Utils
{
    public class Screenshotter
    {
        public void MakeScreenshot(IWebDriver driver)
        {
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(GetCurrentFullFileNameAsString(), ScreenshotImageFormat.Png);
        }

        public string CreateLocation()
        {
            string locationPath = "SeleniumScreenshots/";

            if (!Directory.Exists(locationPath))
            {
                Directory.CreateDirectory(locationPath);
            }
            return locationPath;
        }

        public string GetCurrentFullFileNameAsString()
        {
            return CreateLocation() + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".png";
        }
    }
}