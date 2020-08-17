using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://testing.todorvachev.com");
            
            Thread.Sleep(3000);
            //TestUsingNameSelector(driver);
            //TestUsingIDSelector(driver);
            //TestUsingClassName(driver);
            //TestingUsingPathSelectors(driver);
            HTMLElementTester(driver);
            Thread.Sleep(3000);
            driver.Quit();
        }

        static void HTMLElementTester(IWebDriver driver)
        {
            var htmlElementTester = new HTMLElementTester(driver);
            //htmlElementTester.TestInputTextField();
            //htmlElementTester.TestCheckboxField();
            //htmlElementTester.TestRadioButton();
            //htmlElementTester.TestDropDown();
            htmlElementTester.TestAlert();
        }

        static void TestingUsingPathSelectors(IWebDriver driver)
        {
            var pathSelector = new PathSelectors(driver);
            pathSelector.Test();
        }
        static void TestUsingClassName(IWebDriver driver)
        {
            var classNameSelector = new ClassSelector(driver);
            classNameSelector.Test();
        }

        static void TestUsingNameSelector(IWebDriver driver)
        {
            var nameSelector = new NameSelector(driver);
            nameSelector.Test();
        }

        static void TestUsingIDSelector(IWebDriver driver)
        {
            var idSelector = new IDSelector(driver);
            idSelector.Test();
        }
    }
}
