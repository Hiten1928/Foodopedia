using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            var redirectUrl = Url.Page("/Index");
            return Challenge(
                new AuthenticationProperties { RedirectUri = redirectUrl },
                //Challenging the user by logging in with the OIDC server (Azure)
                OpenIdConnectDefaults.AuthenticationScheme
                );
        }

        public IActionResult Logout()
        {
            var callbackUrl = Url.Page("/Account/SignedOut");
            return SignOut(
                new AuthenticationProperties { RedirectUri = callbackUrl },
                // remove cookie from the list which is associated to the user
                CookieAuthenticationDefaults.AuthenticationScheme,
                // also logout of OIDC identity provider
                OpenIdConnectDefaults.AuthenticationScheme
                );
        }
    }
}
