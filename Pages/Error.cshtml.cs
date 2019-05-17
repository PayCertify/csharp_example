using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace csharp_example.Pages
{
  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public class ErrorModel : PageModel
  {
    public string RequestId { get; set; }
    public string ProcessorMessage { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    public void OnGet(string message)
    {
      RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
      ProcessorMessage = message;
    }
  }
}
