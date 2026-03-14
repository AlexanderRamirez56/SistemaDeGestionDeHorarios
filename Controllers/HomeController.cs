using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaDeHorarios.Data;
using SistemaDeHorarios.Models;
using System.Diagnostics;

namespace SistemaDeHorarios.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Docentes = _context.Docentes.Count();
            ViewBag.Asignaturas = _context.Asignaturas.Count();
            ViewBag.Aulas = _context.Aulas.Count();
            ViewBag.Grupos = _context.Grupos.Count();
            ViewBag.Horarios = _context.Horarios.Count();

            return View();
        }
    }
}