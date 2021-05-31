using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;
using ProEventos.API.Data;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;
        // public IEnumerable<Evento> _evento = new Evento[]{
        //     new Evento()
        //     {
        //         EventoId = 1,
        //         Tema = "Angular 11 .Net 5",
        //         Local= "Londrina",
        //         Lote = "1º lote",
        //         QtdPessoas = 250,
        //         DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
        //         ImagemURL = "Foto.png"
        //     },
        //     new Evento()
        //     {
        //         EventoId = 2,
        //         Tema = "Aula de Angular 11 .Net 5",
        //         Local= "Em Sorriso",
        //         Lote = "2º lote",
        //         QtdPessoas = 235,
        //         DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
        //         ImagemURL = "Foto2.png"
        //     }
        // };
        public EventoController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Inserir()
        {
            return "Exemplo de post";
        }

    }
}
