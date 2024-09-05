# BankApp med konstruktorer

I det tredje steget gjorde vi om alla fält till _private_.
Anledningen till detta var att fält är vår datahantering av det interna tillståndet i våra objekt och denna information måste vi skydda till varje pris ifrån felaktigt utnyttjande.

###### I detta steg ska vi ta ett steg till och se hur vi kan skapa ett objekt med korrekt tillstånd.

Ett objekts tillstånd är detsamma som objektets värden som är satta(tilldelade) de privata fälten.

Ofta behöver vi kunna skriva kod för att kunna sätta fälten till korrekta värden när objekten skapas.
_Kom ihåg att ett objekt skapas genom att använda nyckelordet **new** tillsammans med klassens namn_

Ex. `BankAccount account = new BankAccount()`

Om vi kikar lite närmare på ovanstående syntax så ser vi att vi sätter parenteser efter _BankAccount()_.

Det betyder egentligen att vi anropar en metod som heter _BankAccount_ i klassen BankAccount. Detta kallas för att vi anropar klassens _constructor_ BankAccount.
Så det vi behöver göra för att skapa en \_constructor i vår klass är att skapa en metod som exakt samma namn som klassen.

Ex.

```
public BankAccount(){

}
```

❗️OBSERVERA ATT KONSTRUKTOR METODEN INTE RETURNERAR NÅGOT INTE ENS void❗️

Ex. Här ger vi värden till våra privata fält som vi anser att de ska ha när objektet skapas.

```
public BankAccount(){
  _accountNumber = "";
  _balance = 0;
  _interestRate = (decimal)0.0275;
}
```
