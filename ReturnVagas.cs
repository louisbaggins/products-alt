using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using PlWrk.Models;

namespace PlWrk.Services
{
    class Retorno
    {
        List<Vaga> Vagas= new List<Vaga>();
        WebClient Tube = new WebClient();
        string Cargo;
        string GetHTML;
        public Retorno()
        {
            GetHTML = Tube.DownloadString("https://take.net/trabalhe-conosco/");
            Regex link_aux = new Regex(@"https://take.net/vaga/(.+?)/", RegexOptions.None);
            Cargo = string.Empty;
            if (link_aux.IsMatch(GetHTML))
            {
                Vaga Temp;
                var matches = link_aux.Matches(GetHTML);
                for (int count = 0; count < matches.Count; count++)
                {
                    Cargo = matches[count].Value;
                    Cargo = Cargo.Replace("https://take.net/vaga/", string.Empty).Replace("/", string.Empty);
                    Temp = new Vaga(Cargo, matches[count].Value);
                    Vagas.Add(Temp);
                }
            }
        }

       public List<Vaga> RetornaVagas()
        {
            return Vagas;
        }

    }
}