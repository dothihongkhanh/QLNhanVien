Imports System.Data.OleDb
Public Class QLChucVu
    Private con As OleDbConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Private Sub QLChucVu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String
        constring = "Provider=sqloledb;Data Source=DESKTOP-J8SR7CQ\SQLEXPRESS;Initial Catalog=QLNhanVien_DoThiHongKhanh;User Id=sa;Password=123456"
        con = New OleDbConnection(constring)
        Xuat_nv()
        danh_sach_moi(sender, e)

    End Sub
    Private Sub Xuat_nv()
        Dim lenh As String
        lenh = "select * from ChucVu"
        Dim cmd As New OleDbCommand(lenh, con)
        con.Open()
        Dim bang_doc As OleDbDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("ChucVu")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        DataGridView_CV.DataSource = dttable
        danh_sach = Me.BindingContext(dttable)

    End Sub
    Private Sub xuat()
        txtMaCV.Text = danh_sach.Current("maChucVu")
        txtTenCV.Text = danh_sach.Current("tenChucVu")
        txtMoTa.Text = danh_sach.Current("moTa")
    End Sub

    Private Sub danh_sach_moi(sender As Object, e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat()
    End Sub

    Private Sub btnThoat_cv_Click(sender As Object, e As EventArgs) Handles btnThoat_cv.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnLamMoi_cv_Click(sender As Object, e As EventArgs) Handles btnLamMoi_cv.Click
        txtMaCV.Text = "CV"
        txtTenCV.Text = ""
        txtMoTa.Text = ""
    End Sub

    Private Sub btnThem_cv_Click(sender As Object, e As EventArgs) Handles btnThem_cv.Click
        If MsgBox("Bạn có muốn thêm không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thêm") = MsgBoxResult.Yes Then
            If txtMaCV.Text = "" Or txtTenCV.Text = "" Or txtMoTa.Text = "" Then
                MsgBox("Vui lòng điền dâyd đủ thông tin !!!")
            Else lenh = "insert into ChucVu( maChucVu, tenChucVu, moTa) values(
                   '" & txtMaCV.Text & "', 
                   N'" & txtTenCV.Text & "',
                   N'" & txtMoTa.Text & "')"
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_nv()
                MsgBox("Thêm thành công!")
            End If
        End If

    End Sub

    Private Sub btnSua_cv_Click(sender As Object, e As EventArgs) Handles btnSua_cv.Click
        If MsgBox("Bạn có muốn sửa không ? ", MsgBoxStyle.Question +
                    MsgBoxStyle.YesNo, "Sửa ") = MsgBoxResult.Yes Then
            lenh = "Update ChucVu 
               set maChucVu= '" & txtMaCV.Text & "',
               tenChucVu= N'" & txtTenCV.Text & "',
               moTa= N'" & txtMoTa.Text & "'
               where maChucVu =  '" & Trim(txtMaCV.Text) & "'"
            Dim cmd As New OleDbCommand(lenh, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Xuat_nv()
            MsgBox("Sửa thành công")
        End If

    End Sub

    Private Sub btnXoa_cv_Click(sender As Object, e As EventArgs) Handles btnXoa_cv.Click
        If MsgBox("Bạn có muốn xóa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                              "Xóa") = MsgBoxResult.Yes Then

            If txtMaCV.Text = "" Then
                MsgBox("Chọn giá trị cần xóa !!!")
            Else
                lenh = "delete from ChucVu where maChucVu = '" & txtMaCV.Text & "' "

                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_nv()
                MsgBox("Xóa thành công!")
                txtMaCV.Text = "CV"
                txtTenCV.Text = ""
                txtMoTa.Text = ""
            End If
        End If

    End Sub

    Private Sub btnVeDau_Click(sender As Object, e As EventArgs) Handles btnVeDau.Click
        If danh_sach.Position = 0 Then
            MsgBox("Đã đến đầu danh sách")
        Else
            danh_sach.Position = 0
        End If
    End Sub

    Private Sub btnVeTruoc_Click(sender As Object, e As EventArgs) Handles btnVeTruoc.Click
        If danh_sach.Position = 0 Then
            MsgBox("Đã đến đầu danh sách")
        Else
            danh_sach.Position -= 1
        End If
    End Sub

    Private Sub btnVeSau_Click(sender As Object, e As EventArgs) Handles btnVeSau.Click
        If danh_sach.Position = danh_sach.Count - 1 Then
            MsgBox("Đã đến cuối danh sách")
        Else
            danh_sach.Position += 1
        End If
    End Sub

    Private Sub btnVeCuoi_Click(sender As Object, e As EventArgs) Handles btnVeCuoi.Click
        If danh_sach.Position = danh_sach.Count - 1 Then
            MsgBox("Đã đến cuối danh sách")
        Else
            danh_sach.Position = danh_sach.Count - 1
        End If
    End Sub

    Private Sub btnThoatCV_Click(sender As Object, e As EventArgs) Handles btnThoatCV.Click
        Me.Hide()
    End Sub
End Class