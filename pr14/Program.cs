using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using библиотека14pr;

namespace pr14
{
    internal class Program
    {
        static public string letters(string name)
        {
          
            for(int i=0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    return "Введите только буквы";
                   
                }

            }
            return "";
        }
        static public string numbers(string value)
        {
            int num;
            bool rez = Int32.TryParse(value, out num);
            if (rez)
            {
                return "";
            }
            else
            {
                if (value == null) value = "";
                 return "Введите число";
                
            }

        }
        static void Main(string[] args)
        {
            int i = 0;

            List<contact> a1 = new List<contact>();
            bool loop = true;
            string pr;
            string name;
            string telephone;
            string address;
            string type;
            string congratulation;
            string relation;
            string organization;
            string post;
            while (loop)
            {
                do {
                    Console.WriteLine("Введите имя");
                     name = Console.ReadLine();
                    pr = letters(name);
                    if (pr != "") Console.WriteLine(pr);
                }
                while (pr != "");
                do
                {
                    Console.WriteLine("Введите номер телефона");
                    telephone = Console.ReadLine();
                    pr = numbers(telephone);
                    if (pr != "") Console.WriteLine(pr);
                }
                while (pr != "");
                do
                {
                    Console.WriteLine("Введите адрес");
                    address = Console.ReadLine();
                    pr = letters(address);
                    if (pr != "") Console.WriteLine(pr);
                }
                while (pr != "");
                do
                {
                    Console.WriteLine("Введите вид");
                     type = Console.ReadLine();
                    pr=letters(type);
                    if (pr != "") Console.WriteLine(pr);
                }
                while (pr != "");
                Console.WriteLine("Личный контакт или Деловой?");
                string otvet1 = Console.ReadLine();
                if (otvet1 == "Личный контакт")
                {
                    Console.WriteLine("Введите дату рождения");
                    string userdate = Console.ReadLine();
                    DateTime date1 = DateTime.Parse(userdate);
                    do
                    {
                        Console.WriteLine("Введите необходимо ли поздравлять");
                        congratulation = Console.ReadLine();
                        pr=letters(congratulation);
                        if (pr != "") Console.WriteLine(pr);
                    }
                    while (pr != "");
                    do
                    {
                        Console.WriteLine("Введите семейные отношения");
                         relation = Console.ReadLine();
                        pr=letters(relation);
                        if (pr != "") Console.WriteLine(pr);
                    }
                    while (pr != "");
                    PersonalContacts contacts1 = new PersonalContacts(name, telephone, address, type, date1, congratulation, relation);
                    Console.WriteLine(contacts1.Info());
                    a1.Add(contacts1);
                }
                else if (otvet1 == "Деловой")
                {
                    do
                    {
                        Console.WriteLine("Введите организацию");
                         organization = Console.ReadLine();
                        pr=letters(organization);
                        if (pr != "") Console.WriteLine(pr);
                    }
                    while (pr != "");
                    do
                    {
                        Console.WriteLine("Введите должность");
                        post = Console.ReadLine();
                        pr=letters(post);
                        if (pr != "") Console.WriteLine(pr);
                    }
                    while (pr != "");
                    Console.WriteLine("Введите дату последнего контакта");
                    string date = Console.ReadLine();
                    DateTime date2 = DateTime.Parse(date);
                    Business contacts = new Business(name, telephone, address, type, organization, post, date2);
                    Console.WriteLine(contacts.Info());
                    a1.Add(contacts);
                }
                else
                {
                    Console.WriteLine("Введите корректный ответ");
                }
                Console.WriteLine("Ввести данные?");
                string otvet2 = Console.ReadLine();
                if (otvet2 == "Да")
                {
                    loop = true;
                }
                else
                {
                    loop = false;
                } 
            }
            for (int j = 0; j < a1.Count; j++)
            {
                Console.WriteLine(a1[i].Info());
            }
               
            
            Console.ReadKey();
        }
    }
}
