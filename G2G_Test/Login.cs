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
    class Login
    {
        public static void LoginFlow()
        {
            //verify login page

            Thread.Sleep(4000);
            ElementHelper.VerifyElementTextContains("//h2", "LOGIN SHASSO ACCOUNT");
            //enter email n pw
            DriverEngine.driver.FindElement(By.XPath("//input[@name='LoginForm[customers_email_address]']")).SendKeys(Secure.Decrypt(Username()));
            DriverEngine.driver.FindElement(By.XPath("//input[@name='LoginForm[customers_password]']")).SendKeys(Secure.Decrypt(PassW()));

            //click login btn
            DriverEngine.driver.FindElement(By.XPath("//button[text()='Login']")).Click();
        }

        public static void VerifyLogin()
        {
            //verify profile logged in

            Thread.Sleep(4000);
            DriverEngine.driver.FindElement(By.XPath("//div[contains(@class,'q-avatar bg-red-9')]//span']")).Click();
            ElementHelper.VerifyElementTextContains("//a[contains(@href,'g2g')]//span[@class='block'][text()='ErenYeager10']", "ErenYeager10");
            
        }

        public static void VerifyHomepage()
        {
            Thread.Sleep(4000);
            //verify homepage
            ElementHelper.VerifyElementTextContains("//div[contains(text(),'Trending Games')]", "Trending Games");
        }

        public static string Username()
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string str = "test";
            FileStream fs = new FileStream("LoginDet.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("email");
            for (i = 0; i <= xmlnode.Count - 1; i++)
            {
                str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                Console.WriteLine(str);
            }
            return str;
        }
        public static string PassW()
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string str = "test";
            FileStream fs = new FileStream("LoginDet.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("maskedPW");
            for (i = 0; i <= xmlnode.Count - 1; i++)
            {
                str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                Console.WriteLine(str);
            }
            return str;
        }
    }
}
