Public Class Form1

    Public CambioColor As Boolean = False
    Public Repite = False
    Public números(89) As Byte
    Public i As Byte
    Public index As Byte = 0
    Public Temporal As Integer
    Public screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Public screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

    Private Sub Limpieza(LabelNumero As Byte)
        For i = 0 To 89
            If números(i) = LabelNumero Then
                números(i) = 0
            End If
        Next
    End Sub
    Function OrdenarPantalla()
        Label1.Font = New Font("Microsoft Sans Serif", 44)
        Label1.Location = New Point(screenWidth * 0.03, screenHeight * 0.15)
        Label2.Font = New Font("Microsoft Sans Serif", 44)
        Label2.Location = New Point(screenWidth * 0.095, screenHeight * 0.15)
        Label3.Font = New Font("Microsoft Sans Serif", 44)
        Label3.Location = New Point(screenWidth * 0.16, screenHeight * 0.15)
        Label4.Font = New Font("Microsoft Sans Serif", 44)
        Label4.Location = New Point(screenWidth * 0.225, screenHeight * 0.15)
        Label5.Font = New Font("Microsoft Sans Serif", 44)
        Label5.Location = New Point(screenWidth * 0.29, screenHeight * 0.15)
        Label6.Font = New Font("Microsoft Sans Serif", 44)
        Label6.Location = New Point(screenWidth * 0.355, screenHeight * 0.15)
        Label7.Font = New Font("Microsoft Sans Serif", 44)
        Label7.Location = New Point(screenWidth * 0.42, screenHeight * 0.15)
        Label8.Font = New Font("Microsoft Sans Serif", 44)
        Label8.Location = New Point(screenWidth * 0.485, screenHeight * 0.15)
        Label9.Font = New Font("Microsoft Sans Serif", 44)
        Label9.Location = New Point(screenWidth * 0.55, screenHeight * 0.15)
        Label10.Font = New Font("Microsoft Sans Serif", 44)
        Label10.Location = New Point(screenWidth * 0.615, screenHeight * 0.15)
        Label11.Font = New Font("Microsoft Sans Serif", 44)
        Label11.Location = New Point(screenWidth * 0.03, screenHeight * 0.235)
        Label12.Font = New Font("Microsoft Sans Serif", 44)
        Label12.Location = New Point(screenWidth * 0.095, screenHeight * 0.235)
        Label13.Font = New Font("Microsoft Sans Serif", 44)
        Label13.Location = New Point(screenWidth * 0.16, screenHeight * 0.235)
        Label14.Font = New Font("Microsoft Sans Serif", 44)
        Label14.Location = New Point(screenWidth * 0.225, screenHeight * 0.235)
        Label15.Font = New Font("Microsoft Sans Serif", 44)
        Label15.Location = New Point(screenWidth * 0.29, screenHeight * 0.235)
        Label16.Font = New Font("Microsoft Sans Serif", 44)
        Label16.Location = New Point(screenWidth * 0.355, screenHeight * 0.235)
        Label17.Font = New Font("Microsoft Sans Serif", 44)
        Label17.Location = New Point(screenWidth * 0.42, screenHeight * 0.235)
        Label18.Font = New Font("Microsoft Sans Serif", 44)
        Label18.Location = New Point(screenWidth * 0.485, screenHeight * 0.235)
        Label19.Font = New Font("Microsoft Sans Serif", 44)
        Label19.Location = New Point(screenWidth * 0.55, screenHeight * 0.235)
        Label20.Font = New Font("Microsoft Sans Serif", 44)
        Label20.Location = New Point(screenWidth * 0.615, screenHeight * 0.235)
        Label21.Font = New Font("Microsoft Sans Serif", 44)
        Label21.Location = New Point(screenWidth * 0.03, screenHeight * 0.32)
        Label22.Font = New Font("Microsoft Sans Serif", 44)
        Label22.Location = New Point(screenWidth * 0.095, screenHeight * 0.32)
        Label23.Font = New Font("Microsoft Sans Serif", 44)
        Label23.Location = New Point(screenWidth * 0.16, screenHeight * 0.32)
        Label24.Font = New Font("Microsoft Sans Serif", 44)
        Label24.Location = New Point(screenWidth * 0.225, screenHeight * 0.32)
        Label25.Font = New Font("Microsoft Sans Serif", 44)
        Label25.Location = New Point(screenWidth * 0.29, screenHeight * 0.32)
        Label26.Font = New Font("Microsoft Sans Serif", 44)
        Label26.Location = New Point(screenWidth * 0.355, screenHeight * 0.32)
        Label27.Font = New Font("Microsoft Sans Serif", 44)
        Label27.Location = New Point(screenWidth * 0.42, screenHeight * 0.32)
        Label28.Font = New Font("Microsoft Sans Serif", 44)
        Label28.Location = New Point(screenWidth * 0.485, screenHeight * 0.32)
        Label29.Font = New Font("Microsoft Sans Serif", 44)
        Label29.Location = New Point(screenWidth * 0.55, screenHeight * 0.32)
        Label30.Font = New Font("Microsoft Sans Serif", 44)
        Label30.Location = New Point(screenWidth * 0.615, screenHeight * 0.32)
        Label31.Font = New Font("Microsoft Sans Serif", 44)
        Label31.Location = New Point(screenWidth * 0.03, screenHeight * 0.405)
        Label32.Font = New Font("Microsoft Sans Serif", 44)
        Label32.Location = New Point(screenWidth * 0.095, screenHeight * 0.405)
        Label33.Font = New Font("Microsoft Sans Serif", 44)
        Label33.Location = New Point(screenWidth * 0.16, screenHeight * 0.405)
        Label34.Font = New Font("Microsoft Sans Serif", 44)
        Label34.Location = New Point(screenWidth * 0.225, screenHeight * 0.405)
        Label35.Font = New Font("Microsoft Sans Serif", 44)
        Label35.Location = New Point(screenWidth * 0.29, screenHeight * 0.405)
        Label36.Font = New Font("Microsoft Sans Serif", 44)
        Label36.Location = New Point(screenWidth * 0.355, screenHeight * 0.405)
        Label37.Font = New Font("Microsoft Sans Serif", 44)
        Label37.Location = New Point(screenWidth * 0.42, screenHeight * 0.405)
        Label38.Font = New Font("Microsoft Sans Serif", 44)
        Label38.Location = New Point(screenWidth * 0.485, screenHeight * 0.405)
        Label39.Font = New Font("Microsoft Sans Serif", 44)
        Label39.Location = New Point(screenWidth * 0.55, screenHeight * 0.405)
        Label40.Font = New Font("Microsoft Sans Serif", 44)
        Label40.Location = New Point(screenWidth * 0.615, screenHeight * 0.405)
        Label41.Font = New Font("Microsoft Sans Serif", 44)
        Label41.Location = New Point(screenWidth * 0.03, screenHeight * 0.49)
        Label42.Font = New Font("Microsoft Sans Serif", 44)
        Label42.Location = New Point(screenWidth * 0.095, screenHeight * 0.49)
        Label43.Font = New Font("Microsoft Sans Serif", 44)
        Label43.Location = New Point(screenWidth * 0.16, screenHeight * 0.49)
        Label44.Font = New Font("Microsoft Sans Serif", 44)
        Label44.Location = New Point(screenWidth * 0.225, screenHeight * 0.49)
        Label45.Font = New Font("Microsoft Sans Serif", 44)
        Label45.Location = New Point(screenWidth * 0.29, screenHeight * 0.49)
        Label46.Font = New Font("Microsoft Sans Serif", 44)
        Label46.Location = New Point(screenWidth * 0.355, screenHeight * 0.49)
        Label47.Font = New Font("Microsoft Sans Serif", 44)
        Label47.Location = New Point(screenWidth * 0.42, screenHeight * 0.49)
        Label48.Font = New Font("Microsoft Sans Serif", 44)
        Label48.Location = New Point(screenWidth * 0.485, screenHeight * 0.49)
        Label49.Font = New Font("Microsoft Sans Serif", 44)
        Label49.Location = New Point(screenWidth * 0.55, screenHeight * 0.49)
        Label50.Font = New Font("Microsoft Sans Serif", 44)
        Label50.Location = New Point(screenWidth * 0.615, screenHeight * 0.49)
        Label51.Font = New Font("Microsoft Sans Serif", 44)
        Label51.Location = New Point(screenWidth * 0.03, screenHeight * 0.575)
        Label52.Font = New Font("Microsoft Sans Serif", 44)
        Label52.Location = New Point(screenWidth * 0.095, screenHeight * 0.575)
        Label53.Font = New Font("Microsoft Sans Serif", 44)
        Label53.Location = New Point(screenWidth * 0.16, screenHeight * 0.575)
        Label54.Font = New Font("Microsoft Sans Serif", 44)
        Label54.Location = New Point(screenWidth * 0.225, screenHeight * 0.575)
        Label55.Font = New Font("Microsoft Sans Serif", 44)
        Label55.Location = New Point(screenWidth * 0.29, screenHeight * 0.575)
        Label56.Font = New Font("Microsoft Sans Serif", 44)
        Label56.Location = New Point(screenWidth * 0.355, screenHeight * 0.575)
        Label57.Font = New Font("Microsoft Sans Serif", 44)
        Label57.Location = New Point(screenWidth * 0.42, screenHeight * 0.575)
        Label58.Font = New Font("Microsoft Sans Serif", 44)
        Label58.Location = New Point(screenWidth * 0.485, screenHeight * 0.575)
        Label59.Font = New Font("Microsoft Sans Serif", 44)
        Label59.Location = New Point(screenWidth * 0.55, screenHeight * 0.575)
        Label60.Font = New Font("Microsoft Sans Serif", 44)
        Label60.Location = New Point(screenWidth * 0.615, screenHeight * 0.575)
        Label61.Font = New Font("Microsoft Sans Serif", 44)
        Label61.Location = New Point(screenWidth * 0.03, screenHeight * 0.66)
        Label62.Font = New Font("Microsoft Sans Serif", 44)
        Label62.Location = New Point(screenWidth * 0.095, screenHeight * 0.66)
        Label63.Font = New Font("Microsoft Sans Serif", 44)
        Label63.Location = New Point(screenWidth * 0.16, screenHeight * 0.66)
        Label64.Font = New Font("Microsoft Sans Serif", 44)
        Label64.Location = New Point(screenWidth * 0.225, screenHeight * 0.66)
        Label65.Font = New Font("Microsoft Sans Serif", 44)
        Label65.Location = New Point(screenWidth * 0.29, screenHeight * 0.66)
        Label66.Font = New Font("Microsoft Sans Serif", 44)
        Label66.Location = New Point(screenWidth * 0.355, screenHeight * 0.66)
        Label67.Font = New Font("Microsoft Sans Serif", 44)
        Label67.Location = New Point(screenWidth * 0.42, screenHeight * 0.66)
        Label68.Font = New Font("Microsoft Sans Serif", 44)
        Label68.Location = New Point(screenWidth * 0.485, screenHeight * 0.66)
        Label69.Font = New Font("Microsoft Sans Serif", 44)
        Label69.Location = New Point(screenWidth * 0.55, screenHeight * 0.66)
        Label70.Font = New Font("Microsoft Sans Serif", 44)
        Label70.Location = New Point(screenWidth * 0.615, screenHeight * 0.66)
        Label71.Font = New Font("Microsoft Sans Serif", 44)
        Label71.Location = New Point(screenWidth * 0.03, screenHeight * 0.745)
        Label72.Font = New Font("Microsoft Sans Serif", 44)
        Label72.Location = New Point(screenWidth * 0.095, screenHeight * 0.745)
        Label73.Font = New Font("Microsoft Sans Serif", 44)
        Label73.Location = New Point(screenWidth * 0.16, screenHeight * 0.745)
        Label74.Font = New Font("Microsoft Sans Serif", 44)
        Label74.Location = New Point(screenWidth * 0.225, screenHeight * 0.745)
        Label75.Font = New Font("Microsoft Sans Serif", 44)
        Label75.Location = New Point(screenWidth * 0.29, screenHeight * 0.745)
        Label76.Font = New Font("Microsoft Sans Serif", 44)
        Label76.Location = New Point(screenWidth * 0.355, screenHeight * 0.745)
        Label77.Font = New Font("Microsoft Sans Serif", 44)
        Label77.Location = New Point(screenWidth * 0.42, screenHeight * 0.745)
        Label78.Font = New Font("Microsoft Sans Serif", 44)
        Label78.Location = New Point(screenWidth * 0.485, screenHeight * 0.745)
        Label79.Font = New Font("Microsoft Sans Serif", 44)
        Label79.Location = New Point(screenWidth * 0.55, screenHeight * 0.745)
        Label80.Font = New Font("Microsoft Sans Serif", 44)
        Label80.Location = New Point(screenWidth * 0.615, screenHeight * 0.745)
        Label81.Font = New Font("Microsoft Sans Serif", 44)
        Label81.Location = New Point(screenWidth * 0.03, screenHeight * 0.83)
        Label82.Font = New Font("Microsoft Sans Serif", 44)
        Label82.Location = New Point(screenWidth * 0.095, screenHeight * 0.83)
        Label83.Font = New Font("Microsoft Sans Serif", 44)
        Label83.Location = New Point(screenWidth * 0.16, screenHeight * 0.83)
        Label84.Font = New Font("Microsoft Sans Serif", 44)
        Label84.Location = New Point(screenWidth * 0.225, screenHeight * 0.83)
        Label85.Font = New Font("Microsoft Sans Serif", 44)
        Label85.Location = New Point(screenWidth * 0.29, screenHeight * 0.83)
        Label86.Font = New Font("Microsoft Sans Serif", 44)
        Label86.Location = New Point(screenWidth * 0.355, screenHeight * 0.83)
        Label87.Font = New Font("Microsoft Sans Serif", 44)
        Label87.Location = New Point(screenWidth * 0.42, screenHeight * 0.83)
        Label88.Font = New Font("Microsoft Sans Serif", 44)
        Label88.Location = New Point(screenWidth * 0.485, screenHeight * 0.83)
        Label89.Font = New Font("Microsoft Sans Serif", 44)
        Label89.Location = New Point(screenWidth * 0.55, screenHeight * 0.83)
        Label90.Font = New Font("Microsoft Sans Serif", 44)
        Label90.Location = New Point(screenWidth * 0.615, screenHeight * 0.83)
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_Ayuda.Text = "Al hacer click en los números de abajo se los marcara, si pasa el mouse por encima de uno de los botones inferiores se le explicará su funcionamiento" + vbCrLf + "y si hace click sobre este texto la ayuda desaparecera."
        Me.Size = New Size(screenWidth, screenHeight)
        Pic_Border.Size = New Size(screenWidth, screenHeight * 0.12)
        Pic_Border.Location = New Point(0, 0)
        Pic_Border_2.Size = New Size(screenHeight * 0.12, screenWidth)
        Pic_Border_2.Location = New Point(screenWidth - screenHeight * 0.12, 0)
        Btn_Cerrar.Size = New Size(screenHeight * 0.1, screenHeight * 0.1)
        Btn_Cerrar.Location = New Point(screenWidth - (screenWidth * 0.063), screenHeight * 0.01)
        Btn_Minimizar.Size = New Size(screenHeight * 0.1, screenHeight * 0.1)
        Btn_Minimizar.Location = New Point(screenWidth - (screenWidth * 0.126), screenHeight * 0.01)
        Btn_Reinicio.Size = New Size(screenHeight * 0.1, screenHeight * 0.1)
        Btn_Reinicio.Location = New Point(screenWidth - (screenWidth * 0.063), screenHeight * 0.89)
        Btn_LimpiezaManual.Size = New Size(screenHeight * 0.1, screenHeight * 0.1)
        Btn_LimpiezaManual.Location = New Point(screenWidth - (screenWidth * 0.063), screenHeight * 0.78)
        Btn_Randomize.Size = New Size(screenHeight * 0.1, screenHeight * 0.1)
        Btn_Randomize.Location = New Point(screenWidth - (screenWidth * 0.063), screenHeight * 0.67)
        OrdenarPantalla()
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

    Private Sub Btn_Randomize_Click(sender As Object, e As EventArgs) Handles Btn_Randomize.Click
        CambioColor = False
        Randomize()
        i = 0
        Temporal = CInt(Int((90 * Rnd()) + 1))
        Do
            Repite = False
            If números(i) = 0 Then
                index = index + 1
                números(i) = Temporal
                Btn_Randomize.Text = Temporal
                Repite = True
            Else
                If Temporal = números(i) Then
                    Temporal = CInt(Int((90 * Rnd()) + 1))
                    i = 0
                End If
            End If
            i = i + 1
        Loop Until Repite = True
    End Sub

    Private Sub Btn_Reinicio_Click(sender As Object, e As EventArgs) Handles Btn_Reinicio.Click
        Application.Restart()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim LabelNumero As Byte
        LabelNumero = 1
        If CambioColor = False Then
            Label1.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label1.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim LabelNumero As Byte
        LabelNumero = 2
        If CambioColor = False Then
            Label2.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label2.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim LabelNumero As Byte
        LabelNumero = 3
        If CambioColor = False Then
            Label3.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label3.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim LabelNumero As Byte
        LabelNumero = 4
        If CambioColor = False Then
            Label4.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label4.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim LabelNumero As Byte
        LabelNumero = 5
        If CambioColor = False Then
            Label5.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label5.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim LabelNumero As Byte
        LabelNumero = 6
        If CambioColor = False Then
            Label6.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label6.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim LabelNumero As Byte
        LabelNumero = 7
        If CambioColor = False Then
            Label7.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label7.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim LabelNumero As Byte
        LabelNumero = 8
        If CambioColor = False Then
            Label8.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label8.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim LabelNumero As Byte
        LabelNumero = 9
        If CambioColor = False Then
            Label9.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label9.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim LabelNumero As Byte
        LabelNumero = 10
        If CambioColor = False Then
            Label10.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label10.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim LabelNumero As Byte
        LabelNumero = 11
        If CambioColor = False Then
            Label11.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label11.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim LabelNumero As Byte
        LabelNumero = 12
        If CambioColor = False Then
            Label12.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label12.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim LabelNumero As Byte
        LabelNumero = 13
        If CambioColor = False Then
            Label13.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label13.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Dim LabelNumero As Byte
        LabelNumero = 14
        If CambioColor = False Then
            Label14.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label14.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Dim LabelNumero As Byte
        LabelNumero = 15
        If CambioColor = False Then
            Label15.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label15.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Dim LabelNumero As Byte
        LabelNumero = 16
        If CambioColor = False Then
            Label16.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label16.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Dim LabelNumero As Byte
        LabelNumero = 17
        If CambioColor = False Then
            Label17.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label17.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Dim LabelNumero As Byte
        LabelNumero = 18
        If CambioColor = False Then
            Label18.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label18.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        Dim LabelNumero As Byte
        LabelNumero = 19
        If CambioColor = False Then
            Label19.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label19.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        Dim LabelNumero As Byte
        LabelNumero = 20
        If CambioColor = False Then
            Label20.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label20.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        Dim LabelNumero As Byte
        LabelNumero = 21
        If CambioColor = False Then
            Label21.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label21.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        Dim LabelNumero As Byte
        LabelNumero = 22
        If CambioColor = False Then
            Label22.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label22.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        Dim LabelNumero As Byte
        LabelNumero = 23
        If CambioColor = False Then
            Label23.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label23.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        Dim LabelNumero As Byte
        LabelNumero = 24
        If CambioColor = False Then
            Label24.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label24.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click
        Dim LabelNumero As Byte
        LabelNumero = 25
        If CambioColor = False Then
            Label25.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label25.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        Dim LabelNumero As Byte
        LabelNumero = 26
        If CambioColor = False Then
            Label26.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label26.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        Dim LabelNumero As Byte
        LabelNumero = 27
        If CambioColor = False Then
            Label27.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label27.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click
        Dim LabelNumero As Byte
        LabelNumero = 28
        If CambioColor = False Then
            Label28.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label28.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click
        Dim LabelNumero As Byte
        LabelNumero = 29
        If CambioColor = False Then
            Label29.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label29.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click
        Dim LabelNumero As Byte
        LabelNumero = 30
        If CambioColor = False Then
            Label30.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label30.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click
        Dim LabelNumero As Byte
        LabelNumero = 31
        If CambioColor = False Then
            Label31.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label31.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click
        Dim LabelNumero As Byte
        LabelNumero = 32
        If CambioColor = False Then
            Label32.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label32.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click
        Dim LabelNumero As Byte
        LabelNumero = 33
        If CambioColor = False Then
            Label33.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label33.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click
        Dim LabelNumero As Byte
        LabelNumero = 34
        If CambioColor = False Then
            Label34.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label34.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click
        Dim LabelNumero As Byte
        LabelNumero = 35
        If CambioColor = False Then
            Label35.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label35.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click
        Dim LabelNumero As Byte
        LabelNumero = 36
        If CambioColor = False Then
            Label36.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label36.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click
        Dim LabelNumero As Byte
        LabelNumero = 37
        If CambioColor = False Then
            Label37.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label37.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click
        Dim LabelNumero As Byte
        LabelNumero = 38
        If CambioColor = False Then
            Label38.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label38.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click
        Dim LabelNumero As Byte
        LabelNumero = 39
        If CambioColor = False Then
            Label39.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label39.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label40_Click(sender As Object, e As EventArgs) Handles Label40.Click
        Dim LabelNumero As Byte
        LabelNumero = 40
        If CambioColor = False Then
            Label40.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label40.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs) Handles Label41.Click
        Dim LabelNumero As Byte
        LabelNumero = 41
        If CambioColor = False Then
            Label41.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label41.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label42_Click(sender As Object, e As EventArgs) Handles Label42.Click
        Dim LabelNumero As Byte
        LabelNumero = 42
        If CambioColor = False Then
            Label42.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label42.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label43_Click(sender As Object, e As EventArgs) Handles Label43.Click
        Dim LabelNumero As Byte
        LabelNumero = 43
        If CambioColor = False Then
            Label43.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label43.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click
        Dim LabelNumero As Byte
        LabelNumero = 44
        If CambioColor = False Then
            Label44.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label44.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label45_Click(sender As Object, e As EventArgs) Handles Label45.Click
        Dim LabelNumero As Byte
        LabelNumero = 45
        If CambioColor = False Then
            Label45.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label45.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click
        Dim LabelNumero As Byte
        LabelNumero = 46
        If CambioColor = False Then
            Label46.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label46.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label47_Click(sender As Object, e As EventArgs) Handles Label47.Click
        Dim LabelNumero As Byte
        LabelNumero = 47
        If CambioColor = False Then
            Label47.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label47.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label48_Click(sender As Object, e As EventArgs) Handles Label48.Click
        Dim LabelNumero As Byte
        LabelNumero = 48
        If CambioColor = False Then
            Label48.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label48.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label49_Click(sender As Object, e As EventArgs) Handles Label49.Click
        Dim LabelNumero As Byte
        LabelNumero = 49
        If CambioColor = False Then
            Label49.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label49.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label50_Click(sender As Object, e As EventArgs) Handles Label50.Click
        Dim LabelNumero As Byte
        LabelNumero = 50
        If CambioColor = False Then
            Label50.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label50.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs) Handles Label51.Click
        Dim LabelNumero As Byte
        LabelNumero = 51
        If CambioColor = False Then
            Label51.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label51.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label52_Click(sender As Object, e As EventArgs) Handles Label52.Click
        Dim LabelNumero As Byte
        LabelNumero = 52
        If CambioColor = False Then
            Label52.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label52.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label53_Click(sender As Object, e As EventArgs) Handles Label53.Click
        Dim LabelNumero As Byte
        LabelNumero = 53
        If CambioColor = False Then
            Label53.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label53.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label54_Click(sender As Object, e As EventArgs) Handles Label54.Click
        Dim LabelNumero As Byte
        LabelNumero = 54
        If CambioColor = False Then
            Label54.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label54.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label55_Click(sender As Object, e As EventArgs) Handles Label55.Click
        Dim LabelNumero As Byte
        LabelNumero = 55
        If CambioColor = False Then
            Label55.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label55.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label56_Click(sender As Object, e As EventArgs) Handles Label56.Click
        Dim LabelNumero As Byte
        LabelNumero = 56
        If CambioColor = False Then
            Label56.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label56.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label57_Click(sender As Object, e As EventArgs) Handles Label57.Click
        Dim LabelNumero As Byte
        LabelNumero = 57
        If CambioColor = False Then
            Label57.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label57.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label58_Click(sender As Object, e As EventArgs) Handles Label58.Click
        Dim LabelNumero As Byte
        LabelNumero = 58
        If CambioColor = False Then
            Label58.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label58.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label59_Click(sender As Object, e As EventArgs) Handles Label59.Click
        Dim LabelNumero As Byte
        LabelNumero = 59
        If CambioColor = False Then
            Label59.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label59.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label60_Click(sender As Object, e As EventArgs) Handles Label60.Click
        Dim LabelNumero As Byte
        LabelNumero = 60
        If CambioColor = False Then
            Label60.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label60.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label61_Click(sender As Object, e As EventArgs) Handles Label61.Click
        Dim LabelNumero As Byte
        LabelNumero = 61
        If CambioColor = False Then
            Label61.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label61.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label62_Click(sender As Object, e As EventArgs) Handles Label62.Click
        Dim LabelNumero As Byte
        LabelNumero = 62
        If CambioColor = False Then
            Label62.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label62.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label63_Click(sender As Object, e As EventArgs) Handles Label63.Click
        Dim LabelNumero As Byte
        LabelNumero = 63
        If CambioColor = False Then
            Label63.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label63.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label64_Click(sender As Object, e As EventArgs) Handles Label64.Click
        Dim LabelNumero As Byte
        LabelNumero = 64
        If CambioColor = False Then
            Label64.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label64.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label65_Click(sender As Object, e As EventArgs) Handles Label65.Click
        Dim LabelNumero As Byte
        LabelNumero = 65
        If CambioColor = False Then
            Label65.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label65.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label66_Click(sender As Object, e As EventArgs) Handles Label66.Click
        Dim LabelNumero As Byte
        LabelNumero = 66
        If CambioColor = False Then
            Label66.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label66.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label67_Click(sender As Object, e As EventArgs) Handles Label67.Click
        Dim LabelNumero As Byte
        LabelNumero = 67
        If CambioColor = False Then
            Label67.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label67.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label68_Click(sender As Object, e As EventArgs) Handles Label68.Click
        Dim LabelNumero As Byte
        LabelNumero = 68
        If CambioColor = False Then
            Label68.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label68.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label69_Click(sender As Object, e As EventArgs) Handles Label69.Click
        Dim LabelNumero As Byte
        LabelNumero = 69
        If CambioColor = False Then
            Label69.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label69.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label70_Click(sender As Object, e As EventArgs) Handles Label70.Click
        Dim LabelNumero As Byte
        LabelNumero = 70
        If CambioColor = False Then
            Label70.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label70.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label71_Click(sender As Object, e As EventArgs) Handles Label71.Click
        Dim LabelNumero As Byte
        LabelNumero = 71
        If CambioColor = False Then
            Label71.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label71.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label72_Click(sender As Object, e As EventArgs) Handles Label72.Click
        Dim LabelNumero As Byte
        LabelNumero = 72
        If CambioColor = False Then
            Label72.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label72.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label73_Click(sender As Object, e As EventArgs) Handles Label73.Click
        Dim LabelNumero As Byte
        LabelNumero = 73
        If CambioColor = False Then
            Label73.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label73.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label74_Click(sender As Object, e As EventArgs) Handles Label74.Click
        Dim LabelNumero As Byte
        LabelNumero = 74
        If CambioColor = False Then
            Label74.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label74.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label75_Click(sender As Object, e As EventArgs) Handles Label75.Click
        Dim LabelNumero As Byte
        LabelNumero = 75
        If CambioColor = False Then
            Label75.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label75.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label76_Click(sender As Object, e As EventArgs) Handles Label76.Click
        Dim LabelNumero As Byte
        LabelNumero = 76
        If CambioColor = False Then
            Label76.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label76.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label77_Click(sender As Object, e As EventArgs) Handles Label77.Click
        Dim LabelNumero As Byte
        LabelNumero = 77
        If CambioColor = False Then
            Label77.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label77.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label78_Click(sender As Object, e As EventArgs) Handles Label78.Click
        Dim LabelNumero As Byte
        LabelNumero = 78
        If CambioColor = False Then
            Label78.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label78.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label79_Click(sender As Object, e As EventArgs) Handles Label79.Click
        Dim LabelNumero As Byte
        LabelNumero = 79
        If CambioColor = False Then
            Label79.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label79.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label80_Click(sender As Object, e As EventArgs) Handles Label80.Click
        Dim LabelNumero As Byte
        LabelNumero = 80
        If CambioColor = False Then
            Label80.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label80.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label81_Click(sender As Object, e As EventArgs) Handles Label81.Click
        Dim LabelNumero As Byte
        LabelNumero = 81
        If CambioColor = False Then
            Label81.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label81.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label82_Click(sender As Object, e As EventArgs) Handles Label82.Click
        Dim LabelNumero As Byte
        LabelNumero = 82
        If CambioColor = False Then
            Label82.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label82.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label83_Click(sender As Object, e As EventArgs) Handles Label83.Click
        Dim LabelNumero As Byte
        LabelNumero = 83
        If CambioColor = False Then
            Label83.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label83.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label84_Click(sender As Object, e As EventArgs) Handles Label84.Click
        Dim LabelNumero As Byte
        LabelNumero = 84
        If CambioColor = False Then
            Label84.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label84.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label85_Click(sender As Object, e As EventArgs) Handles Label85.Click
        Dim LabelNumero As Byte
        LabelNumero = 85
        If CambioColor = False Then
            Label85.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label85.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label86_Click(sender As Object, e As EventArgs) Handles Label86.Click
        Dim LabelNumero As Byte
        LabelNumero = 86
        If CambioColor = False Then
            Label86.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label86.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label87_Click(sender As Object, e As EventArgs) Handles Label87.Click
        Dim LabelNumero As Byte
        LabelNumero = 87
        If CambioColor = False Then
            Label87.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label87.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label88_Click(sender As Object, e As EventArgs) Handles Label88.Click
        Dim LabelNumero As Byte
        LabelNumero = 88
        If CambioColor = False Then
            Label88.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label88.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label89_Click(sender As Object, e As EventArgs) Handles Label89.Click
        Dim LabelNumero As Byte
        LabelNumero = 89
        If CambioColor = False Then
            Label89.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label89.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Label90_Click(sender As Object, e As EventArgs) Handles Label90.Click
        Dim LabelNumero As Byte
        LabelNumero = 90
        If CambioColor = False Then
            Label90.BackColor = Color.LightCoral
            números(index) = LabelNumero
        Else
            Label90.BackColor = Color.IndianRed
            Limpieza(LabelNumero)
        End If
    End Sub

    Private Sub Btn_Randomize_MouseHover(sender As Object, e As EventArgs) Handles Btn_Randomize.MouseHover
        Lbl_Ayuda.Text = "Este boton elegira un numero al azár"
    End Sub

    Private Sub Btn_Randomize_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Randomize.MouseLeave
        Lbl_Ayuda.Text = "Al hacer click en los números de abajo se los marcara, si pasa el mouse por encima de uno de los botones inferiores se le explicará su funcionamiento" + vbCrLf + "y si hace click sobre este texto la ayuda desaparecerá."

    End Sub

    Private Sub Btn_LimpiezaManual_MouseHover(sender As Object, e As EventArgs) Handles Btn_LimpiezaManual.MouseHover
        Lbl_Ayuda.Text = "Al hacer click el usuario podra cambiar el color de los numeros manualmente y al hacer doble click el programa funcionara como antes."
    End Sub

    Private Sub Btn_LimpiezaManual_MouseLeave(sender As Object, e As EventArgs) Handles Btn_LimpiezaManual.MouseLeave
        Lbl_Ayuda.Text = "Al hacer click en los números de abajo se los marcara, si pasa el mouse por encima de uno de los botones inferiores se le explicará su funcionamiento" + vbCrLf + "y si hace click sobre este texto la ayuda desaparecera."

    End Sub

    Private Sub Btn_Reinicio_MouseHover(sender As Object, e As EventArgs) Handles Btn_Reinicio.MouseHover
        Lbl_Ayuda.Text = "Al tocar este botón se reiniciara el programa."
    End Sub

    Private Sub Btn_Reinicio_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Reinicio.MouseLeave
        Lbl_Ayuda.Text = "Al hacer click en los números de abajo se los marcara, si pasa el mouse por encima de uno de los botones inferiores se le explicará su funcionamiento" + vbCrLf + "y si hace click sobre este texto la ayuda desaparecera."

    End Sub

    Private Sub Lbl_Ayuda_Click(sender As Object, e As EventArgs) Handles Lbl_Ayuda.Click
        Lbl_Ayuda.Visible = False
    End Sub

    Private Sub Pic_Border_Click(sender As Object, e As EventArgs) Handles Pic_Border.Click
        Lbl_Ayuda.Visible = True
    End Sub
End Class
