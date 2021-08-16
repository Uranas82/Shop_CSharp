using System;

// 1 - Pasirasyti Produkt klasese "IncreaseKiekis" "DecreseKiekis" metodus
// 2 - Product klase padaryt abstract, pridek "IncreaseKiekis" "DecreseKiekis" metodus, sukurt konstruktoriu, kuris priema (kieki, kaina)
namespace miniProjektas
{
    public abstract class  Product 
    {
        protected readonly int _id;
        protected readonly string _name;
        protected int _amount;
        protected int _price;

        protected Product(int id, string name)
        {
            _id = id;
           _name = name;
            _amount = 100;
        }

        public void DecreaseKiekis(int amount)
    {
        _amount -= amount;
    }
        public void IncreaseKiekis(int amount)
    {
        _amount += amount;
    }
        public override string ToString()
        {
            return $"Id: {_id}, Pavadinimas: {_name}, Kaina: {_price}, Kiekis: {_amount}; ";
        }

        public int GetId()
        {
            return _id;
        }

        public int GetQty()
        {
            return _amount;
        }
    }
}
