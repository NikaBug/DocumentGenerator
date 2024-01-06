using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    /// <summary>
    /// Команда
    /// </summary>
    public class Command
    {
        /// <summary>
        /// конструктор команди
        /// </summary>
        /// <param name="inputTemplate">заповнений шаблон вхідного документу</param>
        /// <param name="outputTemplate">шаблон вихідного документу</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Command(Template inputTemplate, Template outputTemplate) 
        {
            if(inputTemplate == null)
            {
                throw new ArgumentNullException(nameof(inputTemplate));
            }

            if (outputTemplate == null)
            {
                throw new ArgumentNullException(nameof(outputTemplate));
            }

            this.InputTemplate = inputTemplate;
            this.OutputTemplate = outputTemplate;
        }

        /// <summary>
        /// Заповнений шаблон вхідного документу
        /// </summary>
        public Template InputTemplate { get; }

        /// <summary>
        /// Шаблон вихідного документу
        /// </summary>
        public Template OutputTemplate { get; }

    }
}
