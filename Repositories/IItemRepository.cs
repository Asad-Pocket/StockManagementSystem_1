﻿using StockManagementSystem.Models;

namespace StockManagementSystem.Repositories
{
    public interface IItemRepository : IRepository<Item>
    {
        public IEnumerable<Item> GetAllInItem();
    }

}
