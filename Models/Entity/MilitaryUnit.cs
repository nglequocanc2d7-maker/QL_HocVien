using System;

namespace QL_HocVien.Models.Entity
{
    public class MilitaryUnit
    {
        public int Id { get; set; }
        public string UnitCode { get; set; } = string.Empty; // cBB1, cBB2, cBB3, cBB4, dBB1, dBB2, eBB1, bBB1...
        public string UnitName { get; set; } = string.Empty; // Đại đội 1, Đại đội 2, Tiểu đoàn 1...
        public string ParentUnit { get; set; } = "Tiểu đoàn 1"; // Đơn vị cấp trên trực thuộc
        public string CommanderName { get; set; } = string.Empty; // Chỉ huy trưởng đơn vị
        public string ContactPhone { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
