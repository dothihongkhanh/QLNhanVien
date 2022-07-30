<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThongKe_CV
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ChucVuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLNhanVien_DoThiHongKhanhDataSet = New QLNhanVien_DoThiHongKhanh.QLNhanVien_DoThiHongKhanhDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ChucVuTableAdapter = New QLNhanVien_DoThiHongKhanh.QLNhanVien_DoThiHongKhanhDataSetTableAdapters.ChucVuTableAdapter()
        Me.btnThoatTKCV = New System.Windows.Forms.Button()
        Me.btnQLTC = New System.Windows.Forms.Button()
        CType(Me.ChucVuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLNhanVien_DoThiHongKhanhDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChucVuBindingSource
        '
        Me.ChucVuBindingSource.DataMember = "ChucVu"
        Me.ChucVuBindingSource.DataSource = Me.QLNhanVien_DoThiHongKhanhDataSet
        '
        'QLNhanVien_DoThiHongKhanhDataSet
        '
        Me.QLNhanVien_DoThiHongKhanhDataSet.DataSetName = "QLNhanVien_DoThiHongKhanhDataSet"
        Me.QLNhanVien_DoThiHongKhanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.ChucVuBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "QLNhanVien_DoThiHongKhanh.Report_DSChucVu.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(11, 79)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(809, 521)
        Me.ReportViewer1.TabIndex = 0
        '
        'ChucVuTableAdapter
        '
        Me.ChucVuTableAdapter.ClearBeforeFill = True
        '
        'btnThoatTKCV
        '
        Me.btnThoatTKCV.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoatTKCV.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.thoat
        Me.btnThoatTKCV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoatTKCV.Location = New System.Drawing.Point(662, 14)
        Me.btnThoatTKCV.Name = "btnThoatTKCV"
        Me.btnThoatTKCV.Size = New System.Drawing.Size(84, 39)
        Me.btnThoatTKCV.TabIndex = 1
        Me.btnThoatTKCV.Text = "Thoát"
        Me.btnThoatTKCV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoatTKCV.UseVisualStyleBackColor = False
        '
        'btnQLTC
        '
        Me.btnQLTC.BackColor = System.Drawing.Color.Lime
        Me.btnQLTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQLTC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnQLTC.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.qlai
        Me.btnQLTC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQLTC.Location = New System.Drawing.Point(74, 14)
        Me.btnQLTC.Name = "btnQLTC"
        Me.btnQLTC.Size = New System.Drawing.Size(167, 39)
        Me.btnQLTC.TabIndex = 2
        Me.btnQLTC.Text = "Quay lại trang chủ"
        Me.btnQLTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQLTC.UseVisualStyleBackColor = False
        '
        'ThongKe_CV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(833, 611)
        Me.Controls.Add(Me.btnQLTC)
        Me.Controls.Add(Me.btnThoatTKCV)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ThongKe_CV"
        Me.Text = "ThongKe_CV"
        CType(Me.ChucVuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLNhanVien_DoThiHongKhanhDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ChucVuBindingSource As BindingSource
    Friend WithEvents QLNhanVien_DoThiHongKhanhDataSet As QLNhanVien_DoThiHongKhanhDataSet
    Friend WithEvents ChucVuTableAdapter As QLNhanVien_DoThiHongKhanhDataSetTableAdapters.ChucVuTableAdapter
    Friend WithEvents btnThoatTKCV As Button
    Friend WithEvents btnQLTC As Button
End Class
