using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter
{
    public class Prompt
    {
        public const string _Default_prompt = "Jupiter# ";
        public static string _User_prefered_prompt = "";
        public static string GetPromt()
        {
            string promptStr;
            if(_User_prefered_prompt.Length > 0) 
            {
                promptStr = _User_prefered_prompt;
            }
            else
            {
                promptStr = _Default_prompt;
            }
            return promptStr;
        }
    }
}
