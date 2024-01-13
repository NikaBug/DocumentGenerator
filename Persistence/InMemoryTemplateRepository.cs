using Domain;

namespace Persistence
{
    /// <summary>
    /// In Memory Template Repository
    /// </summary>
    public class InMemoryTemplateRepository : ITemplateRepository
    {
        private IList<Template> tmp = new List<Template>();

        /// <summary>
        /// Delete template
        /// </summary>
        /// <param name="name">template name</param>
        /// <returns>The successfully completed task</returns>
        public Task Delete(string name)
        {
            bool res = false;
            var item = tmp.FirstOrDefault(t => t.FileName == name);
            if (item != null)
            {
                res = tmp.Remove(item);
            }
            return Task.FromResult(res);
        }

        /// <summary>
        /// Get template
        /// </summary>
        /// <param name="name">template name</param>
        /// <returns>The successfully completed task</returns>
        public Task<IEnumerable<Template>> Get(string name)
        {
            var list = new List<Template>();
            foreach (var it in tmp)
            {
                if (it.FileName == name)
                {
                    list.Add(it);
                }
            }
            return Task.FromResult<IEnumerable<Template>>(list);
        }

        /// <summary>
        /// Save template
        /// </summary>
        /// <param name="template">template</param>
        /// <returns>The successfully completed task</returns>
        public Task Save(Template template)
        {
            tmp.Add(template);
            return Task.CompletedTask;
        }
    }
}
