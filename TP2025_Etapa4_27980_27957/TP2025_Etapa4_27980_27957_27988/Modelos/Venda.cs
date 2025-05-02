using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2025_Etapa4_27980_27957_27988.Modelos
{
    public class Venda
    {
        #region Attributes

        public int id;
        public DateTime dataVenda;
        public int valorFinal;
        public int custo;
        public int idCarro;
        public int idCliente;
        public int idFuncionario;

        public string nomeCarro = "";
        public string nomeCliente = "";
        public string NomeFuncionario = "";

        #endregion
    }
}
