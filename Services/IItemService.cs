using StockManagementSystem.Models;
using ItemBo = StockManagementSystem.BusinessObject.Item;
using ItemEo = StockManagementSystem.Models.Item;
using CategoryBo = StockManagementSystem.BusinessObject.Category;
using CategoryEo = StockManagementSystem.Models.Category;
using CompanyBo = StockManagementSystem.BusinessObject.Company;
using CompanyEo = StockManagementSystem.Models.Company;
namespace StockManagementSystem.Service
{
    public interface IItemService 
    {
        IEnumerable<ItemEo> GetAllItem();
        ItemBo GetById(int id);
        void Create(ItemBo item);
        void Update(ItemBo _item);
        void Delete(int id);
        List<CategoryBo> GetCategory();
        List<CompanyBo> GetCompany();
        Dictionary<string, int> CalculateCategoryCounts();
    }
}
