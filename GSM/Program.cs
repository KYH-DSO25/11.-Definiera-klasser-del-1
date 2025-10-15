/*
 * 1    Skapa en klass som hanterar information om en mobiltelefon: modell, 
 *      tillverkare, pris, ägare, batteriegenskaper (modell, samtalstid och vilotid) 
 *      samt bildskärmsegenskaper (storlek, antal färger). 
 *      Skapa 3 separata klasser (klass GSM innehåller instanser av klasserna 
 *      Battery och Display)
 *      
 * 2    Skapa flera konstruktorer för klasserna som tar emot olika uppsättningar 
 *      argument (all information för klassen eller en delmängd). 
 *      Antag att modell och tillverkare är obligatoriska (de andra är frivilliga). 
 *      Alla okända fält sätts till null.
 * 
 * 3    Lägg till en enumeration BatteryType (Li-jon, NiMH, NiCd, …) och använd det 
 *      som ett nytt fält för batterier.
 * 
 * 4    Lägg till en metod till klassen GSM för att visa all information om den. 
 *      Försök gärna att göra en override av metoden ToString()
 * 
 * 5    Använd egenskaper för att kapsla in datafälten i klasserna GSM, 
 *      Battery och  Display
 * 
 * 6    Lägg till ett statiskt fält och en egenskap IPhone10 i klassen GSM för att 
 *      hantera information om iPhone 10
 */

using GSM;

GSM_Test.TestRunner();


Console.Write("Tryck på en tangent för att stänga fönstret...");
Console.ReadKey();