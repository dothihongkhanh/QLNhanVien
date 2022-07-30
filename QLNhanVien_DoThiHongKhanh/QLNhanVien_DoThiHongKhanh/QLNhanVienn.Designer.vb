<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QLNhanVienn
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbbMPB = New System.Windows.Forms.ComboBox()
        Me.cbbMaCV = New System.Windows.Forms.ComboBox()
        Me.rdobtnNu = New System.Windows.Forms.RadioButton()
        Me.rdobtnNam = New System.Windows.Forms.RadioButton()
        Me.dateNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.btnXoa_nv = New System.Windows.Forms.Button()
        Me.btnSua_nv = New System.Windows.Forms.Button()
        Me.btnLamMoi_nv = New System.Windows.Forms.Button()
        Me.btnThem_nv = New System.Windows.Forms.Button()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txtTenNV = New System.Windows.Forms.TextBox()
        Me.txtmaNV = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnVeCuoi_nv = New System.Windows.Forms.Button()
        Me.btnVeSau_nv = New System.Windows.Forms.Button()
        Me.btnVeTruoc_nv = New System.Windows.Forms.Button()
        Me.btnVeDau_nv = New System.Windows.Forms.Button()
        Me.DataGridView_NV = New System.Windows.Forms.DataGridView()
        Me.btnThoatNV = New System.Windows.Forms.Button()
        Me.btnThoat_nv = New System.Windows.Forms.Button()
        Me.QlNhanVien_DoThiHongKhanhDataSet1 = New QLNhanVien_DoThiHongKhanh.QLNhanVien_DoThiHongKhanhDataSet()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView_NV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QlNhanVien_DoThiHongKhanhDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label1.Location = New System.Drawing.Point(322, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ NHÂN VIÊN"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Controls.Add(Me.cbbMPB)
        Me.GroupBox1.Controls.Add(Me.cbbMaCV)
        Me.GroupBox1.Controls.Add(Me.rdobtnNu)
        Me.GroupBox1.Controls.Add(Me.rdobtnNam)
        Me.GroupBox1.Controls.Add(Me.dateNgaySinh)
        Me.GroupBox1.Controls.Add(Me.btnXoa_nv)
        Me.GroupBox1.Controls.Add(Me.btnSua_nv)
        Me.GroupBox1.Controls.Add(Me.btnLamMoi_nv)
        Me.GroupBox1.Controls.Add(Me.btnThem_nv)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.txtSDT)
        Me.GroupBox1.Controls.Add(Me.txtTenNV)
        Me.GroupBox1.Controls.Add(Me.txtmaNV)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(898, 210)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thiết lập thông tin nhân viên"
        '
        'cbbMPB
        '
        Me.cbbMPB.FormattingEnabled = True
        Me.cbbMPB.Location = New System.Drawing.Point(128, 107)
        Me.cbbMPB.Name = "cbbMPB"
        Me.cbbMPB.Size = New System.Drawing.Size(170, 26)
        Me.cbbMPB.TabIndex = 24
        '
        'cbbMaCV
        '
        Me.cbbMaCV.FormattingEnabled = True
        Me.cbbMaCV.Location = New System.Drawing.Point(128, 66)
        Me.cbbMaCV.Name = "cbbMaCV"
        Me.cbbMaCV.Size = New System.Drawing.Size(170, 26)
        Me.cbbMaCV.TabIndex = 23
        '
        'rdobtnNu
        '
        Me.rdobtnNu.AutoSize = True
        Me.rdobtnNu.Location = New System.Drawing.Point(528, 108)
        Me.rdobtnNu.Name = "rdobtnNu"
        Me.rdobtnNu.Size = New System.Drawing.Size(48, 22)
        Me.rdobtnNu.TabIndex = 22
        Me.rdobtnNu.TabStop = True
        Me.rdobtnNu.Text = "Nữ"
        Me.rdobtnNu.UseVisualStyleBackColor = True
        '
        'rdobtnNam
        '
        Me.rdobtnNam.AutoSize = True
        Me.rdobtnNam.Location = New System.Drawing.Point(434, 107)
        Me.rdobtnNam.Name = "rdobtnNam"
        Me.rdobtnNam.Size = New System.Drawing.Size(61, 22)
        Me.rdobtnNam.TabIndex = 21
        Me.rdobtnNam.TabStop = True
        Me.rdobtnNam.Text = "Nam"
        Me.rdobtnNam.UseVisualStyleBackColor = True
        '
        'dateNgaySinh
        '
        Me.dateNgaySinh.Location = New System.Drawing.Point(434, 64)
        Me.dateNgaySinh.Name = "dateNgaySinh"
        Me.dateNgaySinh.Size = New System.Drawing.Size(170, 24)
        Me.dateNgaySinh.TabIndex = 20
        '
        'btnXoa_nv
        '
        Me.btnXoa_nv.BackColor = System.Drawing.Color.White
        Me.btnXoa_nv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa_nv.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.xoa
        Me.btnXoa_nv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa_nv.Location = New System.Drawing.Point(775, 112)
        Me.btnXoa_nv.Name = "btnXoa_nv"
        Me.btnXoa_nv.Size = New System.Drawing.Size(100, 54)
        Me.btnXoa_nv.TabIndex = 19
        Me.btnXoa_nv.Text = "Xóa"
        Me.btnXoa_nv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoa_nv.UseVisualStyleBackColor = False
        '
        'btnSua_nv
        '
        Me.btnSua_nv.BackColor = System.Drawing.Color.White
        Me.btnSua_nv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua_nv.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.sua
        Me.btnSua_nv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua_nv.Location = New System.Drawing.Point(775, 34)
        Me.btnSua_nv.Name = "btnSua_nv"
        Me.btnSua_nv.Size = New System.Drawing.Size(100, 54)
        Me.btnSua_nv.TabIndex = 18
        Me.btnSua_nv.Text = "Sửa"
        Me.btnSua_nv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSua_nv.UseVisualStyleBackColor = False
        '
        'btnLamMoi_nv
        '
        Me.btnLamMoi_nv.BackColor = System.Drawing.Color.White
        Me.btnLamMoi_nv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLamMoi_nv.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.lammoi
        Me.btnLamMoi_nv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLamMoi_nv.Location = New System.Drawing.Point(651, 33)
        Me.btnLamMoi_nv.Name = "btnLamMoi_nv"
        Me.btnLamMoi_nv.Size = New System.Drawing.Size(100, 54)
        Me.btnLamMoi_nv.TabIndex = 17
        Me.btnLamMoi_nv.Text = "Làm mới"
        Me.btnLamMoi_nv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLamMoi_nv.UseVisualStyleBackColor = False
        '
        'btnThem_nv
        '
        Me.btnThem_nv.BackColor = System.Drawing.Color.White
        Me.btnThem_nv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem_nv.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.them
        Me.btnThem_nv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem_nv.Location = New System.Drawing.Point(651, 115)
        Me.btnThem_nv.Name = "btnThem_nv"
        Me.btnThem_nv.Size = New System.Drawing.Size(100, 54)
        Me.btnThem_nv.TabIndex = 16
        Me.btnThem_nv.Text = "Thêm"
        Me.btnThem_nv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThem_nv.UseVisualStyleBackColor = False
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(434, 145)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(170, 24)
        Me.txtDiaChi.TabIndex = 15
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(434, 27)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(170, 24)
        Me.txtSDT.TabIndex = 12
        '
        'txtTenNV
        '
        Me.txtTenNV.Location = New System.Drawing.Point(128, 145)
        Me.txtTenNV.Name = "txtTenNV"
        Me.txtTenNV.Size = New System.Drawing.Size(170, 24)
        Me.txtTenNV.TabIndex = 11
        '
        'txtmaNV
        '
        Me.txtmaNV.Location = New System.Drawing.Point(128, 30)
        Me.txtmaNV.Name = "txtmaNV"
        Me.txtmaNV.Size = New System.Drawing.Size(170, 24)
        Me.txtmaNV.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(338, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 18)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Địa chỉ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(338, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Giới tính"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(338, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Ngày sinh"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(336, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Số điện thoại"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tên nhân viên"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Mã phòng ban"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mã chức vụ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã nhân viên"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox2.Controls.Add(Me.btnVeCuoi_nv)
        Me.GroupBox2.Controls.Add(Me.btnVeSau_nv)
        Me.GroupBox2.Controls.Add(Me.btnVeTruoc_nv)
        Me.GroupBox2.Controls.Add(Me.btnVeDau_nv)
        Me.GroupBox2.Controls.Add(Me.DataGridView_NV)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 276)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(902, 313)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin nhân viên"
        '
        'btnVeCuoi_nv
        '
        Me.btnVeCuoi_nv.BackColor = System.Drawing.Color.LawnGreen
        Me.btnVeCuoi_nv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeCuoi_nv.Location = New System.Drawing.Point(574, 250)
        Me.btnVeCuoi_nv.Name = "btnVeCuoi_nv"
        Me.btnVeCuoi_nv.Size = New System.Drawing.Size(68, 50)
        Me.btnVeCuoi_nv.TabIndex = 4
        Me.btnVeCuoi_nv.Text = ">>|"
        Me.btnVeCuoi_nv.UseVisualStyleBackColor = False
        '
        'btnVeSau_nv
        '
        Me.btnVeSau_nv.BackColor = System.Drawing.Color.LawnGreen
        Me.btnVeSau_nv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeSau_nv.Location = New System.Drawing.Point(473, 250)
        Me.btnVeSau_nv.Name = "btnVeSau_nv"
        Me.btnVeSau_nv.Size = New System.Drawing.Size(68, 50)
        Me.btnVeSau_nv.TabIndex = 3
        Me.btnVeSau_nv.Text = ">>"
        Me.btnVeSau_nv.UseVisualStyleBackColor = False
        '
        'btnVeTruoc_nv
        '
        Me.btnVeTruoc_nv.BackColor = System.Drawing.Color.LawnGreen
        Me.btnVeTruoc_nv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeTruoc_nv.Location = New System.Drawing.Point(369, 250)
        Me.btnVeTruoc_nv.Name = "btnVeTruoc_nv"
        Me.btnVeTruoc_nv.Size = New System.Drawing.Size(68, 50)
        Me.btnVeTruoc_nv.TabIndex = 2
        Me.btnVeTruoc_nv.Text = "<<"
        Me.btnVeTruoc_nv.UseVisualStyleBackColor = False
        '
        'btnVeDau_nv
        '
        Me.btnVeDau_nv.BackColor = System.Drawing.Color.LawnGreen
        Me.btnVeDau_nv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeDau_nv.Location = New System.Drawing.Point(264, 250)
        Me.btnVeDau_nv.Name = "btnVeDau_nv"
        Me.btnVeDau_nv.Size = New System.Drawing.Size(68, 50)
        Me.btnVeDau_nv.TabIndex = 1
        Me.btnVeDau_nv.Text = "|<<"
        Me.btnVeDau_nv.UseVisualStyleBackColor = False
        '
        'DataGridView_NV
        '
        Me.DataGridView_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_NV.Location = New System.Drawing.Point(6, 23)
        Me.DataGridView_NV.Name = "DataGridView_NV"
        Me.DataGridView_NV.RowHeadersWidth = 51
        Me.DataGridView_NV.RowTemplate.Height = 24
        Me.DataGridView_NV.Size = New System.Drawing.Size(874, 221)
        Me.DataGridView_NV.TabIndex = 0
        '
        'btnThoatNV
        '
        Me.btnThoatNV.BackColor = System.Drawing.Color.White
        Me.btnThoatNV.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.thoat
        Me.btnThoatNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoatNV.Location = New System.Drawing.Point(808, 17)
        Me.btnThoatNV.Name = "btnThoatNV"
        Me.btnThoatNV.Size = New System.Drawing.Size(67, 37)
        Me.btnThoatNV.TabIndex = 4
        Me.btnThoatNV.Text = "Thoát"
        Me.btnThoatNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoatNV.UseVisualStyleBackColor = False
        '
        'btnThoat_nv
        '
        Me.btnThoat_nv.BackColor = System.Drawing.Color.Black
        Me.btnThoat_nv.ForeColor = System.Drawing.Color.White
        Me.btnThoat_nv.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.qlai
        Me.btnThoat_nv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat_nv.Location = New System.Drawing.Point(68, 17)
        Me.btnThoat_nv.Name = "btnThoat_nv"
        Me.btnThoat_nv.Size = New System.Drawing.Size(137, 37)
        Me.btnThoat_nv.TabIndex = 3
        Me.btnThoat_nv.Text = "Quay lại trang chủ"
        Me.btnThoat_nv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat_nv.UseVisualStyleBackColor = False
        '
        'QlNhanVien_DoThiHongKhanhDataSet1
        '
        Me.QlNhanVien_DoThiHongKhanhDataSet1.DataSetName = "QLNhanVien_DoThiHongKhanhDataSet"
        Me.QlNhanVien_DoThiHongKhanhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QLNhanVienn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImage = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.NVIEN
        Me.ClientSize = New System.Drawing.Size(934, 603)
        Me.Controls.Add(Me.btnThoatNV)
        Me.Controls.Add(Me.btnThoat_nv)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "QLNhanVienn"
        Me.Text = "QLNhanVienn"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView_NV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QlNhanVien_DoThiHongKhanhDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnXoa_nv As Button
    Friend WithEvents btnSua_nv As Button
    Friend WithEvents btnLamMoi_nv As Button
    Friend WithEvents btnThem_nv As Button
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents txtTenNV As TextBox
    Friend WithEvents txtmaNV As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView_NV As DataGridView
    Friend WithEvents btnThoat_nv As Button
    Friend WithEvents btnVeCuoi_nv As Button
    Friend WithEvents btnVeSau_nv As Button
    Friend WithEvents btnVeTruoc_nv As Button
    Friend WithEvents btnVeDau_nv As Button
    Friend WithEvents btnThoatNV As Button
    Friend WithEvents dateNgaySinh As DateTimePicker
    Friend WithEvents QlNhanVien_DoThiHongKhanhDataSet1 As QLNhanVien_DoThiHongKhanhDataSet
    Friend WithEvents rdobtnNu As RadioButton
    Friend WithEvents rdobtnNam As RadioButton
    Friend WithEvents cbbMaPB As ComboBox
    Friend WithEvents cbbMaCV As ComboBox
    Friend WithEvents cbbMPB As ComboBox
End Class
