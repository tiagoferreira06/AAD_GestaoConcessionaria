using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2025_Etapa4_27980_27957_27988.Modelos
{
    public class Servico
    {
        #region Attributes

        public int id;
        public string tipoServico = "";
        public DateTime dataServico;
        public double custo;
        public int idCliente;
        public int? idCarro;
        public int? idPromocao;

        public string nomeCliente = "";
        public string? nomeCarro;
        public string? nomePromocao;

        #endregion

    }
}
