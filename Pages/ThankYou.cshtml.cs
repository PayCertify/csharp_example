using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayCertify;

namespace csharp_example.Pages
{
  public class ThankYouModel : PageModel
  {
    public string TransactionData { get; set; }
    public void OnGet()
    {
    }

    public IActionResult OnPost(IFormCollection formData)
    {
      var response = Plugin.parse(formData);
      var success = response["success"];
      if (success.ToString() == "True")
      {
        return Page();
      }
      return RedirectToPage("/error", new { message = response["message"] });
    }
  }
}