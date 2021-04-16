Imports System.Data.SqlClient
Public Class FrmConLibro
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
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents TxtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents TxtResumen As System.Windows.Forms.TextBox
    Friend WithEvents rbtnAutor As System.Windows.Forms.RadioButton
    Friend WithEvents rbtntitulo As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnAutor = New System.Windows.Forms.RadioButton()
        Me.rbtntitulo = New System.Windows.Forms.RadioButton()
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
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbtnAutor, Me.rbtntitulo})
        Me.GroupBox1.Location = New System.Drawing.Point(20, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda por"
        '
        'rbtnAutor
        '
        Me.rbtnAutor.Location = New System.Drawing.Point(116, 48)
        Me.rbtnAutor.Name = "rbtnAutor"
        Me.rbtnAutor.Size = New System.Drawing.Size(104, 16)
        Me.rbtnAutor.TabIndex = 3
        Me.rbtnAutor.Text = "Autor"
        '
        'rbtntitulo
        '
        Me.rbtntitulo.Location = New System.Drawing.Point(8, 48)
        Me.rbtntitulo.Name = "rbtntitulo"
        Me.rbtntitulo.Size = New System.Drawing.Size(104, 16)
        Me.rbtntitulo.TabIndex = 1
        Me.rbtntitulo.Text = "Titulo"
        '
        'lblTitulo
        '
        Me.lblTitulo.Location = New System.Drawing.Point(280, 28)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(204, 16)
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
        'FrmConLibro
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(536, 412)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtResumen, Me.DataGrid1, Me.btnCancelar, Me.btnAceptar, Me.TxtBusqueda, Me.lblTitulo, Me.GroupBox1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmConLibro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmConLibro"
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

    Private Sub rbtntitulo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtntitulo.Click, rbtnAutor.Click

        Select Case sender.name
            Case "rbtntitulo"
                strcampo = "Tit_Lib"
                oper = " Titulo de Libro "
            Case "rbtnAutor"
                strcampo = "Aut_Lib"
                oper = " Autor de Libro "
                Exit Sub
        End Select

        Me.lblTitulo.Text = "ingrese " & oper & " a buscar"
        Me.DataGrid1.DataSource = Nothing
        TxtBusqueda.Clear()
        TxtBusqueda.Focus()
        TxtResumen.Clear()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim strSQL, primero, ultimo As String
        Dim total As Integer
        strSQL = "SELECT * FROM Libro WHERE " & Trim(strcampo) & " LIKE '" & Trim(Me.TxtBusqueda.Text) & "%'"
        If TxtBusqueda.Text = "" Then
            MsgBox("ingrese el " & oper & " del Libro a buscar")
            TxtBusqueda.Focus()
            Exit Sub
        End If

        'Creando objeto DataAdapter
        objDataAdapter = New SqlDataAdapter(strSQL, ModConexion.Conexion)
        ModConexion.Conexion.Open()
        'Creando objeto DataSet
        objDataSet = New DataSet()
        objDataAdapter.Fill(objDataSet, "Libro")
        ModConexion.Conexion.Close()
        'resumen de la busqueda
        total = Me.objDataSet.Tables("Libro").Rows.Count
        If total > 0 Then
            Me.DataGrid1.DataSource = objDataSet
            Me.DataGrid1.DataMember = "Libro"
            primero = Me.objDataSet.Tables("Libro").Rows.Item(0)(1)
            ultimo = Me.objDataSet.Tables("Libro").Rows.Item(total - 1)(1)
            TxtResumen.Text = "Se encontraron " & Str(total) & " Libro" & " desde " & primero & _
            " hasta " & ultimo
        Else
            TxtResumen.Text = "No se encontraron datos...."
        End If
    End Sub

    Private Sub CboCargo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call btnAceptar.PerformClick()
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

   
    Private Sub FrmConLibro_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ModConexion.FCL = False
    End Sub
End Class
