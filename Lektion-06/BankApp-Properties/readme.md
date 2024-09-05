# BankApp med Properties

I det tredje(föregående) steget gjorde vi om alla fält till _private_.
Anledningen till detta var att fält är vår datahantering av det interna tillståndet i våra objekt och denna information måste vi skydda till varje pris ifrån felaktigt utnyttjande.

###### I detta fjärde steg ska vi ta oss lite mer närmare ett mer korrekt tillvägagångssätt.

Istället för att använda en förhistorisk teknik att skydda våra fält ska vi nu ta och titta på en mer modern metod som ofta användes i C# i tidigare versioner.
