Public Class DangNhap
    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        Dim tb$
        If txtTenDN.Text = "abc" And txtMatKhau.Text = "123" Then
            tb = MsgBox("Đăng nhập thành công!", vbOKOnly, "Thông báo")
            Form1.Show()
            Me.Hide()
        Else
            tb = MsgBox("Tên đăng nhập hoặc mật khẩu không đúng, vui lòng nhập lại!", vbOKOnly, "Thông báo")
            txtTenDN.Text = ""
            txtMatKhau.Text = ""
        End If


    End Sub



    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub DangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckBox1.Checked = True Then
            txtTenDN.Text = "abc"
            txtMatKhau.Text = "123"
        Else
            txtTenDN.Text = ""
            txtMatKhau.Text = ""
        End If
    End Sub
End Class