# ECOMMERCE JUNTOS SOMOS MAIS

## TIME GRACE HOPPER

- Jamile Barroso
- Raquel de Noronha
- Thaynara Moreira

### Regra de Negócio:

A Juntos Somos Mais está construindo uma nova plataforma de e-commerce e precisa de uma API para gerenciar os pedidos, catálogo de produtos e cadastro de usuário.

O sistema deve permitir cadastro de novos clientes, incluindo dados pessoais e dados para contato, além de ser possível fazer a compra de produtos e associar a um pedido para o cliente cadastrado, e o histórico de pedido deve ser consultado.

### Intruções:

1. Para rodar a aplicação, só é preciso clonar o projeto e rodar na sua máquina local, não sendo necessário configurar o banco de dados pois utilizamos o SQLite do .NET que será executado quando a aplicação for executada.

2. Os dados do banco de dados são inseridos através do Migrations e pode ser consultado dentro do projeto da aplicação na pasta Migrations

3. Caso queira rodar a aplicacao no sql server, é preciso apagar a configuracao referente ao SQLite de dentro da da startup e do appsettings e descomentar a configuracao referente ao sql

3.1 Também é preciso deletar as migrations da aplicação pois são referentes ao banco SQLite

3.2 As inserções de dados do banco sql server podem ser realizadas através do script sql ou rodando novamente o migrations após realizar as alterações para o banco sql server

## Endpoints

- GET/api/clientes - Lista todos os clientes
- POST/api/clientes - Cadastra cliente
- GET/api/pedidos - Consulta pedidos por ID
- POST/api/pedidos - Cadastra pedido
- GET/api/produtos - Lista todos os produtos
- POST/api/produtos - Cadastra produto
- PUT/api/produtos - Atualiza produto
- GET/api/produtos/id - Consulta prooduto por ID
- DELETE/api/produtos/id - Deleta produto