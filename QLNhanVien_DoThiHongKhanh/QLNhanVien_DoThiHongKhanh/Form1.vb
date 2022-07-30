Public Class Form1
    Private Sub ĐăngXuatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuatToolStripMenuItem.Click
        Dim tb$
        tb = MsgBox("Bạn muốn đăng xuất?", vbYesNoCancel, "Thông báo")
        If tb = 6 Then
            DangNhap.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub



    Private Sub QuảnLýPhòngBanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýPhòngBanToolStripMenuItem.Click
        QLPhongBan.Show()
        Me.Hide()
    End Sub

    Private Sub QuảnLýChứcVụToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýChứcVụToolStripMenuItem.Click
        QLChucVu.Show()
        Me.Hide()
    End Sub

    Private Sub ThoátToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub QuảnLýNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýNhânViênToolStripMenuItem.Click
        QLNhanVienn.Show()
        Me.Hide()
    End Sub

    Private Sub DanhSáchNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchNhânViênToolStripMenuItem.Click
        ThongKe_NV.Show()
        Me.Hide()
    End Sub

    Private Sub DanhSáchChứcVụToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchChứcVụToolStripMenuItem.Click
        ThongKe_CV.Show()
        Me.Hide()
    End Sub

    Private Sub DanhSáchPhòngBanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchPhòngBanToolStripMenuItem.Click
        ThongKe_PB.Show()
        Me.Hide()
    End Sub
End Class
