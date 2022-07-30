<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DangNhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTenDN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên đăng nhập"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(56, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(659, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ĐĂNG NHẬP HỆ THỐNG QUẢN LÝ NHÂN VIÊN"
        '
        'txtTenDN
        '
        Me.txtTenDN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenDN.Location = New System.Drawing.Point(106, 158)
        Me.txtTenDN.Name = "txtTenDN"
        Me.txtTenDN.Size = New System.Drawing.Size(209, 30)
        Me.txtTenDN.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(103, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mật khẩu"
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatKhau.Location = New System.Drawing.Point(106, 258)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(209, 30)
        Me.txtMatKhau.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.DangNhap
        Me.Label4.Location = New System.Drawing.Point(356, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(473, 251)
        Me.Label4.TabIndex = 5
        '
        'btnDangNhap
        '
        Me.btnDangNhap.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDangNhap.Location = New System.Drawing.Point(324, 371)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(174, 61)
        Me.btnDangNhap.TabIndex = 6
        Me.btnDangNhap.Text = "Đăng nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.White
        Me.btnThoat.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.thoat
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(773, 12)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 40)
        Me.btnThoat.TabIndex = 8
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(107, 306)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(208, 22)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Duy trì trạng thái đăng nhập"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(860, 464)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenDN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DangNhap"
        Me.Text = "DangNhap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTenDN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDangNhap As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
