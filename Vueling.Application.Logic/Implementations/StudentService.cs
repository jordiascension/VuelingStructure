
using log4net;
using System.Collections.Generic;
using Vueling.Application.Logic.Contracts;
using Vueling.Domain.Entites;
using Vueling.Infrastructure.Repository.Contracts;

namespace Vueling.Application.Logic.Implementations
{
    public class StudentService : IService<Student>
    {
        private readonly IRepository<Student> repository = null;
        private readonly ILog logger = null;

        public StudentService()
        {

        }

        public StudentService(ILog logger, 
            IRepository<Student> repository)
        {
            this.logger = logger;
            this.repository = repository;
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
            try
            {
                return repository.GetAll();
            }
            catch (System.Exception ex)
            {
                logger.Error(ex.Message, ex);
                throw;
            }
        }

        public Student Update(int id, Student model)
        {
            throw new System.NotImplementedException();
        }
    }
}
