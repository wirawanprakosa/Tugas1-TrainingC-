using System;
using System.Collections.Generic;
using System.Linq;
public class Customer
{
    static void Main (string[] args)
    {
        // List<produk> produks = new List<produk>();
        List<string> listProdukNamaInput = new List<string>();
        List<string> listProdukJumlahInput = new List<string>();
        List<string> listProdukHargaInput = new List<string>();

        string produkNamaInput;
        string produkJumlahInput;
        string produkHargaInput;

        string customer;
        string produk;
        int jumlah;

        Console.WriteLine("=== Nama Produk ===");
        Console.Write("Masukkan Nama Produk (dipisah tanda koma) : ");
        produkNamaInput = Console.ReadLine();
        listProdukNamaInput = produkNamaInput.Split(',').ToList();

        Console.WriteLine("=== Jumlah Produk ===");
        Console.Write("Masukkan Jumlah Produk (dipisah tanda koma) : ");
        produkJumlahInput = Console.ReadLine();
        listProdukJumlahInput = produkJumlahInput.Split(',').ToList();

        Console.WriteLine("=== Harga Produk ===");
        Console.Write("Masukkan Harga Produk (dipisah tanda koma) : ");
        produkHargaInput = Console.ReadLine();
        listProdukHargaInput = produkHargaInput.Split(',').ToList();

        int jumlahSemuaProduk = 0;
        for (int i = 0; i < listProdukJumlahInput.Count; i++)
        {
            // produks[i].nama = listProdukNamaInput[i];
            // produks[i].jumlah = listProdukJumlahInput[i];
            jumlahSemuaProduk = jumlahSemuaProduk + Convert.ToInt32(listProdukJumlahInput[i]);
            // produks[i].harga = listProdukHargaInput[i];
        }

        int totalHargaSemuaProduk = 0;
        for (int i = 0; i < listProdukHargaInput.Count; i++)
        {
            totalHargaSemuaProduk = totalHargaSemuaProduk + Convert.ToInt32(listProdukHargaInput[i]);
        }

        Console.WriteLine($"Jumlah semua produk : {jumlahSemuaProduk}");
        Console.WriteLine($"Total harga semua produk : {totalHargaSemuaProduk}");

        Console.WriteLine("=== Pesanan Customer ===");
        Console.Write("Masukkan Nama Customer : ");
        customer = Console.ReadLine();

        Console.Write("Masukkan Nama Produk : ");
        produk = Console.ReadLine();

        Console.Write("Masukkan Jumlah Produk : ");
        jumlah = Convert.ToInt32(Console.ReadLine());

        int index = listProdukNamaInput.FindIndex(a => a.Contains(produk));

        Console.WriteLine($"Harga satuan produk : {listProdukHargaInput[index]}");
        Console.WriteLine($"Total Harga : {jumlah * Convert.ToInt32(listProdukHargaInput[index])}");
    }
}

// public class produk
// {
//     public string nama;
//     public int jumlah;
//     public int harga;
// }