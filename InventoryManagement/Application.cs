using InventoryManagement.Contracts;
using InventoryManagement.Services.Shell;

namespace InventoryManagement
{
    public class Application
    {
        private readonly IArticleRepository _articleRepository;

        public Application(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void Start()
        {
            var userInputProcessor = new ShellUserInputProcessor(_articleRepository);
            var shellMenu = new ShellMenu(userInputProcessor);

            while (true)
            {
                shellMenu.Show();
            }
        }
    }
}
