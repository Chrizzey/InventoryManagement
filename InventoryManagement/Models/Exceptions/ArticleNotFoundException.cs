namespace InventoryManagement.Models.Exceptions
{
    /// <summary>
    /// Represents an error when an article is not available
    /// </summary>
    public class ArticleNotFoundException : Exception
    {
        /// <summary>
        /// Gets the ID of the queried article
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Creates a new instance
        /// </summary>
        /// <param name="id">The ID of the queried article</param>
        public ArticleNotFoundException(int id)
        : base($"No Article with ID {id} exists")
        {
            Id = id;
        }
    }
}
