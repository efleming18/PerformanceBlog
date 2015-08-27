using System.Collections.Generic;
using System.Web.Http;
using Api.Models;

namespace Api.Controllers
{
    [RoutePrefix("api/quarterbacks")]
    public class QuarterbackController : ApiController
    {
        [Route("list")]
        public QuarterbackModel GetListOfQuarterbacks()
        {
            var qb = new QuarterbackModel
            {
                Name = "Peyton Manning",
                Interceptions = 0,
                PassingYards = 5000,
                Touchdowns = 45,
                QBR = 100
            };
            return qb;
        }

        [Route("touchdowns/{touchdowns:int}")]
        public string Get(int touchdowns)
        {
            if (touchdowns == 45)
            {
                return "Must be Peyton Manning...";
            }
            return "Prly not Peyton...";
        }
    }
}
