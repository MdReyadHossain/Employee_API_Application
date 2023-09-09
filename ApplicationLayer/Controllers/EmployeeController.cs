using BusinessLogicLayer.DTOs;
using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApplicationLayer.Controllers
{
    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        /*---------API01#---------*/
        [HttpPatch]
        [Route("update")]
        public HttpResponseMessage UpdateEmployee(EmployeeDTO obj)
        {
            try
            {
                var data = EmployeeService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }

        /*---------API02#---------*/
        [HttpGet]
        [Route("salary/third")]
        public HttpResponseMessage ThirdHighestSalary()
        {
            try
            {
                var data = EmployeeService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
    }
}
