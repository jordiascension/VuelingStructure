
using System;

namespace Vueling.Domain.Entites
{
    public class Student : IDomainObject
    {
        private Guid id;

        public string Name { get; set; }

        public Guid Id { get => id; private set => id = value; }

        public Student() 
        {
            this.id = Guid.NewGuid();
        }
    }
}
