using System;

/*
 * ═══════════════════════════════════════════════════════════
 * STUDI KASUS: MENGHITUNG BANGUN RUANG
 * Kubus dan Balok dengan Function
 * author : adzrachmadhip
 * ═══════════════════════════════════════════════════════════
 */

class PerhitunganBangunRuang
{
    static void Main(string[] args)
    {
        bool lanjut = true;
        
        while (lanjut)
        {
            // Tampilkan menu utama
            TampilkanHeader();
            TampilkanMenu();
            
            Console.Write("Pilih menu (1-3): ");
            string pilihan = Console.ReadLine();
            
            Console.Clear();
            
            switch (pilihan)
            {
                case "1":
                    ProsesKubus();
                    break;
                case "2":
                    ProsesBalok();
                    break;
                case "3":
                    lanjut = false;
                    Console.WriteLine("👋 Terima kasih telah menggunakan program!");
                    break;
                default:
                    Console.WriteLine("❌ Pilihan tidak valid!");
                    break;
            }
            
            if (lanjut)
            {
                Console.WriteLine("\n\nTekan Enter untuk kembali ke menu...");
                Console.ReadLine();
            }
        }
    }
    
    // ═══════════════════════════════════════════════════════════
    // FUNCTION: TAMPILKAN HEADER
    // ═══════════════════════════════════════════════════════════
    static void TampilkanHeader()
    {
        Console.Clear();
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║    📦 KALKULATOR BANGUN RUANG 📦          ║");
        Console.WriteLine("║       Kubus & Balok                       ║");
        Console.WriteLine("╚════════════════════════════════════════════╝");
        Console.WriteLine();
    }
    
    // ═══════════════════════════════════════════════════════════
    // FUNCTION: TAMPILKAN MENU
    // ═══════════════════════════════════════════════════════════
    static void TampilkanMenu()
    {
        Console.WriteLine("Pilih Bangun Ruang:");
        Console.WriteLine("1. 🟦 Kubus");
        Console.WriteLine("2. 📦 Balok");
        Console.WriteLine("3. 🚪 Keluar");
        Console.WriteLine();
    }
    
    // ═══════════════════════════════════════════════════════════
    // FUNCTION: PROSES KUBUS
    // ═══════════════════════════════════════════════════════════
    static void ProsesKubus()
    {
        TampilkanHeaderKubus();
        
        // Input sisi kubus
        Console.Write("Masukkan panjang sisi kubus (cm): ");
        double sisi = double.Parse(Console.ReadLine());
        
        // Hitung dengan function
        double volume = HitungVolumeKubus(sisi);
        double luasPermukaan = HitungLuasPermukaanKubus(sisi);
        double kelilingAlas = HitungKelilingAlasKubus(sisi);
        
        // Tampilkan hasil
        TampilkanHasilKubus(sisi, volume, luasPermukaan, kelilingAlas);
    }
    
    // ═══════════════════════════════════════════════════════════
    // FUNCTION: PROSES BALOK
    // ═══════════════════════════════════════════════════════════
    static void ProsesBalok()
    {
        TampilkanHeaderBalok();
        
        // Input dimensi balok
        Console.Write("Masukkan panjang balok (cm): ");
        double panjang = double.Parse(Console.ReadLine());
        
        Console.Write("Masukkan lebar balok (cm): ");
        double lebar = double.Parse(Console.ReadLine());
        
        Console.Write("Masukkan tinggi balok (cm): ");
        double tinggi = double.Parse(Console.ReadLine());
        
        // Hitung dengan function
        double volume = HitungVolumeBalok(panjang, lebar, tinggi);
        double luasPermukaan = HitungLuasPermukaanBalok(panjang, lebar, tinggi);
        double kelilingAlas = HitungKelilingAlasBalok(panjang, lebar);
        
        // Tampilkan hasil
        TampilkanHasilBalok(panjang, lebar, tinggi, volume, luasPermukaan, kelilingAlas);
    }
    
    // ═══════════════════════════════════════════════════════════
    // FUNCTION: HITUNG VOLUME KUBUS
    // Rumus: V = s³
    // ═══════════════════════════════════════════════════════════
    static double HitungVolumeKubus(double sisi)
    {
        return sisi * sisi * sisi;
    }
    
    // ═══════════════════════════════════════════════════════════
    // FUNCTION: HITUNG LUAS PERMUKAAN KUBUS
    // Rumus: L = 6 × s²
    // ═══════════════════════════════════════════════════════════
    static double HitungLuasPermukaanKubus(double sisi)
    {
        return 6 * sisi * sisi;
    }
    
    // ═══════════════════════════════════════════════════════════
    // FUNCTION: HITUNG KELILING ALAS KUBUS
    // Rumus: K = 4 × s
    // ═══════════════════════════════════════════════════════════
    static double HitungKelilingAlasKubus(double sisi)
    {
        return 4 * sisi;
    }
    
