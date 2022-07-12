using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        return;
                    case 4: // keluar dari program
                        return;
                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.Title = "Responsi Pemrograman";
            Console.Write(" Pilih Menu :");
            Console.WriteLine();
            Console.Write("1.Tambah Data Penjualan");
            Console.WriteLine();
            Console.Write("2.Hapus Data Penjualan");
            Console.WriteLine();
            Console.Write("3.Tampilkan Penjualan");
            Console.WriteLine();
            Console.Write("4.Keluar");
            Console.WriteLine();
        }

        static void TambahPenjualan()
        {
            Console.Clear();

             Console.WriteLine("Tambah Penjualan");
            Console.Write("Nota : ");
            string nota = Console.ReadLine();
            Console.Write("Tanggal : ");
            string tanggal = Console.ReadLine();
            Console.Write("Costumer : ");
            string costumer = Console.ReadLine();
            Console.Write("Jenis [T/K] : ");
            string jenis = Console.ReadLine();
            if (jenis == "T")
            {
                jenis = "Tunai";
            }
            else
            {
                jenis = "Kredit";
            }
            Console.Write("Total Nota : ");
            double total = Convert.ToDouble(Console.ReadLine());

            daftarPenjualan.Add(new Penjualan() { Nota = nota, Tanggal = tanggal, Costumer = costumer, Jenis = jenis, Total = total });

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            Console.WriteLine("Hapus Data Penjualan");
            string hapus;
            Console.WriteLine("Nota : ");
            hapus = Console.ReadLine();
            int x = 0;
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                if (hapus == penjualan.Nota)
                {
                    daftarPenjualan.RemoveAt(x);
                    Console.WriteLine("Data Penjualan Berhasil Dihapus");
                    break;

                }
                x++;
                Console.WriteLine("Nota tidak ditemukan");
            }


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            Console.WriteLine("Data Penjualan");
            int no = 1;
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}",
                no, penjualan.Nota, penjualan.Tanggal, penjualan.Costumer, penjualan.Jenis, penjualan.Total);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
