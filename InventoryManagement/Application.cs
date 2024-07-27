using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.Contracts;

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

        }

        
    }
}
