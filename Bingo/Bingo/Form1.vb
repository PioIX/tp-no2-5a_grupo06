Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Size = New Size(screenWidth, screenHeight)
        Pic_Border.Size = New Size(screenWidth, screenHeight * 0.12)
        Pic_Border.Location = New Point(0, 0)
        Btn_Cerrar.Size = New Size(screenHeight * 0.1, screenHeight * 0.1)
        Btn_Cerrar.Location = New Point(screenWidth - (screenWidth * 0.063), screenHeight * 0.01)
        Btn_Minimizar.Size = New Size(screenHeight * 0.1, screenHeight * 0.1)
        Btn_Minimizar.Location = New Point(screenWidth - (screenWidth * 0.126), screenHeight * 0.01)
        Btn_Reinicio.Size = New Size(screenHeight * 0.1, screenHeight * 0.1)
        Btn_Reinicio.Location = New Point(screenWidth * 0.005, screenHeight * 0.01)
    End Sub

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        Application.ExitThread()
    End Sub

    Private Sub Btn_Minimizar_Click(sender As Object, e As EventArgs) Handles Btn_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btn_Reinicio_Click(sender As Object, e As EventArgs) Handles Btn_Reinicio.Click

    End Sub

    ' Hacer MouseClick

End Class
