using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Main metode Meniu -> Parduotuves metodus kviecia -> Parduotuve kviecia produktu metodus
namespace miniProjektas
{
    public class Shop 
    {
        private readonly List<Product> _produktai;

        public Shop()
        {
            _produktai = new List<Product>
            {
                new Book(1, "Book"),
                new Cup(2, "Cup"),
                new Candy(3, "Candy")
            };
        }

        public void List()
        {
            foreach (var item in _produktai)
            {
                if (item.GetQty() != 0)
                {
                    Console.WriteLine(item.ToString());
                }                
            }
        }

        public void Buy(int buyId, int buyQty)
        {
            var produktas = GetProductById(buyId);
            produktas.DecreaseKiekis(buyQty);
        }

        public void Add(int addId, int addQty)
        {
            var produktas = GetProductById(addId);
            produktas.IncreaseKiekis(addQty);
        }

        private Product GetProductById(int id)
        {
            foreach (var item in _produktai)
            {
                if (item.GetId() == id)
                {
                    return item;
                }
            }
            return null;
        }   


    }
}
