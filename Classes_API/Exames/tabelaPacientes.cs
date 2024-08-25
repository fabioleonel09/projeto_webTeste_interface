using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webTesteInterface.Classes_API.Exames
{
    public class tabelaPacientes
    {
        public string cpf { get; set; }
        public string nomePaciente { get; set; }
        public DateTime dataNascimento { get; set; }
        public string examesRealizados { get; set; }
        public DateTime dataExameRealizado { get; set; }
    }
}