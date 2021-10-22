using System;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;

using (var driver = new ChromeDriver())
{
    var devToolsDriver = driver as IDevTools;
    driver.Url = "https://www.selenium.dev";
    var devToolsSession = driver.GetDevToolsSession();
    driver.Close();
    await Task.Delay(TimeSpan.FromSeconds(5));
}
