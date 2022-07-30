<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QLPhongBan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QLPhongBan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dateNgayThanhLap = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnXoa_pb = New System.Windows.Forms.Button()
        Me.btnLamMoi_pb = New System.Windows.Forms.Button()
        Me.btnSua_pb = New System.Windows.Forms.Button()
        Me.btnThem_pb = New System.Windows.Forms.Button()
        Me.txtSDTPB = New System.Windows.Forms.TextBox()
        Me.txtTenPB = New System.Windows.Forms.TextBox()
        Me.txtMaPB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnThoat_pb = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnVeCuoi_pb = New System.Windows.Forms.Button()
        Me.btnVeSau_pb = New System.Windows.Forms.Button()
        Me.btnVeTruoc_pb = New System.Windows.Forms.Button()
        Me.btnVeDau_pb = New System.Windows.Forms.Button()
        Me.DataGridView_PB = New System.Windows.Forms.DataGridView()
        Me.btnThoatPB = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(282, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ PHÒNG BAN"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.dateNgayThanhLap)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnXoa_pb)
        Me.GroupBox1.Controls.Add(Me.btnLamMoi_pb)
        Me.GroupBox1.Controls.Add(Me.btnSua_pb)
        Me.GroupBox1.Controls.Add(Me.btnThem_pb)
        Me.GroupBox1.Controls.Add(Me.txtSDTPB)
        Me.GroupBox1.Controls.Add(Me.txtTenPB)
        Me.GroupBox1.Controls.Add(Me.txtMaPB)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 356)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thiết lập thông tin chi tiết phòng ban"
        '
        'dateNgayThanhLap
        '
        Me.dateNgayThanhLap.Location = New System.Drawing.Point(168, 172)
        Me.dateNgayThanhLap.Name = "dateNgayThanhLap"
        Me.dateNgayThanhLap.Size = New System.Drawing.Size(170, 24)
        Me.dateNgayThanhLap.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Ngày thành lập"
        '
        'btnXoa_pb
        '
        Me.btnXoa_pb.BackColor = System.Drawing.Color.White
        Me.btnXoa_pb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa_pb.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.xoa
        Me.btnXoa_pb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa_pb.Location = New System.Drawing.Point(198, 280)
        Me.btnXoa_pb.Name = "btnXoa_pb"
        Me.btnXoa_pb.Size = New System.Drawing.Size(95, 55)
        Me.btnXoa_pb.TabIndex = 9
        Me.btnXoa_pb.Text = "Xóa"
        Me.btnXoa_pb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoa_pb.UseVisualStyleBackColor = False
        '
        'btnLamMoi_pb
        '
        Me.btnLamMoi_pb.BackColor = System.Drawing.Color.White
        Me.btnLamMoi_pb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLamMoi_pb.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.lammoi
        Me.btnLamMoi_pb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLamMoi_pb.Location = New System.Drawing.Point(63, 220)
        Me.btnLamMoi_pb.Name = "btnLamMoi_pb"
        Me.btnLamMoi_pb.Size = New System.Drawing.Size(95, 55)
        Me.btnLamMoi_pb.TabIndex = 8
        Me.btnLamMoi_pb.Text = "Làm mới"
        Me.btnLamMoi_pb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLamMoi_pb.UseVisualStyleBackColor = False
        '
        'btnSua_pb
        '
        Me.btnSua_pb.BackColor = System.Drawing.Color.White
        Me.btnSua_pb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua_pb.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.sua
        Me.btnSua_pb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua_pb.Location = New System.Drawing.Point(63, 280)
        Me.btnSua_pb.Name = "btnSua_pb"
        Me.btnSua_pb.Size = New System.Drawing.Size(95, 55)
        Me.btnSua_pb.TabIndex = 7
        Me.btnSua_pb.Text = "Sửa"
        Me.btnSua_pb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSua_pb.UseVisualStyleBackColor = False
        '
        'btnThem_pb
        '
        Me.btnThem_pb.BackColor = System.Drawing.Color.White
        Me.btnThem_pb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem_pb.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.them
        Me.btnThem_pb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem_pb.Location = New System.Drawing.Point(198, 220)
        Me.btnThem_pb.Name = "btnThem_pb"
        Me.btnThem_pb.Size = New System.Drawing.Size(95, 55)
        Me.btnThem_pb.TabIndex = 6
        Me.btnThem_pb.Text = "Thêm"
        Me.btnThem_pb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThem_pb.UseVisualStyleBackColor = False
        '
        'txtSDTPB
        '
        Me.txtSDTPB.Location = New System.Drawing.Point(168, 139)
        Me.txtSDTPB.Name = "txtSDTPB"
        Me.txtSDTPB.Size = New System.Drawing.Size(170, 24)
        Me.txtSDTPB.TabIndex = 5
        '
        'txtTenPB
        '
        Me.txtTenPB.Location = New System.Drawing.Point(168, 97)
        Me.txtTenPB.Name = "txtTenPB"
        Me.txtTenPB.Size = New System.Drawing.Size(170, 24)
        Me.txtTenPB.TabIndex = 4
        '
        'txtMaPB
        '
        Me.txtMaPB.Location = New System.Drawing.Point(168, 57)
        Me.txtMaPB.Name = "txtMaPB"
        Me.txtMaPB.Size = New System.Drawing.Size(170, 24)
        Me.txtMaPB.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Số điện thoại"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tên phòng ban"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã phòng ban"
        '
        'btnThoat_pb
        '
        Me.btnThoat_pb.BackColor = System.Drawing.Color.Black
        Me.btnThoat_pb.ForeColor = System.Drawing.Color.White
        Me.btnThoat_pb.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.qlai
        Me.btnThoat_pb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat_pb.Location = New System.Drawing.Point(57, 20)
        Me.btnThoat_pb.Name = "btnThoat_pb"
        Me.btnThoat_pb.Size = New System.Drawing.Size(141, 40)
        Me.btnThoat_pb.TabIndex = 2
        Me.btnThoat_pb.Text = "Quay lại trang chủ"
        Me.btnThoat_pb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat_pb.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnVeCuoi_pb)
        Me.GroupBox2.Controls.Add(Me.btnVeSau_pb)
        Me.GroupBox2.Controls.Add(Me.btnVeTruoc_pb)
        Me.GroupBox2.Controls.Add(Me.btnVeDau_pb)
        Me.GroupBox2.Controls.Add(Me.DataGridView_PB)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(405, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(484, 356)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin phòng ban"
        '
        'btnVeCuoi_pb
        '
        Me.btnVeCuoi_pb.BackColor = System.Drawing.Color.ForestGreen
        Me.btnVeCuoi_pb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeCuoi_pb.ForeColor = System.Drawing.Color.White
        Me.btnVeCuoi_pb.Location = New System.Drawing.Point(348, 280)
        Me.btnVeCuoi_pb.Name = "btnVeCuoi_pb"
        Me.btnVeCuoi_pb.Size = New System.Drawing.Size(68, 45)
        Me.btnVeCuoi_pb.TabIndex = 4
        Me.btnVeCuoi_pb.Text = ">>|"
        Me.btnVeCuoi_pb.UseVisualStyleBackColor = False
        '
        'btnVeSau_pb
        '
        Me.btnVeSau_pb.BackColor = System.Drawing.Color.ForestGreen
        Me.btnVeSau_pb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeSau_pb.ForeColor = System.Drawing.Color.White
        Me.btnVeSau_pb.Location = New System.Drawing.Point(252, 280)
        Me.btnVeSau_pb.Name = "btnVeSau_pb"
        Me.btnVeSau_pb.Size = New System.Drawing.Size(68, 45)
        Me.btnVeSau_pb.TabIndex = 3
        Me.btnVeSau_pb.Text = ">>"
        Me.btnVeSau_pb.UseVisualStyleBackColor = False
        '
        'btnVeTruoc_pb
        '
        Me.btnVeTruoc_pb.BackColor = System.Drawing.Color.ForestGreen
        Me.btnVeTruoc_pb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeTruoc_pb.ForeColor = System.Drawing.Color.White
        Me.btnVeTruoc_pb.Location = New System.Drawing.Point(139, 280)
        Me.btnVeTruoc_pb.Name = "btnVeTruoc_pb"
        Me.btnVeTruoc_pb.Size = New System.Drawing.Size(68, 45)
        Me.btnVeTruoc_pb.TabIndex = 2
        Me.btnVeTruoc_pb.Text = "<<"
        Me.btnVeTruoc_pb.UseVisualStyleBackColor = False
        '
        'btnVeDau_pb
        '
        Me.btnVeDau_pb.BackColor = System.Drawing.Color.ForestGreen
        Me.btnVeDau_pb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeDau_pb.ForeColor = System.Drawing.Color.White
        Me.btnVeDau_pb.Location = New System.Drawing.Point(45, 280)
        Me.btnVeDau_pb.Name = "btnVeDau_pb"
        Me.btnVeDau_pb.Size = New System.Drawing.Size(68, 45)
        Me.btnVeDau_pb.TabIndex = 1
        Me.btnVeDau_pb.Text = "|<<"
        Me.btnVeDau_pb.UseVisualStyleBackColor = False
        '
        'DataGridView_PB
        '
        Me.DataGridView_PB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_PB.Location = New System.Drawing.Point(19, 39)
        Me.DataGridView_PB.Name = "DataGridView_PB"
        Me.DataGridView_PB.RowHeadersWidth = 51
        Me.DataGridView_PB.RowTemplate.Height = 24
        Me.DataGridView_PB.Size = New System.Drawing.Size(449, 214)
        Me.DataGridView_PB.TabIndex = 0
        '
        'btnThoatPB
        '
        Me.btnThoatPB.BackColor = System.Drawing.Color.White
        Me.btnThoatPB.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.thoat
        Me.btnThoatPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoatPB.Location = New System.Drawing.Point(717, 23)
        Me.btnThoatPB.Name = "btnThoatPB"
        Me.btnThoatPB.Size = New System.Drawing.Size(76, 38)
        Me.btnThoatPB.TabIndex = 4
        Me.btnThoatPB.Text = "Thoát"
        Me.btnThoatPB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoatPB.UseVisualStyleBackColor = False
        '
        'QLPhongBan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(900, 443)
        Me.Controls.Add(Me.btnThoatPB)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnThoat_pb)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "QLPhongBan"
        Me.Text = "QLPhongBan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnXoa_pb As Button
    Friend WithEvents btnLamMoi_pb As Button
    Friend WithEvents btnSua_pb As Button
    Friend WithEvents btnThem_pb As Button
    Friend WithEvents txtSDTPB As TextBox
    Friend WithEvents txtTenPB As TextBox
    Friend WithEvents txtMaPB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnThoat_pb As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView_PB As DataGridView
    Friend WithEvents btnVeCuoi_pb As Button
    Friend WithEvents btnVeSau_pb As Button
    Friend WithEvents btnVeTruoc_pb As Button
    Friend WithEvents btnVeDau_pb As Button
    Friend WithEvents btnThoatPB As Button
    Friend WithEvents dateNgayThanhLap As DateTimePicker
    Friend WithEvents Label5 As Label
End Class
