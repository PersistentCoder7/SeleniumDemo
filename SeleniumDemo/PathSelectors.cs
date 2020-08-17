using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    public class PathSelectors
    {
        public PathSelectors(IWebDriver driver)
        {
            Driver = driver;
        }

        public void Test()
        {
            var CSSPath = @"#post-108 > div > figure > img";
            var XPath = "//*[@id=\"post-108\"]/div/figure/img";
            var SiteUrl = "https://testing.todorvachev.com/selectors/css-path/";

            Driver.Navigate().GoToUrl(SiteUrl);
            var xp= Driver.FindElement(By.XPath(XPath));
            var cp = Driver.FindElement(By.CssSelector(CSSPath));

            if (xp.Displayed)
            {
                Console.WriteLine("Xpath element found!");
            }
            if (xp.Displayed)
            {
                Console.WriteLine("CSS Selector element found!");
            }
            

        }
        public IWebDriver Driver { get; }
    }
}
