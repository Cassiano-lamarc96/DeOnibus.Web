using DeOnibus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeOnibus.Data.Mappings
{
    public class ViagemMap : EntityTypeConfiguration<Viagem>
    {
        public ViagemMap()
        {
            HasKey(v => v.objectId);
            Property(v => v.dataCompra).IsRequired();
        }
    }
}
