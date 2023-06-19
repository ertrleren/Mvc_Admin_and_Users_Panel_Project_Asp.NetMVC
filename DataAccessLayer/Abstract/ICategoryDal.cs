using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal : IRepository<Category>
    {
        
    }
}
//Katmanlı mimaride, arayüz (interface) kavramı, farklı katmanlar arasındaki iletişimi ve etkileşimi sağlamak için kullanılır. Arayüzler, bir katmanın başka bir katmanla etkileşime geçtiği noktaları tanımlar // ve bu sayede katmanlar arasında bağımsızlık ve esneklik sağlanır. İşlevsel olarak arayüzler, aşağıdaki amaçları yerine getirir: