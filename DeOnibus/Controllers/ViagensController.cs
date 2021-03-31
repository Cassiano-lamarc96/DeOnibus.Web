using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DeOnibus.Models;
using Newtonsoft.Json;

namespace DeOnibus.Controllers
{
    public class ViagensController : Controller
    {
        // GET: Viagens
        public async Task<ActionResult> Index()
        {
            RetornoServicoViagem retornoServicoViagems = new RetornoServicoViagem();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["urldeOnibus"].ToString());

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("X-Parse-Application-Id", "LtD1wBDjTJB7CcuF3hNRNmvRI9CQpozYzN7jIxfA");
                client.DefaultRequestHeaders.Add("X-Parse-REST-API-Key", "1TMvuvt9n2qHCqdQ8qpLw7DX6wUQpq2zhq0OGTvp");


                HttpResponseMessage Res = await client.GetAsync("");

                if (Res.IsSuccessStatusCode)
                {
                    var retorno = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    retornoServicoViagems = JsonConvert.DeserializeObject<RetornoServicoViagem>(retorno);

                }
                //returning the employee list to view  
                return View(retornoServicoViagems.results);
            }
        }

        [Route("comprarPassagem/{id}")]
        public JsonResult ComprarPassagem(string id)
        {
            return Json("Ok", JsonRequestBehavior.AllowGet);
        }
    }
}