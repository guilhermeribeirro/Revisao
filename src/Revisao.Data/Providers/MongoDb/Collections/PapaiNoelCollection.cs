using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Providers.MongoDb.Collections
{
   

        [BsonCollection("PapaiNoel")]
        public class PapaiNoelCollection : Document
        {
        public Guid CodigoId { get;  set; }

        public string Nome { get; set; }
        
        public string EnderecoCompleto { get; set; }


        public int Idade { get; set; }


        public string TextoCarta { get;  set; }


        public string Login { get; set; }



        public string Senha { get; set; }
    }


    
}
