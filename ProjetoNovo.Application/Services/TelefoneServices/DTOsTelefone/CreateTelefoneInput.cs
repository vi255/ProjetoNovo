﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Services.TelefoneServices.DTOsTelefone
{
    public class CreateTelefoneInput
    {
        public int NumeroTelefone { get; set; }
        public string TipoTelefone { get; set; }
        public int ClienteId { get; set; }
    }
}
