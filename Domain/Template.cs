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
        public Template(string fileName, string filePath, byte[] fileContent, Dictionary<string, string> fileBookmarks)
        {
            if (fileContent == null || !fileContent.Any())
            {
                throw new ArgumentNullException(nameof(fileContent));
            }

            this.FileName = fileName ?? throw new ArgumentNullException(nameof(fileName));
            this.FileContent = fileContent;
            this.FilePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
            this.FileBookmarks = fileBookmarks;
        }

        /// <summary>
        /// Назва файлу
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// Шлях до файлу
        /// </summary>
        public string FilePath { get; }

        /// <summary>
        /// Зміст файлу
        /// </summary>
        public byte[] FileContent { get; }

        /// <summary>
        /// Закладки файлу
        /// (ключ - назва, значення - тип)
        /// </summary>
        public Dictionary<string, string> FileBookmarks { get; }
    }
}
