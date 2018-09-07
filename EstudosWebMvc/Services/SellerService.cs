using EstudosWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EstudosWebMvc.Services
{
    public class SellerService
    {
        private readonly EstudosWebMvcContext _context;

        public SellerService(EstudosWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
