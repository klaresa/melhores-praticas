using OpenQA.Selenium;
using Xunit;

namespace TP3Alunos.XUnitTestProject1
{
    public class MostrarHomePg
    {
        [Fact]
        public void MostrarHome()
        {
            IWebDriver web = new OpenQA.Selenium.Chrome.ChromeDriver();
            web.Url = "https://localhost:5001/";
            web.Navigate();

            web.Quit();
        }

        [Fact]
        public void AdicionarItem()
        {
            IWebDriver web = new OpenQA.Selenium.Chrome.ChromeDriver();
            web.Url = "https://localhost:5001/";
            web.Navigate();

            for (int i = 1; i <= 5; i++)
            {
                var nomeInput = web.FindElement(By.Name("nome"));
                var matriculaInput = web.FindElement(By.Name("matricula"));
                var botao = web.FindElement(By.Name("salvar"));

                nomeInput.SendKeys("teste " + i.ToString());
                matriculaInput.SendKeys(i.ToString());

                botao.Click();

                web.Url = "https://localhost:5001/";
                web.Navigate();
            }

            web.Url = "https://localhost:5001/aluno/lista";
            web.Navigate();
            var mudaRota = web.Url;

            Assert.True(web.Url == mudaRota);

            web.Quit();
        }
    }
}
