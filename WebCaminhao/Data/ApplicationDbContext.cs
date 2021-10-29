using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebCaminhao.Models;

namespace WebCaminhao.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Caminhao> Caminhao { get; set; }
        public DbSet<TipoAnoFabricacao> TipoAnoFabricacao { get; set; }
        public DbSet<TipoAnoModelo> TipoAnoModelo { get; set; }
        public DbSet<TipoModelo> TipoModelo { get; set; }

    }
}
