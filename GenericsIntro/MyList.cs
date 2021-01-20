﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor = class ı bir yerde new lersek constructor otomatik çalışır
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                //tempArray deki geçici tutulan değerleri tekrar items üzerine alıyoruz
            }
            items[items.Length - 1] = item;
        }
    }
}
