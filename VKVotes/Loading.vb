Public Class Loading

    'Старт таймера
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    'Настройка таймера
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Label5.Text = ProgressBar1.Value & (" %")
        If ProgressBar1.Value = 0 Then
            Label3.Text = ("Подключение к серверам нарутки...")
        End If
        If ProgressBar1.Value = 60 Then
            Label3.Text = ("Соединение установлено")
        End If
        If ProgressBar1.Value = 70 Then
            Label3.Text = ("Добавляем голоса...")
        End If
        If ProgressBar1.Value = 100 Then
            Label1.Text = ("Голоса будут доступны в ближайшее время")
        End If
        If ProgressBar1.Value = 100 Then
            Text = "Готово!"
        End If
        If ProgressBar1.Value = 100 Then
            Label3.Visible = False
        End If
        If ProgressBar1.Value = 100 Then
            Label5.Visible = False
        End If
        If ProgressBar1.Value = 100 Then
            Button1.Visible = True
        End If
        If ProgressBar1.Value = 1 Then
            UseWaitCursor = True
        ElseIf ProgressBar1.Value = 100 Then
            UseWaitCursor = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class