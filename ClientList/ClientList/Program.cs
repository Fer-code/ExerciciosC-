//Fazendo um CRUD com uma lista
using System;
using System.Collections.Generic;
using ClientList;

public class Menu
{
    static void Main(string[] args)
    {
        bool sair = false;

        Cliente cliente = new Cliente();

        List<Cliente> listC = new List<Cliente>();

        while (!sair)
        {
            Console.Clear();

            Console.WriteLine("________________CLIENTES______________");

            Console.WriteLine("\n");
            Console.WriteLine("______Listagem de clientes:");
            foreach (Cliente cli in listC)
            {
                Console.WriteLine($"ID: {cli.id},Nome: {cli.nome}, Telefone: {cli.telefone}");
            }
            Console.WriteLine("\n");

            Console.WriteLine("1 - Adcionar cliente.");
            Console.WriteLine("2 - Excluir cliente.");
            Console.WriteLine("4- Sair");

            Console.WriteLine("\n");

            Console.WriteLine("Insira qual deseja:");

            switch (Console.ReadLine())
            {
                case "1":
                    try
                    {
                        Cliente clienteNovo = new Cliente();
                        Console.Clear();
                        Console.WriteLine("___Adcionar novo cliente");
                        Console.WriteLine("Nome: ");
                        clienteNovo.nome = Console.ReadLine();
                        Console.WriteLine("Telefone: ");
                        clienteNovo.telefone = Console.ReadLine();

                        int id = listC.Count + 1;

                        clienteNovo.id = id;

                        listC.Add(clienteNovo);
                    }catch (Exception ex) { Console.WriteLine(ex.Message); }
                    

                    Console.ReadLine();

                    break;

                case "2":
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("__Exclusão de clientes \n");
                        Console.WriteLine("Insira o ID do cliente");
                        int index = int.Parse(Console.ReadLine());
                        if (index >= 1 && index <= listC.Count)
                        {
                            listC.RemoveAt(index - 1);
                            Console.WriteLine("Item excluído com sucesso.");
                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                    
                    Console.ReadLine();

                    break;

                case "4":
                    sair = true;
                    break;

            }

        }
    }
}