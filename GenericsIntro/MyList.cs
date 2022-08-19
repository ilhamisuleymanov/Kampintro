using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {

        T[] items;  // T tipli items adli massiv tesvir olunur
        public MyList()     //constructor
        {
            items = new T[0]; //constructor işə düşən kimi element olaraq (items) T massivini yaradır və 0-layır
        }
        public void Add(T item)  //dinamik olaraq massive element elave etmek (Length-i art;rmaq)
        {
            T[] tempArray = items;     //items massivini bufer (keçici) massive (tempArray) yazırıq ki, itmesin
            items = new T[items.Length + 1];   // her new əməliyyatı edərkən referans tipli obyekt yaranır,
                                               // lakin eyni adlı əvvəl mövcud massivin (obyektin) referans adresi də dəyişir və kohne-original massiv yox olur -uçur.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length-1] = item;  //public void Add(T item)

        }

        public int Length
        {
            get { return items.Length; }

        }

        public T[] Items           //Items 
        {
            get { return items; }

        }

    }
}
