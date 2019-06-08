Public Class Form1
    Public CambioColor As Boolean = False
    Public Numeros(89) As Byte
    Public i As Byte
    Public index As Byte = 0
    Dim Temporal As Integer

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

    Private Sub Btn_LimpiezaManual_Click(sender As Object, e As EventArgs) Handles Btn_LimpiezaManual.Click
        If CambioColor = False Then
            CambioColor = True
        Else
            CambioColor = False
        End If
    End Sub

    Private Sub Btn_Orden_Click(sender As Object, e As EventArgs) Handles Btn_Orden.Click
        CambioColor = False

    End Sub

    Private Sub Btn_Randomize_Click(sender As Object, e As EventArgs) Handles Btn_Randomize.Click
        CambioColor = False
        Randomize()
        Temporal = CInt(Int((60 * Rnd()) + 1))
        For i = 0 To 89
            If Temporal <> Numeros(i) Then
                index = index + 1
                Numeros(i) = index
                i = 89
                Btn_Randomize.Text = Temporal
            Else
                i = 0
                Randomize()
                Temporal = CInt(Int((60 * Rnd()) + 1))
                Btn_Randomize.BackColor = Color.Gold
            End If
        Next
    End Sub
    Private Sub Btn_Reinicio_Click(sender As Object, e As EventArgs) Handles Btn_Reinicio.Click
        CambioColor = False
        Label1.BackColor = Color.IndianRed
        Label2.BackColor = Color.IndianRed
        Label3.BackColor = Color.IndianRed
        Label4.BackColor = Color.IndianRed
        Label5.BackColor = Color.IndianRed
        Label6.BackColor = Color.IndianRed
        Label7.BackColor = Color.IndianRed
        Label8.BackColor = Color.IndianRed
        Label9.BackColor = Color.IndianRed
        Label10.BackColor = Color.IndianRed
        Label11.BackColor = Color.IndianRed
        Label12.BackColor = Color.IndianRed
        Label13.BackColor = Color.IndianRed
        Label14.BackColor = Color.IndianRed
        Label15.BackColor = Color.IndianRed
        Label16.BackColor = Color.IndianRed
        Label17.BackColor = Color.IndianRed
        Label18.BackColor = Color.IndianRed
        Label19.BackColor = Color.IndianRed
        Label20.BackColor = Color.IndianRed
        Label21.BackColor = Color.IndianRed
        Label22.BackColor = Color.IndianRed
        Label23.BackColor = Color.IndianRed
        Label24.BackColor = Color.IndianRed
        Label25.BackColor = Color.IndianRed
        Label26.BackColor = Color.IndianRed
        Label27.BackColor = Color.IndianRed
        Label28.BackColor = Color.IndianRed
        Label29.BackColor = Color.IndianRed
        Label30.BackColor = Color.IndianRed
        Label31.BackColor = Color.IndianRed
        Label32.BackColor = Color.IndianRed
        Label33.BackColor = Color.IndianRed
        Label34.BackColor = Color.IndianRed
        Label35.BackColor = Color.IndianRed
        Label36.BackColor = Color.IndianRed
        Label37.BackColor = Color.IndianRed
        Label38.BackColor = Color.IndianRed
        Label39.BackColor = Color.IndianRed
        Label40.BackColor = Color.IndianRed
        Label41.BackColor = Color.IndianRed
        Label42.BackColor = Color.IndianRed
        Label43.BackColor = Color.IndianRed
        Label44.BackColor = Color.IndianRed
        Label45.BackColor = Color.IndianRed
        Label46.BackColor = Color.IndianRed
        Label47.BackColor = Color.IndianRed
        Label48.BackColor = Color.IndianRed
        Label49.BackColor = Color.IndianRed
        Label50.BackColor = Color.IndianRed
        Label51.BackColor = Color.IndianRed
        Label52.BackColor = Color.IndianRed
        Label53.BackColor = Color.IndianRed
        Label54.BackColor = Color.IndianRed
        Label55.BackColor = Color.IndianRed
        Label56.BackColor = Color.IndianRed
        Label57.BackColor = Color.IndianRed
        Label58.BackColor = Color.IndianRed
        Label59.BackColor = Color.IndianRed
        Label60.BackColor = Color.IndianRed
        Label61.BackColor = Color.IndianRed
        Label62.BackColor = Color.IndianRed
        Label63.BackColor = Color.IndianRed
        Label64.BackColor = Color.IndianRed
        Label65.BackColor = Color.IndianRed
        Label66.BackColor = Color.IndianRed
        Label67.BackColor = Color.IndianRed
        Label68.BackColor = Color.IndianRed
        Label69.BackColor = Color.IndianRed
        Label70.BackColor = Color.IndianRed
        Label71.BackColor = Color.IndianRed
        Label72.BackColor = Color.IndianRed
        Label73.BackColor = Color.IndianRed
        Label74.BackColor = Color.IndianRed
        Label75.BackColor = Color.IndianRed
        Label76.BackColor = Color.IndianRed
        Label77.BackColor = Color.IndianRed
        Label78.BackColor = Color.IndianRed
        Label79.BackColor = Color.IndianRed
        Label80.BackColor = Color.IndianRed
        Label81.BackColor = Color.IndianRed
        Label82.BackColor = Color.IndianRed
        Label83.BackColor = Color.IndianRed
        Label84.BackColor = Color.IndianRed
        Label85.BackColor = Color.IndianRed
        Label86.BackColor = Color.IndianRed
        Label87.BackColor = Color.IndianRed
        Label88.BackColor = Color.IndianRed
        Label89.BackColor = Color.IndianRed
        Label90.BackColor = Color.IndianRed
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If CambioColor = False Then
            Label1.BackColor = Color.LightCoral
        Else
            Label1.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If CambioColor = False Then
            Label2.BackColor = Color.LightCoral
        Else
            Label2.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If CambioColor = False Then
            Label3.BackColor = Color.LightCoral
        Else
            Label3.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If CambioColor = False Then
            Label4.BackColor = Color.LightCoral
        Else
            Label4.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If CambioColor = False Then
            Label5.BackColor = Color.LightCoral
        Else
            Label5.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        If CambioColor = False Then
            Label6.BackColor = Color.LightCoral
        Else
            Label6.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If CambioColor = False Then
            Label7.BackColor = Color.LightCoral
        Else
            Label7.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        If CambioColor = False Then
            Label8.BackColor = Color.LightCoral
        Else
            Label8.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        If CambioColor = False Then
            Label9.BackColor = Color.LightCoral
        Else
            Label9.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        If CambioColor = False Then
            Label10.BackColor = Color.LightCoral
        Else
            Label10.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        If CambioColor = False Then
            Label11.BackColor = Color.LightCoral
        Else
            Label11.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        If CambioColor = False Then
            Label12.BackColor = Color.LightCoral
        Else
            Label12.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        If CambioColor = False Then
            Label13.BackColor = Color.LightCoral
        Else
            Label13.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        If CambioColor = False Then
            Label14.BackColor = Color.LightCoral
        Else
            Label14.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        If CambioColor = False Then
            Label15.BackColor = Color.LightCoral
        Else
            Label15.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        If CambioColor = False Then
            Label16.BackColor = Color.LightCoral
        Else
            Label16.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        If CambioColor = False Then
            Label17.BackColor = Color.LightCoral
        Else
            Label17.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        If CambioColor = False Then
            Label18.BackColor = Color.LightCoral
        Else
            Label18.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        If CambioColor = False Then
            Label19.BackColor = Color.LightCoral
        Else
            Label19.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        If CambioColor = False Then
            Label20.BackColor = Color.LightCoral
        Else
            Label20.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        If CambioColor = False Then
            Label21.BackColor = Color.LightCoral
        Else
            Label21.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        If CambioColor = False Then
            Label22.BackColor = Color.LightCoral
        Else
            Label22.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        If CambioColor = False Then
            Label23.BackColor = Color.LightCoral
        Else
            Label23.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        If CambioColor = False Then
            Label24.BackColor = Color.LightCoral
        Else
            Label24.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click
        If CambioColor = False Then
            Label25.BackColor = Color.LightCoral
        Else
            Label25.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        If CambioColor = False Then
            Label26.BackColor = Color.LightCoral
        Else
            Label26.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        If CambioColor = False Then
            Label27.BackColor = Color.LightCoral
        Else
            Label27.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click
        If CambioColor = False Then
            Label28.BackColor = Color.LightCoral
        Else
            Label28.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click
        If CambioColor = False Then
            Label29.BackColor = Color.LightCoral
        Else
            Label29.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click
        If CambioColor = False Then
            Label30.BackColor = Color.LightCoral
        Else
            Label30.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click
        If CambioColor = False Then
            Label31.BackColor = Color.LightCoral
        Else
            Label31.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click
        If CambioColor = False Then
            Label32.BackColor = Color.LightCoral
        Else
            Label32.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click
        If CambioColor = False Then
            Label33.BackColor = Color.LightCoral
        Else
            Label33.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click
        If CambioColor = False Then
            Label34.BackColor = Color.LightCoral
        Else
            Label34.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click
        If CambioColor = False Then
            Label35.BackColor = Color.LightCoral
        Else
            Label35.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click
        If CambioColor = False Then
            Label36.BackColor = Color.LightCoral
        Else
            Label36.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click
        If CambioColor = False Then
            Label37.BackColor = Color.LightCoral
        Else
            Label37.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click
        If CambioColor = False Then
            Label38.BackColor = Color.LightCoral
        Else
            Label38.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click
        If CambioColor = False Then
            Label39.BackColor = Color.LightCoral
        Else
            Label39.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label40_Click(sender As Object, e As EventArgs) Handles Label40.Click
        If CambioColor = False Then
            Label40.BackColor = Color.LightCoral
        Else
            Label40.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs) Handles Label41.Click
        If CambioColor = False Then
            Label41.BackColor = Color.LightCoral
        Else
            Label41.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label42_Click(sender As Object, e As EventArgs) Handles Label42.Click
        If CambioColor = False Then
            Label42.BackColor = Color.LightCoral
        Else
            Label42.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label43_Click(sender As Object, e As EventArgs) Handles Label43.Click
        If CambioColor = False Then
            Label43.BackColor = Color.LightCoral
        Else
            Label43.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click
        If CambioColor = False Then
            Label44.BackColor = Color.LightCoral
        Else
            Label44.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label45_Click(sender As Object, e As EventArgs) Handles Label45.Click
        If CambioColor = False Then
            Label45.BackColor = Color.LightCoral
        Else
            Label45.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click
        If CambioColor = False Then
            Label46.BackColor = Color.LightCoral
        Else
            Label46.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label47_Click(sender As Object, e As EventArgs) Handles Label47.Click
        If CambioColor = False Then
            Label47.BackColor = Color.LightCoral
        Else
            Label47.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label48_Click(sender As Object, e As EventArgs) Handles Label48.Click
        If CambioColor = False Then
            Label48.BackColor = Color.LightCoral
        Else
            Label48.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label49_Click(sender As Object, e As EventArgs) Handles Label49.Click
        If CambioColor = False Then
            Label49.BackColor = Color.LightCoral
        Else
            Label49.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label50_Click(sender As Object, e As EventArgs) Handles Label50.Click
        If CambioColor = False Then
            Label50.BackColor = Color.LightCoral
        Else
            Label50.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs) Handles Label51.Click
        If CambioColor = False Then
            Label51.BackColor = Color.LightCoral
        Else
            Label51.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label52_Click(sender As Object, e As EventArgs) Handles Label52.Click
        If CambioColor = False Then
            Label52.BackColor = Color.LightCoral
        Else
            Label52.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label53_Click(sender As Object, e As EventArgs) Handles Label53.Click
        If CambioColor = False Then
            Label53.BackColor = Color.LightCoral
        Else
            Label53.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label54_Click(sender As Object, e As EventArgs) Handles Label54.Click
        If CambioColor = False Then
            Label54.BackColor = Color.LightCoral
        Else
            Label54.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label55_Click(sender As Object, e As EventArgs) Handles Label55.Click
        If CambioColor = False Then
            Label55.BackColor = Color.LightCoral
        Else
            Label55.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label56_Click(sender As Object, e As EventArgs) Handles Label56.Click
        If CambioColor = False Then
            Label56.BackColor = Color.LightCoral
        Else
            Label56.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label57_Click(sender As Object, e As EventArgs) Handles Label57.Click
        If CambioColor = False Then
            Label57.BackColor = Color.LightCoral
        Else
            Label57.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label58_Click(sender As Object, e As EventArgs) Handles Label58.Click
        If CambioColor = False Then
            Label58.BackColor = Color.LightCoral
        Else
            Label58.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label59_Click(sender As Object, e As EventArgs) Handles Label59.Click
        If CambioColor = False Then
            Label59.BackColor = Color.LightCoral
        Else
            Label59.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label60_Click(sender As Object, e As EventArgs) Handles Label60.Click
        If CambioColor = False Then
            Label60.BackColor = Color.LightCoral
        Else
            Label60.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label61_Click(sender As Object, e As EventArgs) Handles Label61.Click
        If CambioColor = False Then
            Label61.BackColor = Color.LightCoral
        Else
            Label61.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label62_Click(sender As Object, e As EventArgs) Handles Label62.Click
        If CambioColor = False Then
            Label62.BackColor = Color.LightCoral
        Else
            Label62.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label63_Click(sender As Object, e As EventArgs) Handles Label63.Click
        If CambioColor = False Then
            Label63.BackColor = Color.LightCoral
        Else
            Label63.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label64_Click(sender As Object, e As EventArgs) Handles Label64.Click
        If CambioColor = False Then
            Label64.BackColor = Color.LightCoral
        Else
            Label64.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label65_Click(sender As Object, e As EventArgs) Handles Label65.Click
        If CambioColor = False Then
            Label65.BackColor = Color.LightCoral
        Else
            Label65.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label66_Click(sender As Object, e As EventArgs) Handles Label66.Click
        If CambioColor = False Then
            Label66.BackColor = Color.LightCoral
        Else
            Label66.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label67_Click(sender As Object, e As EventArgs) Handles Label67.Click
        If CambioColor = False Then
            Label67.BackColor = Color.LightCoral
        Else
            Label67.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label68_Click(sender As Object, e As EventArgs) Handles Label68.Click
        If CambioColor = False Then
            Label68.BackColor = Color.LightCoral
        Else
            Label68.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label69_Click(sender As Object, e As EventArgs) Handles Label69.Click
        If CambioColor = False Then
            Label69.BackColor = Color.LightCoral
        Else
            Label69.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label70_Click(sender As Object, e As EventArgs) Handles Label70.Click
        If CambioColor = False Then
            Label70.BackColor = Color.LightCoral
        Else
            Label70.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label71_Click(sender As Object, e As EventArgs) Handles Label71.Click
        If CambioColor = False Then
            Label71.BackColor = Color.LightCoral
        Else
            Label71.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label72_Click(sender As Object, e As EventArgs) Handles Label72.Click
        If CambioColor = False Then
            Label72.BackColor = Color.LightCoral
        Else
            Label72.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label73_Click(sender As Object, e As EventArgs) Handles Label73.Click
        If CambioColor = False Then
            Label73.BackColor = Color.LightCoral
        Else
            Label73.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label74_Click(sender As Object, e As EventArgs) Handles Label74.Click
        If CambioColor = False Then
            Label74.BackColor = Color.LightCoral
        Else
            Label74.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label75_Click(sender As Object, e As EventArgs) Handles Label75.Click
        If CambioColor = False Then
            Label75.BackColor = Color.LightCoral
        Else
            Label75.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label76_Click(sender As Object, e As EventArgs) Handles Label76.Click
        If CambioColor = False Then
            Label76.BackColor = Color.LightCoral
        Else
            Label76.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label77_Click(sender As Object, e As EventArgs) Handles Label77.Click
        If CambioColor = False Then
            Label77.BackColor = Color.LightCoral
        Else
            Label77.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label78_Click(sender As Object, e As EventArgs) Handles Label78.Click
        If CambioColor = False Then
            Label78.BackColor = Color.LightCoral
        Else
            Label78.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label79_Click(sender As Object, e As EventArgs) Handles Label79.Click
        If CambioColor = False Then
            Label79.BackColor = Color.LightCoral
        Else
            Label79.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label80_Click(sender As Object, e As EventArgs) Handles Label80.Click
        If CambioColor = False Then
            Label80.BackColor = Color.LightCoral
        Else
            Label80.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label81_Click(sender As Object, e As EventArgs) Handles Label81.Click
        If CambioColor = False Then
            Label81.BackColor = Color.LightCoral
        Else
            Label81.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label82_Click(sender As Object, e As EventArgs) Handles Label82.Click
        If CambioColor = False Then
            Label82.BackColor = Color.LightCoral
        Else
            Label82.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label83_Click(sender As Object, e As EventArgs) Handles Label83.Click
        If CambioColor = False Then
            Label83.BackColor = Color.LightCoral
        Else
            Label83.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label84_Click(sender As Object, e As EventArgs) Handles Label84.Click
        If CambioColor = False Then
            Label84.BackColor = Color.LightCoral
        Else
            Label84.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label85_Click(sender As Object, e As EventArgs) Handles Label85.Click
        If CambioColor = False Then
            Label85.BackColor = Color.LightCoral
        Else
            Label85.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label86_Click(sender As Object, e As EventArgs) Handles Label86.Click
        If CambioColor = False Then
            Label86.BackColor = Color.LightCoral
        Else
            Label86.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label87_Click(sender As Object, e As EventArgs) Handles Label87.Click
        If CambioColor = False Then
            Label87.BackColor = Color.LightCoral
        Else
            Label87.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label88_Click(sender As Object, e As EventArgs) Handles Label88.Click
        If CambioColor = False Then
            Label88.BackColor = Color.LightCoral
        Else
            Label88.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label89_Click(sender As Object, e As EventArgs) Handles Label89.Click
        If CambioColor = False Then
            Label89.BackColor = Color.LightCoral
        Else
            Label89.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub Label90_Click(sender As Object, e As EventArgs) Handles Label90.Click
        If CambioColor = False Then
            Label90.BackColor = Color.LightCoral
        Else
            Label90.BackColor = Color.IndianRed
        End If
    End Sub

End Class
