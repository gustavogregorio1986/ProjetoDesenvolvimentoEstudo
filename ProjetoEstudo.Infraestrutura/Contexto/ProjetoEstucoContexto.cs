using Microsoft.EntityFrameworkCore;
using ProjetoEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Infraestrutura.Contexto
{
    public class ProjetoEstucoContexto : DbContext
    {
        public ProjetoEstucoContexto(DbContextOptions optiuons)
            : base(optiuons)
        {

        }

        public DbSet<Carro> Carros { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
