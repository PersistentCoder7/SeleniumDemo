using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    public class IDSelector
    {
        public IDSelector(IWebDriver driver)
        {
            Driver = driver;
        }

        public void Test()
        {
            Driver.Navigate().GoToUrl("https://testing.todorvachev.com/selectors/id/");
            var element = Driver.FindElement(By.Id("testImage"));
            if (element.Displayed)
            {
                Console.WriteLine("We were able to find an element by id");


            }
        }
        public IWebDriver Driver { get; }
    }
}
