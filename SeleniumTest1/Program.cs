using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest1
{
	class Program
	{
		static void Main(string[] args)
		{
			sifremiUnuttum();
			ilanAra();
		}
		static IWebDriver  driver = new ChromeDriver();
		static string link = @"http://www.unclesoftware.com/";
		public static void girisTest()//Giriş Yapma use case'i test ediliyor
		{			
			driver.Navigate().GoToUrl(link);
			driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/ul/li[2]/a")).Click();
			driver.FindElement(By.Name("emailorname")).SendKeys("Sreilus");
			driver.FindElement(By.Name("password")).SendKeys("12345678");
			driver.FindElement(By.XPath("//*[@id='loginForm']/div[3]/a")).Click();
			Thread.Sleep(3000);
					
		}
		public static void ilanAra()//İlan arama use case'i test ediliyor
		{
			girisTest();
			driver.FindElement(By.XPath("//*[@id='search-job-btn']")).Click();			
			Thread.Sleep(2000);
			driver.FindElement(By.XPath("/html/body/nav/div/div[3]/form/div[1]/div/div/button/span[1]")).Click();
			Thread.Sleep(2000);
			driver.FindElement(By.XPath("/html/body/nav/div/div[3]/form/div[1]/div/div/div/ul/li[26]/a/span[1]")).Click();
			Thread.Sleep(2000);
			driver.FindElement(By.XPath("/html/body/nav/div/div[3]/form/div[2]/div/div/button")).Click();
			Thread.Sleep(2000);
			driver.FindElement(By.XPath("/html/body/nav/div/div[3]/form/div[2]/div/div/div/ul/li[16]/a")).Click();
			Thread.Sleep(2000);
			driver.FindElement(By.XPath("//*[@id='search-job-form-btn']")).Click();
			Thread.Sleep(2000);
			driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/a")).Click();
			Thread.Sleep(2000);
			driver.FindElement(By.XPath("//*[@id='244']/button")).Click();
		}
		public static void kayitOlTest()//Kayıt olma use case'i test ediliyor
		{
			driver.Navigate().GoToUrl(link);
			driver.FindElement(By.LinkText("Kayıt Ol")).Click();
			driver.FindElement(By.Id("i1")).SendKeys("Jack Sparrow");
			driver.FindElement(By.Id("i2")).SendKeys("jacksrwwq2w6475@gmail.com");
			driver.FindElement(By.Id("i3")).SendKeys("12345678");
			driver.FindElement(By.XPath("//*[@id='signupForm']/div[3]/a")).Click();
			Thread.Sleep(5000);
			driver.FindElement(By.ClassName("form-control")).SendKeys("ddfdsffsf");
			driver.FindElement(By.XPath("//*[@id='welcomePForm']/div[2]/a")).Click();
		}
		public static void sifremiUnuttum()//Şifremi unuttum use case'i test ediliyor
		{
			driver.Navigate().GoToUrl(link);
			driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/ul/li[2]/a")).Click();
			driver.FindElement(By.XPath("//*[@id='loginForm']/div[2]/div[3]/a")).Click();
			Thread.Sleep(3000);
			driver.FindElement(By.Name("email")).SendKeys("jacksrwwq2w64@gmail.com");
			driver.FindElement(By.XPath("//*[@id='forgotForm']/div[3]/a")).Click();
			driver.FindElement(By.XPath("/html/body/nav/div/div[1]/a")).Click();
		}
	}
}
