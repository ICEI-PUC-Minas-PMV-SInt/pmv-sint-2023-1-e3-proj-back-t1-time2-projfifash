# Arquitetura da Solução
<!-- 
<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

![Arquitetura da Solução](img/arch-back.JPG)
 -->
#### Camada de Apresentação
A camada de apresentação é responsável pela interface do usuário. Ela inclui a lógica para a interação do usuário com a aplicação e é onde os usuários interagem com a aplicação. Nesta camada, podemos usar tecnologias como Windows Forms, WPF ou ASP.NET para criar a interface gráfica.

#### Camada de Negócios
A camada de negócios contém a lógica de negócios da aplicação. Ela processa as solicitações do usuário e executa a lógica de negócios que está diretamente relacionada ao domínio do projeto de moda. Esta camada pode incluir classes que representam objetos de negócios, como peças de roupa, coleções, estoques, fornecedores, clientes, entre outros.

#### Camada de Acesso a Dados
A camada de acesso a dados é responsável pela comunicação com o banco de dados. Ela inclui as classes e métodos para conectar-se ao banco de dados e executar operações de leitura e gravação. Nesta camada, podemos usar tecnologias como o Entity Framework, ADO.NET ou NHibernate para fornecer a conexão com o banco de dados.

#### Camada de Infraestrutura
A camada de infraestrutura contém componentes que fornecem suporte à aplicação, como serviços de logging, autenticação, autorização, e-mail, entre outros. Nesta camada, podemos usar bibliotecas de terceiros ou desenvolver nossos próprios componentes para suportar as funcionalidades necessárias.

#### Camada de Testes
A camada de testes inclui os testes unitários, de integração e de aceitação da aplicação. Ela é responsável por garantir a qualidade da aplicação e verificar se ela está funcionando corretamente. Nesta camada, podemos usar ferramentas como o NUnit, xUnit ou MSTest para criar os testes automatizados.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Classes”.

> - [Diagramas de Classes - Documentação da IBM](https://www.ibm.com/docs/pt-br/rational-soft-arch/9.6.1?topic=diagrams-class)
> - [O que é um diagrama de classe UML? | Lucidchart](https://www.lucidchart.com/pages/pt/o-que-e-diagrama-de-classe-uml)

## Modelo ER

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.]

As referências abaixo irão auxiliá-lo na geração do artefato “Modelo ER”.

> - [Como fazer um diagrama entidade relacionamento | Lucidchart](https://www.lucidchart.com/pages/pt/como-fazer-um-diagrama-entidade-relacionamento)

## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.
 
As referências abaixo irão auxiliá-lo na geração do artefato “Esquema Relacional”.

> - [Criando um modelo relacional - Documentação da IBM](https://www.ibm.com/docs/pt-br/cognos-analytics/10.2.2?topic=designer-creating-relational-model)

## Modelo Físico (DDL)

Entregar um arquivo banco.sql contendo os scripts de criação das tabelas do banco de dados. Este arquivo deverá ser incluído dentro da pasta src\bd.

## Instruções SQL de Manipulação do BD (DML)

Entregar um arquivo dml.sql contendo os scripts de manipulação de banco de dados. Este arquivo deverá ser incluído dentro da pasta src\bd.

## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
