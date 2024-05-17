namespace Domain
{
    /// <summary>
    /// ������
    /// </summary>
    public class Template
    {

        /// <summary>
        /// ����������� �������
        /// </summary>
        /// <param name="fileName">����� �����</param>
        /// <param name="fileContent">���� �����</param>
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
        /// ����� �����
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// ���� �� �����
        /// </summary>
        public string FilePath { get; }

        /// <summary>
        /// ���� �����
        /// </summary>
        public byte[] FileContent { get; }

        /// <summary>
        /// �������� �����
        /// (���� - �����, �������� - ���)
        /// </summary>
        public Dictionary<string, string> FileBookmarks { get; }
    }
}
