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

            // Perulangan menggunakan While
            while (true)
            {
                // Memanggil Fungsi TampilMenu
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");

                // menyimpan input yang dimasukkan user ke variable nomorMenu yang bertipe data integer
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                // Percabangan menggunakan switch case
                switch (nomorMenu)
                {
                    // Jika nomerMenu bernilai 1 maka akan meenjalankan blok berikut
                    case 1:
                        
                        // Menjalankan fungsi TambahPenjualan
                        TambahPenjualan();

                        // Keluar dari switch case
                        break;

                    // Jika nomerMenu bernilai 2 maka akan meenjalankan blok berikut
                    case 2:

                        // Menjalankan fungsi HapusPenjualan
                        HapusPenjualan();

                        // Keluar dari switch case
                        break;

                    // Jika nomerMenu bernilai 3 maka akan meenjalankan blok berikut
                    case 3:

                        // Menjalankan fungsi TampilPenjualan
                        TampilPenjualan();

                        // Keluar dari switch case
                        break;

                    // Jika nomerMenu bernilai 3 maka akan meenjalankan blok berikut
                    case 4: // keluar dari program
                        return;
                    default:
                        break;
                }
            }
        }

        // Deklarasi Fungsi TampilMenu
        static void TampilMenu()
        {
            // Membersihkan Layar Console 
            Console.Clear();

            // Memberikan judul Console
            Console.Title = "Responsi Pemrograman";

            // Menampilkan sebuah string tanpa pindah baris
            Console.Write(" Pilih Menu :");

            // Menampilkan sebuah string dengan pindah baris
            Console.WriteLine();

            // Menampilkan sebuah string tanpa pindah baris
            Console.Write("1.Tambah Data Penjualan");

            // Menampilkan sebuah string dengan pindah baris
            Console.WriteLine();

            // Menampilkan sebuah string tanpa pindah baris
            Console.Write("2.Hapus Data Penjualan");

            // Menampilkan sebuah string dengan pindah baris
            Console.WriteLine();

            // Menampilkan sebuah string tanpa pindah baris
            Console.Write("3.Tampilkan Penjualan");

            // Menampilkan sebuah string dengan pindah baris
            Console.WriteLine();

            // Menampilkan sebuah string tanpa pindah baris
            Console.Write("4.Keluar");

            // Menampilkan sebuah string dengan pindah baris
            Console.WriteLine();
        }

        // Deklarasi Fungsi TambahPenjualan
        static void TambahPenjualan()
        {
            // Membersihkan layar Console
            Console.Clear();

            // Menampilkan sebuah string dengan pindah baris
            Console.WriteLine("Tambah Penjualan");

            // Menampilkan sebuah string tanpa pindah baris
            Console.Write("Nota : ");

            // menyimpan input yang dimasukkan user ke variable nota yang bertipe data string
            string nota = Console.ReadLine();

            // Menampilkan sebuah string tanpa pindah baris
            Console.Write("Tanggal : ");

            // menyimpan input yang dimasukkan user ke variable tanggal yang bertipe data string
            string tanggal = Console.ReadLine();

            // Menampilkan sebuah string tanpa pindah baris
            Console.Write("Costumer : ");

            // menyimpan input yang dimasukkan user ke variable costumer yang bertipe data string
            string costumer = Console.ReadLine();

            // Menampilkan sebuah string tanpa pindah baris
            Console.Write("Jenis [T/K] : ");

            // menyimpan input yang dimasukkan user ke variable jenis yang bertipe data string
            string jenis = Console.ReadLine();

            // Pengkondisian jika niali variable jenis sama dengan string T maka eksekusi blok berikut
            if (jenis == "T")
            {

                // Assigment variable jenis dengan string Tunai
                jenis = "Tunai";
            }

            // Jika bukan maka esekusi blok berikut
            else
            {

                // Assigment nilai variable jenis dengan string Kredit
                jenis = "Kredit";
            }

            // Menampilkan sebuah string tanpa pindah baris
            Console.Write("Total Nota : ");

            // menyimpan input yang dimasukkan user ke variable total yang bertipe data double
            double total = Convert.ToDouble(Console.ReadLine());

            // Menambahkan element List
            daftarPenjualan.Add(new Penjualan() { Nota = nota, Tanggal = tanggal, Costumer = costumer, Jenis = jenis, Total = total });

            // Menampilkan sebuah string dengan pindah baris
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            
            // Membaca Key yang diinputkan user untuk melanjutkan program
            Console.ReadKey();
        }

        // Deklarasi fungsi HapusPenjualan
        static void HapusPenjualan()
        {
            // Membersihkan layar console
            Console.Clear();

            // Menampilkan sebuah string dengan pindah baris
            Console.WriteLine("Hapus Data Penjualan");
            
            // Menampilkan sebuah string tanpa pindah baris
            Console.WriteLine("Nota : ");

            // menyimpan input yang dimasukkan user ke variable hapus yang bertipe data string
            string hapus = Console.ReadLine();

            // deklarasi variable x dengan tipe data integer yang mempunyai value 0
            int x = 0;

            // Mengakses semua element daftarPenjualan menggunakan foreach
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                // Cek apakah hapus sama dengan objek penjualan
                if (hapus == penjualan.Nota)
                {
                    // Menghapus list pada index x
                    daftarPenjualan.RemoveAt(x);

                    // Menampilkan sebuah string dengan pindah baris
                    Console.WriteLine("Data Penjualan Berhasil Dihapus");

                    // Keluar dari perulangan foreach
                    break;

                }

                // Incerment value dari variable X
                x++;

                // Menampilkan sebuah string dengan pindah baris
                Console.WriteLine("Nota tidak ditemukan");
            }

            // Menampilkan sebuah string dengan pindah baris
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");

            // Membaca Key yang diinputkan user untuk melanjutkan program
            Console.ReadKey();
        }

        // Deklarasi fungsi TampilPenjualan
        static void TampilPenjualan()
        {
            // Membersihkan layar Console
            Console.Clear();

            // Menampilkan sebuah string dengan pindah baris
            Console.WriteLine("Data Penjualan");

            // Deklarasi variable no dengan tipe data Integer yang mempunyai value 1
            int no = 1;

            // Mengakses semua element daftarPenjualan menggunakan foreach
            foreach (Penjualan penjualan in daftarPenjualan)
            {

                // Menampilkan sebuah string dengan pindah baris
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}",
                no, penjualan.Nota, penjualan.Tanggal, penjualan.Costumer, penjualan.Jenis, penjualan.Total);
                
                // Incerment nilai variable no
                no++;
            }

            // Menampilkan sebuah string dengan pindah baris
            Console.WriteLine("\nTekan enter untuk kembali ke menu");

            // Membaca Key yang diinputkan user untuk melanjutkan program
            Console.ReadKey();
        }
    }
}
