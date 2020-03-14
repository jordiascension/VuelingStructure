using System;
using System.Collections.Generic;
using Vueling.Domain.Entites;
using Vueling.Infrastructure.Repository.Contracts;

namespace Vueling.Infrastructure.Repository.Implementations
{
    public class StudentRepository : IRepository<Student>
    {
        public Student Create(Student model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student Update(int id, Student model)
        {
            throw new NotImplementedException();
        }
    }
}
