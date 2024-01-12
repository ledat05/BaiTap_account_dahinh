using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2_Dahinh_OPP
{
    internal class SanPham
    {
        private string tensanpham;
        private double giamua;
        //Phuong thuc khoi tao
        public SanPham() 
        { }
        public SanPham(string tensanpham, double giamua)
        {

            this.tensanpham = tensanpham;
            
            this.giamua = giamua;

        }
        //property
        public string TenSanPham
        {

            set { tensanpham = value; }
            get { return tensanpham; }
        }

        public double GiaMua
        {

            set { giamua = value; }
            get { return giamua; }

        }
        //cac phuong thuc ao
        public virtual double TinhGiaBan()

        {
            return 0;
        }
        public virtual string InChiTiet()
        {

            return tensanpham;

        }
        public virtual void Nhap()
        {

            Console.Write("Nhap ten san pham : ");
            tensanpham = Console.ReadLine();
            Console.Write("Nhap gia mua : ");
            giamua = double.Parse(Console.ReadLine());

        }
    }
}