namespace Domain
{
    /// <summary>
    /// Command
    /// </summary>
    public class Command
    {
        /// <summary>
        /// Command constructor
        /// </summary>
        /// <param name="commandName">command name</param>
        /// <param name="commandSetting">command setting</param>
        /// <param name="inputTemplate">completed input document template</param>
        /// <param name="outputTemplate">output document template</param>
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
        /// Command Setting
        /// </summary>
        public IReadOnlyDictionary<string, string> CommandSetting { get; }

        /// <summary>
        /// Command name
        /// </summary>
        public string CommandName { get; }

        /// <summary>
        /// Input Template
        /// </summary>
        public Template InputTemplate { get; }

        /// <summary>
        /// Template output
        /// </summary>
        public Template OutputTemplate { get; }
    }
}
