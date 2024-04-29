using System;
using System.Text;

namespace HW_Strings
{
	public class StringHW
	{
		public StringHW()
		{
		}

		public void Task1_ConcatenateStrings(string str1, string str2)
		{
            var builder = new StringBuilder();
            builder.Append(str1);
			builder.Append(str2);
            Console.WriteLine($"Результат конкатенации: {builder.ToString()}");
        }

		public void Task2_GreetUser(string name, int age)
		{
			Console.WriteLine($"Hello, {name}!\nYou are {age} years old.");
		}

        public void Task3_GetStringInfo(string str)
        {
            Console.WriteLine($"Кол-во символов:{str.Length};\nСтрока в верхнем регистре: {str.ToUpper()};\nСтрока в нижнем регистре: {str.ToLower()}.");
        }

        public string Task4_GetSubstring(string str)
        {
            return str.Substring(0,5);
        }

        public string Task5_ArrayToSentence(String[] ArrayOfStr)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < ArrayOfStr.Length; i++)
            {
                builder.Append(ArrayOfStr[i]+" ");
            }
            return builder.ToString();
        }

        public string Task6_Replacement(string inputString, string wordToReplace, string replacementWord)
        {
            return inputString.Replace(wordToReplace, replacementWord);
        }
    }
}

