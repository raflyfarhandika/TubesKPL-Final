using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL_E_Pen
{
    public class ModelBiodata<x>
    {
        private x Nama { get; set; }
        private x Agama { get; set; }
        private x Pendidikan { get; set; }
        private x AlamatLengkap { get; set; }
        private x Namaorangtua { get; set; }
        private x jenisKelamin { get; set; }
        private x TanggalLahir { get; set; }

        public void BiodataPengguna(x NamaLengkap, x Agamaa, x PendidikanAkhir, x Alamat, x NamaOrtu, x Kelamin, x TglLahir)
        {
            Nama = NamaLengkap;
            Agama = Agamaa;
            Pendidikan = PendidikanAkhir;
            AlamatLengkap = Alamat;
            Namaorangtua = NamaOrtu;
            jenisKelamin = Kelamin;
            TanggalLahir = TglLahir;
        }


    }
}