using InfCommerce.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InfCommerce.WebUI.ViewModels
{
    public class ProductVM
    {
        public IEnumerable<Product> SimilarProducts { get; set; }
        public Product Product { get; set; }
    }
}
