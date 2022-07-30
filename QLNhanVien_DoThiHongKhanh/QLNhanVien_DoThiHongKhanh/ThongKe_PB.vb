Public Class ThongKe_PB
    Private Sub ThongKe_PB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QLNhanVien_DoThiHongKhanhDataSet.PhongBan' table. You can move, or remove it, as needed.
        Me.PhongBanTableAdapter.Fill(Me.QLNhanVien_DoThiHongKhanhDataSet.PhongBan)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnThoatTKPB_Click(sender As Object, e As EventArgs) Handles btnThoatTKPB.Click
        Me.Close()
    End Sub

    Private Sub btnQLTC_Click(sender As Object, e As EventArgs) Handles btnQLTC.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class