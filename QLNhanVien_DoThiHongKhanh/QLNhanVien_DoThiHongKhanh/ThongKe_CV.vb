Public Class ThongKe_CV
    Private Sub ThongKe_CV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QLNhanVien_DoThiHongKhanhDataSet.ChucVu' table. You can move, or remove it, as needed.
        Me.ChucVuTableAdapter.Fill(Me.QLNhanVien_DoThiHongKhanhDataSet.ChucVu)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnThoatTKCV_Click(sender As Object, e As EventArgs) Handles btnThoatTKCV.Click
        Me.Close()
    End Sub

    Private Sub btnQLTC_Click(sender As Object, e As EventArgs) Handles btnQLTC.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class