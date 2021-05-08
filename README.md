**Desafio**
----
 Api desenvolvida em NET 5 e fluxo conversacional do bot da plataforma Blip.

* **URL**

  `https://bootblip.herokuapp.com/api/`
  
**Requirido:**
 
`user=[string]`
https://bootblip.herokuapp.com/api/{user}/repos

* **MÉTODO:**

  `GET`
  
*  **URL Params**

   `Sort`:	|string |	query | Ordernar repositórios a partir de: `created`, `updated`, `pushed`, `full_name`.
   `Direction`:	| string | query |	Tipo de Ordenação `asc` or `desc`, crescente ou decrescente.
   `limitResults`:	| int | query |	Numero derepositórios por requisição
   `language`:	| string | query | Classificar repositórios por language
   
   
* **Exemplo:**
  [link](https://bootblip.herokuapp.com/api/takenet/repos?sort=created&direction=asc&limitResults=5&language=c%23)
