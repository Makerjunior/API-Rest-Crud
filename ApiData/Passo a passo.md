## Conexão com Banco de dados Mysql.
_Pacotes necessários_ :

```
Microsoft.EntityFrameworkCore.Desing 
```
```
Microsoft.EntityFrameworkCore.Tools
```
```
Pomelo.EntityFrameworkCore.Mysql
```

Apos criar na pasta Model a classe ModelUsuario que será a representação do banco, ou  seja o Modelo de Entidade.
  Criamos  na pasta Context a Classe ApiDbContext que será arquivo de Contexto do banco.
Então, criamos a connectstring ou string de conexão, no arquivo appsetings.json com usuário, senha e nome do banco.
Instalamos o EF Core globalmente para podermos criar as migrations com o comando abaixo:
```
dotnet tool install --global dotnet-ef
```
Em seguida adicionamos a migration com o comando abaixo:
```
dotnet ef migrations add NomeDaMigração
```
E por último criamos o banco rodando a migrations com o comando abaixo :
```
dotnet ef database update
````
Será gerado um arquivo na pasta Migrations com a migration que nessa caso chamamos de first.
