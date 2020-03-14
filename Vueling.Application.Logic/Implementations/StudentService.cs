
using System.Collections.Generic;
using Vueling.Application.Logic.Contracts;
using Vueling.Domain.Entites;

namespace Vueling.Application.Logic.Implementations
{
    public class StudentService : IService<Student>
    {
        public StudentService() { 
        
        }

        public Student Create(Student model)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Student Update(int id, Student model)
        {
            throw new System.NotImplementedException();
        }
    }
}
