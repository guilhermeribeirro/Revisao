using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class PapaiNoel
    {
        #region 1 - Contrutores
        [JsonConstructor]
        public PapaiNoel(Guid proximoCodigo, string nome, string enderecoCompleto, int idade, string textoCarta)
        {
            CodigoId = proximoCodigo;
            Nome = nome;
            EnderecoCompleto = enderecoCompleto;
            Idade = idade;
            TextoCarta = textoCarta;


        }
        //[JsonConstructor]
        //public PapaiNoel(int proximoCodigo, string nome, string enderecoCompleto, int idade, string textoCarta)
        //{
        //    Codigo = proximoCodigo;
        //    Nome = nome;
        //    EnderecoCompleto = enderecoCompleto;
        //    Idade = idade;
        //    TextoCarta = textoCarta;


        //}






        #endregion

        #region 2 - Propriedades


        public Guid CodigoId { get; private set; } 
        public string Nome { get; private set; }

        public string EnderecoCompleto { get; private set; }


        public int Idade { get; private set; }


        public string TextoCarta { get; private set; }


        #endregion

        #region 3 - Comportamentos

        

        public void AlterarNome(string nome) => Nome = Nome;

        

        public void AlterarIdade(int idade) => Idade = Idade;

        public void AlterarEndereco(string enderecoCompleto) => EnderecoCompleto = EnderecoCompleto;


        public void SetaCodigoPapaiNoel(Guid novocodigo) => CodigoId = novocodigo;

        #endregion





    }
}
