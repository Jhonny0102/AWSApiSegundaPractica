using AWSApiSegundaPractica.Data;
using AWSApiSegundaPractica.Models;
using Microsoft.EntityFrameworkCore;

namespace AWSApiSegundaPractica.Repositories
{
    public class RepositoryPractica
    {
        private EventoContext contextE; //Context de la BBDD Evento
        private CategoriaContext contextC; //Context de la BBDD Categoria
        public RepositoryPractica(EventoContext contextE , CategoriaContext contextC)
        {
            this.contextE = contextE;
            this.contextC = contextC;
        }

        //Mostrar las Categorías de los Eventos
        public async Task<List<Categoria>> GetCategoriasAsync()
        {
            return await this.contextC.Categorias.ToListAsync();
        }

        //Mostrar los Eventos
        public async Task<List<Evento>> GetEventosAsync()
        {
            return await this.contextE.Eventos.ToListAsync();
        }

        //Mostrar Eventos por categoría
        public async Task<List<Evento>> GetEventosPorCategoriaAsync(int idcategoria)
        {
            return await this.contextE.Eventos.Where(z => z.IdCategoria == idcategoria).ToListAsync();
        }
    }
}
