using Microsoft.AspNetCore.Mvc;

namespace TP9.Controllers;

public class AccountController : Controller
{
    public IActionResult Index()
    {
        return View();
    }


    [HttpPost] public IActionResult Login(Usuario usuarioP)
    {
        Usuario nuevo = BD.loginUsuario(usuarioP);
        if(nuevo == null)
        {
            ViewBag.error = "No existe el usuario";
            return View("FormLogin");
        }
        return View("Bienvenida");
    }

    public IActionResult LoginForm()
    {
        return View("FormLogin");
    }

    [HttpPost] public IActionResult Registrar(Usuario usuarioP)
    {
        BD.agregarUsuario(usuarioP);
        return View("FormLogin");
    }

    public IActionResult registrarForm()
    {
        return View("FromRegistrar");
    }

    [HttpPost] public IActionResult olvideMiContra(Usuario usuarioP)
    {
        string str = BD.olvideMiContraseña(usuarioP);
        ViewBag.mail = usuarioP.Email;
        ViewBag.Contraseña = str;
        return View("olvidemiContra");
    }

    public IActionResult olvideMiContraForm()
    {
        return View("olvideMiContraForm");
    }

}