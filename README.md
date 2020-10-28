<h1 align="center"> Tutorial Web Api ASP.NET Core </h1>

---

## 📑 Sobre

Nesse repositório é colocado em prática e documentando os conceitos básicos da criação de uma API Web do [Tutorial: criar uma API Web com ASP.NET Core](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio) da **Microsoft**.

### Deverá ser aprendido:

- [X] Criar um projeto de API Web.
- [X] Adicionar uma classe de modelo e um contexto de banco de dados.
- [X] Faça scaffold de um controlador com métodos CRUD.
- [X] Configure o roteamento, os caminhos de URL e os valores retornados.
- [X] Chamar a API Web com o Postman.

A API deve gerenciar itens de "tarefas pendentes" armazenados em um banco de dados. 

### Visão geral

Esse tutorial cria a seguinte API:

<img src="https://user-images.githubusercontent.com/37695655/97029752-3e249680-1534-11eb-9f21-36248e609d7c.PNG" height="340" width="550">

---

## 🧠 Conceitos aprendidos

📌 **1. O modelo de projeto cria uma API WeatherForecast que ao ser executada retorna um JSON.**

|Json        |
|------------|
|É uma formatação leve de troca de dados. *JSON é em formato texto e completamente independente de linguagem, pois usa convenções que são familiares às linguagens C e familiares, incluindo *C++*, *C#*, *Java*, *JavaScript*, *Perl*, *Python* e muitas outras. Logo, é ideal para troca de dados.|

📌 **2. Posteriormente foi adicionado uma classe Model. Em que na aplicação o modelo para esse aplicativo é uma unica classe *TodoItem*.** 

|Classe Model|
|------------|
|É um conjunto de classes que representam os dados gerenciados pelo aplicativo.|

**3. Foi adicionando o contexto de banco de dados adicionando pacotes NuGet *Microsoft.EntityFrameworkCore.SqlServer* e  *EntityFrameworkCore. inmemory*. Na aplicação o contexto de banco de dados é classe *TodoContext* presente no *Model* da aplicação.** 

|Contexto de banco de dados|
|--------------------------|
|É a classe principal que coordena a funcionalidade do *Entity Framework* para um modelo de dados. Essa classe é derivada da classe *Microsoft.EntityFrameworkCore.DbContext*.| 

📌 **4. Também foi registrado o contexto do banco de dados no contêiner de *Injeção de Dependência*. Esse contêiner fornece o serviço aos controladores.** 

|Injeção de Dependência|
|----------------------|
|É um padrão de projeto que visa remover dependências desnecessárias entre as classes ou torná-las mais suaves e ter um design de software que seja fácil de manter e evoluir. A *ASP.NET Core* e o *Entity Framework Core* são fortemente baseados em injeção de dependência e usam centenas de contratos. Este recurso permite a injeção de dependências do lado de fora de uma classe de forma que a classe onde a dependência é injeta só precisa saber do contrato (definido em uma interface ou classe abstrata), e assim, a classe pode ser independente dos seus objetos.|

📌 **5. Posteriormente foi feito um *scaffold* de um controlador.**

|Scaffold|
|--------|
|É um pré-moldado que permite criar um rápido esqueleto funcional para o seu sistema em prol da alta produtividade.|

📌 **6. O próximo passo foi criar os métodoS *HTTP POST*, *HTTP GET*, *HTTP PUT* e *HTTP DELET* na classe TodoItemController e consecutivamente foram testados no *Postman*. Além de utilizar os verbos HTTP, também foram utilizados os status HTTP.**

|Verbos HTTP|Definições|
|-----------|----------|
|GET|Solicita a representação de um recurso específico. Retorna apenas dados.|
|PUT|Fornece da suporte para altualizações parciais.|
|POST|Normalmente usado sem passagem de parâmetro. Usado para criar uma nova nota.|
|DELET|Usado para remover o recurso (por exemplo uma nota). Utilize por exemplo com passagem de ID.|


|Controller|
|----------|
|É responsável por controlar a maneira como um usuário interage com uma aplicação MVC e possui o fluxo de controle lógico para uma aplicação ASP .NET MVC. É o controlador que determina que resposta será enviada de volta ao usuário quando ele faz uma requisição via navegador.|

|Status HTTP|Code|Definição|
|--------------|----------|----------|
|404|NotFound()|Indica que o recurso solicitado não existe no servidor.|
|400|BadRequest()|Indica que a solicitação não pôde ser entendida pelo servidor. Será enviado quando nenhum outro erro for aplicável ou se o erro exato for desconhecido ou não tiver seu próprio código de erro.|
|204|NoContent()|indica que a solicitação foi processada com êxito e que a resposta está intencionalmente em branco.|

|Postman|
|-------|
|Ferramenta que facilita o desenvolvimento, pois oferece ferramentas como criar, compartilhar, testar e documentar APIs..|

📌 **7. Para evitar o excesso de postagem foi criando a classe *TodoItemDTO* e as classes *TodoItem* e *TodoItemsController* foram atualizada para o Padrão de Projeto *Objeto de Tranferência de Dados(DTO)* .**

|Objeto de Tranferência de Dados|
|-----------------------|
| é um padrão de projeto de software usado para transferir dados entre subsistemas de um software. DTOs são frequentemente usados em conjunção com objetos de acesso a dados para obter dados de um banco de dados.|

---

## ⚙️ Tecnologias utilizadas

O projeto foi desenvolvido utilizando as seguintes tecnologias:

 - [Entity Framework](https://docs.microsoft.com/pt-br/ef/)
 - [Postman](https://www.postman.com/)
 - [Injeção de Dependencia](http://www.macoratti.net/19/04/c_dioc1.htm)
 - [Objeto de Transferência de Dados](http://www.macoratti.net/19/07/c_dtovopc1.htm)
 
---

## ☄️ Como baixar o projeto

No promit command:

```bash

    # Clonar o repositório
    $ git clone https://github.com/fabianysousa/tutorial-web-api-aspnet-core

    # Entrar no diretório
    $ cd tutorial-web-api-aspnet-core
    
    # Rode o projeto
    $ dotnet run

```
---
## 💡 Insight

Fazer esse tutorial me forneceu o entendimento do funcionamento da aplicação e além de me promover a experiência de utilizar o Postman para testar as requisições HTTP e utilizar os Padrões de projeto Injeção de Dependência e Objeto de Transferência de Dados.

---

Desenvolvido ❤️ por Fabiany de Sousa Costa
