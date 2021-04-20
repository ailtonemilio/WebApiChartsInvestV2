using WebApiChartsInvestV2.Model.Entities;
using WebApiChartsInvestV2.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApiChartsInvestV2.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
                SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Copia os dados do RegisterViewModel para o IdentityUser
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email
                };

                // Armazena os dados do usuário na tabela AspNetUsers
                var result = await userManager.CreateAsync(user, model.Password);

                // Se o usuário foi criado com sucesso, faz o login do usuário
                // usando o serviço SignInManager e redireciona para o Método Action Index
                if (result.Succeeded)
                {
                    // Se o usuário estiver logado e for do perfil Admin
                    // então o usuário é o usuário Admin que esta criando
                    // um novo usuário, assim vamos direcioná-lo para o
                    // usuário Admin para a Action ListRoles
                    if (signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                    {
                        return RedirectToAction("ListUsers", "Administration");
                    }

                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }

                // Se houver erros então inclui no ModelState
                // que será exibido pela tag helper summary na validação
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }
    }
}
