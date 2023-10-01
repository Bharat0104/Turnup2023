using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Open the Browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// lunch to Trunup portal and navigate to login 
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

// Identify the Username taxbox and enter valid password  
IWebElement usernameTexrbox = driver.FindElement(By.Id("UserName"));
usernameTexrbox.SendKeys("hari");

// Identify the Password taxbox and enter valid textbox
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

// Identify login taxbox and click o the login button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

// check User able to login sucessfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == " Hello hari")
{
    Console.WriteLine(" user logged in sucessfully");
}

else
{
    Console.WriteLine("User has not been logged in");
}




