using System;
using System.Collections.Generic;
using System.Text;

namespace SkalProj_Datastrukturer_Minne {

    class QuestionsAndAnswer {


        //                 Övning 1: ExamineList()
        
        // 1. Hur fungerar stacken och heapen ? Förklara gärna med exempel eller skiss på dess grundläggande funktion.

        /* 
        - Stacken används för att lagra lokala variabler av value typer till exempel int, double , long och refrence variabler till exemple 
        employee, student, car refrence variables.
        och metoder anrop DoThing() exempelvis.
        Variabler i stacken köras i tur ordning, stacken tar bort dem när de är färdigkörs.
        -Heapen används för att lagra klass, objekt, listor, ..osv  samt instatns variabler som är en del av klassen och är inte lokala variabler.
        Heapen tar inte bort själv objekter efter den körsfärdiga utan det är GC som tar hand om det.
         */

        //2. Vad är Value Types repsektive Reference Types och vad skiljer dem åt?

        /*
         Value Typer är variabler som lagras i stacken -eller heapen om den är instatns variabler och är en del av klassen- till exempel 
        Int, double,bool values 
         referens Typer är objekter som lagras i Heapen och har en referns namn som lagras i stacken.

         */

        //3. Följande metoder ( se bild nedan ) genererar olika svar. Den första returnerar 3, den
        // andra returnerar 4, varför?


        /*
          Iförsta bilden vi har 2 variabler x, y type Integer som  har 2 olika värde  från början x = 0; och y = 0; sen x, y tildellas nya 
        värde 
         x=3; y=x; alstå y fick samma värde som x  y = 3;
        sen y värde ändras till 4 y=4;  men x behållade den gamla värde x= 3; det är därför  första koden i bilden1 retunerar 3

         I bild2

        Vi skapade  objekt x som har värde MyValue =3  
        sen skapade vi objekt y 
        sen y = x och det betyder att referns y pekar på objekt x nu och att y objekt blev utan referens så GC kan tar bort y objekt 
        nu
        nu vi har vi en x object som har 2 referenser x och y
        och vi kan ändra property för x obj antengen me x referens eller y referens 
        y.MyValue = 4   är exakt samma om vi skriver x.MyValue = 4
        det är därför vi fick 4 i andra bilden
         */

        //2. När ökar listans kapacitet? (Alltså den underliggande arrayens storlek)?
        //3.Med hur mycket ökar kapaciteten?

        /*
         Först list kapacitet är 0 så fort vi ligger ett objekt list kapacitet ökar med 4 om vi ligger mer än 4 objecter eller variabler i listan ökar kapacitet 
        till 8 
        om vi förtsätta ligga mer än 8 objekter ökar kapacitet till 16  
        ligga mer än 16 objekter ökar kapacitet till 32   och sen till 64, 128, 256 ,.. osv.
         */
        //4.Varför ökar inte listans kapacitet i samma takt som element läggs till?

        /*
         List ökar inte när man ligga ett objekt till list utan den har fixed kapacitet från början , om man ligga mer objekter och finns inte mer tillgängliga platser
        för nya objekter dotnet ramverk skapar ett nytt list med double kapacitet och kopera den gamal list till den nya listan automatisk och på det här sätet ökar 
        kapacitet till den nya list när den blir fullt med objekter.         
         */
        //5. Minskar kapaciteten när element tas bort ur listan?

        /*
         Nej kapaciteten ska inte minskar
         */

        //6. När är det då fördelaktigt att använda en egendefinierad array istället för en lista?

        /*
          När man har bestämd och fixed antal av objekter som ska lagras i arrayen        
         
         */



        //                                                 Övning 3: ExamineStack()




        //        1. Simulera ännu en gång ICA-kön på papper.Denna gång med en stack.Varför är det
        //inte så smart att använda en stack i det här fallet?

        /*
         * för att den sist som kommer in i kön expedieras först 
         */

        //        2. Implementera en ReverseText-metod som läser in en sträng från användaren och
        //med hjälp av en stack vänder ordning på teckenföljden för att sedan skriva ut den
        //omvända strängen till användaren.














    }
}