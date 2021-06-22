using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class ControleRepository : IControleRepository
    {
        private Context _con { get; set; }

        public ControleRepository(Context con)
        {
            _con = con;
        }

     
    }
}
