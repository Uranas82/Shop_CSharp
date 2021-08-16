using System;

namespace miniProjektas 
{
    public class Book : Product
    {
        public Book(int id, string name) : base(id, name)
        {
            _price = 15;
        }       
    }
}
