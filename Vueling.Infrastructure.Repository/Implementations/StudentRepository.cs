﻿using System;
using System.Collections.Generic;
using Vueling.Domain.Entites;
using Vueling.Infrastructure.Repository.Contracts;
using log4net;

namespace Vueling.Infrastructure.Repository.Implementations
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly ILog logger = null;

        public StudentRepository()
        {

        }

        public StudentRepository(ILog logger)
        {
            this.logger = logger;
        }

        public Student Create(Student model)
        {
            logger.Info("Create method started");
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            
            logger.Info("Create method finished");
            return model;
        }

        public bool Delete(int id)
        {
            logger.Info("Delete method started");

            logger.Info("Delete method finished");
            return true;
        }

        public List<Student> GetAll()
        {
            logger.Info("GetAll method started");
            List<Student> studentList = new List<Student>();

            try
            {
                Student student1 = new Student
                {
                    Name = "Pepe"
                };
                studentList.Add(student1);

                Student student2 = new Student
                {
                    Name = "Montse"
                };
                studentList.Add(student2);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);
                throw;
            }

            logger.Info("GetAll method finished");
            return studentList;
        }

        public Student Update(int id, Student model)
        {
            logger.Info("Update method started");
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            logger.Info("Update method finished");
            return model;
        }
    }
}
