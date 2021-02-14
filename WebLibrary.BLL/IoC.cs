using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using WebLibrary.BLL.Interfaces;
using WebLibrary.BLL.Services;
using WebLibrary.DAL;
using WebLibrary.DAL.Repositories;
using WebLibrary.DAL.Repositories.Interfaces;
namespace WebLibrary.BLL
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