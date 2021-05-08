**Desafio**
----
 Descrição da Api desenvolvida em NET 5 para a etapa técnica do processo seletivo da take blip.

* **URL**

  `https://bootblip.herokuapp.com/api/`
  
   **Requirido:**
 
   `user=[string]`
    https://bootblip.herokuapp.com/api/{user}/repos

* **MÉTODO:**

  `GET`
  
*  **URL Params**

   * `Sort`:	|string |	query | Ordernar repositórios a partir de: `created`, `updated`, `pushed`, `full_name`.
   * `Direction`:	| string | query |	Tipo de Ordenação `asc` or `desc`, crescente ou decrescente.
   * `limitResults`:	| int | query |	Número de repositórios por requisição
   * `language`:	| string | query | Classificar repositórios por liguagem de programação
   
   
* **Exemplo:**
  [https://bootblip.herokuapp.com/api/takenet/repos?sort=created&direction=asc&limitResults=5&language=c%23](https://bootblip.herokuapp.com/api/takenet/repos?sort=created&direction=asc&limitResults=5&language=c%23)
