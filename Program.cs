using program;
using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PETSHOP

{
    class Program
    {
        static void Main(string[] args)
        {
            // Objek class collection
            List<JualKucing> listJualKucing = new List<JualKucing>();

            void TampilanJualKucing()
            {
                int noAntrian = 1;

                foreach (JualKucing JualKucing in listJualKucing)
                {
                    Console.WriteLine("{0}. Jenis Kucing: {1}, Jenis Kelamin: {2}, Jumlah Kucing: {3}, {4}", noAntrian, JualKucing.JenisKucing, JualKucing.JenisKelamin, JualKucing.JumlahKucing, JualKucing.Harga());

                    noAntrian++;
                }
            }

            void TambahHewan(string jeniskucing, string jeniskelamin, string jumlahkucing, double hargakucing)
            {
                listJualKucing.Add(new Hewan { JenisKucing = jeniskucing, JenisKelamin = jeniskelamin, HargaKucing = hargakucing, JumlahKucing = jumlahkucing });
            }

            void TambahMakanan(string jeniskucing, int jumlahmakanan, int hargamakanan)
            {
                listJualKucing.Add(new Makanan { JenisKucing = jeniskucing, JumlahMakanan = jumlahmakanan, HargaMakanan = hargamakanan });
            }

            void TambahAksesoris(string jeniskelamin, string jumlahkucing, int jumlahaksesoris, int hargaaksesoris)
            {
                listJualKucing.Add(new Aksesoris { JenisKelamin = jeniskelamin, JumlahKucing = jumlahkucing, JumlahAksesoris = jumlahaksesoris, HargaAksesoris = hargaaksesoris });
            }

            void HapusJualKucing()
            {
                int no = 1;
                int jumlah = 0;

                foreach (JualKucing jualkucing in listJualKucing)
                {
                    Console.WriteLine("{0}. Jenis Kucing : {1}", no, jualkucing.JenisKucing);

                    no++;
                    jumlah += 1;
                }
                Console.WriteLine();
                Console.Write("Pilih Data Yang Ingin Dihapus [1-");
                Console.Write(jumlah);
                Console.Write("] : ");
                int index_jeniskucing = int.Parse(Console.ReadLine());
                index_jeniskucing = index_jeniskucing - 1;

                listJualKucing.RemoveAt(index_jeniskucing);
                Console.WriteLine();
                Console.WriteLine("Data Kucing Berhasil Dihapus ");
                Console.WriteLine();
                Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
            }

            bool exit = false;
            while (exit == false)
            {
                Console.Title = "UAS - Polymorphsim, Inheritance, Abstraction & Collection";
                Console.WriteLine("Pilih Menu Aplikasi :");
                Console.WriteLine();
                Console.WriteLine("1. Tambah Data Kucing");
                Console.WriteLine("2. Hapus Data Kucing");
                Console.WriteLine("3. Tampilkan Data Kucing");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.Write("Nomer Menu [1..4] = ");
                int pilihan = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();

                if (pilihan < 1)
                {
                    Console.WriteLine("Menu Yang Anda Pilih Tidak Tersedia");
                }

                else if (pilihan > 4)
                {
                    Console.WriteLine("Menu Yang Anda Pilih Tidak Tersedia");
                }

                else if (pilihan == 1)
                {
                    Console.WriteLine("Tambah Data Kucing");
                    Console.WriteLine();
                    Console.Write("Jenis [1. Hewan, 2. Makanan, 3.Aksesoris ] : ");
                    int jenis = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (jenis == 1)
                    {
                        Console.Write("Jenis Kucing : ");
                        string jeniskucing = Console.ReadLine();
                        Console.Write("Jenis Kelamin : ");
                        string jeniskelamin = Console.ReadLine();
                        Console.Write("Jumlah Kucing : ");
                        string jumlahkucing = Console.ReadLine();
                        Console.Write("Harga Kucing : ");
                        int harga_kucing = int.Parse(Console.ReadLine());
                      //  string jns = "Hewan";

                        TambahHewan (jeniskucing, jeniskelamin, jumlahkucing, harga_kucing);
                    }

                    else if (jenis == 2)
                    {
                        Console.Write("Jenis Kucing : ");
                        string jeniskucing = Console.ReadLine();
                        Console.Write("Jumlah Makanan : ");
                        int jumlahmakanan = int.Parse(Console.ReadLine()); ;
                        Console.Write("Harga Makanan : ");
                        int hargamakanan = int.Parse(Console.ReadLine());
                      //  string jns = "Makanan";

                        TambahMakanan(jeniskucing, jumlahmakanan, hargamakanan);
                    }

                    else if (jenis == 3)
                    {

                        Console.Write("Jenis Kelamin : ");
                        string jeniskelamin = Console.ReadLine();
                        Console.Write("Jumlah Kucing : ");
                        string jumlahkucing = Console.ReadLine();
                        Console.Write("Jumlah Aksesoris : ");
                        int jumlahaksesoris = int.Parse(Console.ReadLine());
                        Console.Write("Harga Aksesoris : ");
                        int hargaaksesoris = int.Parse(Console.ReadLine());
                        //string jns = "Aksesoris";

                        TambahAksesoris(jeniskelamin, jumlahkucing, jumlahaksesoris, hargaaksesoris);
                    }
                    else
                    {
                        Console.WriteLine("Menu salah");
                    }
                    Console.WriteLine();
                    Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");


                }

                else if (pilihan == 2)
                {
                    HapusJualKucing();
                }

                else if (pilihan == 3)
                {
                    Console.WriteLine("Data Kucing");
                    Console.WriteLine();
                    TampilanJualKucing();

                    Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
                }

                else if (pilihan == 4)
                {
                    exit = true;
                }

                Console.ReadLine();
            }
        }
    }
}