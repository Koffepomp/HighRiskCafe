// Mål
// - Fråga användaren om den vill ha en kaffe och om den säger ja fråga vilken typ av alternativen ovan
// - Skapa en lista med strängar CoffeeTypes
// - Om användaren skriver en typ som inte finns, ska ett felmeddelande visas, och användaren ska få feedback att skriva in en annan typ
// - Skapa en klass Coffee med följande properties:
//      public bool IsDone { get; set }
//      public string CoffeeType { get; set; }
//      public string FailedStep { get; set; }
// - Skapa en klass CoffeeMaker som innehåller följande metoder (om du behöver mer är det ok):
//      MakeCoffee(public)
//      High Risk Café 2
//      AskForCoffee (private)
//      AskForCoffeeType(private)
//      ValidateCoffeeType(private)
//          Tar emot en sträng, coffeType och returnerar en bool om typen av kaffe finns i listan
//      CalculateSuccess (private)
//          Räknar ut om något steg har misslyckats med new Random().Next();
//      PutCoffeeInMachine(private)
//      PutWaterInMachine(private)
//      PlaceCupInMachine(private)
//      StartMachine(private)
//      ServeCoffeeToGuest(private)
// - Det enda som ska finnas i Program.cs är:
//      CoffeeMaker coffeeMaker = new();
//      coffeeMaker.MakeCoffee();
// - Ge varje steg ovan en 20% risk att misslyckas genom new Random().Next();
// - Om ett steg misslyckades ska det sparas en sträng i FailedStep-propertyn på Coffee-objektet om var det gick snett
// - Om alla steg gick bra ska det i ServeCoffeeToGuest returneras ett Coffee-objekt med IsDone satt till true.
//   Men det gick fel någonstans ska IsDone vara false när det returneras, och vi ska printa ut var felet uppstod