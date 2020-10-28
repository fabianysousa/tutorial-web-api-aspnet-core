using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

// Protocolo HTTP : conjunto de métodos de requisição responsáveis por indicar a ação a ser executada para um dado recurso(socket).
/*
    HTTP Verbs (Verbos HTTP) :  GET, HEAD, OPTIONS
                                podem ser do tipo safe, idempotent ou cacheable. 
 */

/* 
    Safe : leva a operações somente de leitura. 
           GET, HEAD e OPTIONS.
           Todos os métodos safe são idempotente, mas nem todo idempotente são safe. Ex PUT e DELETE.
 */

/* 
    Idempotente : pode ser feito uma ou mais vezes enquanto deixa o servidor no mesmo estado.
                  GET, HEAD, PUT e DELETE.
                  Método POST n é idempotente.
 */

/*
    Cacheable : resposta HTTP que pode ser armazenada em cache usado posteriormente e salvando uma nova solicitação no servidor.
                GET, HEAD, POST e PATCH.
                Métodos PUT e DELETE não são cachable. 
 */

/*
    API : interface para comunicação entre sistemas
 */

// Async/await : são promessas

namespace TodoApi.Controllers
{
    [Route("api/TodoItems")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly TodoContext _context;

        public TodoItemsController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems
        // Solicita a representação de um recurso específico
        // Retorna apenas dados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItemDTO>>> GetTodoItems()
        {
            return await _context.TodoItems
                .Select(x => ItemToDTO(x))
                .ToListAsync();
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItemDTO>> GetTodoItem(long id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound(); // status HTTP 404 : indica que o recurso solicitado não existe no servidor.
            }

            return ItemToDTO(todoItem);
        }
        

        // PUT: api/TodoItems/5
        // Exige que o cliente envie a entidade inteira atualizada, não apenas as alterações.

        // PATCH : da suporte para altualizações parciais

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTodoItem(long id, TodoItemDTO todoItemDTO)
        {
            if (id != todoItemDTO.Id)
            {
                return BadRequest(); // status HTTP 400 : indica que a solicitação não pôde ser entendida pelo servidor. Será enviado quando nenhum outro erro for aplicável ou se o erro exato for desconhecido ou não tiver seu próprio código de erro.
            }

            var todoItem = await _context.TodoItems.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound(); // status HTTP 404 : indica que o recurso solicitado não existe no servidor.
            }

            todoItem.Name = todoItemDTO.Name;
            todoItem.IsComplete = todoItemDTO.IsComplete;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!TodoItemExists(id))
            {
                return NotFound();
            }

            return NoContent(); // status HTTP 204 : indica que a solicitação foi processada com êxito e que a resposta está intencionalmente em branco.
        }

        // POST: api/TodoItems
        // Normalmente usado sem passagem de parâmetro.
        // usado para criar uma nova nota.
        [HttpPost]
        public async Task<ActionResult<TodoItemDTO>> CreateTodoItem(TodoItemDTO todoItemDTO)
        {
            var todoItem = new TodoItem
            {
                IsComplete = todoItemDTO.IsComplete,
                Name = todoItemDTO.Name
            };

            _context.TodoItems.Add(todoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetTodoItem),
                new { id = todoItem.Id },
                ItemToDTO(todoItem));
        }

        // DELETE: api/TodoItems/5
        // Usado para remover o recurso (por exemplo uma nota)
        // Utilize por exemplo com passagem de ID.
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(long id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TodoItemExists(long id) =>
             _context.TodoItems.Any(e => e.Id == id);

        private static TodoItemDTO ItemToDTO(TodoItem todoItem) =>
            new TodoItemDTO
            {
                Id = todoItem.Id,
                Name = todoItem.Name,
                IsComplete = todoItem.IsComplete
            };
    }
}
