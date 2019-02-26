# dotnet-core2-rest-app

Solução com projeto API Rest;
Implementado com dotnet core 2_2;


## Observações: 
  #### Para a API responsável em obter o MDR do adquirente segue:
  #### endpoint base(GET): https://localhost:5001/api/mdr/adquirente/{adquirente}
  #### estamos utilizando três Adquirentes diferentes possiveis ao acessar esta api
          ```
          exemplos: 
          - https://localhost:5001/api/mdr/adquirente/Stone
          - https://localhost:5001/api/mdr/adquirente/Cielo
          - https://localhost:5001/api/mdr/adquirente/Rede
          ```
          
         Ps. Caso não utilizado um dos três( "Stone", "Cielo", "Rede" ), será retornado 404 notFound
 
 #### Para a API responsável em obter o cálculo do valor liquido baseado nos dados  ( valor, adquirente, bandeira, tipoTransacao )  
 #### endpoint base(POST): https://localhost:5001/api/transaction
         
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
