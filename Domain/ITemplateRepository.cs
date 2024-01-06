using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Інтерфейс репозиторію для шаблону
    /// </summary>
    public interface ITemplateRepository
    {
        Task<IEnumerable<Template>> Get(string name);
        Task Save(Template template);
        Task Delete(string name);
    }
}
