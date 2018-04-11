using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassLibrary
{
    public class StoreContext : DbContext
    {
        public DbSet<Desenvolvedor> Desenvolvedores  { get; set; }
        public DbSet<Endereco> Enderecos  { get; set; }
        public DbSet<Funcionario> Funcionarios  { get; set; }
        public DbSet<Gerente> Gerentes  { get; set; }
        public DbSet<Jogo> Jogos  { get; set; }
        public DbSet<Pessoa> Pessoas  { get; set; }
        public DbSet<Programador> Programadores  { get; set; }
        public DbSet<Tag> Tags  { get; set; }
        public DbSet<TagJogo> TagsJogo  { get; set; }
        public DbSet<Usuario> Usuarios  { get; set; }

        private static IConfigurationRoot Configuration;

        public StoreContext()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = (Configuration.GetConnectionString("StoreDB"));
            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TagJogo>()
                .HasKey(tj => new {tj.JogoId , tj.TagId });

            modelBuilder.Entity<TagJogo>()
                .HasOne(j => j.Jogo)
                .WithMany(t => t.TagsJogo)
                .OnDelete(DeleteBehavior.Restrict);

            
        }
    }
}
