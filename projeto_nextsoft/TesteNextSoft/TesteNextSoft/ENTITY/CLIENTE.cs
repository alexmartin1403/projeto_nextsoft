using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteNextSoft.ENTITY
{
    public class CLIENTE
    {
        public int ID_CLIENTE { get; set; }
        public int CPF { get; set; }
        public string NOME { get; set; }
        public string EMAIL { get; set; }
        public string TELEFONE { get; set; }      
    }
}