using System;

namespace miniProjektas
{
    public class Cup : Product
    {
        public Cup(int id, string name) : base(id, name)
        {
            _price = 10;
        }

    }
}
