using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Jupiter
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            BeforeRunBeautifier.Runner();
        }

        protected override void Run()
        {
            Console.Write(Prompt.GetPromt());
            var input = Console.ReadLine();
            input = input.ToLower();
            input = input.Trim();
            switch (input) 
            {
                case "":
                    break;
                case "clear":
                case "cls":
                case "pak":
                    Commands.Clear();
                    break;
                case "poweroff":
                case "khamoosh":
                case "shutdown":
                    Commands.PowerOff();
                    break;
                case "reboot":
                case "restart":
                    Commands.Reboot();
                    break;
                case "setprompt":
                    Commands.SetPrompt();
                    break;
                case "setprompttodefault":
                    Commands.SetPromptToDefault();
                    break;
                case "about":
                    Commands.About();
                    break;
                case "setuser":
                    Commands.SetUser();
                    break;
                case "getuser":
                    Console.WriteLine(Commands.GetUser());
                    break;
                case "setusertodefault":
                    Commands.SetUserToDefault();
                    break;
                default:
                    Console.WriteLine("Command not found.");
                    break;
            }
        }
    }
}
