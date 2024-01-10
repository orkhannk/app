

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Abbas", "Nermin ", "Tofiq" };
            byte[] ages = { 22, 33, 44, };
            string opt;
            do
            {
                Console.WriteLine("1.Butun telebelere bax ");
                Console.WriteLine("2.Yeni telebe elave et ");
                Console.WriteLine("3.Telebeler uzerinde axtaris et ");
                Console.WriteLine("4. Secilmis nomreli telebeni goster  ");
                Console.WriteLine("5.Secilmis nomreli telebeni sil ");
                Console.WriteLine("0.Cix");
                Console.WriteLine("\n Emeliyyat secin :");
                opt = Console.ReadLine();


                switch (opt)
                {
                    case "1":
                        for (int i = 0; i < names.Length; i++)

                            Console.WriteLine($"{i}.{names[i]} - {ages[i]}");
                        break;

                    case "2":
                        Console.WriteLine("adi  daxil edin :");
                        string name = Console.ReadLine();
                            Console.WriteLine("age :");
                            string agestr = Console.ReadLine();
                            byte age = Convert.ToByte(agestr);
                            Array.Resize(ref names, names.Length + 1);
                            names[names.Length - 1] = name;
                            Array.Resize(ref ages, ages.Length + 1);
                            ages[ages.Length - 1] = age;
                       
                        
                        break;


                    case "3":
                        WorkOnTheNameOfStudent(names);
                        break;


                    case "4":
                        Console.WriteLine("indexi daxil edin : ");
                        string indexStr = Console.ReadLine();
                        try
                        {
                            int index = Convert.ToInt32(indexStr);
                            Console.WriteLine($"name : {names[index]} - age : {ages[index]}  ");

                        }
                        catch
                        {
                            Console.WriteLine("xeta bas verdi !");

                        }
                        break;
                    case "5":
                        RemoveStudent(names);
                        
                        break;
                    case "0":
                        break;

                    default:Console.WriteLine("yanlis emeliyyat !");
                        break;


                }

            }
            while (opt != "0");

            static bool HasOnlyLetter(string str)
            {
                if (String.IsNullOrWhiteSpace(str)) return false;

                for (int i = 0; i < str.Length; i++)
                {
                    if (!char.IsLetter(str[i])) return false;
                }

                return true;
            }

            static bool CheckName(string name)
            {
                if (String.IsNullOrWhiteSpace(name)) return false;

                if (name.Length >= 3 && name.Length <= 20 && HasOnlyLetter(name)) return true;
                return false;
            }

            static void WorkOnTheNameOfStudent(string[] names)
            {
                Console.WriteLine("Axtaris deyerini daxil edin :!");
                string Name1 = Console.ReadLine();
                for(int i = 0; i < names.Length; i++)
                {
                    if (names[i].Contains(Name1))
                    {
                        Console.WriteLine(names[i]);
                        
                    }
                }
            }

            


            static void RemoveStudent(string[] names)
            {
                Console.WriteLine("silmek istediyiniz telebenin indeksini daxil edin : ");
                string indexStr = Console.ReadLine();
                int index = Convert.ToInt32(indexStr);
                string[] newArray = new string[names.Length - 1];
                int index1 = 0;
                for(int i = 0; i < names.Length; i++)
                {
                    if (i != index)
                    {
                        newArray[index1] = names[i];
                        index1++;

                    }
                    
                }
                for (int i = 0; i < newArray.Length; i++)
                {
                    Console.WriteLine(newArray[i]);
                }

            }

            
                  
            

        }
    }
}
