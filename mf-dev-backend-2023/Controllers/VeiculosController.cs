using mf_dev_backend_2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2023.Controllers
{
    public class VeiculosController : Controller
    {
        private readonly AppDbContext _Context;
        public VeiculosController(AppDbContext context) 
        {
            _Context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _Context.Veiculos.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                _Context.Veiculos.Add(veiculo);
                await _Context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
