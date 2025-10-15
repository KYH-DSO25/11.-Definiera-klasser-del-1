/*
* 7.    Skapa en klass GSMTest för att testa klassen GSM:
*           Skapa en array av några GSM
*           Visa informationen om GSMerna i arrayen
*           Visa information om den statiska egenskapen IPhone10
*/

namespace GSM;
class GSM_Test
{
    public static void TestRunner()
    {
        // Skapa några instanser av GSM
        List<GSM> mobilePhones = new List<GSM>();

        // Mobil nr 1
        {
            mobilePhones.Add(new GSM("Asha 501", "Nokia", "GLOBUL", 599.99m, new Display(3, 1250)));
        }
        // Mobil nr 2
        {
            GSM mobile = new GSM("Xperia ray", "Sony Ericsson");
            mobile.Owner = "Virizon";
            mobile.Price = 1000;
            mobile.Battery = new Battery(Battery.Type.NiMH);
            mobile.Battery.HoursTalk = 200;

            mobilePhones.Add(mobile);
        }

        // Skriv ut information om telefonerna
        foreach (var phone in mobilePhones)
        {
            Console.Write(phone);
        }

        // Telefon nr 3 finns som static i GSM. Skriv ut den
        Console.Write(GSM.Iphone10);
    }
}
