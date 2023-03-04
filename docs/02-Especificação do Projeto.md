# Especificações do Projeto



## Personas

<table>
    <tr>
      <th>Amanda Oliveira</th>
    </tr>
    <tr>
      <td width="300px"><img src="../docs/img/persona-1-amanda.jpg"></td>
      <td>Idade: 22 </br>Ocupação: estudante de direito, carioca, solteira, </br>que gosta de sair com os amigos aos finais de semana e </br>tem interesse se vestir com peças mais elaboradas.</td>
      <td>Aplicativos:
        <ul>
          <li>Instagram</li>
          <li>Facebook</li>
        </ul>
      </td>    
    </tr>
    <tr>
      <td>Motivações:</br>Comprar roupas da moda com preço acessível</td>
      <td>Frustações:</br>Não encontrar uma plataforma com interface agradável e fácil de usar.</td>
      <td>Hobbies:</br> Ir ao karaokê com as amigas</td>
    </tr>
</table>
</br></br></br>
<table>
    <tr>
      <th>Júlia Gomes</th>
    </tr>
    <tr>
      <td width="300px"><img src="../docs/img/persona-2-julia.jpg" width= "300px"></td>
      <td>Idade: 22 </br>Ocupação: Estudante. 
se interessa por maquiagem.
</td>
      <td>Aplicativos:
        <ul>
          <li>Instagram</li>
          <li>Tiktok</li>
        </ul>
      </td>    
    </tr>
    <tr>
      <td>Motivações:</br>Comprar roupas da moda com preço acessível</td>
      <td>Frustações:</br>Não encontrar uma plataforma com interface agradável e fácil de usar.</td>
      <td>Hobbies:</br> Ir ao karaokê com as amigas</td>
    </tr>
</table>



## Histórias de Usuários

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Cliente             | Desejo consultar catálogo          | Decidir o que vou comprar|
|Cliente             | Desejo abrir página do item        | Visualizar detalhes do produto|
|Cliente             | Desejo adicionar itens ao carrinho | Para guardar os itens de interesse|
|Cliente             | Desejo fazer login no site         | Para finalizar compra   |
|Cliente             | Desejo alterar dados do perfil     | Para alterar endereço |
|Cliente             | Desejo excluir o cadastro no site  | Para excluir meu cadastro pessoal do site      |
|Administrador       | Cadastrar item                     | Disponibilizar as informações coletadas através de uma pesquisa para atender o público. |
|Administrador       | Editar cadastro do item            | Editar as informações com dados mais recentes dos produtos |
|Administrador       | Incluir imagens                    | Para que possíveis clientes vejam fotos dos produtos |
|Administrador       | Apagar imagens                     | Para remover fotos antigas e que não façam parte do marketing atual|
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |
|Administrador       | Excluir cliente                    | Excluir cliente caso solicitado ou que infrinja as regras do site |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto. Para determinar a prioridade de requisitos, aplicar uma técnica de priorização de requisitos e detalhar como a técnica foi aplicada.

### Requisitos Funcionais

|ID    | Descrição do Requisito | Dificuldade (B/M/A)* | Prioridade (B/M/A)* |
|------|-----------------------------------------|----|----|
|RF-001| O sistema deve permitir cadastrar, alterar e excluir informações sobre produtos de moda   | MÉDIA | MÉDIA |
|RF-002| O sistema deve permitir cadastrar, alterar e excluir imagens e vídeos dos produtos de moda   | MÉDIA | MÉDIA |
|RF-003| O sistema deve permitir comparar todos os recursos e funções dos produtos de moda   | ALTA | ALTA |
|RF-004| O sistema deve permitir buscar os produtos de moda por palavra-chave   | MÉDIA | MÉDIA |
|RF-005| O sistema deve permitir o cadastro e a exclusão de usuários | ALTA | ALTA |
|RF-006| O sistema deve permitir a recuperação de login para administradores do sistema | ALTA | ALTA |
|RF-007| O sistema deve permitir que o usuário escolha e favorite o produto desejado  | MÉDIA | MÉDIA |
|RF-008| O sistema deve permitir que o usuário busque por produtos utilizando filtros | MÉDIA | MÉDIA |



### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em dispositivos móveis | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 
|RNF-003| O sistema deve rodar em diversos tipos de navegadores |  ALTA | 
|RNF-004| O sistema deve ser intuitivo e de fácil compreensão ao usuário |  MÉDIA | 
|RNF-005| O sistema deve ficar no ar 24h |  MÉDIA | 
|RNF-006| O sistema não apresentará aos usuários quaisquer dados de cunho privativo |  ALTA | 
|RNF-007| O sistema deve ter certificação de segurança | ALTA | 
|RNF-009| O sistema deve usar Azure Cosmos DB para armazenamento de arquivos |  MÉDIA | 
|RNF-010| O sistema deve ter ferramenta de análise de dados com o Plausable Analytics |  BAIXA | 
|RNF-011| O sistema deve respeitar as boas práticas de acessibilidade | MÉDIA



## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre. |
|02| O front end deve ser desenvolvido em Javascript e deve ser utilizado o framework React. |
|05| O sistema deve fazer uso de Media Queries |
|03| Deve ser utilizado Bootstrap para confecção de interface do usuário. |
|07| O transporte de informações se dará por meio do formato JSON. |
|09| O sistema será construido de forma modular.  |
|10| Os módulos do back end serão desenvolvidos em C# utilizando .NET. |
|13| O sistema deve fazer uso do banco de dados SQLServer.|
|11| O GIT deve ser utilizado como ferramenta de versionamento. |


## Diagrama de Casos de Uso

<img src="../docs/img/Diagrama%20de%20Casos%20de%20uso%20FIFASH.jpg">