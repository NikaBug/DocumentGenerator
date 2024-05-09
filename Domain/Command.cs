namespace Domain
{
    /// <summary>
    /// Команда
    /// </summary>
    public class Command
    {
        /// <summary>
        /// Конструктор команди
        /// </summary>
        /// <param name="commandName">назва команди</param>
        /// <param name="commandSetting">налаштування команди</param>
        /// <param name="inputTemplate">вхідний шаблон</param>
        /// <param name="outputTemplate">вихідний шаблон</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Command(string commandName,
            IReadOnlyDictionary<string, string> commandSetting,
            Template inputTemplate,
            Template outputTemplate)
        {
            this.CommandName = commandName ?? throw new ArgumentNullException(nameof(commandName));
            this.CommandSetting = commandSetting ?? throw new ArgumentNullException(nameof(commandSetting));
            this.InputTemplate = inputTemplate ?? throw new ArgumentNullException(nameof(inputTemplate));
            this.OutputTemplate = outputTemplate ?? throw new ArgumentNullException(nameof(outputTemplate));
        }

        /// <summary>
        /// Налаштування команди
        /// </summary>
        public IReadOnlyDictionary<string, string> CommandSetting { get; set; }

        /// <summary>
        /// Назва команди
        /// </summary>
        public string CommandName { get; set; }

        /// <summary>
        /// Вхідий шаблон
        /// </summary>
        public Template InputTemplate { get; }

        /// <summary>
        /// Вихідний шаблон
        /// </summary>
        public Template OutputTemplate { get; }
    }
}
