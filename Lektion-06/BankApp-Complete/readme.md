# BankApp med Autogenererade Properties(egenskaper)

###### I detta steg ska vi ta det slutgiltiga steget för att göra om våra privata fält och egenskaper att vara modern C# kod

För att slippa ange privata fält som vi sedan får åtkomst till via _Properties_ kan vi använda en väldigt trevlig syntax.

Ex.
`public string AccountNumber{get;set;}`

Observera att vi inte har någon kod(logik) i vare sig _get_ eller _set_ delen.

🤔 Vad pågår här egentligen?

Det som sker är att vi kan koncentrera oss på ge våra egenskaper läsbara namn med en korrekt betydelse och inte tänka på att skapa privata fält med kryptiska namn såsom, _\_accountNumber_ och så vidare.

Vad som sker under ytan är att när våra egenskaper kompileras av C# kompilatorn så genereras för varje egenskap ett matchande fält som får namnet efter våra egenskaper men med camelCase namngivning.

Så i vårt exempel ovan med egenskapen _AccountNumber_ skapar kompilatorn motsvarande privata fält _\_accountNumber_.

Syftet med Autogenererade egenskaper är att vi som utvecklare kan fokusera på vår applikation och logik och slippa duplicerad kod för att hantera de privata fälten.

😳 Men hur gör vi om vi vill ha en egenskap som är skrivskyddad eller endast ska få ett värde via konstruktorn?

För att skapa en skrivskyddad egenskap, det vill säga att applikationer inte ska kunna ange värde på egenskapen. Så tar vi helt enkelt och lägger till nyckelordet _private_ på _set_ delen i egenskapen.

Ex.
`public string AccountNumber{get; private set;}`

Om vi vill att endast konstruktorn får sätta ett värde och förhindra alla inklusive klassens egna metoder att ändra en egenskaps värde så tar vi helt enkelt bort _set_ ifrån egenskapen.

Ex.
`public string AccountNumber{get;}`
