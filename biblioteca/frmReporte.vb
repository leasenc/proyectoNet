Imports System.Data.SqlClient
Public Class frmReporte
    Inherits System.Windows.Forms.Form
    Dim SQLAdapter_Master As SqlDataAdapter
    Dim DataSet_Master As New dsBiblioteca1()

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnSelImpresora As System.Windows.Forms.Button
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents rbtnFICHA As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnTEMA As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnUSU As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnDEVOLUCION As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnEMPLEADO As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnLIBRO As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCARNET As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnTU As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnSelImpresora = New System.Windows.Forms.Button()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnFICHA = New System.Windows.Forms.RadioButton()
        Me.rbtnTEMA = New System.Windows.Forms.RadioButton()
        Me.rbtnUSU = New System.Windows.Forms.RadioButton()
        Me.rbtnDEVOLUCION = New System.Windows.Forms.RadioButton()
        Me.rbtnEMPLEADO = New System.Windows.Forms.RadioButton()
        Me.rbtnLIBRO = New System.Windows.Forms.RadioButton()
        Me.rbtnCARNET = New System.Windows.Forms.RadioButton()
        Me.rbtnTU = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Yellow
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Purple
        Me.btnSalir.Location = New System.Drawing.Point(512, 344)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 40)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        '
        'btnSelImpresora
        '
        Me.btnSelImpresora.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSelImpresora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelImpresora.ForeColor = System.Drawing.Color.Thistle
        Me.btnSelImpresora.Location = New System.Drawing.Point(384, 344)
        Me.btnSelImpresora.Name = "btnSelImpresora"
        Me.btnSelImpresora.Size = New System.Drawing.Size(104, 40)
        Me.btnSelImpresora.TabIndex = 12
        Me.btnSelImpresora.Text = "Seleccionar Tipo de Impresora"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnEjecutar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjecutar.ForeColor = System.Drawing.Color.Thistle
        Me.btnEjecutar.Location = New System.Drawing.Point(264, 344)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(96, 40)
        Me.btnEjecutar.TabIndex = 11
        Me.btnEjecutar.Text = "Ejecutar Reporte"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.ForeColor = System.Drawing.Color.Thistle
        Me.btnSeleccionar.Location = New System.Drawing.Point(144, 344)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(96, 40)
        Me.btnSeleccionar.TabIndex = 10
        Me.btnSeleccionar.Text = "Seleccionar Reporte"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbtnFICHA, Me.rbtnTEMA, Me.rbtnUSU, Me.rbtnDEVOLUCION, Me.rbtnEMPLEADO, Me.rbtnLIBRO, Me.rbtnCARNET, Me.rbtnTU})
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 312)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reporte de:"
        '
        'rbtnFICHA
        '
        Me.rbtnFICHA.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnFICHA.ForeColor = System.Drawing.Color.Teal
        Me.rbtnFICHA.Location = New System.Drawing.Point(16, 256)
        Me.rbtnFICHA.Name = "rbtnFICHA"
        Me.rbtnFICHA.Size = New System.Drawing.Size(104, 40)
        Me.rbtnFICHA.TabIndex = 16
        Me.rbtnFICHA.Text = "Ficha de Prestamo"
        '
        'rbtnTEMA
        '
        Me.rbtnTEMA.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnTEMA.ForeColor = System.Drawing.Color.Teal
        Me.rbtnTEMA.Location = New System.Drawing.Point(16, 160)
        Me.rbtnTEMA.Name = "rbtnTEMA"
        Me.rbtnTEMA.TabIndex = 11
        Me.rbtnTEMA.Text = "Tema"
        '
        'rbtnUSU
        '
        Me.rbtnUSU.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnUSU.ForeColor = System.Drawing.Color.Teal
        Me.rbtnUSU.Location = New System.Drawing.Point(16, 56)
        Me.rbtnUSU.Name = "rbtnUSU"
        Me.rbtnUSU.Size = New System.Drawing.Size(104, 32)
        Me.rbtnUSU.TabIndex = 10
        Me.rbtnUSU.Text = "Usuario"
        '
        'rbtnDEVOLUCION
        '
        Me.rbtnDEVOLUCION.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDEVOLUCION.ForeColor = System.Drawing.Color.Teal
        Me.rbtnDEVOLUCION.Location = New System.Drawing.Point(16, 224)
        Me.rbtnDEVOLUCION.Name = "rbtnDEVOLUCION"
        Me.rbtnDEVOLUCION.TabIndex = 9
        Me.rbtnDEVOLUCION.Text = "Devolucion"
        '
        'rbtnEMPLEADO
        '
        Me.rbtnEMPLEADO.Checked = True
        Me.rbtnEMPLEADO.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnEMPLEADO.ForeColor = System.Drawing.Color.Teal
        Me.rbtnEMPLEADO.Location = New System.Drawing.Point(16, 192)
        Me.rbtnEMPLEADO.Name = "rbtnEMPLEADO"
        Me.rbtnEMPLEADO.TabIndex = 7
        Me.rbtnEMPLEADO.TabStop = True
        Me.rbtnEMPLEADO.Text = "Empleado"
        '
        'rbtnLIBRO
        '
        Me.rbtnLIBRO.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnLIBRO.ForeColor = System.Drawing.Color.Teal
        Me.rbtnLIBRO.Location = New System.Drawing.Point(16, 128)
        Me.rbtnLIBRO.Name = "rbtnLIBRO"
        Me.rbtnLIBRO.TabIndex = 4
        Me.rbtnLIBRO.Text = "Libro"
        '
        'rbtnCARNET
        '
        Me.rbtnCARNET.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCARNET.ForeColor = System.Drawing.Color.Teal
        Me.rbtnCARNET.Location = New System.Drawing.Point(16, 96)
        Me.rbtnCARNET.Name = "rbtnCARNET"
        Me.rbtnCARNET.TabIndex = 3
        Me.rbtnCARNET.Text = "Carnet"
        '
        'rbtnTU
        '
        Me.rbtnTU.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnTU.ForeColor = System.Drawing.Color.Teal
        Me.rbtnTU.Location = New System.Drawing.Point(16, 24)
        Me.rbtnTU.Name = "rbtnTU"
        Me.rbtnTU.TabIndex = 0
        Me.rbtnTU.Text = "Tipo Usuario"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(232, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 32)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "REPORTE DE DATOS"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.CrystalReportViewer1.BackColor = System.Drawing.Color.RoyalBlue
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrystalReportViewer1.ForeColor = System.Drawing.Color.Navy
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(136, 48)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(512, 280)
        Me.CrystalReportViewer1.TabIndex = 7
        '
        'frmReporte
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(672, 414)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnSalir, Me.btnSelImpresora, Me.btnEjecutar, Me.btnSeleccionar, Me.GroupBox1, Me.Label1, Me.CrystalReportViewer1})
        Me.Name = "frmReporte"
        Me.Text = "frmReporte"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        MsgBox("A ACCEDIDO A LOS REPORTES DE LA BASE DE DATOS")
        Me.Close()
    End Sub
    Private Sub btnSelImpresora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelImpresora.Click
        Dim PrintDialog1 As New PrintDialog()
        PrintDialog1.Document = PrintDocument1

        Dim result As DialogResult = PrintDialog1.ShowDialog()
        If (result = DialogResult.OK) Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub OpenReporte(ByVal sql As String, ByVal aliasTabla As String)
        Dim i As Integer
        If Conexion.State = ConnectionState.Closed Then
            Conexion.Open()
        End If
        SQLAdapter_Master = New SqlDataAdapter(sql, Conexion)
        DataSet_Master.Clear()
        SQLAdapter_Master.Fill(DataSet_Master, aliasTabla)
    End Sub
    Private Sub OpenrptTU()
        Dim rpt As New rptTU()
        Call OpenReporte("Select * from Tipo_Usuario", "Tipo_Usuario")
        Call rpt.SetDataSource(DataSet_Master)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub OpenrptUsuario()
        Dim rpt As New rptUsuario()
        Call OpenReporte("Select * from OUsuario", "OUsuario")
        Call rpt.SetDataSource(DataSet_Master)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
    Private Sub OpenrptCarnet()
        Dim rpt As New rptCarnet()
        Call OpenReporte("Select * from Carne", "Carne")
        Call rpt.SetDataSource(DataSet_Master)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
    Private Sub OpenrptFicha()
        Dim rpt As New rptFicha()
        Call OpenReporte("Select * from OFicha_de_Prestamo", "OFicha_de_Prestamo")
        Call rpt.SetDataSource(DataSet_Master)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
    Private Sub OpenrptLibro()
        Dim rpt As New rptLibro()
        Call OpenReporte("Select * from Libro", "Libro")
        Call rpt.SetDataSource(DataSet_Master)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
    Private Sub OpenrptTema()
        Dim rpt As New rptTema()
        Call OpenReporte("Select * from Tema", "Tema")
        Call rpt.SetDataSource(DataSet_Master)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
    Private Sub OpenrptDevolucion()
        Dim rpt As New rptDevolucion()
        Call OpenReporte("Select * from Devolucion", "Devolucion")
        Call rpt.SetDataSource(DataSet_Master)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
    Private Sub OpenrptEmpleado()
        Dim rpt As New rptEmpleado()
        Call OpenReporte("Select * from OEmpleado", "OEmpleado")
        Call rpt.SetDataSource(DataSet_Master)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
    Private Sub rbtnTU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnUSU.Click
        If rbtnTU.Checked Then
            Call OpenrptTU()
        End If
    End Sub
    Private Sub rbtnUsu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnUSU.Click
        If rbtnUSU.Checked Then
            Call OpenrptUsuario()
        End If
    End Sub
    Private Sub rbtnCarnet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnUSU.Click
        If rbtnCARNET.Checked Then
            Call OpenrptCarnet()
        End If
    End Sub
    Private Sub rbtnFicha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnUSU.Click
        If rbtnFICHA.Checked Then
            Call OpenrptFicha()
        End If
    End Sub
    Private Sub rbtnLibro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnUSU.Click
        If rbtnLIBRO.Checked Then
            Call OpenrptLibro()
        End If
    End Sub
    Private Sub rbtnTema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnUSU.Click
        If rbtnTEMA.Checked Then
            Call OpenrptTema()
        End If
    End Sub
    Private Sub rbtnDevolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnUSU.Click
        If rbtnDEVOLUCION.Checked Then
            Call OpenrptDevolucion()
        End If
    End Sub
    Private Sub rbtnEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnUSU.Click
        If rbtnEMPLEADO.Checked Then
            Call OpenrptEmpleado()
        End If
    End Sub
    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click

        If Me.rbtnTU.Checked = True Then
            Call OpenrptTU()
        End If

        If Me.rbtnUSU.Checked = True Then
            Call OpenrptUsuario()
        End If

        If Me.rbtnCARNET.Checked = True Then
            Call OpenrptCarnet()
        End If

        If Me.rbtnFICHA.Checked = True Then
            Call OpenrptFicha()
        End If

        If Me.rbtnLIBRO.Checked = True Then
            Call OpenrptLibro()
        End If

        If Me.rbtnTEMA.Checked = True Then
            Call OpenrptTema()
        End If

        If Me.rbtnDEVOLUCION.Checked = True Then
            Call OpenrptDevolucion()
        End If

        If Me.rbtnEMPLEADO.Checked = True Then
            Call OpenrptEmpleado()
        End If

    End Sub


    Private Sub frmReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