    // ═══════════════════════════════════════════════════════════
    // FUNCTION: HITUNG VOLUME BALOK
    // Rumus: V = p × l × t
    // ═══════════════════════════════════════════════════════════
    static double HitungVolumeBalok(double panjang, double lebar, double tinggi)
    {
        return panjang * lebar * tinggi;
    }
    
    // ═══════════════════════════════════════════════════════════
    // FUNCTION: HITUNG LUAS PERMUKAAN BALOK
    // Rumus: L = 2 × (pl + pt + lt)
    // ═══════════════════════════════════════════════════════════
    static double HitungLuasPermukaanBalok(double panjang, double lebar, double tinggi)
    {
        return 2 * (panjang * lebar + panjang * tinggi + lebar * tinggi);
    }
    
    // ═══════════════════════════════════════════════════════════
    // FUNCTION: HITUNG KELILING ALAS BALOK
    // Rumus: K = 2 × (p + l)
    // ═══════════════════════════════════════════════════════════
    static double HitungKelilingAlasBalok(double panjang, double lebar)
    {
        return 2 * (panjang + lebar);
    }
    
    // ═══════════════════════════════════════════════════════════
    // FUNCTION: TAMPILKAN HEADER KUBUS
    // ═══════════════════════════════════════════════════════════
    static void TampilkanHeaderKubus()
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║           🟦 PERHITUNGAN KUBUS 🟦         ║");
        Console.WriteLine("╚════════════════════════════════════════════╝");
        Console.WriteLine();
        Console.WriteLine("Informasi:");
        Console.WriteLine("• Kubus memiliki 6 sisi yang sama");
        Console.WriteLine("• Semua rusuk kubus memiliki panjang sama");
        Console.WriteLine();
    }
    
    // ═══════════════════════════════════════════════════════════
    // FUNCTION: TAMPILKAN HEADER BALOK
    // ═══════════════════════════════════════════════════════════
    static void TampilkanHeaderBalok()
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║           📦 PERHITUNGAN BALOK 📦         ║");
        Console.WriteLine("╚════════════════════════════════════════════╝");
        Console.WriteLine();
        Console.WriteLine("Informasi:");
        Console.WriteLine("• Balok memiliki panjang, lebar, tinggi berbeda");
        Console.WriteLine("• Balok memiliki 6 sisi berbentuk persegi panjang");
        Console.WriteLine();
    }
    
    // ═══════════════════════════════════════════════════════════
    // FUNCTION: TAMPILKAN HASIL KUBUS
    // ═══════════════════════════════════════════════════════════
    static void TampilkanHasilKubus(double sisi, double volume, 
                                    double luasPermukaan, double kelilingAlas)
    {
        Console.WriteLine("\n╔════════════════════════════════════════════╗");
        Console.WriteLine("║              📊 HASIL PERHITUNGAN         ║");
        Console.WriteLine("╚════════════════════════════════════════════╝");
        Console.WriteLine();
        Console.WriteLine("Data Kubus:");
        Console.WriteLine($"  Panjang Sisi      : {sisi} cm");
        Console.WriteLine();
        Console.WriteLine("Hasil Perhitungan:");
        Console.WriteLine($"  Volume            : {volume:N2} cm³");
        Console.WriteLine($"  Luas Permukaan    : {luasPermukaan:N2} cm²");
        Console.WriteLine($"  Keliling Alas     : {kelilingAlas:N2} cm");
        Console.WriteLine();
        Console.WriteLine("Rumus yang digunakan:");
        Console.WriteLine($"  • Volume          : s³ = {sisi}³");
        Console.WriteLine($"  • Luas Permukaan  : 6 × s² = 6 × {sisi}²");
        Console.WriteLine($"  • Keliling Alas   : 4 × s = 4 × {sisi}");
    }
    
    // ═══════════════════════════════════════════════════════════
    // FUNCTION: TAMPILKAN HASIL BALOK
    // ═══════════════════════════════════════════════════════════
    static void TampilkanHasilBalok(double panjang, double lebar, double tinggi,
                                    double volume, double luasPermukaan, 
                                    double kelilingAlas)
    {
        Console.WriteLine("\n╔════════════════════════════════════════════╗");
        Console.WriteLine("║              📊 HASIL PERHITUNGAN         ║");
        Console.WriteLine("╚════════════════════════════════════════════╝");
        Console.WriteLine();
        Console.WriteLine("Data Balok:");
        Console.WriteLine($"  Panjang           : {panjang} cm");
        Console.WriteLine($"  Lebar             : {lebar} cm");
        Console.WriteLine($"  Tinggi            : {tinggi} cm");
        Console.WriteLine();
        Console.WriteLine("Hasil Perhitungan:");
        Console.WriteLine($"  Volume            : {volume:N2} cm³");
        Console.WriteLine($"  Luas Permukaan    : {luasPermukaan:N2} cm²");
        Console.WriteLine($"  Keliling Alas     : {kelilingAlas:N2} cm");
        Console.WriteLine();
        Console.WriteLine("Rumus yang digunakan:");
        Console.WriteLine($"  • Volume          : p × l × t = {panjang} × {lebar} × {tinggi}");
        Console.WriteLine($"  • Luas Permukaan  : 2(pl + pt + lt)");
        Console.WriteLine($"  • Keliling Alas   : 2(p + l) = 2({panjang} + {lebar})");
    }
}

