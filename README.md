# projeto-estacionamento-dotnet
Projeto desenvolvido em .NET para serviço de estacionamento de veículos.

- Para testar a aplicação:
- Instale o docker na máquina;
- execute na raiz do projeto "docker compose up -d";
- configure o banco de dados conforme imagens abaixo;
- coloque no navegador http://localhost:8080
Faça o login
![login-db](https://github.com/user-attachments/assets/29289631-7290-46b1-985a-8a371f138b2d)

Crie um servidor
![registre um servidor](https://github.com/user-attachments/assets/357ec047-a633-4aae-adec-a6ce7a46d8d5)

Coloque o nome do database, usuario e senha conforme arquivo .env
![conexão](https://github.com/user-attachments/assets/888ebde0-891d-4c43-9371-12428ac0fbbe)

Pronto...
![database](https://github.com/user-attachments/assets/083adca0-9134-4cdb-9de7-c7bbb7d9daeb)

por final 
execute "dotnet ef database update" para as migrations

e por ultimo
execute "dotnet run"

abra o link para acessar a documentação 
https://localhost:7122/swagger
![swagger](https://github.com/user-attachments/assets/bc759ffd-7669-4696-863e-5f2d6883b9fe)
