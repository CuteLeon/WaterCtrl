<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WaterCtrlForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WaterCtrlForm))
        Me.ControlPanel = New System.Windows.Forms.Panel()
        Me.DisableButton = New System.Windows.Forms.Button()
        Me.FlattenButton = New System.Windows.Forms.Button()
        Me.RandomButton = New System.Windows.Forms.Button()
        Me.EnabledButton = New System.Windows.Forms.Button()
        Me.HeightNumeric = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadiusNumeric = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ControlPanel.SuspendLayout()
        CType(Me.HeightNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadiusNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ControlPanel
        '
        Me.ControlPanel.BackColor = System.Drawing.Color.Transparent
        Me.ControlPanel.Controls.Add(Me.DisableButton)
        Me.ControlPanel.Controls.Add(Me.FlattenButton)
        Me.ControlPanel.Controls.Add(Me.RandomButton)
        Me.ControlPanel.Controls.Add(Me.EnabledButton)
        Me.ControlPanel.Controls.Add(Me.HeightNumeric)
        Me.ControlPanel.Controls.Add(Me.Label2)
        Me.ControlPanel.Controls.Add(Me.RadiusNumeric)
        Me.ControlPanel.Controls.Add(Me.Label1)
        Me.ControlPanel.Location = New System.Drawing.Point(0, 0)
        Me.ControlPanel.Name = "ControlPanel"
        Me.ControlPanel.Size = New System.Drawing.Size(100, 320)
        Me.ControlPanel.TabIndex = 0
        '
        'DisableButton
        '
        Me.DisableButton.Enabled = False
        Me.DisableButton.Location = New System.Drawing.Point(10, 152)
        Me.DisableButton.Name = "DisableButton"
        Me.DisableButton.Size = New System.Drawing.Size(86, 23)
        Me.DisableButton.TabIndex = 8
        Me.DisableButton.Text = "关闭特效"
        Me.DisableButton.UseVisualStyleBackColor = True
        '
        'FlattenButton
        '
        Me.FlattenButton.Enabled = False
        Me.FlattenButton.Location = New System.Drawing.Point(10, 123)
        Me.FlattenButton.Name = "FlattenButton"
        Me.FlattenButton.Size = New System.Drawing.Size(86, 23)
        Me.FlattenButton.TabIndex = 7
        Me.FlattenButton.Text = "平复波纹"
        Me.FlattenButton.UseVisualStyleBackColor = True
        '
        'RandomButton
        '
        Me.RandomButton.Enabled = False
        Me.RandomButton.Location = New System.Drawing.Point(10, 94)
        Me.RandomButton.Name = "RandomButton"
        Me.RandomButton.Size = New System.Drawing.Size(86, 23)
        Me.RandomButton.TabIndex = 6
        Me.RandomButton.Text = "随机波纹"
        Me.RandomButton.UseVisualStyleBackColor = True
        '
        'EnabledButton
        '
        Me.EnabledButton.Location = New System.Drawing.Point(10, 65)
        Me.EnabledButton.Name = "EnabledButton"
        Me.EnabledButton.Size = New System.Drawing.Size(86, 23)
        Me.EnabledButton.TabIndex = 5
        Me.EnabledButton.Text = "开启特效"
        Me.EnabledButton.UseVisualStyleBackColor = True
        '
        'HeightNumeric
        '
        Me.HeightNumeric.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.HeightNumeric.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.HeightNumeric.Location = New System.Drawing.Point(49, 36)
        Me.HeightNumeric.Maximum = New Decimal(New Integer() {2147483315, 0, 0, 0})
        Me.HeightNumeric.Name = "HeightNumeric"
        Me.HeightNumeric.Size = New System.Drawing.Size(47, 23)
        Me.HeightNumeric.TabIndex = 4
        Me.HeightNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HeightNumeric.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "深度："
        '
        'RadiusNumeric
        '
        Me.RadiusNumeric.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RadiusNumeric.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.RadiusNumeric.Location = New System.Drawing.Point(49, 7)
        Me.RadiusNumeric.Maximum = New Decimal(New Integer() {2147483315, 0, 0, 0})
        Me.RadiusNumeric.Name = "RadiusNumeric"
        Me.RadiusNumeric.Size = New System.Drawing.Size(47, 23)
        Me.RadiusNumeric.TabIndex = 2
        Me.RadiusNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RadiusNumeric.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "半径："
        '
        'WaterCtrlForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(570, 320)
        Me.Controls.Add(Me.ControlPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WaterCtrlForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "水波纹特效"
        Me.ControlPanel.ResumeLayout(False)
        Me.ControlPanel.PerformLayout()
        CType(Me.HeightNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadiusNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ControlPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents RadiusNumeric As NumericUpDown
    Friend WithEvents HeightNumeric As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents EnabledButton As Button
    Friend WithEvents RandomButton As Button
    Friend WithEvents FlattenButton As Button
    Friend WithEvents DisableButton As Button
End Class
