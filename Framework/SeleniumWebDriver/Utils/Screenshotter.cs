using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.IO;

namespace SeleniumWebDriver.Utils
{
    public class Screenshotter
    {
        public void MakeScreenshot(IWebDriver driver)
        {
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(GetCurrentTimeAsString(), ScreenshotImageFormat.Png);
        }

        public string CreateLocation()
        {
            string saveLocation = "SeleniumScreenshots/";

            if (!Directory.Exists(saveLocation))
            {
                Directory.CreateDirectory(saveLocation);
            }
            return saveLocation;
        }

        public string GetCurrentTimeAsString()
        {
            return CreateLocation() + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".png";
        }
    }
}