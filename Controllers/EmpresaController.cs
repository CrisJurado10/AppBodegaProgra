using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using appBodega.Utils;
using appBodega.Models;
using appBodega.Services;

namespace appBodega.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IAPIService _apiService;

        public EmpresaController(IAPIService apiService)
        {
            _apiService = apiService;
        }


        // GET: EmpresaController
        public async Task<IActionResult> Index()
        {
            List<Empresa> empresas = await _apiService.GetEmpresas();
            return View(empresas);
        }

        // GET: EmpresaController/Details/5
        public async Task<IActionResult> Details(int EmpresaID)
        {
            Empresa empresa = await _apiService.GetEmpresa(EmpresaID);
            if (empresa != null)
            {
                return View(empresa);
            }
            return RedirectToAction("Index");
        }

        // GET: EmpresaController/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Empresa empresa)
        {
            Empresa empresa2 = await _apiService.PostEmpresa(empresa);
            return RedirectToAction("Index");
        }


        // GET: EmpresaController/Edit/5
        public async Task<IActionResult> Edit(int EmpresaID)
        {
           Empresa empresa = await _apiService.GetEmpresa(EmpresaID);
            if (empresa != null)
            {
                return View(empresa);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Empresa empresa)
        {
            Empresa empresa2 = await _apiService.GetEmpresa(empresa.EmpresaID);
            if (empresa2 != null)
            {
                Empresa empresa3 = await _apiService.PutEmpresa(empresa.EmpresaID, empresa);

                return RedirectToAction("Index");
            }
            return View();
        }


        // GET: EmpresaController/Delete/5
        public async Task<IActionResult> Delete(int EmpresaID)
        {
            Boolean empresa2= await _apiService.DeleteEmpresa(EmpresaID);
            if (empresa2 != false)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }


    }
}
