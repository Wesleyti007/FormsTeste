using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forms.Data;
using Forms.Models;


namespace Forms.Services
{
    public class DepartamentService
    {
        private readonly FormsContext _context;

        public DepartamentService(FormsContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList();
        }

    }
}
