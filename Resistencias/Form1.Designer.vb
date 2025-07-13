<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        b1 = New PictureBox()
        b3 = New PictureBox()
        b2 = New PictureBox()
        b4 = New PictureBox()
        banda1 = New ListBox()
        banda2 = New ListBox()
        banda3 = New ListBox()
        banda4 = New ListBox()
        bandaM = New ListBox()
        bandaT = New ListBox()
        bM = New PictureBox()
        bT = New PictureBox()
        numBandas = New ComboBox()
        resultado = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        CType(b1, ComponentModel.ISupportInitialize).BeginInit()
        CType(b3, ComponentModel.ISupportInitialize).BeginInit()
        CType(b2, ComponentModel.ISupportInitialize).BeginInit()
        CType(b4, ComponentModel.ISupportInitialize).BeginInit()
        CType(bM, ComponentModel.ISupportInitialize).BeginInit()
        CType(bT, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' b1
        ' 
        b1.Location = New Point(482, 124)
        b1.Name = "b1"
        b1.Size = New Size(18, 72)
        b1.TabIndex = 4
        b1.TabStop = False
        ' 
        ' b3
        ' 
        b3.Location = New Point(551, 124)
        b3.Name = "b3"
        b3.Size = New Size(18, 72)
        b3.TabIndex = 5
        b3.TabStop = False
        ' 
        ' b2
        ' 
        b2.Location = New Point(515, 124)
        b2.Name = "b2"
        b2.Size = New Size(18, 72)
        b2.TabIndex = 6
        b2.TabStop = False
        ' 
        ' b4
        ' 
        b4.Location = New Point(587, 124)
        b4.Name = "b4"
        b4.Size = New Size(18, 72)
        b4.TabIndex = 7
        b4.TabStop = False
        ' 
        ' banda1
        ' 
        banda1.FormattingEnabled = True
        banda1.Location = New Point(194, 74)
        banda1.Name = "banda1"
        banda1.Size = New Size(150, 24)
        banda1.TabIndex = 8
        ' 
        ' banda2
        ' 
        banda2.FormattingEnabled = True
        banda2.Location = New Point(194, 104)
        banda2.Name = "banda2"
        banda2.Size = New Size(150, 24)
        banda2.TabIndex = 9
        ' 
        ' banda3
        ' 
        banda3.FormattingEnabled = True
        banda3.Location = New Point(194, 134)
        banda3.Name = "banda3"
        banda3.Size = New Size(150, 24)
        banda3.TabIndex = 10
        ' 
        ' banda4
        ' 
        banda4.FormattingEnabled = True
        banda4.Location = New Point(194, 164)
        banda4.Name = "banda4"
        banda4.Size = New Size(150, 24)
        banda4.TabIndex = 11
        ' 
        ' bandaM
        ' 
        bandaM.FormattingEnabled = True
        bandaM.Location = New Point(194, 195)
        bandaM.Name = "bandaM"
        bandaM.Size = New Size(150, 24)
        bandaM.TabIndex = 12
        ' 
        ' bandaT
        ' 
        bandaT.FormattingEnabled = True
        bandaT.Location = New Point(194, 225)
        bandaT.Name = "bandaT"
        bandaT.Size = New Size(150, 24)
        bandaT.TabIndex = 13
        ' 
        ' bM
        ' 
        bM.Location = New Point(622, 124)
        bM.Name = "bM"
        bM.Size = New Size(18, 72)
        bM.TabIndex = 14
        bM.TabStop = False
        ' 
        ' bT
        ' 
        bT.Location = New Point(658, 124)
        bT.Name = "bT"
        bT.Size = New Size(18, 72)
        bT.TabIndex = 15
        bT.TabStop = False
        ' 
        ' numBandas
        ' 
        numBandas.FormattingEnabled = True
        numBandas.Location = New Point(525, 33)
        numBandas.Name = "numBandas"
        numBandas.Size = New Size(151, 28)
        numBandas.TabIndex = 16
        ' 
        ' resultado
        ' 
        resultado.Location = New Point(194, 299)
        resultado.Name = "resultado"
        resultado.Size = New Size(328, 27)
        resultado.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 225)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 20)
        Label1.TabIndex = 19
        Label1.Text = "Banda de Tolerancia"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(62, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 20)
        Label2.TabIndex = 20
        Label2.Text = "Segunda Banda"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(69, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 20)
        Label3.TabIndex = 21
        Label3.Text = "Primera Banda"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(72, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 20)
        Label4.TabIndex = 22
        Label4.Text = "Tercera Banda"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(77, 168)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 20)
        Label5.TabIndex = 23
        Label5.Text = "Cuarta Banda"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(23, 199)
        Label6.Name = "Label6"
        Label6.Size = New Size(152, 20)
        Label6.TabIndex = 24
        Label6.Text = "Banda Multiplicadora"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.plantillaResistenciare
        PictureBox1.Location = New Point(376, 104)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(400, 115)
        PictureBox1.TabIndex = 25
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(23, 302)
        Label7.Name = "Label7"
        Label7.Size = New Size(157, 20)
        Label7.TabIndex = 26
        Label7.Text = "Valor de la Resistencia"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(resultado)
        Controls.Add(numBandas)
        Controls.Add(bT)
        Controls.Add(bM)
        Controls.Add(bandaT)
        Controls.Add(bandaM)
        Controls.Add(banda4)
        Controls.Add(banda3)
        Controls.Add(banda2)
        Controls.Add(banda1)
        Controls.Add(b4)
        Controls.Add(b2)
        Controls.Add(b3)
        Controls.Add(b1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(b1, ComponentModel.ISupportInitialize).EndInit()
        CType(b3, ComponentModel.ISupportInitialize).EndInit()
        CType(b2, ComponentModel.ISupportInitialize).EndInit()
        CType(b4, ComponentModel.ISupportInitialize).EndInit()
        CType(bM, ComponentModel.ISupportInitialize).EndInit()
        CType(bT, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents b1 As PictureBox
    Friend WithEvents b3 As PictureBox
    Friend WithEvents b2 As PictureBox
    Friend WithEvents b4 As PictureBox
    Friend WithEvents banda1 As ListBox
    Friend WithEvents banda2 As ListBox
    Friend WithEvents banda3 As ListBox
    Friend WithEvents banda4 As ListBox
    Friend WithEvents bandaM As ListBox
    Friend WithEvents bandaT As ListBox
    Friend WithEvents bM As PictureBox
    Friend WithEvents bT As PictureBox
    Friend WithEvents numBandas As ComboBox
    Friend WithEvents resultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label

End Class
