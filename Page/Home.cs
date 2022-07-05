using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoTesteCSharp.page
{
    public class Home
    {
        private IWebDriver driver;

        public Home(IWebDriver driver)
        {
            //Referencia via injeção de dependencia o driver o chrome.
            this.driver = driver;
        }

        private IWebElement CampoDeBusca()
        {
            return driver.FindElement(By.Id("search_query_top"));
        }

        private IWebElement Pesquisar()
        {
            return driver.FindElement(By.CssSelector("#searchbox > button"));
        }

        public void AcessarSite(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        public void Consultar(string produto)
        {
            CampoDeBusca().SendKeys(produto);
            Pesquisar().Click();
        }
    }
}
