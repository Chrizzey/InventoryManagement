using System.Collections.ObjectModel;
using InventoryManagement.Contracts;
using InventoryManagement.Models.Articles;
using InventoryManagement.Models.Exceptions;

namespace InventoryManagement.Services
{
    /// <summary>
    /// Represents the storage of articles
    /// </summary>
    public class ArticleRepository : IArticleRepository
    {
        private readonly Dictionary<int, Article> _articles;

        public ArticleRepository()
        {
            _articles = new Dictionary<int, Article>();
        }

        /// <inheritdoc />
        public void AddArticle(Article article)
        {
            if (_articles.ContainsKey(article.Id))
            {
                throw new DuplicateArticleException(article);
            }

            _articles.Add(article.Id, article);
        }

        /// <inheritdoc />
        /// <exception cref="ArticleNotFoundException">
        /// No article matches the ID of the given <param name="article"></param>
        /// </exception>
        public void UpdateArticle(Article article)
        {
            ThrowIfIdDoesNotExist(article.Id);
            _articles[article.Id] = article;
        }

        /// <inheritdoc />
        /// <exception cref="ArticleNotFoundException">No article matches the given <param name="id"></param></exception>
        public Article GetArticle(int id)
        {
            ThrowIfIdDoesNotExist(id);
            return _articles[id].Clone();
        }

        /// <inheritdoc />
        public IEnumerable<Article> GetAllArticles()
        {
            var articles = new List<Article>();
            foreach (var article in _articles.Values)
            {
                articles.Add(article.Clone());
            }

            return new ReadOnlyCollection<Article>(articles);
        }

        /// <inheritdoc />
        /// <exception cref="ArticleNotFoundException">
        /// No article matches the ID of the given <param name="article"></param>
        /// </exception>
        public void DeleteArticle(Article article)
        {
            DeleteArticle(article.Id);
        }

        /// <inheritdoc />
        /// <exception cref="ArticleNotFoundException">No article matches the given <param name="id"></param></exception>
        public void DeleteArticle(int id)
        {
            ThrowIfIdDoesNotExist(id);
            _articles.Remove(id);
        }

        private void ThrowIfIdDoesNotExist(int id)
        {
            if (!_articles.ContainsKey(id))
            {
                throw new ArticleNotFoundException(id);
            }
        }
    }
}
