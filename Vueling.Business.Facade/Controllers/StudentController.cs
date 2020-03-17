using System;
using System.Web.Http;
using log4net;
using Vueling.Application.Logic.Contracts;
using Vueling.Domain.Entites;

namespace Vueling.Business.Facade.Controllers
{
    
    public class StudentController : ApiController
    {
        private readonly ILog logger = null;
        private readonly IService<Student> service = null;

        public StudentController()
        {
        }

        public StudentController(ILog logger, IService<Student> service)
        {
            this.logger = logger;
            this.service = service;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
           // throw new NotImplementedException
           //     ("The method is not implemented yet");
            logger.Debug("Error Log");
            return Ok(service.GetAll());
            //return Ok("Everythink is ok");
        }
    }
}