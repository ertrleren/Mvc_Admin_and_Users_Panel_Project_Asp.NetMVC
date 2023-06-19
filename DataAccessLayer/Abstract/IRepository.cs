using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> //T değeri benim türüm olacak ve sql den gelen entityi karsılayacak
    {
        List<T> List();
        void Insert(T p);
        T Get(Expression<Func<T, bool>> filter);
        void Delete(T p); 
        void Update(T p);
        List<T> List(Expression<Func<T, bool>> filter); // Şartlı listeleme     Örnek yazar adı ali olanları getir

    }
}

// bu dosyada eklediğimiz fonsyonların tamamı Abstrac klasörü içerisindeki interfacelerin hepsine eklenmiş oldu. Diğer interfaceler IRepository ile fonksyonları ekliyor

