using AutoMapper;
using Domain;
using MVCPresentationLayer.Models.Genero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Infrastructure
{
	public class GenericProfile : Profile
	{
		public GenericProfile()
		{
			CreateMap<GeneroInsertViewModel, Genero>();
		}
	}
}
