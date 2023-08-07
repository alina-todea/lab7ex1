using System;

namespace lab7ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /*
 Partea 1 POS-ul
Un POSl va accepta atat plata contactless cat si plata contact-full. Cele doua modalitati de plata vor fi modelate prin intermediul a doua metode, ce vor primi cate doi parametri:
1. Suma de plata
2. dispozitivul prin care se va efectua plata „ascuns” sub o interfata specifica fiecarui mod de plata.
Pentru plata prin intermediul POS-ului, clientul va putea folosi atat
     carduri clasice – suporta doar plati contactfull
     carduri contactless - suporta atat plati contact-full cat si plati contactless
     telefoanemobilecontactless-suportadoarplaticontactless

Descrierea interfetelor
Plata contact-full implica urmatoarele operatiuni:
     Introduce
     EfectueazaPlata
     Extrage
Plata contactless implica urmatoarele operatiuni:
     Apropie
     EfectueazaPlata

Instantiati casa, carduri, telefoane, efectuati plati.
Scrieti clasa, apelati metodele, efectuati plati. Pentru verificarea functionarii programului, metodele descrise vor afisa pe ecran mesaje adecvate.



Partea a 2-a Casa de marcat
Casa de marcat va oferi metode de plata cash sau prin intermediul unui POS.
    • In cazul platii cash, casa de marcat
        1. va deschide un seif
        2. va introduce suma in seif
        3. va inchide seif-ul
        4. Va elibera chitanta
        Aceasta functionalitate va fi modelata printr-o metoda care va primi un singur parametru, suma de plata. La fiecare dintre operatiunile de mai sus, un mesaj corespunzator va fi afisat pe ecran


• In cazul platii cu cardul, casa de marcat ---------> neimplementata
    1.Va trimite POS-ului suma de plata
        ▪ Comunicarea cu POS-ul va fi realizata prin intermediul unei interfete

    2.va pune la dispozitia clientului POS-ul.
        ▪ Pos-ul pus la dispozitia clientului va avea “incarcata” suma de plata
        ▪ Clientul (functia main) va decide modalitatea de plata prin intermediul cardului(contactless/contactfull)
Scrieti clasele, apelati metodele, efectuati plati. Pentru verificarea functionarii programului, metodele descrise vor afisa pe ecran mesaje adecvate.
      
             
             */


           
            var pos2 = new Pos(0);
            var casa = new Casa(100, pos2);
            

          

            Console.WriteLine("");

            
            
            casa.RequestPayment();
            string metodaPlata = Console.ReadLine();

            if (metodaPlata=="cash")
            {
                casa.ProcessSaleCash(120);
            }
            else if (metodaPlata== "card contactless")
            {
                //Console.WriteLine("habar n-am sa fac bucata asta");
                pos2.RequestPayment();
                IContactlessPay contactlessCard = new ContactlessCard(200);
                bool successContactlessCard = pos2.ProcessSaleCard(contactlessCard);
                pos2.ConfirmPayment("Contactless Card", successContactlessCard);
                Console.WriteLine("==========");
            }
            else if (metodaPlata == "card clasic")
            {
                //Console.WriteLine("habar n-am sa fac bucata asta");
                pos2.RequestPayment();
                IContactfulPay classicCard = new ContactfulCard(100);
                bool successClassicCard = pos2.ProcessSaleCard(classicCard);
                pos2.ConfirmPayment("Classic Card", successClassicCard);
                Console.WriteLine("==========");

            }
            else if (metodaPlata == "telefon")
            {
                //Console.WriteLine("habar n-am sa fac bucata asta");
                pos2.RequestPayment();
                IContactlessPay phone3 = new Phone(70);
                bool successPhone = pos2.ProcessSaleCard(phone3);
                //ConfirmPayment("Phone", successPhone);
                pos2.ConfirmPayment("Phone", successPhone);
                Console.WriteLine("==========");

            }
            else if (metodaPlata == "card")
            {
                pos2.RequestPayment();
                IContactfulPay contactlessCardAsContactful = new ContactlessCard(200);
                bool successContactlessCardAsContactful = pos2.ProcessSaleCard(contactlessCardAsContactful);
                pos2.ConfirmPayment("Contactless Card as Contactful", successContactlessCardAsContactful);
                Console.WriteLine("==========");
            }
            else
            {
                Console.WriteLine("nu dam pe caiet");
            }
        }
    }
}
