Imports System.Data.OleDb
Public Class QLNhanVienn
    Private con As OleDbConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String


    Private Sub QLNhanVienn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String
        constring = "Provider=sqloledb;Data Source=DESKTOP-J8SR7CQ\SQLEXPRESS;Initial Catalog=QLNhanVien_DoThiHongKhanh;User Id=sa;Password=123456"
        con = New OleDbConnection(constring)
        Xuat_nv()
        danh_sach_moi(sender, e)

        Dim dt2 As New DataTable
        Dim sqlquery2 As String
        sqlquery2 = "select * from PhongBan"
        Dim SQL2 As New OleDbDataAdapter(sqlquery2, con)
        SQL2.Fill(dt2)
        Dim cmd2 As New OleDbCommand(sqlquery2, con)
        cbbMPB.DataSource = dt2
        cbbMPB.DisplayMember = "maPhongBan"

        Dim dt1 As New DataTable
        Dim sqlquery1 As String
        sqlquery1 = "select * from ChucVu"
        Dim SQL1 As New OleDbDataAdapter(sqlquery1, con)
        SQL1.Fill(dt1)
        Dim cmd1 As New OleDbCommand(sqlquery1, con)
        cbbMaCV.DataSource = dt1
        cbbMaCV.DisplayMember = "maChucVu"




    End Sub
    Private Sub Xuat_nv()
        Dim lenh As String
        lenh = "select * from NhanVien"
        Dim cmd As New OleDbCommand(lenh, con)
        con.Open()
        Dim bang_doc As OleDbDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("NhanVien")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        DataGridView_NV.DataSource = dttable
        danh_sach = Me.BindingContext(dttable)

    End Sub

    Private Sub xuat()
        txtmaNV.Text = danh_sach.Current("maNV")
        cbbMaCV.Text = danh_sach.Current("maChucVu")
        cbbMPB.Text = danh_sach.Current("maPhongBan")
        txtTenNV.Text = danh_sach.Current("tenNV")
        txtSDT.Text = danh_sach.Current("SDT")
        dateNgaySinh.Value = danh_sach.Current("ngaySinh")

        If danh_sach.Current("gioiTinh") = "Nam" Then
            rdobtnNam.Checked = True
        Else
            rdobtnNu.Checked = True
        End If
        txtDiaChi.Text = danh_sach.Current("diaChi")
    End Sub





    Private Sub danh_sach_moi(sender As Object, e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat()
    End Sub

    Private Sub btnLamMoi_nv_Click(sender As Object, e As EventArgs) Handles btnLamMoi_nv.Click
        txtmaNV.Text = "NV"
        txtTenNV.Text = ""
        txtSDT.Text = ""
        dateNgaySinh.Value = DateTime.Now.AddDays(0)
        rdobtnNam.Checked = False And rdobtnNu.Checked = False
        txtDiaChi.Text = ""
        cbbMaCV.Text = ""
        cbbMPB.Text = ""




    End Sub

    Private Sub btnThoat_nv_Click(sender As Object, e As EventArgs) Handles btnThoat_nv.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub btnThem_nv_Click(sender As Object, e As EventArgs) Handles btnThem_nv.Click
        Dim gioitinh$
        If rdobtnNam.Checked = True Then
            gioitinh = "Nam"
        Else
            gioitinh = "Nữ"
        End If
        If MsgBox("Bạn có muốn thêm không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thêm") = MsgBoxResult.Yes Then
            If txtmaNV.Text = "" Or txtTenNV.Text = "" Or txtSDT.Text = "" Or txtDiaChi.Text = "" Or rdobtnNam.Checked = False And rdobtnNu.Checked = False Or cbbMaCV.Text = "" Or cbbMPB.Text = "" Then
                MsgBox("Vui lòng điền dâyd đủ thông tin !!!")
            Else lenh = "insert into NhanVien(maNV, maChucVu, maPhongBan, tenNV, SDT, ngaySinh, gioiTinh, diaChi) values(
                   '" & txtmaNV.Text & "',
                   '" & cbbMaCV.Text & "',
                   '" & cbbMPB.Text & "',
                   N'" & txtTenNV.Text & "',
                   '" & txtSDT.Text & "', 
                   '" & dateNgaySinh.Value.Date.ToString("yyyyMMdd") & "',
                   N'" & gioitinh & "', 
                   N'" & txtDiaChi.Text & "')"
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_nv()
                MsgBox("Thêm thành công!")
            End If
        End If

    End Sub

    Private Sub btnSua_nv_Click(sender As Object, e As EventArgs) Handles btnSua_nv.Click
        Dim gioitinh$
        If rdobtnNam.Checked = True Then
            gioitinh = "Nam"
        Else
            gioitinh = "Nữ"
        End If
        If MsgBox("Bạn có muốn sửa không ? ", MsgBoxStyle.Question +
                    MsgBoxStyle.YesNo, "Sửa ") = MsgBoxResult.Yes Then
            lenh = "Update NhanVien 
               set  maNV= '" & txtmaNV.Text & "',
               maChucVu= '" & cbbMaCV.Text & "',
               maPhongBan= '" & cbbMPB.Text & "', 
               tenNV= N'" & txtTenNV.Text & "', 
               SDT= '" & txtSDT.Text & "', 
               ngaySinh='" & dateNgaySinh.Value.Date.ToString("yyyyMMdd") & "', 
               gioiTinh= N'" & gioitinh & "',
               diaChi=N'" & txtDiaChi.Text & "'
               where maNV =  '" & Trim(txtmaNV.Text) & "'"
            Dim cmd As New OleDbCommand(lenh, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Xuat_nv()
            MsgBox("Sửa thành công")
        End If

    End Sub

    Private Sub btnXoa_nv_Click(sender As Object, e As EventArgs) Handles btnXoa_nv.Click
        If MsgBox("Bạn có muốn xóa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                              "Xóa") = MsgBoxResult.Yes Then

            If txtmaNV.Text = "" Then
                MsgBox("Chọn giá trị cần xóa !!!")
            Else
                lenh = "delete from NhanVien where maNV = '" & txtmaNV.Text & "' "

                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_nv()
                MsgBox("Xóa thành công!")
                txtmaNV.Text = "NV"
                cbbMaCV.Text = ""
                cbbMPB.Text = ""
                txtTenNV.Text = ""
                txtSDT.Text = ""
                dateNgaySinh.Value = DateTime.Now.AddDays(0)
                rdobtnNam.Checked = False And rdobtnNu.Checked = False
                txtDiaChi.Text = ""
            End If
        End If

    End Sub

    Private Sub btnVeDau_nv_Click(sender As Object, e As EventArgs) Handles btnVeDau_nv.Click
        If danh_sach.Position = 0 Then
            MsgBox("Đã đến đầu danh sách")
        Else
            danh_sach.Position = 0
        End If
    End Sub

    Private Sub btnVeTruoc_nv_Click(sender As Object, e As EventArgs) Handles btnVeTruoc_nv.Click
        If danh_sach.Position = 0 Then
            MsgBox("Đã đến đầu danh sách")
        Else
            danh_sach.Position -= 1
        End If
    End Sub

    Private Sub btnVeSau_nv_Click(sender As Object, e As EventArgs) Handles btnVeSau_nv.Click
        If danh_sach.Position = danh_sach.Count - 1 Then
            MsgBox("Đã đến cuối danh sách")
        Else
            danh_sach.Position += 1
        End If
    End Sub

    Private Sub btnVeCuoi_nv_Click(sender As Object, e As EventArgs) Handles btnVeCuoi_nv.Click
        If danh_sach.Position = danh_sach.Count - 1 Then
            MsgBox("Đã đến cuối danh sách")
        Else
            danh_sach.Position = danh_sach.Count - 1
        End If
    End Sub

    Private Sub btnThoatNV_Click(sender As Object, e As EventArgs) Handles btnThoatNV.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class