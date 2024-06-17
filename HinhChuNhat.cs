using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HinhChuNhat_Class
{
    internal class HinhChuNhat
    {
        public double chieuCao;
        public double chieuRong;
        public double TinhDienTich()
        { 
            return chieuCao * chieuRong;
        }
        public double TinhChuVi()
        {
            return (chieuCao + chieuRong) * 2;
        }
    }  
}
