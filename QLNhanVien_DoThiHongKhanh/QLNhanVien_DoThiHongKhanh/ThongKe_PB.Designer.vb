<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ThongKe_PB
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ThongKe_PB))
        Me.PhongBanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLNhanVien_DoThiHongKhanhDataSet = New QLNhanVien_DoThiHongKhanh.QLNhanVien_DoThiHongKhanhDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PhongBanTableAdapter = New QLNhanVien_DoThiHongKhanh.QLNhanVien_DoThiHongKhanhDataSetTableAdapters.PhongBanTableAdapter()
        Me.btnThoatTKPB = New System.Windows.Forms.Button()
        Me.btnQLTC = New System.Windows.Forms.Button()
        CType(Me.PhongBanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLNhanVien_DoThiHongKhanhDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PhongBanBindingSource
        '
        Me.PhongBanBindingSource.DataMember = "PhongBan"
        Me.PhongBanBindingSource.DataSource = Me.QLNhanVien_DoThiHongKhanhDataSet
        '
        'QLNhanVien_DoThiHongKhanhDataSet
        '
        Me.QLNhanVien_DoThiHongKhanhDataSet.DataSetName = "QLNhanVien_DoThiHongKhanhDataSet"
        Me.QLNhanVien_DoThiHongKhanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PhongBanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "QLNhanVien_DoThiHongKhanh.Report_DSPhongBan.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 59)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(787, 433)
        Me.ReportViewer1.TabIndex = 0
        '
        'PhongBanTableAdapter
        '
        Me.PhongBanTableAdapter.ClearBeforeFill = True
        '
        'btnThoatTKPB
        '
        Me.btnThoatTKPB.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnThoatTKPB.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.thoat
        Me.btnThoatTKPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoatTKPB.Location = New System.Drawing.Point(641, 14)
        Me.btnThoatTKPB.Name = "btnThoatTKPB"
        Me.btnThoatTKPB.Size = New System.Drawing.Size(84, 39)
        Me.btnThoatTKPB.TabIndex = 1
        Me.btnThoatTKPB.Text = "Thoát"
        Me.btnThoatTKPB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoatTKPB.UseVisualStyleBackColor = False
        '
        'btnQLTC
        '
        Me.btnQLTC.BackColor = System.Drawing.Color.SpringGreen
        Me.btnQLTC.Image = Global.QLNhanVien_DoThiHongKhanh.My.Resources.Resources.qlai
        Me.btnQLTC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQLTC.Location = New System.Drawing.Point(68, 14)
        Me.btnQLTC.Name = "btnQLTC"
        Me.btnQLTC.Size = New System.Drawing.Size(165, 39)
        Me.btnQLTC.TabIndex = 2
        Me.btnQLTC.Text = "Quay lại trang chủ"
        Me.btnQLTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQLTC.UseVisualStyleBackColor = False
        '
        'ThongKe_PB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(809, 527)
        Me.Controls.Add(Me.btnQLTC)
        Me.Controls.Add(Me.btnThoatTKPB)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ThongKe_PB"
        Me.Text = "ThongKe_PB"
        CType(Me.PhongBanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLNhanVien_DoThiHongKhanhDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PhongBanBindingSource As BindingSource
    Friend WithEvents QLNhanVien_DoThiHongKhanhDataSet As QLNhanVien_DoThiHongKhanhDataSet
    Friend WithEvents PhongBanTableAdapter As QLNhanVien_DoThiHongKhanhDataSetTableAdapters.PhongBanTableAdapter
    Friend WithEvents btnThoatTKPB As Button
    Friend WithEvents btnQLTC As Button
End Class
