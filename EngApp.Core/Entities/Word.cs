using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngApp.Core.Entities
{
    public class Word
    {
        public int Id { get; set; }

        public required string Text { get; set; }
        public required string Meaning { get; set; }
        public required string MySentence { get; set; }
        public required string Note { get; set; }
        public required string PartOfSpeech { get; set; }

        public DateTime AddedDate { get; set; }

        public int CorrectCount { get; set; }
        public int WrongCount { get; set; }
        public int ReviewCount { get; set; }

        public DateTime? LastReviewedDate { get; set; }

        // Spaced Repetition System (SRS) fields
        public DateTime NextReviewDate { get; set; }
        public double EaseFactor { get; set; }
        public int Interval { get; set; }
        public int Repetitions { get; set; }
        public bool IsNew { get; set; }
    }
}
