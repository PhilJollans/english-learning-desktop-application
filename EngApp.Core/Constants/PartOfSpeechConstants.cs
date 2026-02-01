using System.Collections.Generic;

namespace EngApp.Core.Constants
{
    /// <summary>
    /// Constants for grammatical part of speech categories
    /// </summary>
    public static class PartOfSpeechConstants
    {
        public const string Noun = "Noun";
        public const string Verb = "Verb";
        public const string Adjective = "Adjective";
        public const string Adverb = "Adverb";
        public const string Pronoun = "Pronoun";
        public const string Preposition = "Preposition";
        public const string Conjunction = "Conjunction";
        public const string Interjection = "Interjection";
        public const string Unknown = "Unknown";

        /// <summary>
        /// Get all valid part of speech values for UI binding
        /// </summary>
        public static List<string> GetAllValues()
        {
            return new List<string>
            {
                Noun,
                Verb,
                Adjective,
                Adverb,
                Pronoun,
                Preposition,
                Conjunction,
                Interjection,
                Unknown
            };
        }
    }
}
