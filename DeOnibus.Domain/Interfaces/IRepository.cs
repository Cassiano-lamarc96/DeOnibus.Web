using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeOnibus.Domain.Interfaces
{
    public interface IRepository<IEntity>
    {
        IEntity Get(int IdClient);
        List<IEntity> GetAll();
        IEntity Save(IEntity client);
        bool Update(IEntity client);
        bool Delete(IEntity client);
    }
}
