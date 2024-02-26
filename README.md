<H1 align="center">Estrutura Portal Noticias</H1>
<p align="center">🚀 Projeto de criação de uma estrutura de portal noticias para referências futuras</p>



## Recursos Utilizados

* .NET 5.0

## Criação de Models

<details>
  <summary>Clique para mostrar conteúdo</summary>
  
### Classe Noticias
```
Models/Noticia.cs
```
Criação de classe que servirá como base para as noticias.

### Classe Repositório Noticias
```
Models/RepositorioNoticias.cs
```
Criação de classe que servirá como representação de conjunto de dados

</details>





## Criação de Controller

<details>
  <summary>Clique para mostrar conteúdo</summary>
  
### HomeController

```
Controller/HomeController.cs
```

Alteração em homecontroller para que a pagina seja carregada listando as noticias.

### NoticiasController

```
Controller/NoticiasController.cs
```
Criação de NoticiasController para que ao clicar sobre a noticia seja redirecionado para uma página exibindo detalhes

</details>




## Criação da View

<details>
  <summary>Clique para mostrar conteúdo</summary>
  
### Index
```
Home/Index.cs
```
Esta view foi gerada a partir do controller Home/Index e modificada com elementos de bootstrap

### Detalhes
```
Noticias/Detalhes.cs
```
Esta view foi gerada a partir do controller Noticias/Detalhes e modificada com elementos de bootstrap

</details>



# Resultado




<div align="center">
    <h3> View Index</h3>
<img src="https://github.com/lucasmargui/ASP_Portal_de_Noticias/assets/157809964/d3e02408-0f39-4509-9e01-c82c75912811" style="width:90%">
</div>


<div align="center">
  <h3>View Detalhes</h3>
<img src="https://github.com/lucasmargui/ASP_Portal_de_Noticias/assets/157809964/2562b83d-a32e-4501-b280-0aa6a1df2a4b" style="width:90%">
</div>




