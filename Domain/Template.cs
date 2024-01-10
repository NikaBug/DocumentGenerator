namespace Domain
{
    /// <summary>
    /// Template
    /// </summary>
    public class Template
    {
        /// <summary>
        /// template constructor
        /// </summary>
        /// <param name="fileName">path file</param>
        /// <param name="fileContent">content file</param>
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
        /// File name
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// File content
        /// </summary>
        public byte[] FileContent { get; }
    }
}
