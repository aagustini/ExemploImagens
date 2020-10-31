using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExemploImagens.Models;

namespace ExemploImagens.Data
{
    public class EFContext : DbContext
    {
        public EFContext (DbContextOptions<EFContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Imagem> Imagem { get; set; }
    }
}
