using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using appBodega.Services;
using appBodega.Models;

namespace appBodega.Controllers
{
    public class UserController : Controller
    {
        private readonly IAPIService _apiService;

        public UserController(IAPIService apiService)
        {
            _apiService = apiService;
        }
        // GET: UserController
        public async Task<IActionResult> Index()
        {
            List<User> usuarios = await _apiService.GetUsers();
            return View(usuarios);
        }

        // GET: UserController/Details/5
        public async Task<IActionResult> Details(int IdUser)
        {
            
            return RedirectToAction("Index", "Producto");

        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(User usuario)
        {
            User usuario1 = await _apiService.PostUser(usuario);
            return RedirectToAction("Index");
        }

        // GET: UserController/Edit/5
        public async Task<IActionResult> Edit(int IdUser)
        {
            User usuarios = await _apiService.GetUser(IdUser);
            if (usuarios != null)
            {
                return View(usuarios);
            }
            return RedirectToAction("Index");
        }
       
        


        
        
    }
}
