using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplequeueveriyapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class SimpleQueue
    {
        public int[] dizi;
        private int kapasite;
        private int indeks;
        public SimpleQueue(int kapasite)
        {
            if (kapasite <= 0)
            {
                throw new Exception("Dizinin kapasitesi o veya 0'dan az olamaz.");
            }
            else
            {
                this.kapasite = kapasite;
                dizi = new int[kapasite];
            }
        }
        public void Enqueue(int deger)
        {
            if (isFull() == true)
            {
                throw new Exception("Diziye eleman eklemek için yer yoktur.");
            }
            dizi[indeks++] = deger;
        }
        public int Dequeue()
        {
            if (isEmpty() == true)
            {
                throw new Exception("Diziden eleman çıkarmak için eleman yoktur.");
            }
            int item = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = dizi[i + 1];
            }
            indeks--;
            return item;
        }
        public int Peek()
        {
            if (isEmpty() == true)
            {
                throw new Exception("Dizinin son giren bir elemanı yok.");
            }
            return dizi[0];
        }
        public int Size()
        {
            return indeks;
        }
        public bool isFull()
        {
            return indeks == kapasite;
        }
        public bool isEmpty()
        {
            return indeks == 0;
        }
        public void clear()
        {
            indeks = 0;
        }
    }
}
