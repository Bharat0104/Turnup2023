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

Thread.Sleep(1000);

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

// Create a new Time record
IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationDropdown.Click();

// Navigate to Time and Material module
IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();


//Click on creare new button
IWebElement createnewbutton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));

createnewbutton.Click();

// Select time from dropdown
IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
//*[@id="TimeMaterialEditForm"]/div/div[1]/div/span[1]/span
typeCodeDropdown.Click();
IWebElement timeTypeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
timeTypeCode.Click();

// Enter code 
IWebElement codeTaxebox = driver.FindElement(By.Id("Code"));
codeTaxebox.SendKeys("Brisbane");

// Enter description
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("Brisbane");
Thread.Sleep(1000);

// Enter price
IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceTextbox.SendKeys("25");
Thread.Sleep(1000);

// Click save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(1000);

// Check to create to new Time and material recoed has been created
IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
gotoLastPageButton.Click();

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));


if (newCode.Text == "Brisbane")
{
    Console.WriteLine("New Time record has been created Successfully.");

}
else
{
    Console.WriteLine("Time Record has not been created");
}







