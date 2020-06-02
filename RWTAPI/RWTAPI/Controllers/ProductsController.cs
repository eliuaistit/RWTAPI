using AllianceCRM.Insurance;
using Microsoft.AspNetCore.Mvc;
using Raven.Client;
using Raven.Client.Document;
using System.Collections.Generic;
using System.Linq;

namespace RWTAPI.Controllers
{


    public class Regency_Model_HealthPriceRates
    {
        public string Id { get; set; }
        public string Age { get; set; }

    }

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {




        [HttpGet]
        public IEnumerable<Regency_Model_HealthPriceRates> Get()
        {
            using (IDocumentStore store = new DocumentStore
            {
                Url = "http://13.67.68.169:8080/",
                DefaultDatabase = "Regency-Staging"
            })
            {
                store.Initialize();

                List<Regency_Model_HealthPriceRates> Result = GetList(store);

                return Result;

            }
        }


        private static List<Regency_Model_HealthPriceRates> GetList(IDocumentStore store)
        {
            List<Regency_Model_HealthPriceRates> result;
            using (IDocumentSession session = store.OpenSession())
            {
                result = session.Query<Regency_Model_HealthPriceRates>()
                .Take(10)
                .ToList();
            }

            return result;

        }


    }
}