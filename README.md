<h1 align="center">
  <b>Arquitetura Limpa</b>
</h1>

## Objetivo
Iniciar os estudos sobre **Arquitetura Limpa**, para isso foi utilizado a [playlist](https://www.youtube.com/watch?v=Q6z7nj1jWFs&list=PLJ4k1IC8GhW0UmaO35Ng6ny9eoCm24tWQ&pp=iAQB) do **Marcos Macoratti** sobre esse assunto e nesse
repositório você encontra uma sumarização dos tópicos abordados e uma pequena adaptação do projeto contruído nesse curso para o contexto do meu agrado.

## Tipos de projetos

* 4 projetos Class Library
* 1 projeto Blazor

## Projeto
![image](https://github.com/vinicius-je/carshop-clean-architecture/assets/67986109/86be3536-317e-49db-97c9-17625ad84052)

## Dependências entre projetos

|          | CarShop  | Domain | Application | Infrastructure | CrossCutting | Blazor |
|----------|----------|----------|----------|----------|----------|----------|
| CarShop  |          |          |          |          |          |          |
| Domain   |          |          |          |          |          |          |
| Application  |          |     x     |          |          |          |          | 
| Infrastructure  |          |      x    |         |         |          |          |
| CrossCutting  |          |      x    |      x    |       x   |          |          |
| Blazor  |          |          |          |          |    x     |          |

## Responsabilidade por camada

* **Domain:** entidades, enumeradores, interfaces e regras de negócios.
* **Application:** lógica, interface para serviços, implementação dos serviços, dtos, mapeamentos.
* **Infrastructure:** repositórios, serviço de persistência, autenticação & autorização, serviços de email, serviços de cache e outros detalhes.
* **CrossCutting (Camada Transversal):** interfaces, implementação de serviços e injeção de dependência que são utilizados por outras camadas da aplicação.
* **Blazor:** interface com usuário.

## Tecnologias utilizadas

* C#
* Blazor
* Bootstrap
* SQLite

          
          
          
