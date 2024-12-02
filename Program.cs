using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    public static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        Program P = new Program();
        //P.W3school_login();
        //P.W3school_Search();
        //P.Tutorial_ref();
        //P.W3_Hom2();
        //P.Amazon_dropdown();
        P.Amazon_Alert();
    }
    public void W3school_login()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.Navigate().GoToUrl("https://www.w3schools.com/");
        driver.FindElement(By.XPath("//a[@class=\"user-anonymous tnb-login-btn w3-bar-item w3-btn bar-item-hover w3-right ws-light-green ga-top ga-top-login\"]")).Click();
        driver.FindElement(By.Name("email")).SendKeys("tapan.tkp14@gmail.com");
        driver.FindElement(By.XPath("//input[@name=\"password\"]")).SendKeys("Lumia@535");
        driver.FindElement(By.XPath("//button[@class=\"CustomButton_button__V5-G+ LoginForm_login_button__B4Ksc CustomButton_primary__ZDr5g\"]")).Click();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.FindElement(By.XPath("//button[text()=\"Continue\"]")).Click();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.Close();
    }
    public void W3school_Search()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.Navigate().GoToUrl("https://www.w3schools.com/");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.FindElement(By.XPath("//input[@id=\"tnb-google-search-input\"]")).SendKeys("C# Tutorial");
        driver.FindElement(By.XPath("//div[@class=\"tnb-button-light\"]")).Click();
        driver.Close();
    }
    public void Tutorial_ref()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.Navigate().GoToUrl("https://www.w3schools.com/");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.FindElement(By.XPath("//a[@id=\"navbtn_tutorials\"]")).Click();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.FindElement(By.Id("filter-tutorials-input")).SendKeys("C#");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        driver.FindElement(By.XPath("//a[@id=\"tnb-dark-mode-toggle-btn\"]")).Click();
        driver.Quit();

    }
    public void W3_Hom2()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        driver.Navigate().GoToUrl("https://www.w3schools.com/");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        driver.FindElement(By.XPath("//a[text()=\"C#\"]")).Click();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        driver.Quit();
    
    }
    public void Amazon_dropdown()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        driver.Navigate().GoToUrl("https://www.amazon.com/");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        SelectElement s =new SelectElement( driver.FindElement(By.XPath("//select[@id=\"searchDropdownBox\"]")));
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        IList<IWebElement> elementCount = s.Options;
        s.SelectByText("Automotive"); //Select class used for dropdown select

        Console.WriteLine("Total element count is:" + elementCount.Count); // To count how many options are present
        int isize = elementCount.Count;
        for(int i = 0; i < isize;i++)
        {
            string value = elementCount.ElementAt(i).Text; // To print all the options inside dropdown
            Console.WriteLine("All the valuea are: " + value);
        }
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        driver.FindElement(By.XPath("//input[@id=\"nav-search-submit-button\"]")).Click();

        //IWebElement checkbox = driver.FindElement(By.XPath("//input[@id=\"apb-browse-refinements-checkbox_4\"]"));
        //checkbox.Click();
        driver.FindElement(By.XPath("//span[@class='icp-nav-flag icp-nav-flag-us icp-nav-flag-lop']")).Click();
        IWebElement radiobutton = driver.FindElement(By.XPath("//div[@class='a-row a-spacing-mini'][2]"));
        radiobutton.Click();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        driver.FindElement(By.XPath("//input[@class='a-button-input']")).Click();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        driver.Quit();
        
    }
    public void Amazon_Alert()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        driver.Navigate().GoToUrl("https://www.amazon.com/");
        driver.FindElement(By.XPath("//a[@id='nav-global-location-popover-link']")).Click();
        driver.FindElement(By.XPath("//button[@name='glowDoneButton']")).Click();
        //IAlert alert = driver.SwitchTo().Alert();
        //alert.Accept();
        driver.Quit();

    }
}
