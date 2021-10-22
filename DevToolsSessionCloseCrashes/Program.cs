using System;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

using (var driver = new ChromeDriver())
{
    driver.Url = "https://www.selenium.dev";
    var devToolsSession = driver.GetDevToolsSession();
    driver.Close();
    await Task.Delay(TimeSpan.FromSeconds(5));
}
