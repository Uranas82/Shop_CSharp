using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniProjektas
{
    public class Basket
    {
        private readonly List<Product> _produktai;

        public Basket()
        {
            _produktai = new List<Product>();
        }

        public void Add(Product produktas)
        {
            _produktai.Add(produktas);
        }
    }
}
