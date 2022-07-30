create database QLNhanVien_DoThiHongKhanh
use QLNhanVien_DoThiHongKhanh
create table ChucVu
(
	maChucVu char(7) not null primary key,
	tenChucVu nvarchar(50) null,
	moTa nvarchar(30) null
)
create table PhongBan
(
	maPhongBan char (7) not null primary key,
	tenPhongBan nvarchar(50) null,
	SDTPhongBan char(11) null,
	ngayThanhLap date null
)

create table NhanVien
(
	maNV char(7) not null primary key,
	maChucVu char(7) not null,
	maPhongBan char(7) not null,
	tenNV nvarchar(50) null,
	SDT char (11) null,
	ngaySinh date null,
	gioiTinh nvarchar(3) null,
	diaChi nvarchar(50) null,
	foreign key (maChucVu) references ChucVu(maChucVu),
	foreign key (maPhongBan) references PhongBan(maPhongBan)
	--thiết lập ràng buộc phụ thuộc khi Xóa/Update
		on delete
			cascade
		on update 
			cascade
)
insert into ChucVu 
values
	('CV01',N'Trưởng phòng',N'Không có'),
	('CV02',N'Phó phòng',N'Không có')

insert into PhongBan 
values
	('PB01',N'Phòng hành chính','0124789546','01-01-2010'),
	('PB02',N'Phòng nhân sự','0574114552','01-01-2011'),
	('PB03',N'Phòng kế toán','0127745594','01-02-2010'),
	('PB05',N'Phòng kiểm toán','0122365429','01-02-2010')
set dateformat dmy
insert into NhanVien 
values
	('NV001','CV01','PB01',N'Nguyễn Văn An','0124789546','01-03-1999',N'Nam',N'Đà Nẵng'),
	('NV002','CV02','PB01',N'Lê Hữu Nam','0128745932','15-03-2000',N'Nam',N'Đà Nẵng'),
	('NV003','CV01','PB02',N'Phan Văn Nguyên','017748593','23-05-1999',N'Nam',N'Quảng Nam'),
	('NV004','CV02','PB03',N'Nguyễn Thị Lan','0174215435','01-06-1998',N'Nam',N'Đà Nẵng')
	select * from NhanVien