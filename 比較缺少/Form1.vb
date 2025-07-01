Public Class Form1
    Dim member As New Dictionary(Of String, String)
    Dim member2 As New Dictionary(Of String, String)
    Private Structure profile
        Dim name As String

    End Structure
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        member.Clear()
        member2.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox2.Text = String.Join(Environment.NewLine, TextBox1.Lines.Distinct())
        Dim a As Array = TextBox2.Lines
        Array.Sort(a)
        TextBox2.Lines = a

        TextBox4.Text = String.Join(Environment.NewLine, TextBox3.Lines.Distinct())
        Dim b As Array = TextBox4.Lines
        Array.Sort(b)
        TextBox4.Lines = b



        For i = 0 To TextBox2.Lines.Count - 1
            Dim x As String
            Dim Id = i
            x = Trim(TextBox2.Lines(i))
            member.Add(Id, x)
        Next
        For i = 0 To TextBox4.Lines.Count - 1
            Dim x As String
            Dim Id = i
            x = Trim(TextBox4.Lines(i))
            member2.Add(Id, x)
        Next
        For Each x In member2
            If member.ContainsValue(x.Value) Then
                TextBox7.AppendText(x.Value & vbCrLf)
            Else
                TextBox5.AppendText(x.Value & vbCrLf)
            End If
        Next
        For Each x In member
            If member2.ContainsValue(x.Value) Then
                TextBox7.AppendText(x.Value & vbCrLf)
            Else
                TextBox6.AppendText(x.Value & vbCrLf)
            End If
        Next
        TextBox7.Text = String.Join(Environment.NewLine, TextBox7.Lines.Distinct())

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Label1.Text = TextBox8.Text & "有" & TextBox9.Text & "沒有"
        Label2.Text = TextBox9.Text & "有" & TextBox8.Text & "沒有"
        Label3.Text = TextBox8.Text & "," & TextBox9.Text & "共有"
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        Label1.Text = TextBox8.Text & "有" & TextBox9.Text & "沒有"
        Label2.Text = TextBox9.Text & "有" & TextBox8.Text & "沒有"
        Label3.Text = TextBox8.Text & "," & TextBox9.Text & "共有"
    End Sub
    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    ListBox1.Items.Clear()
    '    For Each x In member
    '        ListBox1.Items.Add(x.Key)
    '    Next
    'End Sub
    'Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
    '    Dim x As profile = member.Item(ListBox1.Text)
    '    Debug.Print(ListBox1.Text)
    '    TextBox1.Text = x.birthday
    '    TextBox2.Text = x.name
    '    TextBox3.Text = ListBox1.Text
    '    RadioButton1.Checked = x.gender
    '    RadioButton2.Checked = Not x.gender
    'End Sub
End Class
