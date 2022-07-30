<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QLChucVu
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMoTa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLamMoi_cv = New System.Windows.Forms.Button()
        Me.btnXoa_cv = New System.Windows.Forms.Button()
        Me.btnSua_cv = New System.Windows.Forms.Button()
        Me.btnThem_cv = New System.Windows.Forms.Button()
        Me.txtTenCV = New System.Windows.Forms.TextBox()
        Me.txtMaCV = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnThoat_cv = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnVeCuoi = New System.Windows.Forms.Button()
        Me.btnVeSau = New System.Windows.Forms.Button()
        Me.btnVeTruoc = New System.Windows.Forms.Button()
        Me.btnVeDau = New System.Windows.Forms.Button()
        Me.DataGridView_CV = New System.Windows.Forms.DataGridView()
        Me.btnThoatCV = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView_CV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtMoTa)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnLamMoi_cv)
        Me.GroupBox1.Controls.Add(Me.btnXoa_cv)
        Me.GroupBox1.Controls.Add(Me.btnSua_cv)
        Me.GroupBox1.Controls.Add(Me.btnThem_cv)
        Me.GroupBox1.Controls.Add(Me.txtTenCV)
        Me.GroupBox1.Controls.Add(Me.txtMaCV)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 334)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thiết lập thông tin chức vụ"
        '
        'txtMoTa
        '
        Me.txtMoTa.Location = New System.Drawing.Point(144, 121)
        Me.txtMoTa.Name = "txtMoTa"
        Me.txtMoTa.Size = New System.Drawing.Size(151, 24)
        Me.txtMoTa.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Mô tả"
        '
        'btnLamMoi_cv
        '
        Me.btnLamMoi_cv.BackColor = System.Drawing.Color.Pink
        Me.btnLamMoi_cv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLamMoi_cv.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.lammoi
        Me.btnLamMoi_cv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLamMoi_cv.Location = New System.Drawing.Point(46, 168)
        Me.btnLamMoi_cv.Name = "btnLamMoi_cv"
        Me.btnLamMoi_cv.Size = New System.Drawing.Size(95, 55)
        Me.btnLamMoi_cv.TabIndex = 7
        Me.btnLamMoi_cv.Text = "Làm mới"
        Me.btnLamMoi_cv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLamMoi_cv.UseVisualStyleBackColor = False
        '
        'btnXoa_cv
        '
        Me.btnXoa_cv.BackColor = System.Drawing.Color.Pink
        Me.btnXoa_cv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa_cv.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.xoa
        Me.btnXoa_cv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa_cv.Location = New System.Drawing.Point(175, 249)
        Me.btnXoa_cv.Name = "btnXoa_cv"
        Me.btnXoa_cv.Size = New System.Drawing.Size(95, 55)
        Me.btnXoa_cv.TabIndex = 6
        Me.btnXoa_cv.Text = "Xóa"
        Me.btnXoa_cv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoa_cv.UseVisualStyleBackColor = False
        '
        'btnSua_cv
        '
        Me.btnSua_cv.BackColor = System.Drawing.Color.Pink
        Me.btnSua_cv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua_cv.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.sua
        Me.btnSua_cv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua_cv.Location = New System.Drawing.Point(46, 249)
        Me.btnSua_cv.Name = "btnSua_cv"
        Me.btnSua_cv.Size = New System.Drawing.Size(95, 55)
        Me.btnSua_cv.TabIndex = 5
        Me.btnSua_cv.Text = "Sửa"
        Me.btnSua_cv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSua_cv.UseVisualStyleBackColor = False
        '
        'btnThem_cv
        '
        Me.btnThem_cv.BackColor = System.Drawing.Color.Pink
        Me.btnThem_cv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem_cv.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.them
        Me.btnThem_cv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem_cv.Location = New System.Drawing.Point(175, 168)
        Me.btnThem_cv.Name = "btnThem_cv"
        Me.btnThem_cv.Size = New System.Drawing.Size(95, 55)
        Me.btnThem_cv.TabIndex = 4
        Me.btnThem_cv.Text = "Thêm"
        Me.btnThem_cv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThem_cv.UseVisualStyleBackColor = False
        '
        'txtTenCV
        '
        Me.txtTenCV.Location = New System.Drawing.Point(144, 78)
        Me.txtTenCV.Name = "txtTenCV"
        Me.txtTenCV.Size = New System.Drawing.Size(151, 24)
        Me.txtTenCV.TabIndex = 3
        '
        'txtMaCV
        '
        Me.txtMaCV.Location = New System.Drawing.Point(144, 35)
        Me.txtMaCV.Name = "txtMaCV"
        Me.txtMaCV.Size = New System.Drawing.Size(151, 24)
        Me.txtMaCV.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tên chức vụ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã chức vụ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(263, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "QUẢN LÝ CHỨC VỤ"
        '
        'btnThoat_cv
        '
        Me.btnThoat_cv.BackColor = System.Drawing.Color.Black
        Me.btnThoat_cv.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnThoat_cv.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.qlai
        Me.btnThoat_cv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat_cv.Location = New System.Drawing.Point(52, 23)
        Me.btnThoat_cv.Name = "btnThoat_cv"
        Me.btnThoat_cv.Size = New System.Drawing.Size(137, 43)
        Me.btnThoat_cv.TabIndex = 2
        Me.btnThoat_cv.Text = "Quay lại trang chủ"
        Me.btnThoat_cv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat_cv.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btnVeCuoi)
        Me.GroupBox2.Controls.Add(Me.btnVeSau)
        Me.GroupBox2.Controls.Add(Me.btnVeTruoc)
        Me.GroupBox2.Controls.Add(Me.btnVeDau)
        Me.GroupBox2.Controls.Add(Me.DataGridView_CV)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(372, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 334)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin chức vụ"
        '
        'btnVeCuoi
        '
        Me.btnVeCuoi.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnVeCuoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeCuoi.Location = New System.Drawing.Point(285, 268)
        Me.btnVeCuoi.Name = "btnVeCuoi"
        Me.btnVeCuoi.Size = New System.Drawing.Size(68, 45)
        Me.btnVeCuoi.TabIndex = 4
        Me.btnVeCuoi.Text = ">>|"
        Me.btnVeCuoi.UseVisualStyleBackColor = False
        '
        'btnVeSau
        '
        Me.btnVeSau.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnVeSau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeSau.Location = New System.Drawing.Point(195, 268)
        Me.btnVeSau.Name = "btnVeSau"
        Me.btnVeSau.Size = New System.Drawing.Size(68, 45)
        Me.btnVeSau.TabIndex = 3
        Me.btnVeSau.Text = ">>"
        Me.btnVeSau.UseVisualStyleBackColor = False
        '
        'btnVeTruoc
        '
        Me.btnVeTruoc.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnVeTruoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeTruoc.Location = New System.Drawing.Point(109, 268)
        Me.btnVeTruoc.Name = "btnVeTruoc"
        Me.btnVeTruoc.Size = New System.Drawing.Size(68, 45)
        Me.btnVeTruoc.TabIndex = 2
        Me.btnVeTruoc.Text = "<<"
        Me.btnVeTruoc.UseVisualStyleBackColor = False
        '
        'btnVeDau
        '
        Me.btnVeDau.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnVeDau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeDau.Location = New System.Drawing.Point(20, 268)
        Me.btnVeDau.Name = "btnVeDau"
        Me.btnVeDau.Size = New System.Drawing.Size(68, 45)
        Me.btnVeDau.TabIndex = 1
        Me.btnVeDau.Text = "|<<"
        Me.btnVeDau.UseVisualStyleBackColor = False
        '
        'DataGridView_CV
        '
        Me.DataGridView_CV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_CV.Location = New System.Drawing.Point(12, 23)
        Me.DataGridView_CV.Name = "DataGridView_CV"
        Me.DataGridView_CV.RowHeadersWidth = 51
        Me.DataGridView_CV.RowTemplate.Height = 24
        Me.DataGridView_CV.Size = New System.Drawing.Size(346, 224)
        Me.DataGridView_CV.TabIndex = 0
        '
        'btnThoatCV
        '
        Me.btnThoatCV.BackColor = System.Drawing.Color.White
        Me.btnThoatCV.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.thoat
        Me.btnThoatCV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoatCV.Location = New System.Drawing.Point(662, 28)
        Me.btnThoatCV.Name = "btnThoatCV"
        Me.btnThoatCV.Size = New System.Drawing.Size(69, 43)
        Me.btnThoatCV.TabIndex = 4
        Me.btnThoatCV.Text = "Thoát"
        Me.btnThoatCV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoatCV.UseVisualStyleBackColor = False
        '
        'QLChucVu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(769, 446)
        Me.Controls.Add(Me.btnThoatCV)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnThoat_cv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "QLChucVu"
        Me.Text = "QLChucVu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView_CV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLamMoi_cv As Button
    Friend WithEvents btnXoa_cv As Button
    Friend WithEvents btnSua_cv As Button
    Friend WithEvents btnThem_cv As Button
    Friend WithEvents txtTenCV As TextBox
    Friend WithEvents txtMaCV As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnThoat_cv As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView_CV As DataGridView
    Friend WithEvents btnVeCuoi As Button
    Friend WithEvents btnVeSau As Button
    Friend WithEvents btnVeTruoc As Button
    Friend WithEvents btnVeDau As Button
    Friend WithEvents btnThoatCV As Button
    Friend WithEvents txtMoTa As TextBox
    Friend WithEvents Label4 As Label
End Class
