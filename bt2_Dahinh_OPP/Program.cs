using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2_Dahinh_OPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLySanPham ql = new QuanLySanPham();
            ql.Nhap();
            ql.InChiTiet();
            Console.ReadLine();
        }
    }
}