using Microsoft.AspNetCore.Mvc;

namespace EsercizioParte1.Controllers
{
    public class ImpiegatoController : Controller
    {
        private static List<Impiegato> listaImpiegati = new List<Impiegato>();

        [HttpPost]
        public IActionResult AggiungiImpiegato([FromBody] Impiegato nuovoImpiegato)
        {
            listaImpiegati.Add(nuovoImpiegato);
            return Ok();
        }

        public class Impiegato
        {
            public string Nome { get; set; }
            public string Cognome { get; set; }
            public string CodiceFiscale { get; set; }
            public int Coniugato { get; set; }
            public int Figli { get; set; }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
