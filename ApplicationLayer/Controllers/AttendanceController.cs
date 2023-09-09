using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApplicationLayer.Controllers
{
    [RoutePrefix("api/attendance")]
    public class AttendanceController : ApiController
    {
        /*---------API03#---------*/
        [HttpGet]
        [Route("regularEmployee")]
        public HttpResponseMessage ThirdHighestSalary()
        {
            try
            {
                var data = AttendanceService.GetRegularEmployee();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }

        /*---------API04#---------*/
        [HttpGet]
        [Route("monthlyReport/{year}/{month}")]
        public HttpResponseMessage MonthlyAttendance(int month, int year)
        {
            try
            {
                var data = AttendanceService.GetMonthlyReport(month, year);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
    }
}
