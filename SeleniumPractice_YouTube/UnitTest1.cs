using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumPractice_YouTube
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Opening Chrome Browser to www.guidgenerator.com
            IWebDriver driver = new ChromeDriver(@"C:\Users\Harvey.Sembhy\Desktop\Harvey\Automation Practice\Selenium Practice YouTube\SeleniumPractice_YouTube\SeleniumPractice_YouTube\bin\Debug\netcoreapp2.0");
            driver.Navigate().GoToUrl("https://www.guidgenerator.com/");

            //driver.FindElement(By.Id("txtCount")).Clear();
            //driver.FindElement(By.Id("txtCount")).SendKeys("3");
            //driver.FindElement(By.Id("btnGenerate")).Click();

            // Defining elements by name so you can write separate operations for each
            IWebElement textBox = driver.FindElement(By.Id("txtCount"));
            IWebElement genButton = driver.FindElement(By.Id("btnGenerate"));

            // Performing the operations from the elements defined above
            // You can write the operations as test steps for that element

            textBox.Clear(); // Step 1 = Clear the values inside the text
            textBox.SendKeys("3"); // Step 2 = Enter the value 3
            genButton.Click(); // Step 3 = Click the Generate button
            
            //Close the Chrome browser to end the test
            driver.Close();


        }
    }
}
