using DeOnibus.Data.Mappings;
using DeOnibus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeOnibus.Data.Context
{
    public class LiveerContext : DbContext
    {
        public LiveerContext() : base("name=connStrLiveer") { }

        public virtual DbSet<Viagem> Viagens { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Configurations.Add(new ViagemMap());

            base.OnModelCreating(builder);
        }
    }
}
