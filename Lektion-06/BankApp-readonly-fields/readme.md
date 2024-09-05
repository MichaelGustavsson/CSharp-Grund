# BankApp med skrivskyddade fält

I det tredje steget gjorde vi om alla fält till _private_.
Anledningen till detta var att fält är vår datahantering av det interna tillståndet i våra objekt och denna information måste vi skydda till varje pris ifrån felaktigt utnyttjande.

###### I detta steg ska vi ta ett steg till och se hur vi kan skydda vårt tillstånd ifrån ändringar förutom via en konstruktor metod.

Ibland finns det behov att skydda det interna tillståndet/data ifrån förändring till och med ifrån metoder eller egenskaper i klassen.

För att förhindra att förändringar görs inifrån klassen deklarerar vi fältet som skrivskyddat.
Ex. `private readonly decimal _interestRate`
Nyckelordet här är _readonly_, det gör att nu är det endast tillåtet att ändra eller ange ett värde på _\_interestRate_ via en konstruktor metod.

Ex. Här ger vi värden till våra privata fält som vi anser att de ska ha när objektet skapas. Vi sätter även värdet på _\_interestRate_ via konstruktorn.

```
public BankAccount(){
  _accountNumber = "";
  _balance = 0;
  _interestRate = (decimal)0.0275;
}
```
