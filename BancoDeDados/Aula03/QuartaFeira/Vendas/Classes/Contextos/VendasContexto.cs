using Microsoft.EntityFrameworkCore;

namespace Vendas.Classes.Contextos
{
    internal class VendasContexto : DbContext
    {
        public DbSet<Vendas1> Vendas { get; set; }



    }

    public class Vendas1
    {
    }
}
