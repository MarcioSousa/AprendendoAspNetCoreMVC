using EstudosWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EstudosWebMvc.Services
{
    public class DepartamentService
    {
        private readonly EstudosWebMvcContext _context;

        public DepartamentService(EstudosWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
