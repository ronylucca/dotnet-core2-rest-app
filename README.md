# dotnet-core2-rest-app

- Solução com projeto API Rest;
- Implementado com dotnet core 2_2;
- A aplicação encontra-se rodando no Heroku;
- Criei uma suite de testes(Collection) no Postman e disponibilizei para facilitar já com a url do Heroku =)
Basta importar o arquivo PostmanCollectionApiTests_DotnetCoreRestApi_RonyLucca.json como Collection no Postman.

URL Heroku
```
https://dotnet-core2-rest-app.herokuapp.com/
```


## Observações: 
  #### Para a API responsável em obter o MDR do adquirente segue:
  #### endpoint base(GET): https://dotnet-core2-rest-app.herokuapp.com/api/mdr/adquirente/{adquirente}
  #### estamos utilizando três Adquirentes diferentes possiveis ao acessar esta api
```
	exemplos: 
	- https://dotnet-core2-rest-app.herokuapp.com/api/mdr/adquirente/Stone
	- https://dotnet-core2-rest-app.herokuapp.com/api/mdr/adquirente/Cielo
	- https://dotnet-core2-rest-app.herokuapp.com/api/mdr/adquirente/Rede
```
          
         Ps. Caso não utilizado um dos três( "Stone", "Cielo", "Rede" ), será retornado 404 notFound
 
 #### Para a API responsável em obter o cálculo do valor liquido baseado nos dados  ( valor, adquirente, bandeira, tipoTransacao )  
 #### endpoint base(POST): https://dotnet-core2-rest-app.herokuapp.com/api/transaction
         
 ##### Contrato

```
{
	"valor":3450.00,
	"adquirente": "Stone",
	"bandeira": "Visa",
	"tipoTransacao": "Debito"
}
```
```
valor: precisa ser numérico(decimal)
adquirente: "Stone", "Cielo", "Rede"
bandeira: "Visa", "Master"
tipoTransacao: "Debito"ou "Credito"
```

### Rony de Lucca
### https://www.linkedin.com/in/ronylucca/
