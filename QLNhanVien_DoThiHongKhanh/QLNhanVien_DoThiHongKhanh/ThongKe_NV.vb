Public Class ThongKe_NV
    Private Sub ThongKe_NV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QLNhanVien_DoThiHongKhanhDataSet.NhanVien' table. You can move, or remove it, as needed.
        Me.NhanVienTableAdapter.Fill(Me.QLNhanVien_DoThiHongKhanhDataSet.NhanVien)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnQLTC_Click(sender As Object, e As EventArgs) Handles btnQLTC.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class