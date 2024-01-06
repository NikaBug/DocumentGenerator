using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Інтерфейс репозиторію для команд
    /// </summary>
    public interface ICommandRepository
    {
        Task Convert(Template intmp, Template outtmp);
    }
}
