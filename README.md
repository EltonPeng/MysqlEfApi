# MysqlEfApi

Mysql with .NET Core 3.1 web api

## CMDs
dotnet new api -n mysqlEfApi

dotnet add package MySql.EntityFrameworkCore --version 3.1.10-m8.0.23

vi Dockerfile

docker build -t mysql-webapi . 

vi docker-compose.yaml

docker-compose up
