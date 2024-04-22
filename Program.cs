using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var options = new EdgeOptions() { ImplicitWaitTimeout = TimeSpan.FromSeconds(5) };
            var driver = new EdgeDriver(options);
            driver.Url = "https://google.com";
            driver.FindElement(By.Id("W0wltc")).Click();
            driver.FindElements(By.Name("btnI")).Last().Click();
            driver.ExecuteAsyncScript    
                
                
                
                
                }
    }
}
