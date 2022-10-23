using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun4Odev5
{
    internal class MyDictionary<Dkey , Dvalue>
    {
        KeyValuePair<Dkey , Dvalue>[] kullanicilar;

        public MyDictionary()
        {
            kullanicilar = new KeyValuePair<Dkey , Dvalue>[0];
        }

      

        public void AddManager()
        {
            KeyValuePair<Dkey, Dvalue>[] tempArray = kullanicilar;
            kullanicilar = new KeyValuePair<Dkey, Dvalue>[kullanicilar.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                kullanicilar[i] = tempArray[i];
            }

        }

        public void Add(Dkey _key, Dvalue _value)
        {
            AddManager();

            kullanicilar[kullanicilar.Length - 1] = new KeyValuePair<Dkey, Dvalue>(_key, _value);

        }

        public void Listele()
        {
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
