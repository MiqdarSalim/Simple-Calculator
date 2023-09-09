Public Class Form1

    Dim oprt As String
    Dim SaveFlags As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = "0"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
        Else
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox1.Text = "0"
        oprt = ""
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        oprt = "+"
        SaveFlags = TextBox1.Text
        TextBox1.Text = "0"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        oprt = "-"
        SaveFlags = TextBox1.Text
        TextBox1.Text = "0"
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        oprt = "x"
        SaveFlags = TextBox1.Text
        TextBox1.Text = "0"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        oprt = "/"
        SaveFlags = TextBox1.Text
        TextBox1.Text = "0"
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If Not TextBox1.Text.Contains(".") Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim SaveFlag1 As Double
        Select Case oprt
            Case "+"
                SaveFlag1 = Double.Parse(SaveFlags.Replace(".", ",")) + Double.Parse(TextBox1.Text.Replace(".", ","))
                TextBox1.Text = SaveFlag1.ToString.Replace(",", ".")
            Case "-"
                SaveFlag1 = Double.Parse(SaveFlags.Replace(".", ",")) - Double.Parse(TextBox1.Text.Replace(".", ","))
                TextBox1.Text = SaveFlag1.ToString.Replace(",", ".")
            Case "x"
                SaveFlag1 = Double.Parse(SaveFlags.Replace(".", ",")) * Double.Parse(TextBox1.Text.Replace(".", ","))
                TextBox1.Text = SaveFlag1.ToString.Replace(",", ".")
            Case "/"
                SaveFlag1 = Double.Parse(SaveFlags.Replace(".", ",")) / Double.Parse(TextBox1.Text.Replace(".", ","))
                TextBox1.Text = SaveFlag1.ToString.Replace(",", ".")
        End Select
    End Sub
End Class
