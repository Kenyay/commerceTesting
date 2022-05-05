using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace bank.Pages
{
    public class NotificationModel : PageModel
    {
        private readonly ILogger<NotificationModel> _logger;

        public NotificationModel(ILogger<NotificationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}