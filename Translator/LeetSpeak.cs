using System;

namespace Translator
{
    public class LeetSpeak
    {

        public bool ToLeetSpeak(string characters)
        {
            char[] array = characters.ToCharArray();
            if (Array.IndexOf(array, 'e') == -1)
            {
                return false;
            }
            return true;

        } 


    }
}
