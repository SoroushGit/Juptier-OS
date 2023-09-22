using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter
{
    public class Commands
    {
        public static void Clear()
        {
            Console.Clear();
            return;
        }
        public static void NotFound()
        {
            Console.WriteLine("Command not found.");
        }

        public static void PowerOff()
        {
            Cosmos.System.Power.Shutdown();
        }
        public static void Reboot()
        {
            Cosmos.System.Power.Reboot();
        }
        public static void SetPrompt()
        {
            Console.Write("Enter the new prompt: ");
            string newPrompt = Console.ReadLine();
            newPrompt = newPrompt.TrimStart();
            string testPrompt = newPrompt.Trim();
            if (testPrompt == "")
            {
                Console.WriteLine("Empty prompt not valied.");
                return;
            }
            Prompt._User_prefered_prompt = newPrompt;
        }
        public static void SetPromptToDefault()
        {
            Prompt._User_prefered_prompt = "";
            Console.WriteLine("Changed to default.");
            return;
        }
        public static void About()
        {
            Console.WriteLine("Operating System name: " + Variables._Os_name);
            Console.WriteLine("Version: " + Variables._Os_version);
            Console.WriteLine("Command Prompt User Interface: " + Variables._Command_user_interface);
            Console.WriteLine("Graphical User Interface: " + Variables._Os_graphical_user_interface);
            Console.WriteLine("Developers: " + Variables._Os_developers);
            Console.WriteLine();
            return;
        }
        public static string GetUser()
        {
            if (Variables._User_name != "")
                return Variables._User_name;
            else
                return Variables._Default_user_name;
        }
        public static void SetUser()
        {
            Console.WriteLine("Current user name is: " + GetUser());
            Console.WriteLine("Set the new username: ");
            var Input = Console.ReadLine();
            Input = Input.Trim();
            if(Input == "")
            {
                Console.WriteLine("User name must not be empty.");
                return;
            }
            Variables._User_name = Input;
            return;
        }
        public static void SetUserToDefault()
        {
            Variables._User_name = "";
            Console.WriteLine("User has been set to default");
            return;
        }
    }
}
