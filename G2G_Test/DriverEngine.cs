using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Xml;
using System.IO;
using NUnit;
using NUnit.Framework;


namespace G2G_Test
{
    class DriverEngine
    {
        public static IWebDriver driver = new ChromeDriver();
       
        public static void GoToWebsite(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }
    }

    class URLLoader
    {
        public static string LoadHomepage()
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string str = "test";
            FileStream fs = new FileStream("Data.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("url");
            for (i = 0; i <= xmlnode.Count - 1; i++)
            {
                str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                Console.WriteLine(str);
            }
            return str;
        }
    }
}
