using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoTesteCSharp.Page
{
    public class Pesquisa
    {
        private IWebDriver driver;

        public Pesquisa(IWebDriver driver)
        {
            this.driver = driver;
        }

        private WebDriverWait Esperar()
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        private By ContatorDeProduto()
        {
            return By.ClassName("product-count");
        }

        public Boolean ValidarResultadoDaPesquisa()
        {
            //TODO: Validar se o retorno é bool realmente
            if (Esperar().Until(ExpectedConditions.ElementIsVisible(ContatorDeProduto())).Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
