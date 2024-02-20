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
        /// ����� �����
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// ���� �����
        /// </summary>
        public byte[] FileContent { get; }
    }
}
