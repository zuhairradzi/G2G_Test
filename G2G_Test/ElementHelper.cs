using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Xml;
using System.IO;
using NUnit;
using NUnit.Framework;
using System.Threading;

namespace G2G_Test
{
    class ElementHelper
    {
        
        public static void ElementIsDisplayed(string xpath)
        {
            bool elemDisplayed = true;
            elemDisplayed = DriverEngine.driver.FindElement(By.XPath(xpath)).Displayed;
            Assert.That(elemDisplayed.Equals(true));
        }

        public static void VerifyElementTextMatches(string xpath, string expectedText)
        {
            string elemText = "";
            elemText= DriverEngine.driver.FindElement(By.XPath(xpath)).Text.Trim();
            Assert.That(elemText.Equals(expectedText));
        }
        public static void VerifyElementTextContains(string xpath, string expectedText)
        {
            string elemText = "";
            elemText = DriverEngine.driver.FindElement(By.XPath(xpath)).Text.Trim();
            Assert.That(elemText.Contains(expectedText));
        }
        public static int GetNumberOfElements(string xpath)
        {
            int elemCount = 0;
            elemCount = DriverEngine.driver.FindElements(By.XPath(xpath)).Count;   
            return elemCount;
        }

        public static void ClickIfExist(string xpath)
        {
            int elemCount = 0;
            elemCount = DriverEngine.driver.FindElements(By.XPath(xpath)).Count;
            if (elemCount > 0)
            {
                DriverEngine.driver.FindElement(By.XPath(xpath)).Click();
            }
        }
        public static void VerifyURL(string expectedURL)
        {
            string currentURL = DriverEngine.driver.Url;
            Assert.That(currentURL.Contains(expectedURL));
        }

        public static void ClickElementInIndex(string xpath, int index)
        {
            int elemCount = 0;
            elemCount = DriverEngine.driver.FindElements(By.XPath(xpath)).Count;
            if (elemCount > 0)
            {
                DriverEngine.driver.FindElement(By.XPath(xpath)).Click();
            }
        }
    }
}
