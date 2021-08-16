using System;

namespace miniProjektas
{
    public class Candy : Product
    {
        public Candy(int id, string name) : base(id, name)
        {
            _price = 5;
        }
    }
}
