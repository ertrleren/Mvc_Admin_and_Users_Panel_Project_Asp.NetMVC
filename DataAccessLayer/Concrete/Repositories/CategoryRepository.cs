using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal 
    {
        Context c=new Context();
        DbSet<Category> _object;

        public void Delete(Category p)
        {
            _object.Remove(p);  // (p) gelen değeri kaldır
            c.SaveChanges();   // contextte  değişiklikleri kaydet

        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category p)
        {
           _object.Add(p);  // (p) gelen değeri _onje sınıfına ekle
            c.SaveChanges();  // contextte  değişiklikleri kaydet
        }

        public void Inset(Category p)
        {
            throw new NotImplementedException();
        }

        public List<Category> List()
        {
            return _object.ToList();  // geriye _objectten gelen veriyi listele
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            c.SaveChanges();     // contextte  değişiklikleri kaydet
        }
    }
}

/*
ToList -- listeleme
add--  ekleme
remove--  silme
find-- bulma
 */
