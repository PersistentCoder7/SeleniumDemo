using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    public class HTMLElementTester
    {
        public HTMLElementTester(IWebDriver driver)
        {
            Driver = driver;
        }

        public void TestInputTextField()
        {
            Driver.Navigate().GoToUrl("https://testing.todorvachev.com/special-elements/text-input-field/");
            var element = Driver.FindElement(By.Name("username"));
            element.SendKeys("Somebody is quite happy....");
            Console.WriteLine(element.GetAttribute("value"));
            Console.WriteLine(element.GetAttribute("maxlength"));
        }
        public void TestCheckboxField()
        {
            Driver.Navigate().GoToUrl("https://testing.todorvachev.com/special-elements/check-button-test-3/");
            var element = Driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(3)"));
            //var elements = Driver.FindElements(By.Name())
            //element.Click();
            if (element.GetAttribute("checked")=="true")
            {
                Console.WriteLine("The checkbox is checked");
            }
            Thread.Sleep(2000);
        }

        public void TestAlert()
        {
            Driver.Navigate().GoToUrl("https://testing.todorvachev.com/special-elements/alert-box/");
            var alert = Driver.SwitchTo().Alert();
            Thread.Sleep(3000);
            Console.WriteLine(alert.Text);
            alert.Accept();
            
        }

        public void TestDropDown()
        {
            Driver.Navigate().GoToUrl("https://testing.todorvachev.com/special-elements/drop-down-menu-test/");
            var element = Driver.FindElement(By.Name("DropDownTest")) as SelectElement;
            //element.FindElements()
            Console.WriteLine(element.SelectedOption.Text);
            foreach (var item in element.Options)
            {
                Console.WriteLine(item.Text);
            }
        }

        public void TestRadioButton()
        {
            Driver.Navigate().GoToUrl("https://testing.todorvachev.com/special-elements/radio-button-test/");
            var elements = Driver.FindElements(By.Name("gender"));
            foreach (var item in elements)
            {
                Console.WriteLine("{0}, {1}",item.GetAttribute("value"),item.GetAttribute("checked") );
            }

        }
        public IWebDriver Driver { get; }
    }
}
