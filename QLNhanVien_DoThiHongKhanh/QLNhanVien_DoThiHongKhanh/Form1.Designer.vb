<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TàiKhoảnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐăngXuatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýNhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýPhòngBanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýChứcVụToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThốngKêToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchNhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchChứcVụToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchPhòngBanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TàiKhoảnToolStripMenuItem, Me.QuảnLýNhânViênToolStripMenuItem, Me.QuảnLýPhòngBanToolStripMenuItem, Me.QuảnLýChứcVụToolStripMenuItem, Me.ThốngKêToolStripMenuItem, Me.ThoátToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(988, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TàiKhoảnToolStripMenuItem
        '
        Me.TàiKhoảnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ĐăngXuatToolStripMenuItem})
        Me.TàiKhoảnToolStripMenuItem.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.account
        Me.TàiKhoảnToolStripMenuItem.Name = "TàiKhoảnToolStripMenuItem"
        Me.TàiKhoảnToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.TàiKhoảnToolStripMenuItem.Text = "Tài khoản"
        '
        'ĐăngXuatToolStripMenuItem
        '
        Me.ĐăngXuatToolStripMenuItem.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.lognout
        Me.ĐăngXuatToolStripMenuItem.Name = "ĐăngXuatToolStripMenuItem"
        Me.ĐăngXuatToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ĐăngXuatToolStripMenuItem.Text = "Đăng xuất"
        '
        'QuảnLýNhânViênToolStripMenuItem
        '
        Me.QuảnLýNhânViênToolStripMenuItem.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.qlnv
        Me.QuảnLýNhânViênToolStripMenuItem.Name = "QuảnLýNhânViênToolStripMenuItem"
        Me.QuảnLýNhânViênToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.QuảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên"
        '
        'QuảnLýPhòngBanToolStripMenuItem
        '
        Me.QuảnLýPhòngBanToolStripMenuItem.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.qlpban
        Me.QuảnLýPhòngBanToolStripMenuItem.Name = "QuảnLýPhòngBanToolStripMenuItem"
        Me.QuảnLýPhòngBanToolStripMenuItem.Size = New System.Drawing.Size(169, 24)
        Me.QuảnLýPhòngBanToolStripMenuItem.Text = "Quản lý phòng ban"
        '
        'QuảnLýChứcVụToolStripMenuItem
        '
        Me.QuảnLýChứcVụToolStripMenuItem.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.qlcvu
        Me.QuảnLýChứcVụToolStripMenuItem.Name = "QuảnLýChứcVụToolStripMenuItem"
        Me.QuảnLýChứcVụToolStripMenuItem.Size = New System.Drawing.Size(147, 24)
        Me.QuảnLýChứcVụToolStripMenuItem.Text = "Quản lý chức vụ"
        '
        'ThốngKêToolStripMenuItem
        '
        Me.ThốngKêToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DanhSáchNhânViênToolStripMenuItem, Me.DanhSáchChứcVụToolStripMenuItem, Me.DanhSáchPhòngBanToolStripMenuItem})
        Me.ThốngKêToolStripMenuItem.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.tke
        Me.ThốngKêToolStripMenuItem.Name = "ThốngKêToolStripMenuItem"
        Me.ThốngKêToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.ThốngKêToolStripMenuItem.Text = "Thống kê"
        '
        'DanhSáchNhânViênToolStripMenuItem
        '
        Me.DanhSáchNhânViênToolStripMenuItem.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.qlnv
        Me.DanhSáchNhânViênToolStripMenuItem.Name = "DanhSáchNhânViênToolStripMenuItem"
        Me.DanhSáchNhânViênToolStripMenuItem.Size = New System.Drawing.Size(236, 26)
        Me.DanhSáchNhânViênToolStripMenuItem.Text = "Danh sách nhân viên"
        '
        'DanhSáchChứcVụToolStripMenuItem
        '
        Me.DanhSáchChứcVụToolStripMenuItem.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.qlcvu
        Me.DanhSáchChứcVụToolStripMenuItem.Name = "DanhSáchChứcVụToolStripMenuItem"
        Me.DanhSáchChứcVụToolStripMenuItem.Size = New System.Drawing.Size(236, 26)
        Me.DanhSáchChứcVụToolStripMenuItem.Text = "Danh sách chức vụ"
        '
        'DanhSáchPhòngBanToolStripMenuItem
        '
        Me.DanhSáchPhòngBanToolStripMenuItem.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.qlpban
        Me.DanhSáchPhòngBanToolStripMenuItem.Name = "DanhSáchPhòngBanToolStripMenuItem"
        Me.DanhSáchPhòngBanToolStripMenuItem.Size = New System.Drawing.Size(236, 26)
        Me.DanhSáchPhòngBanToolStripMenuItem.Text = "Danh sách phòng ban"
        '
        'ThoátToolStripMenuItem1
        '
        Me.ThoátToolStripMenuItem1.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.thoat
        Me.ThoátToolStripMenuItem1.Name = "ThoátToolStripMenuItem1"
        Me.ThoátToolStripMenuItem1.Size = New System.Drawing.Size(81, 24)
        Me.ThoátToolStripMenuItem1.Text = "Thoát"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = resources.GetString("OleDbSelectCommand1.CommandText")
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-J8SR7CQ\SQLEXPRESS;Password=123456;User ID" &
    "=sa;Initial Catalog=QLNhanVien_DoThiHongKhanh"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ChucVu", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("maChucVu", "maChucVu"), New System.Data.Common.DataColumnMapping("tenChucVu", "tenChucVu"), New System.Data.Common.DataColumnMapping("maNV", "maNV"), New System.Data.Common.DataColumnMapping("maChucVu1", "maChucVu1"), New System.Data.Common.DataColumnMapping("maPhongBan", "maPhongBan"), New System.Data.Common.DataColumnMapping("tenNV", "tenNV"), New System.Data.Common.DataColumnMapping("SDT", "SDT"), New System.Data.Common.DataColumnMapping("ngaySinh", "ngaySinh"), New System.Data.Common.DataColumnMapping("gioiTinh", "gioiTinh"), New System.Data.Common.DataColumnMapping("diaChi", "diaChi"), New System.Data.Common.DataColumnMapping("maPhongBan1", "maPhongBan1"), New System.Data.Common.DataColumnMapping("tenPhongBan", "tenPhongBan"), New System.Data.Common.DataColumnMapping("SDTPhongBan", "SDTPhongBan")})})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.rsz_1rsz_1trangchu
        Me.ClientSize = New System.Drawing.Size(988, 568)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TàiKhoảnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ĐăngXuatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýPhòngBanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýChứcVụToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThốngKêToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents QuảnLýNhânViênToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DanhSáchNhânViênToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DanhSáchChứcVụToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DanhSáchPhòngBanToolStripMenuItem As ToolStripMenuItem
End Class
