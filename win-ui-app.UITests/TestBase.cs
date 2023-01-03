using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace win_ui_app.UITests
{
    public class TestBase
    {
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        // TODO: Find another way to store and specify this .exe file path, or we need to replace this for each local env
        private const string AppId = @"D:\My Repos\win-ui-app\win-ui-app\bin\x86\Debug\net6.0-windows10.0.19041.0\win10-x86\win-ui-app.exe";

        protected static WindowsDriver<WindowsElement> session = null;

        public static void Setup(TestContext context)
        {
            if (session == null)
            {
                var appiumOptions = new AppiumOptions();
                appiumOptions.AddAdditionalCapability("app", AppId);
                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appiumOptions);

            }
            Thread.Sleep(3000);
            session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void TearDown()
        {
            if (session != null)
            {
                session.Quit();
                session = null;
            }
        }
    }
}
