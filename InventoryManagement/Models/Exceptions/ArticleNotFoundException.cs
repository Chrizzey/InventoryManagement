namespace InventoryManagement.Models.Exceptions
{
    public class ArticleNotFoundException : Exception
    {
        public int Id { get; }

        public ArticleNotFoundException(int id)
        : base($"No Article with ID {id} exists")
        {
            Id = id;
        }
    }
}
