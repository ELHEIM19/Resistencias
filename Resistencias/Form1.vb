' Eliminar la línea banda1.Items(i).colors.Add(color.FromName(color)) porque ComboBox no tiene la propiedad itemColors ni colors.
' Si deseas mostrar los colores en los ComboBox, debes personalizar el dibujo de los ítems.

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'calcular resistencia
        'cargar colores a los combobox
        Dim colores As String() = {"negro", "marron", "rojo", "naranja", "amarillo", "verde", "azul", "violeta", "gris", "blanco"}
        Dim tolerancia As String() = {"dorado", "plata", "rojo", "marron", "verde", "sin color"}
        Dim ColoresARGB As Color() = {Color.Black, Color.Brown, Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Purple, Color.Gray, Color.White}

        ' Agregar colores individualmente a cada ComboBox
        For i As Integer = 0 To colores.Length - 1
            banda1.Items.Add(colores(i))
            banda2.Items.Add(colores(i))
            banda3.Items.Add(colores(i))
            banda4.Items.Add(colores(i))
            bandaM.Items.Add(colores(i))
        Next
        For i As Integer = 0 To tolerancia.Length - 1
            bandaT.Items.Add(tolerancia(i))
        Next

        numBandas.Items.Add("4 Bandas")
        numBandas.Items.Add("5 Bandas")
        numBandas.Items.Add("6 Bandas")
        numBandas.SelectedIndex = 0

        'iniciar combobox
        banda1.SelectedIndex = 0
        banda2.SelectedIndex = 1
        banda3.SelectedIndex = 2
        banda4.SelectedIndex = 0
        bandaM.SelectedIndex = 0
        bandaT.SelectedIndex = 0
    End Sub

    Private Sub cambiarColorBanda(item As String, banda As PictureBox, Optional bandaC As ComboBox = Nothing)
        Select Case item.ToLower()
            Case "negro"
                banda.BackColor = Color.Black
            Case "marron"
                banda.BackColor = Color.Brown
            Case "rojo"
                banda.BackColor = Color.Red
            Case "naranja"
                banda.BackColor = Color.Orange
            Case "amarillo"
                banda.BackColor = Color.Yellow
            Case "verde"
                banda.BackColor = Color.Green
            Case "azul"
                banda.BackColor = Color.Blue
            Case "violeta"
                banda.BackColor = Color.Purple
            Case "gris"
                banda.BackColor = Color.Gray
            Case "blanco"
                banda.BackColor = Color.White
            Case "dorado"
                banda.BackColor = Color.Gold
            Case "plata"
                banda.BackColor = Color.Silver
            Case Else
                banda.BackColor = SystemColors.Window
        End Select
    End Sub

    Private Sub calcularResistencia()
        Dim numerobandas As String = numBandas.SelectedItem

        Select Case numerobandas
            Case "4 Bandas"
                Dim banda1 As Integer = Integer.Parse(Me.banda1.SelectedIndex.ToString())
                Dim banda2 As Integer = Integer.Parse(Me.banda2.SelectedIndex.ToString())
                Dim banda3 As Integer = Integer.Parse(Me.bandaM.SelectedIndex.ToString())
                Dim banda4 As Integer = Integer.Parse(Me.bandaT.SelectedIndex.ToString())
                ' La tolerancia no se usa en el cálculo del valor, solo para mostrar el porcentaje
                Dim resistencia As Double = (banda1 * 10 + banda2) * Math.Pow(10, banda3)
                resultado.Text = resistencia.ToString("F2") & " Ohmios"
            Case "5 Bandas"
                Dim banda1 As Integer = Integer.Parse(Me.banda1.SelectedIndex.ToString())
                Dim banda2 As Integer = Integer.Parse(Me.banda2.SelectedIndex.ToString())
                Dim banda3 As Integer = Integer.Parse(Me.banda3.SelectedIndex.ToString())
                Dim banda4 As Integer = Integer.Parse(Me.bandaM.SelectedIndex.ToString())
                Dim banda5 As Integer = Integer.Parse(Me.bandaT.SelectedIndex.ToString())
                ' La tolerancia no se usa en el cálculo del valor, solo para mostrar el porcentaje
                Dim resistencia As Double = (banda1 * 100 + banda2 * 10 + banda3) * Math.Pow(10, banda4)
                resultado.Text = resistencia.ToString("F2") & " Ohmios"

            Case "6 Bandas"
                Dim banda1 As Integer = Integer.Parse(Me.banda1.SelectedIndex.ToString())
                Dim banda2 As Integer = Integer.Parse(Me.banda2.SelectedIndex.ToString())
                Dim banda3 As Integer = Integer.Parse(Me.banda3.SelectedIndex.ToString())
                Dim banda4 As Integer = Integer.Parse(Me.banda4.SelectedIndex.ToString())
                Dim banda5 As Integer = Integer.Parse(Me.bandaM.SelectedIndex.ToString())
                Dim banda6 As Integer = Integer.Parse(Me.bandaT.SelectedIndex.ToString())
                ' La tolerancia no se usa en el cálculo del valor, solo para mostrar el porcentaje
                Dim resistencia As Double = (banda1 * 1000 + banda2 * 100 + banda3 * 10 + banda4) * Math.Pow(10, banda5)
                resultado.Text = resistencia.ToString("F2") & " Ohmios"
        End Select
    End Sub

    Private Sub cambiarColorTolerancia(ByRef banda As PictureBox, item As String)
        Select Case item.ToLower()
            Case "dorado"
                banda.BackColor = Color.Gold
            Case "plata"
                banda.BackColor = Color.Silver
            Case "rojo"
                banda.BackColor = Color.Red
            Case "marron"
                banda.BackColor = Color.Brown
            Case "verde"
                banda.BackColor = Color.Green
            Case "sin color"
                banda.BackColor = SystemColors.Window
        End Select
    End Sub

    Private Sub banda1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles banda1.SelectedIndexChanged
        cambiarColorBanda(banda1.SelectedItem.ToString(), b1)
        calcularResistencia()
        CalcularTolerancia()


    End Sub
    Private Sub banda2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles banda2.SelectedIndexChanged
        cambiarColorBanda(banda2.SelectedItem.ToString(), b2)
        calcularResistencia()
        CalcularTolerancia()
    End Sub
    Private Sub banda3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles banda3.SelectedIndexChanged
        cambiarColorBanda(banda3.SelectedItem.ToString(), b3)
        calcularResistencia()
        CalcularTolerancia()
    End Sub
    Private Sub banda4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles banda4.SelectedIndexChanged
        cambiarColorBanda(banda4.SelectedItem.ToString(), b4)
        calcularResistencia()
        CalcularTolerancia()
    End Sub
    Private Sub bandaM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bandaM.SelectedIndexChanged
        cambiarColorBanda(bandaM.SelectedItem.ToString(), bM)
        calcularResistencia()
        CalcularTolerancia()
    End Sub
    Private Sub bandaT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bandaT.SelectedIndexChanged
        cambiarColorTolerancia(bT, bandaT.SelectedItem.ToString())
        calcularResistencia()
        CalcularTolerancia()
    End Sub

    Private Sub numBandas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles numBandas.SelectedIndexChanged
        Dim numerobandas As String = numBandas.SelectedItem
        Select Case numerobandas
            Case "4 Bandas"

                banda3.Visible = False
                b3.Visible = False
                banda4.Visible = False
                b4.Visible = False
                Label4.Visible = False
                Label5.Visible = False


            Case "5 Bandas"
                banda3.Visible = True
                b3.Visible = True
                banda4.Visible = False
                b4.Visible = False
                Label4.Visible = True
                Label5.Visible = False


            Case "6 Bandas"
                b2.Visible = True
                banda3.Visible = True
                b3.Visible = True
                banda4.Visible = True
                b4.Visible = True
                Label4.Visible = True
                Label5.Visible = True


        End Select
    End Sub

    Private Sub CalcularTolerancia()
        Dim tolerancia As String = bandaT.SelectedItem
        Dim valor As Double = 0.0
        Select Case tolerancia
            Case "dorado"
                valor = 5.0
            Case "plata"
                valor = 10.0
            Case "rojo"
                valor = 2.0
            Case "marron"
                valor = 1.0
            Case "verde"
                valor = 0.5
            Case "sin color"
                valor = 20.0
        End Select
        resultado.Text &= " ± " & valor.ToString() & "%"
    End Sub
End Class
