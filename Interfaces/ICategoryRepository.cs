using System.Collections.Generic;

namespace DI
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
    }
}
