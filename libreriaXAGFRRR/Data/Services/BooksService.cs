﻿using libreriaXAGFRRR.Data.Models;
using libreriaXAGFRRR.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Books = libreriaXAGFRRR.Data.Models.Books;

namespace libreriaXAGFRRR.Data.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }
        //Metodo que nos permite agregar un nuevo libro en la BD
        public void AddBook(Books book)
        {
            var _book = new Books()
            {
                Titulo = book.Titulo,
                Descripcion = book.Descripcion,
                ISRead = book.ISRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Genero,
                Autor = book.Autor,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }
        //Metodo que nos permite obtener una lista de todos los libros de la BD
        public List<Books> GetAllBks() => _context.Books.ToList();
        //Metodo que nos permite obtener el libro que estamos pidiendo de la BD
        public Books GetBookById(int bookid) => _context.Books.FirstOrDefault(n => n.id == bookid);
        //Metodo que nos permite modificar un libro que se encuentra en la BD
        public Books UpdateBookByID(int bookid, BookVM book)
        {
            var _book = _context.Books.FirstOrDefault(n =>n.id == bookid);
            if (_book != null)
            {
                _book.Titulo = book.Titulo;
                _book.Descripcion = book.Descripcion;
                _book.ISRead = book.ISRead;
                _book.DateRead = book.DateRead;
                _book.Rate = book.Rate;
                _book.Genero = book.Genero;
                _book.Autor = book.Autor;
                _book.CoverUrl = book.CoverUrl;

                _context.SaveChanges();
            }
            return _book;
        }
        public void DeleteBookById(int bookid)
        {
            var _book = _context.Books.FirstOrDefault(n =>n.id == bookid);
            if(_book != null)
            {
                _context.Books.Remove(_book);
                _context.SaveChanges();
            }
        }

        internal void AddBook(BookVM book)
        {
            throw new NotImplementedException();
        }
    }
}
