Public Class Form1
    Private Sub ToolStripComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown

        If ComboBox1.Text <> "" And e.KeyCode = 13 Then
            e.Handled = True
            WebBrowser1.Navigate(ComboBox1.Text)
        End If
    End Sub
    Private Sub webBrowser1_Navigated(ByVal sender As Object,
   ByVal e As WebBrowserNavigatedEventArgs) _
   Handles WebBrowser1.Navigated

        ComboBox1.Text = WebBrowser1.Url.ToString()

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        WebBrowser1.Navigate("www.naver.com")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate("www.daum.net")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.Navigate("www.google.co.kr")
    End Sub

    Private Sub WebBrowser1_NewWindow(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles WebBrowser1.NewWindow


        e.Cancel = True


        WebBrowser1.Navigate(WebBrowser1.StatusText)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        WebBrowser1.Navigate("http://isky.co.kr/main.do")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        WebBrowser1.Navigate("http://www.samsung.com/sec/")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebBrowser1.Navigate("http://www.lge.co.kr/lgekor/main.do")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        WebBrowser1.Navigate("http://blog.naver.com/kweonsunho")
    End Sub
End Class
