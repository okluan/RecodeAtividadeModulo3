using LuanLimaMinhaBoaViagem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuanLimaMinhaBoaViagem.Controllers
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }

        public DbSet<Promocao> Promocaos { get; set; }
        public DbSet<Destino> Destinos { get; set; }

        public DbSet<Contato> Contatos { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PromocaoDestino>()
                .HasKey(ba => new { ba.PromocaoId, ba.DestinoId });

            builder.Entity<PromocaoDestino>()
                .HasOne(ba => ba.Promocao)
                .WithMany(ba => ba.Destinos)
                .HasForeignKey(bi => bi.PromocaoId);

            builder.Entity<PromocaoDestino>()
                .HasOne(ba => ba.Destino)
                .WithMany(ba => ba.Promocaos)
                .HasForeignKey(bi => bi.DestinoId);


        }

    }
}
