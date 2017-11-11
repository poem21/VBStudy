Public Class Form1

    Private Sub mnuFile_New_Click(sender As Object, e As EventArgs) Handles mnuFile_New.Click
        Me.mnuFile_New.Text = "File(&F)"
    End Sub

    Private Sub 파일ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 파일ToolStripMenuItem.Click

        Dim frm As Form2 = New Form2
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()


    End Sub

    Private Sub 파일ToolStripMenuItem_MouseHover(sender As Object, e As EventArgs) Handles 파일ToolStripMenuItem.MouseHover
        Me.lblStatusbar.Text = "클릭하면 새로운 파일메뉴가 나타납니다."
    End Sub

    Private Sub 파일ToolStripMenuItem_MouseUp(sender As Object, e As MouseEventArgs) Handles 파일ToolStripMenuItem.MouseUp

    End Sub
End Class

