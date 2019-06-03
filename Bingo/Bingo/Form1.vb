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

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover

    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover

    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover

    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover

    End Sub

    Private Sub Label5_MouseHover(sender As Object, e As EventArgs) Handles Label5.MouseHover

    End Sub

    Private Sub Label6_MouseHover(sender As Object, e As EventArgs) Handles Label6.MouseHover

    End Sub

    Private Sub Label7_MouseHover(sender As Object, e As EventArgs) Handles Label7.MouseHover

    End Sub

    Private Sub Label8_MouseHover(sender As Object, e As EventArgs) Handles Label8.MouseHover

    End Sub

    Private Sub Label9_MouseHover(sender As Object, e As EventArgs) Handles Label9.MouseHover

    End Sub

    Private Sub Label10_MouseHover(sender As Object, e As EventArgs) Handles Label10.MouseHover

    End Sub

    Private Sub Label11_MouseHover(sender As Object, e As EventArgs) Handles Label11.MouseHover

    End Sub

    Private Sub Label12_MouseHover(sender As Object, e As EventArgs) Handles Label12.MouseHover

    End Sub

    Private Sub Label13_MouseHover(sender As Object, e As EventArgs) Handles Label13.MouseHover

    End Sub

    Private Sub Label14_MouseHover(sender As Object, e As EventArgs) Handles Label14.MouseHover

    End Sub

    Private Sub Label15_MouseHover(sender As Object, e As EventArgs) Handles Label15.MouseHover

    End Sub

    Private Sub Label16_MouseHover(sender As Object, e As EventArgs) Handles Label16.MouseHover

    End Sub

    Private Sub Label17_MouseHover(sender As Object, e As EventArgs) Handles Label17.MouseHover

    End Sub

    Private Sub Label18_MouseHover(sender As Object, e As EventArgs) Handles Label18.MouseHover

    End Sub

    Private Sub Label19_MouseHover(sender As Object, e As EventArgs) Handles Label19.MouseHover

    End Sub

    Private Sub Label20_MouseHover(sender As Object, e As EventArgs) Handles Label20.MouseHover

    End Sub

    Private Sub Label21_MouseHover(sender As Object, e As EventArgs) Handles Label21.MouseHover

    End Sub

    Private Sub Label22_MouseHover(sender As Object, e As EventArgs) Handles Label22.MouseHover

    End Sub

    Private Sub Label23_MouseHover(sender As Object, e As EventArgs) Handles Label23.MouseHover

    End Sub

    Private Sub Label24_MouseHover(sender As Object, e As EventArgs) Handles Label24.MouseHover

    End Sub

    Private Sub Label25_MouseHover(sender As Object, e As EventArgs) Handles Label25.MouseHover

    End Sub

    Private Sub Label26_MouseHover(sender As Object, e As EventArgs) Handles Label26.MouseHover

    End Sub

    Private Sub Label27_MouseHover(sender As Object, e As EventArgs) Handles Label27.MouseHover

    End Sub

    Private Sub Label28_MouseHover(sender As Object, e As EventArgs) Handles Label28.MouseHover

    End Sub

    Private Sub Label29_MouseHover(sender As Object, e As EventArgs) Handles Label29.MouseHover

    End Sub

    Private Sub Label30_MouseHover(sender As Object, e As EventArgs) Handles Label30.MouseHover

    End Sub

    Private Sub Label31_MouseHover(sender As Object, e As EventArgs) Handles Label31.MouseHover

    End Sub

    Private Sub Label32_MouseHover(sender As Object, e As EventArgs) Handles Label32.MouseHover

    End Sub

    Private Sub Label33_MouseHover(sender As Object, e As EventArgs) Handles Label33.MouseHover

    End Sub

    Private Sub Label34_MouseHover(sender As Object, e As EventArgs) Handles Label34.MouseHover

    End Sub

    Private Sub Label35_MouseHover(sender As Object, e As EventArgs) Handles Label35.MouseHover

    End Sub

    Private Sub Label36_MouseHover(sender As Object, e As EventArgs) Handles Label36.MouseHover

    End Sub

    Private Sub Label37_MouseHover(sender As Object, e As EventArgs) Handles Label37.MouseHover

    End Sub

    Private Sub Label38_MouseHover(sender As Object, e As EventArgs) Handles Label38.MouseHover

    End Sub

    Private Sub Label39_MouseHover(sender As Object, e As EventArgs) Handles Label39.MouseHover

    End Sub

    Private Sub Label40_MouseHover(sender As Object, e As EventArgs) Handles Label40.MouseHover

    End Sub

    Private Sub Label41_MouseHover(sender As Object, e As EventArgs) Handles Label41.MouseHover

    End Sub

    Private Sub Label42_MouseHover(sender As Object, e As EventArgs) Handles Label42.MouseHover

    End Sub

    Private Sub Label43_MouseHover(sender As Object, e As EventArgs) Handles Label43.MouseHover

    End Sub

    Private Sub Label44_MouseHover(sender As Object, e As EventArgs) Handles Label44.MouseHover

    End Sub

    Private Sub Label45_MouseHover(sender As Object, e As EventArgs) Handles Label45.MouseHover

    End Sub

    Private Sub Label46_MouseHover(sender As Object, e As EventArgs) Handles Label46.MouseHover

    End Sub

    Private Sub Label47_MouseHover(sender As Object, e As EventArgs) Handles Label47.MouseHover

    End Sub

    Private Sub Label48_MouseHover(sender As Object, e As EventArgs) Handles Label48.MouseHover

    End Sub

    Private Sub Label49_MouseHover(sender As Object, e As EventArgs) Handles Label49.MouseHover

    End Sub

    Private Sub Label50_MouseHover(sender As Object, e As EventArgs) Handles Label50.MouseHover

    End Sub

    Private Sub Label51_MouseHover(sender As Object, e As EventArgs) Handles Label51.MouseHover

    End Sub

    Private Sub Label52_MouseHover(sender As Object, e As EventArgs) Handles Label52.MouseHover

    End Sub

    Private Sub Label53_MouseHover(sender As Object, e As EventArgs) Handles Label53.MouseHover

    End Sub

    Private Sub Label54_MouseHover(sender As Object, e As EventArgs) Handles Label54.MouseHover

    End Sub

    Private Sub Label55_MouseHover(sender As Object, e As EventArgs) Handles Label55.MouseHover

    End Sub

    Private Sub Label56_MouseHover(sender As Object, e As EventArgs) Handles Label56.MouseHover

    End Sub

    Private Sub Label57_MouseHover(sender As Object, e As EventArgs) Handles Label57.MouseHover

    End Sub

    Private Sub Label58_MouseHover(sender As Object, e As EventArgs) Handles Label58.MouseHover

    End Sub

    Private Sub Label59_MouseHover(sender As Object, e As EventArgs) Handles Label59.MouseHover

    End Sub

    Private Sub Label60_MouseHover(sender As Object, e As EventArgs) Handles Label60.MouseHover

    End Sub

    Private Sub Label61_MouseHover(sender As Object, e As EventArgs) Handles Label61.MouseHover

    End Sub

    Private Sub Label62_MouseHover(sender As Object, e As EventArgs) Handles Label62.MouseHover

    End Sub

    Private Sub Label63_MouseHover(sender As Object, e As EventArgs) Handles Label63.MouseHover

    End Sub

    Private Sub Label64_MouseHover(sender As Object, e As EventArgs) Handles Label64.MouseHover

    End Sub

    Private Sub Label65_MouseHover(sender As Object, e As EventArgs) Handles Label65.MouseHover

    End Sub

    Private Sub Label66_MouseHover(sender As Object, e As EventArgs) Handles Label66.MouseHover

    End Sub

    Private Sub Label67_MouseHover(sender As Object, e As EventArgs) Handles Label67.MouseHover

    End Sub

    Private Sub Label68_MouseHover(sender As Object, e As EventArgs) Handles Label68.MouseHover

    End Sub

    Private Sub Label69_MouseHover(sender As Object, e As EventArgs) Handles Label69.MouseHover

    End Sub

    Private Sub Label70_MouseLeave(sender As Object, e As EventArgs) Handles Label70.MouseLeave

    End Sub

    Private Sub Label71_MouseHover(sender As Object, e As EventArgs) Handles Label71.MouseHover

    End Sub

    Private Sub Label72_MouseHover(sender As Object, e As EventArgs) Handles Label72.MouseHover

    End Sub

    Private Sub Label73_MouseHover(sender As Object, e As EventArgs) Handles Label73.MouseHover

    End Sub

    Private Sub Label74_MouseHover(sender As Object, e As EventArgs) Handles Label74.MouseHover

    End Sub

    Private Sub Label75_MouseHover(sender As Object, e As EventArgs) Handles Label75.MouseHover

    End Sub

    Private Sub Label76_MouseHover(sender As Object, e As EventArgs) Handles Label76.MouseHover

    End Sub

    Private Sub Label77_MouseHover(sender As Object, e As EventArgs) Handles Label77.MouseHover

    End Sub

    Private Sub Label78_MouseHover(sender As Object, e As EventArgs) Handles Label78.MouseHover

    End Sub

    Private Sub Label79_MouseHover(sender As Object, e As EventArgs) Handles Label79.MouseHover

    End Sub

    Private Sub Label80_MouseHover(sender As Object, e As EventArgs) Handles Label80.MouseHover

    End Sub

    Private Sub Label81_MouseHover(sender As Object, e As EventArgs) Handles Label81.MouseHover

    End Sub

    Private Sub Label82_MouseHover(sender As Object, e As EventArgs) Handles Label82.MouseHover

    End Sub

    Private Sub Label83_MouseHover(sender As Object, e As EventArgs) Handles Label83.MouseHover

    End Sub

    Private Sub Label84_MouseHover(sender As Object, e As EventArgs) Handles Label84.MouseHover

    End Sub

    Private Sub Label85_MouseHover(sender As Object, e As EventArgs) Handles Label85.MouseHover

    End Sub

    Private Sub Label86_MouseHover(sender As Object, e As EventArgs) Handles Label86.MouseHover

    End Sub

    Private Sub Label87_MouseHover(sender As Object, e As EventArgs) Handles Label87.MouseHover

    End Sub

    Private Sub Label88_MouseHover(sender As Object, e As EventArgs) Handles Label88.MouseHover

    End Sub

    Private Sub Label89_MouseHover(sender As Object, e As EventArgs) Handles Label89.MouseHover

    End Sub

    Private Sub Label90_MouseHover(sender As Object, e As EventArgs) Handles Label90.MouseHover

    End Sub


    'Hacer MouseLeave y MouseClick

End Class
