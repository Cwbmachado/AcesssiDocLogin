using AcessiDOC1.Models;
using Microsoft.AspNetCore.Mvc;

public class LoginController : Controller
{
   
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Autenticar(Usuario usuario)
    {
        // Lógica de autenticação 
        if (usuario.NomeUsuario == "usuario" && usuario.Senha == "senha")
        {
            // Autenticação bem-sucedida, redirecionar para a página principal
            return RedirectToAction("Index", "Home");
        }
        else
        {
            // Autenticação falhou, exibir mensagem de erro
            ViewBag.MensagemErro = "Nome de usuário ou senha incorretos.";
            return View("Index");
        }
    }
}
