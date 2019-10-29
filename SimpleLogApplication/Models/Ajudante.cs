using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SimpleLogApplication.Models
{
    public static class Ajudante
    {
        public static string ArquivoLogErros
        {
            get
            {
                return ConfigurationManager.AppSettings[nameof(ArquivoLogErros)];
            }
        }

        public static string ArquivoLogAcoes
        {
            get
            {
                return ConfigurationManager.AppSettings[nameof(ArquivoLogAcoes)];
            }
        }
    }
}