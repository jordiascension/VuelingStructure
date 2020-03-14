using log4net;
using System.Web.Http;
using System.Web.Http.Description;
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

        [HttpGet()]
        public IHttpActionResult Get()
        {
            this.logger.Debug("Error Log");
            return Ok("Everythink is ok");
        }
    }
}