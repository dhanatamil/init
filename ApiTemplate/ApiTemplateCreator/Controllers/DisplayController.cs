using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiTemplateCreator.Controllers
{
    [RoutePrefix("api")]
    public class DisplayController : ApiController
    {
        [HttpGet]
        [Route("welcome")]
        public HttpResponseMessage Display()
        {
            try
            {
                string input = "Welcome";

                if (input != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, input);
                }
                else
                {
                    return Request.CreateErrorResponse((HttpStatusCode)409, new HttpError("Data Is Empty"));
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Error occured :" + ex.Message);  
            }
        }
    }
}
