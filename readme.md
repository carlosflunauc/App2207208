dotnet run: Ejecutar el programa
dotnet build: Para compilar y revisar errores
dotnet --version: para revisar la version del sdk de .net

1)  Descargar e instalar .net core 5.0 https://dotnet.microsoft.com/download

2)  Instalar Visual Studio Code
       2.1) Instalar extensiones:
                a) C# For Microsft
                b) C# Extensions jchannon
                c) C# Extension JosKreativ

3) Se debe instalar el Framework Entity de forma global.
       a) dotnet tool install --global dotnet-ef (instalacion del entity Framework)
       b) dotnet tool update --global dotnet-ef (actualizacion del entity Framework)

4) Instalar la solucion de Entity Framework (el programa que se va a construir)
        (MiprimeraApp es el nombre del programa a   construir)
        dotnet new sln -o MiprimeraApp

5) Instalar las librerias para generar la conexion con la base de datos e implementar las entidades del programa.
    a) dotnet new classlib -o MipriemraApp.Persistencia
    b) dotnet new classlib -o MipriemraApp.Dominio

6) Instalar la aplicacion web para crear el frontend del programa
    a) dotnet new webapp -o MiprimeraApp.frontend

7) Instalar la libreria de consola para realizar pruebas del programa.
    a) dotnet new console -o MiprimeraApp.Consola

8) Instalacion de paquetes:
            --version 5.0.9 (opciona para instalar una version especifica)
    dotnet add package Microsoft.EntityFrameworkCore 
    dotnet add package Microsoft.EntityFrameworkCore.Tools
    dotnet add package Microsoft.EntityFrameworkCore.Design
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer

    a) Carpeta Consola
        dotnet add package Microsoft.EntityFrameworkCore.Design

    b) Carpeta frontend
        dotnet add package Microsoft.EntityFrameworkCore.Design

    c) Carpeta Persistencia
        dotnet add package Microsoft.EntityFrameworkCore 
        dotnet add package Microsoft.EntityFrameworkCore.Tools
        dotnet add package Microsoft.EntityFrameworkCore.Design
        dotnet add package Microsoft.EntityFrameworkCore.SqlServer

9) Crear las referencias a las carpetas de persistencia y dominio; siempre y cuando analicemos que uniones debemos realizar dentro de los .csproj

    dotnet add reference ..\MiprimeraApp.Dominio
        a) Carpeta Consola referencia a Persistencia y Dominio
        b) Carpeta Persistencia referencia a Dominio

10) Crear las entidades en la carpeta Dominio

11) Crear el AppContext para realizar el mapeo de las entidades para crear la migracion y crear la conexion con la base de datos (SQL Server)

12) Crear la migracion a la base de datos
    12.1) Si no se tiene migraciones.
        a) dotnet ef migrations add Inicial --startup-project ..\MiprimeraApp.Consola\

    12.2) Si ya existe migraciones
        a) dotnet ef database update --startup-project ..\MiprimeraApp.Consola\

14) Agregar las referencias en Frontend de: Persistencia y Dominio

        dotnet add reference ..\MiprimeraApp.Dominio
        dotnet add reference ..\MiprimeraApp.Persistencia

15) Crear nueva pagina Razor:

    dotnet new page -n “Index”-na MiprimeraApp.frontend.Pages -o .\Pages\Pacientes

