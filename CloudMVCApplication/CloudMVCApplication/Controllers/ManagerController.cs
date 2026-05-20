using Microsoft.AspNetCore.Mvc;

namespace CloudMVCApplication.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Dashboard() => View();

        public IActionResult MaintenanceRequests() => View();

        public IActionResult RequestDetails() => View();

        public IActionResult AssignTechnician() => View();

        public IActionResult TechnicianWorkload() => View();

        public IActionResult CompletedRepairs() => View();

        public IActionResult Reports() => View();

        public IActionResult Notifications() => View();

        public IActionResult Profile() => View();
    }
}
