Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Ip As String
        Ip = TextBox1.Text
        If My.Computer.Network.Ping(Ip) Then
            Label7.ForeColor = Color.Green
            MsgBox("Online")
        Else
            Label7.ForeColor = Color.Red
            MsgBox("Offline")

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("http://google.com")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("http://terrormodzyt.tk/")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.mediafire.com/folder/fndpdf6r17ys4/TERRORMODZ%20Helper%20VIP%20Update")
        Dim response As System.Net.HttpWebResponse = request.GetResponse

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)

        Dim newestversion As String = sr.ReadToEnd
        Dim currentversion As String = Application.ProductVersion

        If newestversion.Contains(currentversion) Then
            MsgBox("There is a new update avilable!")
        Else
            MsgBox("You are up to date!")

        End If

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("https://docs.google.com/document/d/e/2PACX-1vRmKy_lSyn32Vnfp92ChT54XGdUR4c9J6FINiWWZNj2HDeRZfOLXEd9NmemODhxMo17Q-JcjV3AEZCW/pub")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/c/TERRORMODZ")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        System.Diagnostics.Process.Start("https://viperstresser.us/")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        System.Diagnostics.Process.Start("https://www.paypal.me/TerrorModzYT")
    End Sub
End Class
