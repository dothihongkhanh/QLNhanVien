<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThongKe_NV
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.NhanVienBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLNhanVien_DoThiHongKhanhDataSet = New QLNhanVien_DoThiHongKhanh.QLNhanVien_DoThiHongKhanhDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.NhanVienTableAdapter = New QLNhanVien_DoThiHongKhanh.QLNhanVien_DoThiHongKhanhDataSetTableAdapters.NhanVienTableAdapter()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnQLTC = New System.Windows.Forms.Button()
        CType(Me.NhanVienBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLNhanVien_DoThiHongKhanhDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NhanVienBindingSource
        '
        Me.NhanVienBindingSource.DataMember = "NhanVien"
        Me.NhanVienBindingSource.DataSource = Me.QLNhanVien_DoThiHongKhanhDataSet
        '
        'QLNhanVien_DoThiHongKhanhDataSet
        '
        Me.QLNhanVien_DoThiHongKhanhDataSet.DataSetName = "QLNhanVien_DoThiHongKhanhDataSet"
        Me.QLNhanVien_DoThiHongKhanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.NhanVienBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "QLNhanVien_DoThiHongKhanh.Report_DSNhanVien.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 77)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1114, 622)
        Me.ReportViewer1.TabIndex = 0
        '
        'NhanVienTableAdapter
        '
        Me.NhanVienTableAdapter.ClearBeforeFill = True
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.LightCyan
        Me.btnThoat.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.thoat
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(869, 24)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(84, 37)
        Me.btnThoat.TabIndex = 1
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'btnQLTC
        '
        Me.btnQLTC.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnQLTC.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnQLTC.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.qlai
        Me.btnQLTC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQLTC.Location = New System.Drawing.Point(174, 21)
        Me.btnQLTC.Name = "btnQLTC"
        Me.btnQLTC.Size = New System.Drawing.Size(172, 40)
        Me.btnQLTC.TabIndex = 2
        Me.btnQLTC.Text = "Quay lại trang chủ"
        Me.btnQLTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQLTC.UseVisualStyleBackColor = False
        '
        'ThongKe_NV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LawnGreen
        Me.BackgroundImage = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.NVIEN
        Me.ClientSize = New System.Drawing.Size(1138, 711)
        Me.Controls.Add(Me.btnQLTC)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ThongKe_NV"
        Me.Text = "ThongKe_NV"
        CType(Me.NhanVienBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLNhanVien_DoThiHongKhanhDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents NhanVienBindingSource As BindingSource
    Friend WithEvents QLNhanVien_DoThiHongKhanhDataSet As QLNhanVien_DoThiHongKhanhDataSet
    Friend WithEvents NhanVienTableAdapter As QLNhanVien_DoThiHongKhanhDataSetTableAdapters.NhanVienTableAdapter
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnQLTC As Button
End Class
