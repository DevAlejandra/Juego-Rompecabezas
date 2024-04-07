Public Class Form1
    Dim var As Integer
    Dim objeto As PictureBox

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox5.AllowDrop = True
        PictureBox6.AllowDrop = True
        PictureBox7.AllowDrop = True
        PictureBox8.AllowDrop = True
    End Sub

    Private Sub PictureBox5_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox5.DragDrop, PictureBox6.DragDrop, PictureBox7.DragDrop, PictureBox8.DragDrop
        sender.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub PictureBox5_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox5.DragEnter, PictureBox6.DragEnter, PictureBox7.DragEnter, PictureBox8.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            If sender.tag = var Then
                e.Effect = DragDropEffects.Copy
                'objeto.Image = Nothing
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove, PictureBox2.MouseMove, PictureBox3.MouseMove, PictureBox4.MouseMove
        sender.DoDragDrop(sender.Image, DragDropEffects.Copy)
        var = CInt(sender.tag)
        objeto = sender
    End Sub
End Class
