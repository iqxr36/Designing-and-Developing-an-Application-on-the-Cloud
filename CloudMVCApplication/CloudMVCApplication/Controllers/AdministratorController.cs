using Microsoft.AspNetCore.Mvc;

namespace CloudMVCApplication.Controllers
{
    public class AdministratorController : Controller
    {
        public IActionResult Dashboard() => View();
        public IActionResult Users() => View();
        public IActionResult UserDetail() => View();
        public IActionResult AddUser() => View();
        public IActionResult Properties() => View();
        public IActionResult PropertyDetail() => View();
        public IActionResult AddProperty() => View();
        public IActionResult Units() => View();
        public IActionResult UnitDetail() => View();
        public IActionResult AddUnit() => View();
        public IActionResult Maintenance() => View();
        public IActionResult MaintenanceBoard() => View();
        public IActionResult RequestDetail() => View();
        public IActionResult CreateRequest() => View();
        public IActionResult RequestSubmitted() => View();
        public IActionResult Reports() => View();
        public IActionResult ReportDetail() => View();
        public IActionResult GenerateReport() => View();
        public IActionResult AuditLogs() => View();
        public IActionResult AuditLogDetail() => View();
        public IActionResult Settings() => View();
        public IActionResult QuickActions() => View();
        public IActionResult Notifications() => View();
        public IActionResult Profile() => View();
        public IActionResult ChangeAvatar() => View();
        public IActionResult AdvancedFilters() => View();
        public IActionResult ExportReady() => View();
    }
}
