Imports System.Data.SqlClient
Public Class FrmConCargo
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents TxtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents TxtResumen As System.Windows.Forms.TextBox
    Friend WithEvents rbtnDescripcion As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnDescripcion = New System.Windows.Forms.RadioButton()
        Me.rbtnCodigo = New System.Windows.Forms.RadioButton()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.TxtResumen = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbtnDescripcion, Me.rbtnCodigo})
        Me.GroupBox1.Location = New System.Drawing.Point(20, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda por"
        '
        'rbtnDescripcion
        '
        Me.rbtnDescripcion.Location = New System.Drawing.Point(116, 24)
        Me.rbtnDescripcion.Name = "rbtnDescripcion"
        Me.rbtnDescripcion.Size = New System.Drawing.Size(104, 16)
        Me.rbtnDescripcion.TabIndex = 3
        Me.rbtnDescripcion.Text = "Descripcion"
        '
        'rbtnCodigo
        '
        Me.rbtnCodigo.Location = New System.Drawing.Point(8, 24)
        Me.rbtnCodigo.Name = "rbtnCodigo"
        Me.rbtnCodigo.Size = New System.Drawing.Size(104, 16)
        Me.rbtnCodigo.TabIndex = 0
        Me.rbtnCodigo.Text = "Codigo"
        '
        'lblTitulo
        '
        Me.lblTitulo.Location = New System.Drawing.Point(280, 28)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(140, 16)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "lblTitulo"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(276, 56)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(220, 20)
        Me.TxtBusqueda.TabIndex = 2
        Me.TxtBusqueda.Text = ""
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(280, 92)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "&Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(372, 92)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "&Cancelar"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(28, 140)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(484, 180)
        Me.DataGrid1.TabIndex = 5
        '
        'TxtResumen
        '
        Me.TxtResumen.Location = New System.Drawing.Point(24, 336)
        Me.TxtResumen.Multiline = True
        Me.TxtResumen.Name = "TxtResumen"
        Me.TxtResumen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtResumen.Size = New System.Drawing.Size(488, 52)
        Me.TxtResumen.TabIndex = 6
        Me.TxtResumen.Text = ""
        '
        'FrmConCargo
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(536, 412)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtResumen, Me.DataGrid1, Me.btnCancelar, Me.btnAceptar, Me.TxtBusqueda, Me.lblTitulo, Me.GroupBox1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmConCargo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmConCargo"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    ' Esto va en la sección Declaraciones
    Dim strcampo As String
    Dim objConnection As New SqlConnection() ' creando objeto Connection
    Dim objCommand As SqlCommand ' objeto Comando
    Dim objDataAdapter As SqlDataAdapter ' objeto Adaptador de datos
    Dim objDataSet As DataSet ' objeto Conjunto de datos
    Dim sqlstr, oper As String
    Dim cargo As Boolean


    Private Sub rbtnCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnCodigo.Click, rbtnDescripcion.Click
        Select Case sender.name
            Case "rbtnCodigo"
                strcampo = "codcar"
                oper = " codigo "
            Case "rbtnDescripcion"
                strcampo = "descar"
                oper = " Descripcion "
                Exit Sub
        End Select
        Me.lblTitulo.Text = "ingrese " & oper & " a buscar"
        Me.DataGrid1.DataSource = Nothing
        TxtBusqueda.Clear()
        TxtBusqueda.Focus()
        TxtResumen.Clear()
    End Sub
    Private Sub LlenarCargos()
        Dim cm As New SqlCommand("select * from Cargo", ModConexion.Conexion)
        Dim oDR As SqlDataReader
        ModConexion.Conexion.Open()
        oDR = cm.ExecuteReader()
        oDR.Close()
        ModConexion.Conexion.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim strSQL, primero, ultimo As String
        Dim total As Integer

        strSQL = "SELECT * FROM Cargo WHERE " & Trim(strcampo) & " LIKE '" & _
        Trim(Me.TxtBusqueda.Text) & "%'"
        If TxtBusqueda.Text = "" Then
            MsgBox("ingrese el " & oper & " del Cargo a buscar")
            TxtBusqueda.Focus()
            Exit Sub
        End If
        'Creando objeto DataAdapter
        objDataAdapter = New SqlDataAdapter(strSQL, ModConexion.Conexion)
        ModConexion.Conexion.Open()
        'Creando objeto DataSet
        objDataSet = New DataSet()
        objDataAdapter.Fill(objDataSet, "Cargo")
        ModConexion.Conexion.Close()
        'resumen de la busqueda
        total = Me.objDataSet.Tables("Cargo").Rows.Count
        If total > 0 Then
            Me.DataGrid1.DataSource = objDataSet
            Me.DataGrid1.DataMember = "Cargo"
            primero = Me.objDataSet.Tables("Cargo").Rows.Item(0)(1)
            ultimo = Me.objDataSet.Tables("Cargo").Rows.Item(total - 1)(1)
            TxtResumen.Text = "Se encontraron " & Str(total) & " Cargo " & " desde " & primero & _
            " hasta " & ultimo
        Else
            TxtResumen.Text = "No se encontraron datos...."
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmConCargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
