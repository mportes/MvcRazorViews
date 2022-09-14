using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{
    private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel>{
        new EstudanteViewModel(1, "Maria", "Rua dos Ourives, 35", true),
        new EstudanteViewModel(2, "Pedro", "Rua de Matacavalos, 91", false),
        new EstudanteViewModel(3, "Marta", "Rua de São Bento, 1142", true)
    };

    public IActionResult Index()
    {
        return View(estudantes);
    }

    public IActionResult Show(int id)
    {
        return View(estudantes[id - 1]);
    }
}