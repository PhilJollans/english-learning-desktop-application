#nullable disable
using System;
using System.Drawing;
using System.Windows.Forms;
using EngApp.Business.Interfaces;
using EngApp.Business.Services;
using EngApp.Business.Models;

namespace EngApp.UI
{
    public partial class AnalyticsForm : Form
    {
        private readonly IAnalyticsService _analyticsService;

        public AnalyticsForm()
        {
            InitializeComponent();
            _analyticsService = new AnalyticsService();
            LoadAnalytics();
        }

        private void LoadAnalytics()
        {
            try
            {
                var analytics = _analyticsService.GetAnalytics();

                // Update stat cards
                lblTotalWords.Text = analytics.TotalWords.ToString();
                lblTodayWords.Text = analytics.TodayWords.ToString();
                lblWeekWords.Text = analytics.ThisWeekWords.ToString();
                lblTotalReviews.Text = analytics.TotalReviews.ToString();
                lblSuccessRate.Text = $"{analytics.SuccessRate}%";

                var successValue = Math.Min(100, Math.Max(0, (int)analytics.SuccessRate));
                progressSuccess.Value = successValue;

                // Update title labels with SRS info
                lblSuccessRateTitle.Text = $"Success Rate\n🔥 Streak: {analytics.CurrentStreak} days";
                lblTotalReviewsTitle.Text = $"Total Studies\n📅 Due Today: {analytics.DueWordsToday}";
                lblWeekWordsTitle.Text = $"This Week\n📚 Learning: {analytics.LearningWords}";
                lblTodayWordsTitle.Text = $"Added Today\n⭐ Mastered: {analytics.MasteredWords}";
                lblTotalWordsTitle.Text = $"Total Words\n🆕 New: {analytics.NewWords}";

                // Update most studied words
                dgvMostStudied.DataSource = analytics.MostStudiedWords;

                // Update most difficult words
                dgvMostDifficult.DataSource = analytics.MostDifficultWords;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Analitik verileri yüklenirken hata oluştu:\n{ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
