using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniProjektas
{
    public class User
    {
        private readonly Basket _krepselis;

        public User()
        {
            _krepselis = new Basket();
        }

        public void AddToBasket(Product produktas)
        {
            _krepselis.Add(produktas);
        }
    }
}
