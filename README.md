<div class="bg-gray-dark">
  <h1 align="center">
    Desafio Produtos Favoritos
  </h1>
</div>

<p align="center">
  <a href="https://www.linkedin.com/in/luanpc/">
    <img alt="Carlos Cardoso" src="https://img.shields.io/badge/-LuanPCunha-009db9?style=flat&logo=Linkedin&logoColor=white" />
  </a>
</p>

<div align="center">
  <sub>Desafio Backend Luiza Labs. Desenvolvedor :
    <a href="https://github.com/LuanPCunha">Luan P Cunha</a>
  </sub>
</div>

## :one: Sobre o Projeto

No Desafio a Magalu está expandindo seus negócios e uma das novas missões do time de
tecnologia é criar uma funcionalidade de Produtos Favoritos de nossos Clientes, em
que os aplicativos irão enviar requisições HTTP para um novo backend que
deverá gerenciar os clientes e seus produtos favoritos.

## :two: Tecnologias
Esse projeto foi feito utilizando as seguintes tecnologias:

* C#
* .Net 6 
* Swagger
* Postgresql
* Migrations
* Entity Framework
* JWT


## :three: Como rodar

### 📦 Rode a API

```bash
# Clone o Repositório
$ git clone https://github.com/LuanPCunha/Wishlist-API-Netcore
```

* É necessário ter um banco Postgresql.
* Atualizar a ConnectionString do arquivo appsettings.json.
* Rodar os Migrations pelo console do gerenciador de pacotes.
  * Verificar se o projeto padrão está em Wishlist.InfraStructure  

```bash
$ Add-Migration InitialDatabase 
$ Update-Database
```

Em seguida basta rodar o projeto Wishlist.API. que automaticamente irá subir uma versão da aplicação;

## :Four: Melhorias e Considerações Técnicas

O desafio foi implementado como solicitado nos requisitos pedidos. Porém gostaria de registrar observações:

Autenticação e Autorização: Foi implementada uma autenticação via JWT, porém houveram problemas na hora de tratar a autorização nos endpoints no swagger. Mais verificações são necessárias. Para contornar o problema , não foi tratado a autorização dos metodos. Ao invés disso foi solicitado em cada requisição i Email do usuario.

Modelos de Escrita e Leitura: A estratégia de separar em modelo de escrita e leitura não foi adotada. Entretanto em cenários mais complexos na qual se tenha múltiplas visões de uma única informação, vale adotar a estratégia para melhorar segregação de código e ganho de performance.

Async/Await: Vale destacar que para aplicações que possuam grande volume de acesso, o uso de Async e Await trará ganho de performnace. O mesmo não foi usado no desafio.

Swagger: Não foi solicitado, porém está disponível a documentação da API do Desafio, através da rota/swagger.


## :closed_book: Licencia

Lançado em 2022 :closed_book: Licencia

Esse projeto esta sobre [MIT license](./LICENSE).