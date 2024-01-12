using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2_Dahinh_OPP
{
    internal class NuocUong:SanPham
    {
        private double loinhuan;
        private double chiphigiulanh;
        //phuong thuc khoi tao
        public NuocUong() 
        { }
        public NuocUong(string tensanpham, double giamua) : base(tensanpham, giamua)
        {

            loinhuan = giamua * 0.15;
            chiphigiulanh = giamua * 0.1;

        }
        //phuong thuc ghi de
        public override double TinhGiaBan()
        {

            return GiaMua + loinhuan + chiphigiulanh;

        }
        public override string InChiTiet()
        {

            return TenSanPham + " " + TinhGiaBan();

        }
        public override void Nhap()
        {

            base.Nhap();
            loinhuan = GiaMua * 0.15;
            chiphigiulanh = GiaMua * 0.1;

        }
    }
}
