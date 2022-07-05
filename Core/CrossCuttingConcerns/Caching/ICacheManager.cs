using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key); //alt1
        object Get(string key);//alt2
        void Add(string key, object value, int duration);
        bool IsAdd(string key);//cache de varmı diye bakılır yoksa db den getir + cache de ekle
        void Remove(string key);
        void RemoveByPattern(string pattern);

       

    }
}
