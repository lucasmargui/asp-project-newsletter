<H1 align="center">Newsletter Structure</H1>
<p align="center">🚀 Project to create a newsletter structure for future references</p>



## Resources Used

* .NET 5.0

## Model Create

<details>
   <summary>Click to show content</summary>
  
### News Class
```
Models/Noticia.cs
```
Creation of a class that will serve as the basis for the news.

### News Repository Class
```
Models/RepositorioNoticias.cs
```
Creating a class that will serve as a data set representation

</details>


## Controller Create

<details>
   <summary>Click to show content</summary>
  
### HomeController

```
Controller/HomeController.cs
```

Change in homecontroller so that the page is loaded listing the news.

### NewsController

```
Controller/NoticiasController.cs
```
Creation of NoticiasController so that when clicking on the news, you are redirected to a page displaying details

</details>


## View Create

<details>
   <summary>Click to show content</summary>
  
### Index
```
Home/Index.cs
```
This view was generated from the Home/Index controller and modified with bootstrap elements

### Details
```
News/Details.cs
```
This view was generated from the Noticias/Details controller and modified with bootstrap elements

</details>


### Result

<div align="center">
     <h3>View Index</h3>
<img src="https://github.com/lucasmargui/ASP_Portal_de_Noticias/assets/157809964/d3e02408-0f39-4509-9e01-c82c75912811" style="width:90%">
</div>


<div align="center">
   <h3>View Details</h3>
<img src="https://github.com/lucasmargui/ASP_Portal_de_Noticias/assets/157809964/2562b83d-a32e-4501-b280-0aa6a1df2a4b" style="width:90%">
</div>
