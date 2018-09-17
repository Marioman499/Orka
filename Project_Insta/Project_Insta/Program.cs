using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Project_Insta
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebElement username;
            IWebElement password;
            


            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.instagram.com/accounts/login/?source=auth_switcher");
            for (int i = 0; i < 10; i++)
            {
                
               
                IWebElement element = driver.FindElement(By.TagName("body"));
                element.SendKeys(OpenQA.Selenium.Keys.Control + "t");

            }




        }
    }
}
