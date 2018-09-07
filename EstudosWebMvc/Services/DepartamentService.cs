using EstudosWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace EstudosWebMvc.Services
{
    public class DepartamentService
    {
        private readonly EstudosWebMvcContext _context;

        public DepartamentService(EstudosWebMvcContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList();
        }

    }
}
