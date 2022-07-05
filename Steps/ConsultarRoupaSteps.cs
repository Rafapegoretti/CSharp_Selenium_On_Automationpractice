using AplicacaoTesteCSharp.page;
using AplicacaoTesteCSharp.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AplicacaoTesteCSharp
{
    [Binding]
    public class ConsultarRoupaSteps
    {
        string url = "http://automationpractice.com/";

        IWebDriver driver;
        Pesquisa pesquisa;
        Home home;

        [Given(@"eu acesse o site My Store")]
        public void GivenEuAcesseOSiteMyStore()
        {
            //Inicia as classes
            driver = Util.Util.IniciarDriver();
            home = new Home(driver);
            pesquisa = new Pesquisa(driver);

            //Acessa o site
            home.AcessarSite(url);

        }

        [When(@"eu desejar procurar uma camiseta")]
        public void WhenEuDesejarProcurarUmaCamiseta()
        {
            Thread.Sleep(2000);
            home.Consultar("dresses");
        }

        [Then(@"o site me retorna as camisetas disponiveis")]
        public void ThenOSiteMeRetornaAsCamisetasDisponiveis()
        {
            Thread.Sleep(2000);
            pesquisa.ValidarResultadoDaPesquisa();
            Util.Util.FinalizarDriver(driver);
        }
    }
}
