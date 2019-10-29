using SimpleLogApplication.Models;
using System;
using System.Collections.Specialized;
using System.Web.Mvc;

namespace SimpleLog.Controllers
{
    public class CalculoController : Controller
    {
        public ActionResult Index()
        {
            RegistraLog.Log("Abriu a aplicação");
            return (ActionResult)this.View();
        }

        [HttpPost]
        public ActionResult Calcula(string numero1, string numero2)
        {
            try
            {
                NameValueCollection form = Request.Form;
                double num1 = Convert.ToDouble(form[nameof(numero1)]);
                double num2 = Convert.ToDouble(form[nameof(numero2)]);
                double soma = num1 + num2;
                double subtracao = num1 - num2;
                double multiplicacao = num1 * num2;
                double divisao = num1 / num2;
                RegistraLog.Log($"Cálculo executado com sucesso para os números {num1} e {num2}", Ajudante.ArquivoLogAcoes);
                return (ActionResult)this.Json((object)new
                {
                    soma,
                    subtracao,
                    multiplicacao,
                    divisao
                });
            }
            catch (Exception ex)
            {
                RegistraLog.Log(ex.Message + " | StackTrace" + ex.StackTrace, Ajudante.ArquivoLogErros);
                return (ActionResult)this.Json((object)new
                {
                    soma = "-",
                    subtracao = "-",
                    multiplicacao = "-",
                    divisao = "-"
                });
            }
        }

    }
}
