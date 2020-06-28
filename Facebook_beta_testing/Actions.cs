﻿using OpenQA.Selenium;
using System.Diagnostics;
using System.Threading;

namespace Facebook_beta_testing
{
    public static class Actions
    {
        public static void Login(IWebDriver driver)
        {
            LoginPage page = new LoginPage(driver);
            UserData data = new UserData();

            page.Email.SendKeys(data.email);
            page.Password.SendKeys(data.password);
            page.Login.Click();
            Thread.Sleep(1000);
        }

        public static void Upload(IWebDriver driver)
        {
            HomePage upload = new HomePage(driver);
            UserData data = new UserData();
            upload.WriteSomethingBox.Click();
            Thread.Sleep(500);
            upload.WriteSomethingBox.SendKeys("New Change Script");
            Thread.Sleep(500);

            upload.DropPhotos.Click();
            Thread.Sleep(5000);
            Process.Start(data.AutoIt_Path);
            Thread.Sleep(10000);
            upload.PostButton.Click();
            Thread.Sleep(10000);
        }

        public static void Logout(IWebDriver driver)
        {
            HomePage logout = new HomePage(driver);
            logout.AccountSettings.Click();
            Thread.Sleep(1000);
            logout.LogoutButton.Click();

        }
    }
}
