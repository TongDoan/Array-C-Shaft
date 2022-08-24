using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    class mang {
        public int[] arr;
        public int n;
        public void nhap()
        {
            Console.Write("\n Nhap vao so phan tu cua mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\n Nhap vao gia tri cho phan tu thu {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void show()
        {
            Console.Write("\n Cac phan tu trong mang la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public void TimMax()
        {
            double max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.Write("\nGia tri lon nhat la: " + max);
        }
        public void tongday()
        {
            double s = 0;
            for(int i = 0; i < n; i++)
            {
                s+=arr[i];
            }
            Console.WriteLine("\nTong day la: " + s);
        }
        public void demsoam()
        {
            int dem = 0;
            for(int i = 0; i < n; i++)
            {
                if (arr[i] < 0) dem++;
            }
            if(dem == 0)
            {
                Console.WriteLine("Khong co phan tu am trong mang");
            }
            else
            {
                Console.WriteLine("So phan tu am la: " + dem);
            }
           
        }

    }
   
    
    internal class Program
    {
        static void Main(string[] args)
        {
            mang a = new mang();
            a.nhap();
            a.show();
            a.TimMax();
            a.tongday();
            a.demsoam();
        }
    }
}
