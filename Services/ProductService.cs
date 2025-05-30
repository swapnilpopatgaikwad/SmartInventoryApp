using SmartInventoryApp.Data;
using SmartInventoryApp.Models;

namespace SmartInventoryApp.Services
{
    public class ProductService
    {
        private readonly InventoryContext _context;

        public ProductService(InventoryContext db)
        {
            _context = db;
        }

        public List<Product> GetAll() => _context.Products.ToList();

        public void Add(Product p)
        {
            _context.Products.Add(p);
            _context.SaveChanges();
        }
    }

}
