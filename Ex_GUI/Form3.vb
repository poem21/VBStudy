Imports System.ComponentModel

Public Class Form3

    Private flag = False
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        For i As Integer = 1 To 10
            Debug.WriteLine(i)
            Threading.Thread.Sleep(1000000000)
            Application.DoEvents()
        Next

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        MsgBox("작업끝")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Me.Timer1.Enabled = False

            For i As Integer = 1 To 10
                Me.TextBox1.Text = i
                Threading.Thread.Sleep(1000)
                Application.DoEvents()
            Next

            flag = False

        Catch ex As Exception

        End Try
    End Sub
End Class