Public Class حاسبة_متقدمة
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x = Integer.Parse(TextBox1.Text)
        y = Integer.Parse(TextBox2.Text)

        If RadioButton1.Checked = True Then
            TextBox2.Show()
            TextBox3.Text = (x Mod y).ToString
        End If
        If RadioButton2.Checked = True Then
            TextBox2.Show()
            TextBox3.Text = (x ^ y).ToString
        End If
        If RadioButton3.Checked = True Then

            TextBox2.Hide()


            TextBox3.Text = System.Math.Sqrt(x).ToString
        End If
        If RadioButton4.Checked = True Then

            TextBox3.Text = System.Math.Abs(x).ToString
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub
End Class