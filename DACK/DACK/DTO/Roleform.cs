using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK
{
    public class Roleform
    {
       
        public int Id { get; set; }
        public int QuyenId { get; set; }
        public int ManhinhId { get; set; }
        public bool Truycap { get; set; }
        public bool Them { get; set; }
        public bool Xoa { get; set; }
        public bool Sua { get; set; }
        public bool Inan { get; set; }
        public bool Nhap { get; set; }
        public bool Xuat { get; set; }

    }
}
