using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();

            string commandData = Console.ReadLine();

            while (commandData != "END")
            {
                string[] command = commandData
                    .Split(new string[] {" ", ", " }, StringSplitOptions.RemoveEmptyEntries);
                if(command[0] == "Push")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        int item = int.Parse(command[i]);
                        myStack.Push(item);
                    }
                }
                else if(command[0]=="Pop")
                {
                    try
                    {
                        myStack.Pop();
                    }
                    catch (InvalidOperationException ex)
                    {

                        Console.WriteLine(ex.Message);   
                    }
                }

                commandData = Console.ReadLine();
            }
            foreach (int item in myStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(string.Join(Environment.NewLine,myStack));
        }
    }
}
