using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Objeto de Transferência de Dados(TDO) : modelo de entrada ou modelo de exibição
/*
    DTO é usado para:
        - Evitar sobrepostos.
        - Oculte as propriedades que os clientes não devem exibir.
        - Omita algumas propriedades para reduzir o tamanho da carga.
        - Mesclar grafos de objeto que contêm objetos aninhados. Os gráficos de objeto achatados podem ser mais convenientes para os clientes.
 */

namespace TodoApi.Models
{
    #region snippet
    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
    #endregion
}
