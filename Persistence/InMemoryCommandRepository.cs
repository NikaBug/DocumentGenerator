using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    /// <summary>
    /// Реалізація інтерфейсу репозиторію
    /// команд
    /// </summary>
    public class InMemoryCommandRepository : ICommandRepository
    {
        public Task Convert(Template intmp, Template outtmp)
        {
            throw new NotImplementedException();
        }
    }
}
