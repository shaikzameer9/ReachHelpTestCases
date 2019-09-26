using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using System.Threading;

namespace ReachHelpTestCases
{
    [TestFixture]
    public class UnitTest1
    {
        /*[Test]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://172.16.51.152/ReachAcs/index");
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath(" //a[contains(text(),'Create Account')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("sname")).SendKeys("SHAIK");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("mname")).SendKeys("ZAMEER");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("lname")).SendKeys("KHAJA");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("sphoneno")).SendKeys("1234567890");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("semailid")).SendKeys("sonushaik8686@gmail.com");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("sentityname")).SendKeys("VAJRA FOUNDATION");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("sdesignation")).SendKeys("BUSINESSMAN");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("sstreet1")).SendKeys("Manipal,beside AKMS tours and travels");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("sstreet2")).SendKeys("AP,guntur");
            Task.Delay(2000).Wait();
            SelectElement oSelection = new SelectElement(driver.FindElement(By.Id("scountry")));
            IList<IWebElement> oSize = oSelection.Options;
            int iListSize = oSize.Count;
            for (int i = 0; i < iListSize; i++)
            {
                String sValue = oSelection.Options.ElementAt(i).Text;
                Console.WriteLine("Value of the Select item is : " + sValue);
                if (sValue.Equals("India"))
                {
                    oSelection.SelectByIndex(i);
                    break;
                }
            }
            Task.Delay(2000).Wait();
            SelectElement sSelection = new SelectElement(driver.FindElement(By.Id("sstate")));
            IList<IWebElement> sSize = sSelection.Options;
            int jListSize = sSize.Count;
            for (int j = 0; j < jListSize; j++)
            {
                String vValue = sSelection.Options.ElementAt(j).Text;
                Console.WriteLine("Value of the Select item is : " + vValue);
                if (vValue.Equals("Karnataka"))
                {
                    sSelection.SelectByIndex(j);
                    break;
                }
            }
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("scity")).SendKeys("MANIPAL");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("spincode")).SendKeys("522202");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("chkDisclaimer")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("signupbtn")).Click();
            Task.Delay(2000).Wait();
            driver.Close();



        }
        [Test]
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://172.16.51.152/ReachAcs/index");
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath(" //a[contains(text(),'Create Account')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("sname")).SendKeys("SHAIK");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("mname")).SendKeys("ZAMEER");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("lname")).SendKeys("KHAJA");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("sphoneno")).SendKeys("1234567");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("semailid")).SendKeys("sonushaik");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("sentityname")).SendKeys("VAJRA FOUNDATION");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("sdesignation")).SendKeys("BUSINESSMAN");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("sstreet1")).SendKeys("Manipal,beside AKMS tours and travels");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("sstreet2")).SendKeys("AP,guntur");
            Task.Delay(2000).Wait();
            SelectElement oSelection = new SelectElement(driver.FindElement(By.Id("scountry")));
            IList<IWebElement> oSize = oSelection.Options;
            int iListSize = oSize.Count;
            for (int i = 0; i < iListSize; i++)
            {
                String sValue = oSelection.Options.ElementAt(i).Text;
                Console.WriteLine("Value of the Select item is : " + sValue);
                if (sValue.Equals("Canada"))
                {
                    oSelection.SelectByIndex(i);
                    break;
                }
            }
            Task.Delay(2000);
            SelectElement sSelection = new SelectElement(driver.FindElement(By.Id("sstate")));
            IList<IWebElement> sSize = sSelection.Options;
            int jListSize = sSize.Count;
            for (int j = 0; j < jListSize; j++)
            {
                String vValue = sSelection.Options.ElementAt(j).Text;
                Console.WriteLine("Value of the Select item is : " + vValue);
                if (vValue.Equals("Alberta"))
                {
                    sSelection.SelectByIndex(j);
                    break;
                }
            }
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("scity")).SendKeys("MANIPAL");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("spincode")).SendKeys("522202");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("chkDisclaimer")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("signupbtn")).Click();
            Task.Delay(2000).Wait();
            driver.Close();


        }*/
        [Test]
        public void TestMethod3()
        {



            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://172.16.51.152/ReachAcs/index");
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//li[@id='lmodalid']//a[contains(text(),'Login')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("mobileno")).SendKeys("8801227744");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("password")).SendKeys("12345");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("loginbtn")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("select2-category-container")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys("Food");
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys(Keys.Enter);
            Task.Delay(2000).Wait();
          
            driver.FindElement(By.Id("select2-subCategory-container")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys("Sugar");
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys(Keys.Enter);
         
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("qty")).SendKeys("5");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("select2-unit-container")).Click();
            Task.Delay(2000);
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys("Kg");
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys(Keys.Enter);

           
            driver.FindElement(By.Id("expectedDate")).SendKeys("2019/09/19");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("deliveryAddress")).SendKeys("MANIPAL,UDIPI,SOIS BLOCK- 5 ");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("btnCreateRequest")).Click();
            Task.Delay(2000).Wait();
            driver.Close();




        }
        [Test]
        public void TestMethod4()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://172.16.51.152/ReachAcs/index");
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//li[@id='lmodalid']//a[contains(text(),'Login')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("mobileno")).SendKeys("8801227744");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("password")).SendKeys("12345");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("loginbtn")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("select2-category-container")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys("Clothing");
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys(Keys.Enter);
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("select2-subCategory-container")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys("Saree");
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys(Keys.Enter);

            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("qty")).SendKeys("5");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("select2-unit-container")).Click();
            Task.Delay(2000);
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys("pc");
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys(Keys.Enter);


            driver.FindElement(By.Id("expectedDate")).SendKeys("2019/09/19");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("deliveryAddress")).SendKeys("MANIPAL,UDIPI,SOIS BLOCK- 5 ");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("btnCreateRequest")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void TestMethod5()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://172.16.51.152/ReachAcs/index");
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//li[@id='lmodalid']//a[contains(text(),'Login')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("mobileno")).SendKeys("8801227744");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("password")).SendKeys("12345");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("loginbtn")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("select2-category-container")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys("Shelter");
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys(Keys.Enter);
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("select2-subCategory-container")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys("Room");
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys(Keys.Enter);
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("expectedDate")).SendKeys("2019/09/19");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("deliveryAddress")).SendKeys("MANIPAL,UDIPI,SOIS BLOCK- 5 ");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("btnCreateRequest")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void TestMethod6()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://172.16.51.152/ReachAcs/index");
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//li[@id='lmodalid']//a[contains(text(),'Login')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("mobileno")).SendKeys("8801227744");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("password")).SendKeys("12345");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("loginbtn")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("select2-category-container")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys("Vehicle");
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys(Keys.Enter);
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("select2-subCategory-container")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys("car");
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys(Keys.Enter);
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("expectedDate")).SendKeys("2019/09/19");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("deliveryAddress")).SendKeys("MANIPAL,UDIPI,SOIS BLOCK- 5 ");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("btnCreateRequest")).Click();
            Task.Delay(2000).Wait();
            driver.Close();


        }
        [Test]
        public void TestMethod7()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://172.16.51.152/ReachAcs/index");
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//li[@id='lmodalid']//a[contains(text(),'Login')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("mobileno")).SendKeys("8801227744");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("password")).SendKeys("12345");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("loginbtn")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//span[contains(text(),'Offers')]")).Click(); //Offers
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//a[@class='btn btn-sm btn-round btn-primary trn']")).Click(); //iOffer
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("category")).Click();
            Task.Delay(2000).Wait();
            SelectElement oSelection = new SelectElement(driver.FindElement(By.Id("category")));
            IList<IWebElement> oSize = oSelection.Options;
            int iListSize = oSize.Count;
            for (int i = 0; i < iListSize; i++)
            {
                String sValue = oSelection.Options.ElementAt(i).Text;
                Console.WriteLine("Value of the Select item is : " + sValue);
                if (sValue.Equals("Food"))
                {
                    oSelection.SelectByIndex(i);
                    break;
                }
            }
            Task.Delay(2000).Wait();
            SelectElement sSelection = new SelectElement(driver.FindElement(By.Id("subCategory")));
            IList<IWebElement> sSize = sSelection.Options;
            int jListSize = sSize.Count;
            for (int j = 0; j < jListSize; j++)
            {
                String vValue = sSelection.Options.ElementAt(j).Text;
                Console.WriteLine("Value of the Select item is : " + vValue);
                if (vValue.Equals("Rice"))
                {
                    sSelection.SelectByIndex(j);
                    break;
                }
            }
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("qty")).SendKeys(Keys.Delete);
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("qty")).SendKeys("7");
            Task.Delay(2000).Wait();
            SelectElement aSelection = new SelectElement(driver.FindElement(By.Id("unit")));
            IList<IWebElement> aSize = aSelection.Options;
            int kListSize = aSize.Count;
            for (int k = 0; k < kListSize; k++)
            {
                String eValue = sSelection.Options.ElementAt(k).Text;
                Console.WriteLine("Value of the Select item is : " + eValue);
                if (eValue.Equals("Tonne"))
                {
                    sSelection.SelectByIndex(k);
                    break;
                }
            }
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("description")).SendKeys("I am Zameer from Manipal This is all what i could offer");
            Task.Delay(2000).Wait();
            SelectElement bSelection = new SelectElement(driver.FindElement(By.Id("unit")));
            IList<IWebElement> bSize = bSelection.Options;
            int lListSize = bSize.Count;
            for (int l = 0; l < lListSize; l++)
            {
                String vValue = sSelection.Options.ElementAt(l).Text;
                Console.WriteLine("Value of the Select item is : " + vValue);
                if (vValue.Equals("Deliver"))
                {
                    sSelection.SelectByIndex(l);
                    break;
                }
            }
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("deliveryAddress")).SendKeys("MANIPAL,UDIPI,SOIS BLOCK- 5 ");
            Task.Delay(2000).Wait();            
            driver.FindElement(By.Id("uploadImages")).SendKeys("C:\\Users\\SOIS\\Desktop\\money-2724241__340.jpg");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("btnCreateOffer")).Click();
            Task.Delay(2000).Wait();
            driver.Close();







        }
        [Test]
        public void TestMethod8()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://172.16.51.152/ReachAcs/index");
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//li[@id='lmodalid']//a[contains(text(),'Login')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("mobileno")).SendKeys("8801227744");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("password")).SendKeys("12345");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("loginbtn")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//span[@id='chatWindowToggle']")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("userMessage")).SendKeys("hai i would like to chat with u just for fun");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("sendMessage")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
       /* [Test]
        public void TestMethod9()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://172.16.51.152/ReachAcs/index");
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//a[contains(text(),'About Us')]"));
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//a[contains(text(),'Contact Us')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//a[contains(text(),'Feedback')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("btnDonate")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//ul[@class='info']//a[contains(text(),'Privacy Policy')]")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
            // i am not able to acess the footer items through my test case ....
        }*/
        [Test]
        public void TestMethod10()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://172.16.51.152/ReachAcs/index");
            driver.FindElement(By.Id("btnRequestHelp")).Click();
            Task.Delay(2000);
            driver.FindElement(By.Id("btnOfferHelp")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//div[@id='setmodalsize']//button[@class='btn btn-default'][contains(text(),'Close')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//a[@class='act']")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//a[@class='dropdown-toggle']")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//a[contains(text(),'Other')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//li[4]//ul[1]//li[1]//a[1]")).Click();
            Task.Delay(2000);
           

        }

















    }
}





    

