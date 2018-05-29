using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainingProject
{
    internal static class Task1

    {
        public static readonly Dictionary<Language, string[]> Phrases = new Dictionary<Language, string[]>
        {
            [Language.English] = new[] { "Good day!", "What's the news?" },
            [Language.French] = new[] { "Bonjour!", "Quelles sont les nouvelles?" },
        };

        //Dispalay list of available languages
        public static void DisplayLanguages()
        {
            Console.WriteLine("Select language to view phrases:");

            foreach (var language in Phrases.Keys)
            {
                Console.WriteLine($"{(int)language} - {language}");
            }
        }

        //Locate list of phrases for languages
        public static string[] GetPhrases(int enumNumber)
        {
            foreach (var phrase in Phrases)
            {
                if ((int)phrase.Key == enumNumber)
                {
                    return phrase.Value;
                }
            }

            return null;
        }

        //Dispalay list of phrases
        public static void DisplayPhrases(string[] phrases)
        {
            if (phrases == null || !phrases.Any())
            {
                Console.WriteLine("Somethig went wrong!");
                return;
            }

            Console.WriteLine(string.Join("\n", phrases));
        }

        //Return phrases for selected language
        public static void Main()
        {
            bool resumeSelection;

            do
            {
                DisplayLanguages();
                Console.WriteLine();

                var userTextInput = Console.ReadLine();

                var digitInput = int.Parse(userTextInput);
                Console.WriteLine();

                var phrases = GetPhrases(digitInput);
                DisplayPhrases(phrases);
                Console.WriteLine();

                resumeSelection = ContinueFurther();
                Console.WriteLine();

            } while (resumeSelection);
        }

        //Continue process
        public static bool ContinueFurther()
        {
            Console.WriteLine("Hit q to try again:");

            var SelectedKey = Console.ReadKey().KeyChar;
            var resumeSelection = SelectedKey.Equals('q');

            return resumeSelection;
        }
    }
}
