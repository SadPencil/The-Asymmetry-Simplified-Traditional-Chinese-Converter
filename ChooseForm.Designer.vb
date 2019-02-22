<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox = New System.Windows.Forms.RichTextBox()
        Me.Dictionary = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox
        '
        Me.TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.TextBox.Location = New System.Drawing.Point(12, 12)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.ReadOnly = True
        Me.TextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.TextBox.Size = New System.Drawing.Size(303, 103)
        Me.TextBox.TabIndex = 4
        Me.TextBox.Text = ""
        '
        'Dictionary
        '
        Me.Dictionary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dictionary.BackColor = System.Drawing.SystemColors.Window
        Me.Dictionary.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dictionary.Location = New System.Drawing.Point(12, 159)
        Me.Dictionary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Dictionary.MaxLength = 2147483647
        Me.Dictionary.Multiline = True
        Me.Dictionary.Name = "Dictionary"
        Me.Dictionary.ReadOnly = True
        Me.Dictionary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dictionary.Size = New System.Drawing.Size(303, 103)
        Me.Dictionary.TabIndex = 3
        '
        'ChooseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 275)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.Dictionary)
        Me.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChooseForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "选择繁体字"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Dictionary As System.Windows.Forms.TextBox
End Class
