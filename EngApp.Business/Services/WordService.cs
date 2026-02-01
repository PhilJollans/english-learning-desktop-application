using EngApp.Business.Interfaces;
using EngApp.Core.Entities;
using EngApp.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngApp.Business.Services
{
    public class WordService : IWordService
    {
        private readonly EngAppDbContext _context;

        public WordService()
        {
            _context = new EngAppDbContext();
        }

        public void Add(Word word)
        {
            word.AddedDate = DateTime.Now;
            word.CorrectCount = 0;
            word.WrongCount = 0;
            word.ReviewCount = 0;



            _context.Words.Add(word);
            _context.SaveChanges();
        }

        public void Update(Word word)
        {
            var existingWord = _context.Words.Find(word.Id);
            if (existingWord == null)
                throw new ArgumentException($"Word with ID {word.Id} not found.");

            // Update only the properties that are editable by user
            existingWord.Text = word.Text;
            existingWord.Meaning = word.Meaning;
            existingWord.MySentence = word.MySentence;
            existingWord.Note = word.Note;
            existingWord.PartOfSpeech = word.PartOfSpeech;
            
            // Keep tracking fields intact (AddedDate, CorrectCount, WrongCount, etc.)
            // These are NOT updated here
            
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var word = _context.Words.Find(id);
            if (word == null) return;

            _context.Words.Remove(word);
            _context.SaveChanges();
        }

        public List<Word> GetAll()
        {
            return _context.Words
                .OrderBy(w => w.Text)
                .ToList();
        }

        public Word? GetById(int id)
        {
            return _context.Words.Find(id);
        }

        public List<Word> GetForFlashcard(int takeCount)
        {
            return _context.Words
                .OrderByDescending(w =>
                    (w.WrongCount * 3) +
                    (w.ReviewCount == 0 ? 5 : 0) -
                    (w.CorrectCount))
                .Take(takeCount)
                .ToList();
        }

        public List<Word> GetRandomWords(int count)
        {
            return _context.Words
                .OrderBy(r => Guid.NewGuid())
                .Take(count)
                .ToList();
        }

        public List<string> GetDistractors(int correctWordId, int count)
        {
            return _context.Words
                .Where(w => w.Id != correctWordId && !string.IsNullOrEmpty(w.Meaning))
                .OrderBy(r => Guid.NewGuid())
                .Select(w => w.Meaning!)
                .Take(count)
                .ToList();
        }

        public List<Word> GetPrioritizedWords(List<int> excludeIds)
        {
            return _context.Words
                .Where(w => !excludeIds.Contains(w.Id))
                .OrderByDescending(w => w.WrongCount)
                .ThenBy(w => w.CorrectCount)
                .ThenBy(w => w.AddedDate)
                .ToList();
        }

        public void MarkCorrect(int wordId)
        {
            var word = _context.Words.Find(wordId);
            if (word == null) return;

            word.CorrectCount++;
            word.ReviewCount++;
            word.LastReviewedDate = DateTime.Now;

            _context.SaveChanges();
        }

        public void MarkWrong(int wordId)
        {
            var word = _context.Words.Find(wordId);
            if (word == null) return;

            word.WrongCount++;
            word.ReviewCount++;
            word.LastReviewedDate = DateTime.Now;

            _context.SaveChanges();
        }
    }
}
