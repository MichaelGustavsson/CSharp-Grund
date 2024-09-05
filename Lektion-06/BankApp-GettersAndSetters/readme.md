# BankApp med Getters och Setters metoder

I detta tredje steget av BankApp ska vi ta och göra om alla fält till _private_.
Anledningen till detta är att fält är vår datahantering av det interna tillståndet i våra objekt och denna information måste vi skydda till varje pris ifrån felaktigt utnyttjande.

Tekniken som jag använder i detta exempel är bara ett exempel på hur man kan göra, men som inte är den fullständiga och kompletta lösningen på hur vi bör hantera fältens skydd.

Detta är en teknik som härstammar ifrån språk som C++ och Java.

**_Observera ändringen av namngivningen av de privata fälten._**
