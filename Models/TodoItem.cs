using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    // Model : conjunto de classes que representam os dados gerenciados pelo aplicativo.
    // As classes de modelo podem ir em qualquer lugar do projeto, mas a Models pasta é usada pela Convenção.

    #region snippet
    public class TodoItem
    {
        // Id: chave exclusiva em um banco de dados relacional
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string Secret { get; set; }
        // Os gets e sets das propriedades são necessários para que possa ser feito o gerenciamento de acesso dessas propriedades.
    }
    #endregion
}
