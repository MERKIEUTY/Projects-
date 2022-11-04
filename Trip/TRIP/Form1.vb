Public Class Form1
    Private Sub NO_Click(sender As Object, e As EventArgs) Handles NO.Click

        NO.Hide()
        YES.Hide()
        Label1.Text = "WHAT SHOULD I CALL YOU?"
        TextBox1.Show()
        Button1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String

        name = TextBox1.Text
        TextBox1.Text = name
        MsgBox(" HI " + name + " HOW'S LIFE ")
        MsgBox("REMEMBER I AM ALWAYS HERE FOR YOU")
        MsgBox("BELIEVE IN YOURSELF")
        MsgBox("I KNOW YOU CAN DO IT")
        MsgBox("GOODLUCK")
    End Sub

    Private Sub YES_Click(sender As Object, e As EventArgs) Handles YES.Click
        NO.Hide()
        YES.Hide()

        TextBox1.Show()
        Button2.Show()

        NO.Hide()
        YES.Hide()




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim name As String

        name = TextBox1.Text
        NO.Hide()

        YES.Hide()
        Button2.Hide()

        Label1.Text = " HI " + name + ""
        name = TextBox1.Text
        TextBox1.Text = name
        PictureBox2.Show()
        TextBox1.Hide()
    End Sub
End Class
