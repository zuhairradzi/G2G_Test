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
    class Program
    {
        static void Main(string[] args)
        {
            /*DriverEngine.GoToWebsite(URLLoader.LoadHomepage());

            Login.VerifyHomepage();
            General.GoToLoginPage();
            Login.LoginFlow();
            Login.VerifyLogin();*/

            DriverEngine.GoToWebsite("https://mail.google.com/mail/u/0/");
            Email.LoginGmail();
            Console.WriteLine("pin:"+Email.GetDevicePin());
        }
    }
}
