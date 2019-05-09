using CFAServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;

namespace CFAParseWebAPI.Controllers
{
    public class CFAParseController: ApiController
    {
        private readonly ICFAParseService _cFAParseService;
        public CFAParseController(ICFAParseService cFAParseService)
        {
            _cFAParseService = cFAParseService;
        }

        [HttpPost]
        [Route("api/Parse")]
        public IHttpActionResult Post([FromBody]string s)
        {
            if (s == null)
            {
                return BadRequest();
            }
            try
            {
                return Ok( _cFAParseService.Calculator(s) );
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}