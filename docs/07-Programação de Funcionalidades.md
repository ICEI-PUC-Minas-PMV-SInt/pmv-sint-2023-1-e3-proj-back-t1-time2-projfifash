# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descritas por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos os artefatos criados (código fonte) além das estruturas de dados utilizadas e as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

Para cada requisito funcional, pode ser entregue um artefato desse tipo

> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)
> 
> Marcielen Barbosa:
> 
Inicialização do projeto Back-end feito por Marcielen Barbosa:
Aqui eu inicializei o MVC do cadastro de cliente, começando o crud de clientes do projeto da loja de moda
tela de Cadastro de cliente
![image](https://user-images.githubusercontent.com/80776887/228098383-ac574269-1730-49da-bbbf-a2269ca03a85.png)
Aqui são os campos que vão ser exibidos na tela e salvos no banco 
![image](https://user-images.githubusercontent.com/80776887/229657451-0b4e58c4-0fd2-4c05-86ef-06b5ab6a89fe.png)
As informações dos campos no cadastro de cliente 
![image](https://user-images.githubusercontent.com/80776887/229657711-832c7222-0af6-4f84-893e-689cfe34c91c.png)
O código usado para integrar com o SQL
![image](https://user-images.githubusercontent.com/80776887/229657810-c8504f37-a9b8-4768-b5ac-cd43c793a1b4.png)
A conexão com o banco
![image](https://user-images.githubusercontent.com/80776887/229657897-4c049863-9a5b-40b0-86eb-ed2ff23f9dcc.png)
Finalizei a parte do Crud, criando a sua controller, em que consigo, cadastrar, editar e apagar novos clientes
![image](https://user-images.githubusercontent.com/80776887/233697589-76bfcae6-8b65-4c66-bbe2-f61fdc20a693.png)
como o crud ficou na tela: 
Tela inicial da listagem 
![image](https://user-images.githubusercontent.com/80776887/233697823-b6c9fbe8-fe8c-41b4-8cdd-d16771bde26f.png)
tela de cadastro 
![image](https://user-images.githubusercontent.com/80776887/233697920-521cd502-ff5e-4b1d-95f2-78d2c04cea87.png)
Listagem com um cliente cadastrado 
![image](https://user-images.githubusercontent.com/80776887/233697971-b1135591-d899-431f-9896-1f2d95107e47.png)
Página quando o Adm vai deletar ou alterar um cliente 
![image](https://user-images.githubusercontent.com/80776887/233698090-18487832-02ea-4049-b0d9-8361c3347d9f.png)
![image](https://user-images.githubusercontent.com/80776887/233698157-3456e1e3-6be0-4883-ac54-3942e6bc5bd4.png)
Cadastro Alterado:
![image](https://user-images.githubusercontent.com/80776887/233698267-7a6d6c9c-70b5-4766-953d-96c37549a834.png)
![image](https://user-images.githubusercontent.com/80776887/233698313-42987a73-3b06-43d1-add1-51105a7e707a.png)


Inicialização da tela de cadastro feito por Pedro Henrique Chiarelli de Sousa:

aqui fiz a tela que o cliente irá interagir quando for fazer o cadastro:![Screenshot_68](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-1-e3-proj-back-t1-time2-projfifash/assets/90483031/e3787af2-8203-4254-89f7-364d65d8e66c)

e aqui está quando o cliente preencher os campos do cadastro: 
![Screenshot_69](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-1-e3-proj-back-t1-time2-projfifash/assets/90483031/6ece0bdc-7f7f-46cc-baa1-3ad24c5112b6)

utilizarei ASP.NET para o desenvolvimento desta funcionalidade pois possui uma variedade de recursos e componentes integrados que facilitam a criação de formulários e o processamento de dados de cadastro.
Também utilizarei SQL Server pois é um sistema de gerenciamento de banco de dados relacional e é altamente compatível com a plataforma .NET e possui recursos avançados de segurança e escalabilidade.

# Matheus Gonçalves 
1 - Criação do protótipo da tela do carrinho de compras do site

2 - Na tela do carrinho de compras o cliente após entrar com suas credênciais consiguirá visualiar os items que ele adicionou. Mostrando quais produtos ele adicionou, quantidade, valor e total da compra. O usuários também será capaz de editar os items do carrinho.

- ![tela carrinho de compras - 1](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-1-e3-proj-back-t1-time2-projfifash/assets/75402234/e3763254-5319-4838-9b09-5b003fa66b2d)

3 - A parte de criação do código ainda está sendo processada. Por enquanto realizei pesquisas em videos e em algumas plataformas para saber qual a melhor maneira de realizar a criação do banco de dados junto as demais telas do site. Utilizei de ferramentas como o youtube e Inteligências artificiais para observar exemplos praticos e como executar a tarefa de um carrinho de compras funcional.

4 - Os códigos ainda estão em fases de testes, ou seja, não estão funcionais, sendo ainda protótipos quase teóricos

Exemplos de códigos que poderão ser futuramente implementados no back-end das telas:

![prototipo carrinho de compras - 1](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-1-e3-proj-back-t1-time2-projfifash/assets/75402234/683d9212-7be6-4e27-8537-11d8fd82dc98)

![prototipo carrinho de compras - 2](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-1-e3-proj-back-t1-time2-projfifash/assets/75402234/9a372ee5-3a28-4942-8da1-ba8833e490db)


