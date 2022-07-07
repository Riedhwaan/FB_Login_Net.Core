using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace FB_Login_Net.Core.Pages
{
    // AccountController.cs
    [AllowAnonymous, Microsoft.AspNetCore.Components.Route("account")]
    public class AccountController : Controller
    {
        [Microsoft.AspNetCore.Mvc.Route("facebook-login")]
        public IActionResult FacebookLogin()
        {
            var properties = new AuthenticationProperties { RedirectUri = Url.Action("FacebookResponse") };
            return Challenge(properties, FacebookDefaults.AuthenticationScheme);
        }

        [Microsoft.AspNetCore.Mvc.Route("facebook-response")]
        public async Task<IActionResult> FacebookResponse(AuthenticateResult result)
        {
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            var claims = result.Principal.Identities.FirstOrDefault().Claims.Select(claim => new
                {
                    claim.Issuer,
                    claim.OriginalIssuer,
                    claim.Type,
                    claim.Value
                });
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            return Json(claims);
        }
    }
}
