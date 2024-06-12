using System.Collections.Generic;

namespace EstudosList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); //declaração de lista com instância junto

            list.Add("Maria"); //add, para adicionar a lista
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco"); //insert, insere em alguma posição especifica, por padrão ele insere ao final da lista

            foreach (string obj in list) //foreach para percorrer a lista e imprimir
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count); //mostra o número de strings na lista

            string s1 = list.Find(Test);  //achar algum indicador como no caso primeiro com letra A
            //a função find recebe como argumento outra função que faz o teste para a gente, porem não é obrigado a criar a função e trocar por uma Lambda
            //Função Lambda que seria o indicado |  string s1 = list.Find(x => x[0] == 'A'); forma resumida e melhor opção
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A'); //mesma coisa que Find, pórem para identificar o último caracter
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A'); //achar qual elemento da lista está na primeira posição com a letra A
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A'); //Achar qual elemento da lista está na última posição com a letra B
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5); //filtrar dentro de outra lista com alguma condição 
            Console.WriteLine("------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex"); //remover algo da lista
            Console.WriteLine("------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M'); //remover tudo da lista com base nos argumentos, no caso todos que possuem a letra M
            Console.WriteLine("------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(3); //remover com base na posição, apenas exemplo
            Console.WriteLine("------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2); //remover a partir de algo e quantos, no caso a partir da posiçao 2, remover 2 proximos elementos da lista, apenas exemplo
            Console.WriteLine("------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }

        static bool Test(string s) //teste para list.Find(), porém podemos trocar por uma expressão lambda
        {
            return s[0] == 'A';
        }
    }
}
    

