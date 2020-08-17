using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    public class ClassSelector
    {
        public ClassSelector(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public void Test()
        {
            WebDriver.Navigate().GoToUrl("https://testing.todorvachev.com/selectors/class-name/");
            var element = WebDriver.FindElement(By.ClassName("testClass"));
            if (element.Displayed)
            {
                Console.WriteLine(element.Text);
            }
        }
        public IWebDriver WebDriver { get; }
    }
}
