using EngApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngApp.Business.Interfaces
{
    public interface IWordService
    {
        void Add(Word word);
        void Update(Word word);
        void Delete(int id);

        List<Word> GetAll();
        Word? GetById(int id);

        List<Word> GetForFlashcard(int takeCount);
        
        List<Word> GetRandomWords(int count);
        List<string> GetDistractors(int correctWordId, int count);
        List<Word> GetPrioritizedWords(List<int> excludeIds);
        
        void MarkCorrect(int wordId);
        void MarkWrong(int wordId);
    }
}
