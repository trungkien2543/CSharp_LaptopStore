using System;

namespace LaptopStore.DTO
{
	public class SanPhamDTO
	{
		public string IDLaptop { get; set; }
		public string TenSP { get; set; }
		public long GiaBan { get; set; }
		public string Hang { get; set; }
		public string CPU { get; set; }
		public int RAM { get; set; }
		public string GPU { get; set; }
		public string HinhAnh { get; set; }
		public string KichThuoc { get; set; }
		public string KhuyenMai { get; set; }

		// Constructor
		public SanPhamDTO() { }

		public SanPhamDTO(string idLaptop, string tenSP, long giaBan, string hang, string cpu, int ram, string gpu, string hinhAnh, string kichThuoc, string khuyenMai)
		{
            IDLaptop = idLaptop;
			TenSP = tenSP;
			GiaBan = giaBan;
			Hang = hang;
			CPU = cpu;
			RAM = ram;
			GPU = gpu;
			HinhAnh = hinhAnh;
			KichThuoc = kichThuoc;
			KhuyenMai = khuyenMai;
		}
	}

}