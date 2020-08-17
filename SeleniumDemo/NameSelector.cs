using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    public class NameSelector
    {
        public NameSelector(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        public void Test()
        {
            Driver.Navigate().GoToUrl("https://testing.todorvachev.com/selectors/name/");
            var element = Driver.FindElement(By.Name("myName"));
            if (element.Displayed)
            {
                Console.WriteLine("I am able to see the element in the webpage");
                element.SendKeys("Hello there");
            }

        }
    }
}
