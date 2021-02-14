using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using WebLibrary.BLL.DTOs;
using WebLIbrary.DAL.Models;
using WebLibray.BLL.DTOs;

namespace WebLibray.BLL
{
    class WebLibraryProfiler : Profile
    {
        public WebLibraryProfiler()
        {
            CreateMap<Book, BookDTO>();
            CreateMap<Book, BookDTO>().ReverseMap();
            CreateMap<BookCreateDTO, Book>();


        }
    }
}
