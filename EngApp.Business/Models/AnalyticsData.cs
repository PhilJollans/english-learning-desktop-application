using EngApp.Core.Entities;
using System;
using System.Collections.Generic;

namespace EngApp.Business.Models
{
    public class AnalyticsData
    {
        // Basic Statistics
        public int TotalWords { get; set; }
        public int TodayWords { get; set; }
        public int ThisWeekWords { get; set; }
        public int TotalReviews { get; set; }
        public double SuccessRate { get; set; }

        // Spaced Repetition Statistics
        public int DueWordsToday { get; set; }
        public int CurrentStreak { get; set; }
        public int LongestStreak { get; set; }
        public int NewWords { get; set; }
        public int LearningWords { get; set; }
        public int MasteredWords { get; set; }
        
        public List<WordStatistic> MostStudiedWords { get; set; } = new List<WordStatistic>();
        public List<WordStatistic> MostDifficultWords { get; set; } = new List<WordStatistic>();
    }

    public class WordStatistic
    {
        public string Text { get; set; } = string.Empty;
        public string Meaning { get; set; } = string.Empty;
        public int Count { get; set; }
    }
}
