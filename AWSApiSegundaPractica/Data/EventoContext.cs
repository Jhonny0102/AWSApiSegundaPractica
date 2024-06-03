using AWSApiSegundaPractica.Models;
using Microsoft.EntityFrameworkCore;

namespace AWSApiSegundaPractica.Data
{
    public class EventoContext:DbContext
    {
        public EventoContext(DbContextOptions<EventoContext> options)
            :base(options)
        {

        }
        public DbSet<Evento> Eventos { get; set; }
    }
}
