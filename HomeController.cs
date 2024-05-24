using EquestrianCompetitionsWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Npgsql;
using System.Diagnostics;
using static EquestrianCompetitionsWebApp.Models.Test;

namespace EquestrianCompetitionsWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EcompContext _context;

        public HomeController(ILogger<HomeController> logger, EcompContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<kind_discipline> values = new List<kind_discipline>();

            using (var connection = new NpgsqlConnection("Server=localhost;Database=ecomp;Username=postgres;Password=Korenevam250803;Persist Security Info=True;"))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("SELECT unnest(enum_range(NULL::competitions.kind_discipline))::text", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kind_discipline value;
                            Enum.TryParse(reader.GetString(0), out value);
                            values.Add(value);
                        }
                    }
                }
                
                ViewBag.EnumValues = new SelectList(values);
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}