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
    class General
    {

        public static void GoToLoginPage()
        {
            DriverEngine.driver.FindElement(By.XPath("//header//span[contains(text(),'Login')]")).Click();
        }
    }
}
