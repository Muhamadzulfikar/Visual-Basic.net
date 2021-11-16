Module Module1

    Sub Main()
        Dim mahasiswa As New datamahasiswa
        mahasiswa.kampus = "Institut Teknologi Batam"
        mahasiswa.nama = "Muhamad Zulfikar"
        mahasiswa.nim = 2021018
        mahasiswa.fakultas = "Teknologi Informasi"
        mahasiswa.prodi = "Sistem Informasi"
        Console.WriteLine("Data Mahasiswa")
        Console.WriteLine("Kampus           : " + mahasiswa.kampus)
        Console.WriteLine("Nama Mahasiswa   : " + mahasiswa.nama)
        Console.WriteLine("NIM Mahasiswa    : " + Str(mahasiswa.nim))
        Console.WriteLine("Fakultas         : " + mahasiswa.fakultas)
        Console.WriteLine("Prodi            : " + mahasiswa.prodi)
        Console.ReadLine()

    End Sub

End Module
