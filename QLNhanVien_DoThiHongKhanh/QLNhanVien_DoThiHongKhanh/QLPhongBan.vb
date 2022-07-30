Imports System.Data.OleDb
Public Class QLPhongBan
    Private con As OleDbConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Private Sub QLPhongBan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String
        constring = "Provider=sqloledb;Data Source=DESKTOP-J8SR7CQ\SQLEXPRESS;Initial Catalog=QLNhanVien_DoThiHongKhanh;User Id=sa;Password=123456"
        con = New OleDbConnection(constring)
        Xuat_nv()
        danh_sach_moi(sender, e)


    End Sub
    Private Sub Xuat_nv()
        Dim lenh As String
        lenh = "select * from PhongBan"
        Dim cmd As New OleDbCommand(lenh, con)
        con.Open()
        Dim bang_doc As OleDbDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("PhongBan")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        DataGridView_PB.DataSource = dttable
        danh_sach = Me.BindingContext(dttable)

    End Sub
    Private Sub xuat()
        txtMaPB.Text = danh_sach.Current("maPhongBan")
        txtTenPB.Text = danh_sach.Current("tenPhongBan")
        txtSDTPB.Text = danh_sach.Current("SDTPhongBan")
        dateNgayThanhLap.Value = danh_sach.Current("ngayThanhLap")
    End Sub
    Private Sub danh_sach_moi(sender As Object, e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat()
    End Sub


    Private Sub btnThoat_pb_Click(sender As Object, e As EventArgs) Handles btnThoat_pb.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnLamMoi_pb_Click(sender As Object, e As EventArgs) Handles btnLamMoi_pb.Click
        txtMaPB.Text = "PB"
        txtTenPB.Text = ""
        txtSDTPB.Text = ""
        dateNgayThanhLap.Value = DateTime.Now.AddDays(0)
    End Sub

    Private Sub btnThem_pb_Click(sender As Object, e As EventArgs) Handles btnThem_pb.Click
        If MsgBox("Bạn có muốn thêm không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thêm") = MsgBoxResult.Yes Then
            If txtMaPB.Text = "" Or txtTenPB.Text = "" Or txtSDTPB.Text = "" Then
                MsgBox("Vui lòng điền dâyd đủ thông tin !!!")
            Else lenh = "insert into PhongBan( maPhongBan, tenPhongBan, SDTPhongBan, ngayThanhLap) values(
                   '" & txtMaPB.Text & "',
                   N'" & txtTenPB.Text & "',
                   '" & txtSDTPB.Text & "',
                   ' " & dateNgayThanhLap.Value.Date.ToString("yyyyMMdd") & "')"
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_nv()
                MsgBox("Thêm thành công!")
            End If
        End If

    End Sub

    Private Sub btnSua_pb_Click(sender As Object, e As EventArgs) Handles btnSua_pb.Click
        If MsgBox("Bạn có muốn sửa không ? ", MsgBoxStyle.Question +
                    MsgBoxStyle.YesNo, "Sửa ") = MsgBoxResult.Yes Then
            lenh = "Update PhongBan 
               set  maPhongBan= '" & txtMaPB.Text & "',
               tenPhongBan= '" & txtTenPB.Text & "',
               SDTPhongBan= '" & txtMaPB.Text & "',
               ngayThanhLap= '" & dateNgayThanhLap.Value.Date.ToString("yyyyMMdd") & "'
               where maPhongBan =  '" & Trim(txtMaPB.Text) & "'"
            Dim cmd As New OleDbCommand(lenh, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Xuat_nv()
            MsgBox("Sửa thành công")
        End If

    End Sub

    Private Sub btnXoa_pb_Click(sender As Object, e As EventArgs) Handles btnXoa_pb.Click
        If MsgBox("Bạn có muốn xóa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                              "Xóa") = MsgBoxResult.Yes Then

            If txtMaPB.Text = "" Then
                MsgBox("Chọn giá trị cần xóa !!!")
            Else
                lenh = "delete from PhongBan where maPhongBan = '" & txtMaPB.Text & "' "

                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_nv()
                MsgBox("Xóa thành công!")
                txtMaPB.Text = "PB"
                txtSDTPB.Text = ""
                txtTenPB.Text = ""
            End If
        End If
    End Sub

    Private Sub btnVeDau_pb_Click(sender As Object, e As EventArgs) Handles btnVeDau_pb.Click
        If danh_sach.Position = 0 Then
            MsgBox("Đã đến đầu danh sách")
        Else
            danh_sach.Position = 0
        End If
    End Sub

    Private Sub btnVeTruoc_pb_Click(sender As Object, e As EventArgs) Handles btnVeTruoc_pb.Click
        If danh_sach.Position = 0 Then
            MsgBox("Đã đến đầu danh sách")
        Else
            danh_sach.Position -= 1
        End If
    End Sub

    Private Sub btnVeSau_pb_Click(sender As Object, e As EventArgs) Handles btnVeSau_pb.Click
        If danh_sach.Position = danh_sach.Count - 1 Then
            MsgBox("Đã đến cuối danh sách")
        Else
            danh_sach.Position += 1
        End If
    End Sub

    Private Sub btnVeCuoi_pb_Click(sender As Object, e As EventArgs) Handles btnVeCuoi_pb.Click
        If danh_sach.Position = danh_sach.Count - 1 Then
            MsgBox("Đã đến cuối danh sách")
        Else
            danh_sach.Position = danh_sach.Count - 1
        End If
    End Sub

    Private Sub btnThoatPB_Click(sender As Object, e As EventArgs) Handles btnThoatPB.Click
        Me.Hide()
    End Sub


End Class