using AWSApiSegundaPractica.Models;
using Microsoft.EntityFrameworkCore;

namespace AWSApiSegundaPractica.Data
{
    public class CategoriaContext:DbContext
    {
        public CategoriaContext(DbContextOptions<CategoriaContext> options)
            :base(options)
        {

        }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
