# # CatalogoCD's

<h2><b> Um sistema de catalogo de CD's. Teste aplicado pela empresa INTEEGRA </b></h2>


*O sistema foi desenvolvido na plataforma .NET Core com padrao de projeto MVC;<br />
        *Para o Mapeamento-Objeto relacional foi utilizado o ORM(Object-relational-mapping) - Entity Framework;<br />
        *Aplicacação web com Templete Engine - paginas @Razor; <br />
        *Providers de instalação MySql; <br />
        *Operaçoes do LINQ para consultas.<br />
        
        Comando para Adicionar o Providers da MySql:
        - Abra o Package Manager Console
        - Install-Package Pomelo.EntityFrameworkCore.MySql -Version 2.2.0
        
        
        Comando para Adicionar a Primeira Migration
        - Add-Migration Inicial
        
        Comando para Atualizar o banco d dados
        - Update-Database
