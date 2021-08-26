using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Mvc;
using MVCPresentationLayer.Models.Genero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Controllers
{
    public class GeneroController : Controller
    {
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
            MapperConfiguration config =
                new MapperConfiguration(cfg => cfg.CreateMap<GeneroInsertViewModel, Genero>());

            IMapper mapper = config.CreateMapper();

            Genero genero = mapper.Map<Genero>(viewModel);


            return View();
        }

    }
}
