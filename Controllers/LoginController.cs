using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using gasimmoeval.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace gasimmoeval.Controllers;

public class LoginController : Controller{

    public readonly AdministrateurRepository _administrateurRepository;

    public LoginController(AdministrateurRepository administrateurRepository){
        _administrateurRepository = administrateurRepository;
    }
    public IActionResult LoginPageAdmiin()
    {
        ViewBag.ErrorMessage = TempData["ErrorMessage"] as string;
        return View();
    }
    public IActionResult LoginPageProprietaire()
    {
        ViewBag.ErrorMessage = TempData["ErrorMessage"] as string;
        return View();
    }

    public IActionResult LoginPageClient()
    {
        ViewBag.ErrorMessage = TempData["ErrorMessage"] as string;
        return View();
    }

    public IActionResult VerificationLoginAdmin(string email, string password)
    {
        try
        {
            string id = _administrateurRepository.VerificationLoginAdmin(email, password);
            Console.WriteLine("verification succes");

            HttpContext.Session.SetString("id_admin", id);
            return Redirect("../Bien/AdminPage");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("verification faild");
            TempData["ErrorMessage"] = ex.Message;
            return Redirect("LoginPageAdmin");
        }
    }
}