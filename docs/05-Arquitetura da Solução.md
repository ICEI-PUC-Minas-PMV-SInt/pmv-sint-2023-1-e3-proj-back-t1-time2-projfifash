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

Tabela "Cliente":

id_cliente (chave primária)
nome
email
telefone

Tabela "Site":

id_site (chave primária)
nome
url

Tabela "Roupas":

id_roupa (chave primária)
nome
marca
tamanho
cor
preço

Tabela "Compras":

id_compra (chave primária)
id_cliente (chave estrangeira referenciando a tabela "Cliente")
id_site (chave estrangeira referenciando a tabela "Site")
id_roupa (chave estrangeira referenciando a tabela "Roupas")
data_compra 
As restrições de integridade ficam definidas da seguinte maneira:

Cada tabela possui uma chave primária única (id_cliente, id_site, id_roupa, id_compra).
Na tabela "Compras", as chaves estrangeiras (id_cliente, id_site, id_roupa) referenciam as chaves primárias das tabelas "Cliente", "Site" e "Roupas", respectivamente.
As chaves primárias e as chaves estrangeiras não podem ter valores nulos (NOT NULL).

Esse esquema relacional pode ser adaptado para atender a outros requisitos ou casos de uso específicos.

## Modelo Físico (DDL)

Entregar um arquivo banco.sql contendo os scripts de criação das tabelas do banco de dados. Este arquivo deverá ser incluído dentro da pasta src\bd.

## Instruções SQL de Manipulação do BD (DML)

Entregar um arquivo dml.sql contendo os scripts de manipulação de banco de dados. Este arquivo deverá ser incluído dentro da pasta src\bd.

## Tecnologias Utilizadas

#### IDE's:
<ul>
 <li>  Visual Studio Code;</li>
 <li>  Microsoft Visual Studio;</li>
</ul>

#### Linguagens:
<ul>
 <li>  HTML5;</li>
 <li>  CSS3;</li>
 <li>  JavaScript;</li>
 <li>  SQL;</li>
 <li>  C Sharp;</li>
</ul>

#### Ferramentas:
<ul>
 <li>  MySQL;</li>
 <li>  Lucidchart;</li>
 <li>  BR Modelo Web;</li>
 <li>  Git;</li>
 <li>  Github;</li>
 <li>  GitHub Pages;</li>
</ul>

#### Frameworks:
<ul>
 <li>  ASP.NET Core MVC;</li>
</ul>

#### Bibliotecas:
<ul>
 <li>  React;</li>
</ul>

## Hospedagem

#### Ferramenta utilizada:

<ul>
 <li>Github Pages</li>
</ul>

#### Lançamento:

<ol>
 <li>Criação do repositório</li>
 <li>Clonar o repositório</li>
 <li>Adicionar um arquivo Index na pasta do projeto</li>
 <li>Add, commit, e push nas mudanças</li>
 <li>Acessar no endereço https://username.github.io</li>
</ol>

