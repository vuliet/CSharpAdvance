using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int i, sum = 0, dem, j, k;
            Console.Write("\nDoc va in cac phan tu trong mang:\n");
            Console.Write("----------------------------------\n");

            Console.Write("Nhap 5 phan tu mang:\n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Phan tu {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nCac phan tu trong mang da nhap la: ");
            // In theo chieu xuoi
            // for (i = 0; i < 5; i++) 
            //{
            //    Console.Write("{0}  ", arr[i]);
            //}
            //Console.Write("\n");

            // In theo chieu dao nguoc
            for (i = 4; i >= 0; i--)  
            {
                sum += arr[i];
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
            Console.Write("Tong cac phan tu trong mang la: {0}\n\n", sum);
            for (i = 0; i < 5; i++)
            {
                dem = 1;

                /*kiem tra cac phan tu giong nhau truoc vi tri hien tai va  
                tang bien_dem them 1 neu tim thay.*/
                for (j = 0; j < i - 1; j++)
                {
                    /*tang bien dem khi tim thay phan tu giong nhau.*/
                    if (arr[i] == arr[j])
                    {
                        dem++;
                    }
                }
                /*kiem tra cac phan tu giong nhau sau vi tri hien tai va  
                tang bien_dem them 1 neu tim thay.*/
                for (k = i + 1; k < 5; k++)
                {
                    /*tang bien dem khi tim thay phan tu giong nhau.*/
                    if (arr[i] == arr[k])
                    {
                        dem++;
                    }
                }
                /*In gia tri cua vi tri hien tai trong mang - la gia tri duy nhat 
                khi con tro van chua gia tri ban dau cua no.*/
                if (dem == 1)
                {
                    Console.WriteLine("Phan tu {0} co gia tri duy nhat trong mang la: {1} ",i, arr[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
