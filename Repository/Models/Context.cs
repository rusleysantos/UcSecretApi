using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class Context : DbContext
    {

        [Key]
        public int DbContextId { get; set; }

        [NotMapped]
        private IConfiguration _conf { get; set; }

        public Context(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            _conf = configuration;
        }

        public Context() : base()
        {

        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_conf.GetConnectionString("ConnDB"));
        }

        //public DbSet<Categoria> CATEGORIAS { get; set; }
     

    }
}
