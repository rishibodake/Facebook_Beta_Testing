﻿namespace Facebook_beta_testing.FactoryPattern
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    public class BrowserFactory
    {   
        IWebDriver driver;
        public IWebDriver InitBrowser(string browser)
        {
            switch (browser)
            {
                case "chrome":
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--disable-notifications");
                    driver = new ChromeDriver(chromeOptions);                                        
                    break;                    
                case "firefox":
                    FirefoxOptions firefoxOptions = new FirefoxOptions();                    
                    firefoxOptions.SetPreference("dom.webnotifications.enabled", false);
                    driver = new FirefoxDriver(firefoxOptions);                                   
                    break;
            }           
            return driver;
        }
    }
}
