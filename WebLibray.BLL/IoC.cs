using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WebLIbrary.DAL;
using WebLIbrary.DAL.Repositories;
using WebLIbrary.DAL.Repositories.Interfaces;
using WebLibray.BLL.Interfaces;
using WebLibray.BLL.Services;
using AutoMapper;

namespace WebLibray.BLL
{
    public static class IoC
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUoW, UoW>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBookService, BookService>();
        }


        public static void AddAutoMapper(this IServiceCollection services)
        {
            var MappingConfig = new MapperConfiguration(x => x.AddProfile(new WebLibraryProfiler()));
            IMapper mapper = MappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
