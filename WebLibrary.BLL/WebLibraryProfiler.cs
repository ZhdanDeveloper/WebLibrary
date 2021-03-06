﻿using AutoMapper;
using WebLibrary.BLL.DTOs;
using WebLibrary.DAL.Models;
namespace WebLibrary.BLL
{
    class WebLibraryProfiler : Profile
    {
        public WebLibraryProfiler()
        {
            CreateMap<Book, BookDTO>();
            CreateMap<Book, BookDTO>().ReverseMap();
            CreateMap<BookCreateDTO, Book>();
            CreateMap<BookCreateDTO, Book>().ReverseMap();
            CreateMap<BookCreateDTO, BookDTO>();
            CreateMap<BookCreateDTO, BookDTO>().ReverseMap();


          

        }
    }
}