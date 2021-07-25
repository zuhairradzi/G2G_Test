using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Xml;
using System.IO;
using NUnit;
using NUnit.Framework;
using System.Threading;
using System.Collections.Generic;

namespace G2G_Test
{
    class Email
    {
        public static void LoginGmail()
        {
            
             DriverEngine.driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("zuhairtest120@gmail.com");
            
            DriverEngine.driver.FindElement(By.XPath("//span[text()='Next']")).Click();

            Thread.Sleep(4000);

            DriverEngine.driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("Hello@123TEST");


            DriverEngine.driver.FindElement(By.XPath("//span[text()='Next']")).Click();
            Thread.Sleep(4000);
            ElementHelper.ClickIfExist("//span[text()='Not now']");

            ElementHelper.ClickIfExist("//span[text()='Confirm']");
            Thread.Sleep(4000);
            ElementHelper.VerifyURL("https://mail.google.com/mail/u/0");
        }

        public static string GetDevicePin()
        {
            

            DriverEngine.driver.FindElement(By.XPath("//input[@placeholder='Search mail']")).SendKeys("Device pin");
            DriverEngine.driver.FindElement(By.XPath("//input[@placeholder='Search mail']")).SendKeys(Keys.Enter);

            DriverEngine.driver.FindElement(By.XPath("//div[@class='yW']//span[contains(text(),'Shasso Team')][@name='Shasso Team']")).Click();

            Thread.Sleep(4000);
            string pin = DriverEngine.driver.FindElement(By.XPath("//div[@class='a3s aiL ']//span")).Text;
            DriverEngine.driver.Navigate().Back();

            Thread.Sleep(4000);

            DriverEngine.driver.FindElement(By.XPath("//span[@role='checkbox'][1]")).Click();


            Thread.Sleep(2000);
            DriverEngine.driver.FindElement(By.XPath("//div[@data-tooltip='Delete']")).Click();

            Thread.Sleep(4000);
            return pin;
            
        }
    }
}
