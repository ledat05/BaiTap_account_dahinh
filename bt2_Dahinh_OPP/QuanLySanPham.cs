using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2_Dahinh_OPP
{
    internal class QuanLySanPham
    {
        private string ten;
        private SanPham[] danhSachSP;
        private int n;

        public QuanLySanPham()
        {
            danhSachSP = new SanPham[100];
            ten = "Cua Hang Ban Le";
            n = 0;
        }
        public QuanLySanPham(int sophantu)
        {
            danhSachSP = new SanPham[sophantu];
            ten = "Cua Hang Ban Le";
            n = 0;
        }
        public void Nhap()
        {
            int luachon;
            SanPham sp;
            do
            {
                Console.WriteLine(" -- Moi ban chon loai san pham : ");
                Console.Write(" - 1. Socola | -2. Nuoc uong:");
                luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        sp = new Socola();
                        danhSachSP[n++] = sp;
                        sp.Nhap();
                        break;
                    case 2:
                        sp = new NuocUong();
                        danhSachSP[n++] = sp;
                        sp.Nhap();
                        break;
                }
            } while (luachon != 0);
        }
        public void InChiTiet()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(danhSachSP[i].InChiTiet());
            }
        }
    }
}
