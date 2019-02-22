Public Class ChooseForm
    Private R As Char

    Public Function Choose(ByVal intLocation As Integer, ByRef str As String, ByRef strTemp As Char, ByVal strCHT As String, ByVal strDictionary As String) As Char
        Dim Traditionals() As String = Nothing  '定义一个数组，用来存储可能的繁体字
        Dim n As Integer = 0
        Do
            ReDim Preserve Traditionals(n) '重新定义数组元素个数。
            Traditionals(n) = Microsoft.VisualBasic.Mid(strCHT, n + 1, 1) '从strTraditional字符串截取汉字
            If Traditionals(n) = Nothing Then
                n = n - 1
                ReDim Preserve Traditionals(n) '清除最后一个空元素
                Exit Do
            End If

            n = n + 1
        Loop
        Debug.WriteLine(Traditionals)

        Dim btn(n) As System.Windows.Forms.Button '定义一个数组，用来显示汉字的按钮
        Dim m As Integer = 0
        Dictionary.Text = strDictionary
        Me.Size = New System.Drawing.Size(343, 314)
        For m = 0 To n
            Dictionary.TabIndex = m + 2
            btn(m) = New System.Windows.Forms.Button
            With btn(m)
                .Name = "btn" & CStr(m)
                .Text = Traditionals(m)
                Debug.WriteLine("Traditionals(" & m & ")=" & Traditionals(m))
                .Location = New Point(12 + m * 47, 123)
                .Width = 41
                .Height = 29
                .FlatStyle = FlatStyle.Standard
                .Font = New System.Drawing.Font("Microsoft JhengHei", 12)
                .Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
                .TabIndex = m + 1
            End With
            Controls.Add(btn(m))
            AddHandler btn(m).Click, AddressOf btn_Click
            Debug.WriteLine(btn(m).Text)
        Next
        Me.MinimumSize = New System.Drawing.Size((m + 1) * 47 - 12, 232)

        Me.Text = CStr(CInt(intLocation / str.Length * 100)) & "% - 选择繁体字"
        Do
            R = Nothing
            TextBox.Text = str
            TextBox.Select()
            TextBox.SelectionColor = Color.Black
            TextBox.Select(intLocation - 1 - CharNum(Microsoft.VisualBasic.Left(str, intLocation), vbCrLf), 1)
            TextBox.SelectionColor = Color.Red
            Debug.WriteLine(TextBox.SelectedText)
            Debug.WriteLine(btn)
            Me.ShowDialog()
            If R = Nothing Then
                If MessageBox.Show("是否中止转换？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                    Return Nothing
                    Exit Function
                End If
            End If
        Loop While R = Nothing
        For m = 0 To n
            Controls.Remove(btn(m))
        Next
        btn = Nothing
        Return R
    End Function
    Function CharNum(ByVal strInput As String, ByVal strChar As String) As Integer
        Dim S() As String
        If Len(Trim(strInput)) = 0 Then
            CharNum = 0
        Else
            S = Split(strInput, strChar)
            CharNum = UBound(S)
        End If
    End Function


    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        R = CChar(TryCast(sender, Button).Text)
        Me.Close()
    End Sub

End Class