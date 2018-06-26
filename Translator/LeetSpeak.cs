using System;

namespace Translator
{
    public class LeetSpeak
    {

        public string ToLeetSpeak(string characters)
        {
            
            char[] array = characters.ToCharArray();
            int index = 0;
            foreach (char letter in array)
            {
                if (Array.IndexOf(array, 'e') >= 0)
                {
                    array[(Array.IndexOf(array, 'e'))] = '3';
                }
                if (Array.IndexOf(array, 'o') >= 0)
                {
                    array[(Array.IndexOf(array, 'o'))] = '0';
                }
                if (Array.IndexOf(array, 'I') >= 0)
                {
                    array[(Array.IndexOf(array, 'I'))] = '1';
                }
                if (Array.IndexOf(array, 't') >= 0)
                {
                    array[Array.IndexOf(array, 't')] = '7';
                }
                if (index != 0 && letter == 's')
                {
                    array[index] = 'z';
                }
                index++;
            }
            return string.Join("", array); 
        } 


    }
}
