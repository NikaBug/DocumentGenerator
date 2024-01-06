using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    /// <summary>
    /// Реалізація інтерфейсу репозиторію для
    /// шаблону
    /// </summary>
    public class InMemoryTemplateRepository : ITemplateRepository
    {
        public Task Delete(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Template>> Get(string name)
        {
            throw new NotImplementedException();
        }

        public Task Save(Template template)
        {
            throw new NotImplementedException();
        }
    }
}
