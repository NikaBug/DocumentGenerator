namespace Domain
{
    /// <summary>
    /// Шаблон
    /// </summary>
    public class Template
    {
        /// <summary>
        /// Конструктор шаблона
        /// </summary>
        /// <param name="fileName">назва файлу</param>
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
