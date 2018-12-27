using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlWrk.Models
{
   
       public class Vaga
        {
            public string Cargo { get; set; }
            public string Link { get; set; }
            public Vaga()
            {
            }
            public Vaga(string Cargo, string link)
            {
                this.Cargo = Cargo;
                this.Link = link;
            }

        }
    }
