# HydroSmart GUI - UTS Pemrograman Berbasis Objek (C# Windows Forms)

Versi tampilan jendela (GUI) dari HydroSmart. Logika (Models + Services) sama dengan versi konsol.

## Cara menjalankan di Visual Studio 2022 (Windows)
1. Extract zip, lalu buka file `HydroSmartGUI.sln` dengan Visual Studio 2022.
2. Pastikan workload **".NET desktop development"** terpasang (Tools > Get Tools and Features).
3. Tekan **F5** (Start) untuk menjalankan.

Butuh .NET 8 SDK (sudah ikut di Visual Studio 2022 versi 17.8 ke atas).

## Login
Akun demo: `admin` / `admin123` atau `petani` / `petani123`.

## Halaman
- Login (3x percobaan)
- Dashboard: ringkasan jumlah tanaman, siap panen, analisis
- Fitur 1 - Kelola Tanaman: tambah, lihat, ubah, hapus
- Fitur 2 - Analisis Penyakit: centang gejala, diagnosa + penanganan

Progress 50%: fitur Monitoring Nutrisi, Pengingat Perawatan, dan Logout belum dimasukkan.

## Edit tampilan lewat Designer
Klik dua kali `DashboardPage.cs`, `TanamanPage.cs`, atau `AnalisisPage.cs` di Solution Explorer: halaman akan terbuka di mode Design
dan semua tombol/kotak/tabel bisa digeser dan diubah. Kalau muncul pesan error di Designer, tekan **Build > Rebuild Solution** dulu lalu buka lagi.

## Struktur
```
Models/    -> kelas data (Tanaman abstract, Selada, Kangkung, Pakcoy, User, ...)
Services/  -> logika bisnis (TanamanService, AnalisisService, AuthService, Layanan)
Forms/     -> tampilan (LoginForm, MainForm, HalamanBase + 3 halaman (masing-masing ada file .Designer.cs), Tema)
Program.cs -> titik masuk (alur login -> utama)
```

## Konsep PBO
Abstraction (`Tanaman`, `IDiagnosa`), Inheritance (`Selada`/`Kangkung`/`Pakcoy` : `Tanaman`; semua halaman : `HalamanBase`),
Polymorphism (override batas pH/TDS, `TipsPerawatan()`, `FaseTumbuh()`, `Muat()`), Encapsulation (validasi setter `Nama`), Interface, Enum.

Data disimpan di memori (hilang saat aplikasi ditutup).
