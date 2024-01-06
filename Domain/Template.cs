using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Шаблон
    /// </summary>
    public class Template
    {
        /// <summary>
        /// конструктор шаблону
        /// </summary>
        /// <param name="fileName">шлях до файлу</param>
        /// <param name="fileContent">зміст файлу</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Template(string fileName, byte[] fileContent)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException(nameof(fileName));
            }

            if (fileContent == null || !fileContent.Any())
            {
                throw new ArgumentNullException(nameof(fileContent));
            }

            this.FileName = fileName;
            this.FileContent = fileContent;
        }

        /// <summary>
        /// Назва файлу
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// Зміст файлу
        /// </summary>
        public byte[] FileContent { get; }

    }
}