/*
 * ═══════════════════════════════════════════════════════════
 * PENJELASAN FUNCTION YANG DIGUNAKAN
 * ═══════════════════════════════════════════════════════════
 * 
 * 1. TampilkanHeader() 
 *    - Return: void
 *    - Parameter: tidak ada
 *    - Fungsi: Tampilkan header program
 * 
 * 2. TampilkanMenu()
 *    - Return: void
 *    - Parameter: tidak ada
 *    - Fungsi: Tampilkan pilihan menu
 * 
 * 3. ProsesKubus()
 *    - Return: void
 *    - Parameter: tidak ada
 *    - Fungsi: Koordinasi proses perhitungan kubus
 * 
 * 4. ProsesBalok()
 *    - Return: void
 *    - Parameter: tidak ada
 *    - Fungsi: Koordinasi proses perhitungan balok
 * 
 * 5. HitungVolumeKubus(double sisi)
 *    - Return: double
 *    - Parameter: sisi (panjang sisi kubus)
 *    - Fungsi: Menghitung volume kubus
 * 
 * 6. HitungLuasPermukaanKubus(double sisi)
 *    - Return: double
 *    - Parameter: sisi
 *    - Fungsi: Menghitung luas permukaan kubus
 * 
 * 7. HitungKelilingAlasKubus(double sisi)
 *    - Return: double
 *    - Parameter: sisi
 *    - Fungsi: Menghitung keliling alas kubus
 * 
 * 8. HitungVolumeBalok(double panjang, double lebar, double tinggi)
 *    - Return: double
 *    - Parameter: panjang, lebar, tinggi
 *    - Fungsi: Menghitung volume balok
 * 
 * 9. HitungLuasPermukaanBalok(double panjang, double lebar, double tinggi)
 *    - Return: double
 *    - Parameter: panjang, lebar, tinggi
 *    - Fungsi: Menghitung luas permukaan balok
 * 
 * 10. HitungKelilingAlasBalok(double panjang, double lebar)
 *     - Return: double
 *     - Parameter: panjang, lebar
 *     - Fungsi: Menghitung keliling alas balok
 * 
 * 11. TampilkanHeaderKubus()
 *     - Return: void
 *     - Parameter: tidak ada
 *     - Fungsi: Tampilkan header kubus
 * 
 * 12. TampilkanHeaderBalok()
 *     - Return: void
 *     - Parameter: tidak ada
 *     - Fungsi: Tampilkan header balok
 * 
 * 13. TampilkanHasilKubus(...)
 *     - Return: void
 *     - Parameter: sisi, volume, luasPermukaan, kelilingAlas
 *     - Fungsi: Tampilkan hasil perhitungan kubus
 * 
 * 14. TampilkanHasilBalok(...)
 *     - Return: void
 *     - Parameter: panjang, lebar, tinggi, volume, luasPermukaan, kelilingAlas
 *     - Fungsi: Tampilkan hasil perhitungan balok
 * 
 * ═══════════════════════════════════════════════════════════
 * KEUNTUNGAN MENGGUNAKAN FUNCTION DALAM PROGRAM INI:
 * ═══════════════════════════════════════════════════════════
 * 
 * 1. REUSABLE
 *    - Function perhitungan bisa dipanggil berkali-kali
 *    - Tidak perlu copy-paste rumus
 * 
 * 2. MUDAH DITEST
 *    - Bisa test setiap function secara terpisah
 *    - Contoh: HitungVolumeKubus(10) harus return 1000
 * 
 * 3. MUDAH DIMAINTAIN
 *    - Kalau ada bug di rumus, tinggal fix 1 function
 *    - Tidak perlu cari-cari di banyak tempat
 * 
 * 4. READABLE
 *    - Main() jadi mudah dibaca
 *    - Seperti membaca flowchart
 * 
 * 5. MODULAR
 *    - Bisa tambah bangun ruang lain (tabung, bola, dll)
 *    - Tinggal tambah function baru
 * 
 * ═══════════════════════════════════════════════════════════
 * CONTOH PENGEMBANGAN:
 * ═══════════════════════════════════════════════════════════
 * 
 * Tambahkan bangun ruang lain dengan mudah:
 * 
 * static double HitungVolumeTabung(double jariJari, double tinggi)
 * {
 *     return 3.14 * jariJari * jariJari * tinggi;
 * }
 * 
 * static double HitungVolumeBola(double jariJari)
 * {
 *     return (4.0 / 3.0) * 3.14 * jariJari * jariJari * jariJari;
 * }
 * 
 * ═══════════════════════════════════════════════════════════
 */