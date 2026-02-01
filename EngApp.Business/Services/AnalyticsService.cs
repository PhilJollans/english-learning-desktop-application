using EngApp.Business.Interfaces;
using EngApp.Business.Models;
using EngApp.Data.Context;
using System;
using System.Linq;

namespace EngApp.Business.Services
{
    public class AnalyticsService : IAnalyticsService
    {
        private readonly EngAppDbContext _context;

        public AnalyticsService()
        {
            _context = new EngAppDbContext();
        }

        public AnalyticsData GetAnalytics()
        {
            var analytics = new AnalyticsData();
            var allWords = _context.Words.ToList();

            // Toplam kelime sayısı
            analytics.TotalWords = allWords.Count;

            // Bugün eklenen kelimeler
            var today = DateTime.Today;
            analytics.TodayWords = allWords.Count(w => w.AddedDate.Date == today);

            // Bu hafta eklenen kelimeler (son 7 gün)
            var weekAgo = DateTime.Today.AddDays(-7);
            analytics.ThisWeekWords = allWords.Count(w => w.AddedDate.Date >= weekAgo);

            // Toplam çalışma sayısı
            analytics.TotalReviews = allWords.Sum(w => w.ReviewCount);

            // Başarı oranı hesaplama
            var totalCorrect = allWords.Sum(w => w.CorrectCount);
            var totalWrong = allWords.Sum(w => w.WrongCount);
            var totalAttempts = totalCorrect + totalWrong;
            analytics.SuccessRate = totalAttempts > 0 
                ? Math.Round((double)totalCorrect / totalAttempts * 100, 1) 
                : 0;

            // En çok çalışılan kelimeler (ReviewCount'a göre top 10)
            analytics.MostStudiedWords = allWords
                .Where(w => w.ReviewCount > 0)
                .OrderByDescending(w => w.ReviewCount)
                .Take(10)
                .Select(w => new WordStatistic
                {
                    Text = w.Text,
                    Meaning = w.Meaning,
                    Count = w.ReviewCount
                })
                .ToList();

            // En zor kelimeler (WrongCount'a göre top 10)
            analytics.MostDifficultWords = allWords
                .Where(w => w.WrongCount > 0)
                .OrderByDescending(w => w.WrongCount)
                .Take(10)
                .Select(w => new WordStatistic
                {
                    Text = w.Text,
                    Meaning = w.Meaning,
                    Count = w.WrongCount
                })
                .ToList();

            // Spaced Repetition Statistics
            analytics.DueWordsToday = allWords.Count(w => w.NextReviewDate <= today);
            analytics.NewWords = allWords.Count(w => w.IsNew);
            analytics.LearningWords = allWords.Count(w => !w.IsNew && w.Repetitions < 4);
            analytics.MasteredWords = allWords.Count(w => w.Repetitions >= 4);

            // Calculate streak
            analytics.CurrentStreak = CalculateCurrentStreak(allWords);
            analytics.LongestStreak = CalculateLongestStreak(allWords);

            return analytics;
        }

        private int CalculateCurrentStreak(System.Collections.Generic.List<Core.Entities.Word> allWords)
        {
            if (!allWords.Any()) return 0;

            var today = DateTime.Today;
            var streak = 0;
            var checkDate = today;

            // Check backwards from today
            while (true)
            {
                var hasReview = allWords.Any(w => 
                    w.LastReviewedDate.HasValue && 
                    w.LastReviewedDate.Value.Date == checkDate);

                if (hasReview)
                {
                    streak++;
                    checkDate = checkDate.AddDays(-1);
                }
                else
                {
                    // Allow one day skip if we're checking today
                    if (checkDate == today && streak == 0)
                    {
                        checkDate = checkDate.AddDays(-1);
                        continue;
                    }
                    break;
                }
            }

            return streak;
        }

        private int CalculateLongestStreak(System.Collections.Generic.List<Core.Entities.Word> allWords)
        {
            if (!allWords.Any()) return 0;

            var reviewDates = allWords
                .Where(w => w.LastReviewedDate.HasValue)
                .Select(w => w.LastReviewedDate!.Value.Date)
                .Distinct()
                .OrderBy(d => d)
                .ToList();

            if (!reviewDates.Any()) return 0;

            int longestStreak = 1;
            int currentStreak = 1;

            for (int i = 1; i < reviewDates.Count; i++)
            {
                var daysDiff = (reviewDates[i] - reviewDates[i - 1]).Days;

                if (daysDiff == 1)
                {
                    currentStreak++;
                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
                else
                {
                    currentStreak = 1;
                }
            }

            return longestStreak;
        }
    }
}
