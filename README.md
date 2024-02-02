<H1 align="center">Estrutura Portal Noticias</H1>
<p align="center">🚀 Projeto de criação de uma estrutura de portal noticias para referências futuras</p>



## Recursos Utilizados

* .NET 5.0

## Criação de Models

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


## Criação de Controller

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

## Criação da View

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

# Resultado

## View Index

<img src="https://cdn.discordapp.com/attachments/1046824853015113789/1202857548911218708/image.png?ex=65cefb63&is=65bc8663&hm=60d8bab30160c73bddb53e59bd48f972abc88694942873f0c41ab623aea945cd&" alt="">

## View Detalhes
<img src="https://cdn.discordapp.com/attachments/1046824853015113789/1202857768248414238/image.png?ex=65cefb97&is=65bc8697&hm=d76422b6643a6d9247c2be26ae0d434d1072e231678dd4166e78bf5508b8bbcb&" alt="">


