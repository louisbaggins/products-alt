using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using PlWrk.Models;
using PlWrk.Services;

namespace PlWrk.Controllers
{

    public class ProductsController : ApiController
    {
        List<Vaga> HTML;
        Retorno getvagas = new Retorno();
        public IEnumerable<Vaga> GetAllVagas()
        {
        HTML = getvagas.RetornaVagas();
        return HTML;
        }

        public IHttpActionResult GetVagabyName(string name)
        {
            var pesquisa = HTML.FirstOrDefault((p) => p.Cargo == name);
            if(pesquisa == null)
            {
                return NotFound();
            }
            return Ok(pesquisa);
        }
    }
}