using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2_Dahinh_OPP
{
    internal class Socola:SanPham
    {
        private double loinhuan;
        //phuong thuc khoi tao
        public Socola()
        { }
        public Socola(string tensanpham, double giamua) : base(tensanpham, giamua)
        {

            loinhuan = GiaMua * 0.2;

        }
        //phuong thuc ghi de
        //tinh gia ban
        public override double TinhGiaBan()
        {

            return GiaMua + loinhuan;

        }
        public override string InChiTiet()
        {

            return TenSanPham + " " + TinhGiaBan();

        }
        public override void Nhap()
        {

            base.Nhap();
            loinhuan = GiaMua * 0.2;

        }
    }
}
