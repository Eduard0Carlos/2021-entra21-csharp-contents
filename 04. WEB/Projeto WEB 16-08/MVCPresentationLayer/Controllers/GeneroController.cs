using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Mvc;
using MVCPresentationLayer.Models.Genero;
using Service;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Controllers
{
    public class GeneroController : Controller
    {
        private IGeneroService _generoService;
        private IMapper _mapper;

        public GeneroController(IGeneroService generoService, IMapper mapper)
        {
            this._generoService = generoService;
            this._mapper = mapper;
        }



        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(GeneroInsertViewModel viewModel)
        {
            Genero genero = _mapper.Map<Genero>(viewModel);

            Response response = _generoService.Cadastrar(genero);
            if (response.DeuBoa)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Error = response.Mensagem;

            return View();
        }

    }
}
