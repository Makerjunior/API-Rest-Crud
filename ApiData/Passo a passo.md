Conexãoc com Banco de dados Mysql
Apos criar na pasta Model A classe ModelUsuario que será a representação do banco ou Modelo de Entidade
Criamos a classe na pasta Context a Classe ApiDbContext que será arquivo que Contexto do Banco.
Então, Criamos a Connectstrng ou string de conexão no arquivo appsetings.json com usuário, senha, nome do banco
Istalamos o EF Coreglobalmenta para podermos criar as mugrations com o comando abaixo:
dotnet tool install --global dotnet-ef
Em seguida adicionar a migration com o comando abaixo :
dotnet ef migrations add NomeDaMigração
dotnet ef database update
Será gerado um arquivo na pasta Migrations com a migration que nessa caso chamamos de first
