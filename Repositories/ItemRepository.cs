using StockManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StockManagementSystem.Repositories;
using StockManagementSystem.Data;

namespace StockManagementSystem.Repositories
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(ApplicationDbContext ctx) : base(ctx)
        {
        }
        public IEnumerable<Item> GetAllInItem()
        {
            IEnumerable<Item> items = _ctx.ItemList.Include(x => x.Category).Include(x => x.Company).ToList();
            return items;
        }
    }
}
