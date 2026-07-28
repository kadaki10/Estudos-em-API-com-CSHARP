using Apitarefas.ModelsViews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
namespace Apitarefas.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public HomeView Index()
    {
        return new HomeView
        {
            Mensagem = "Bem vindo a API de tarefas",
            Documentacao = "/swagger"
        };
    }       
}
