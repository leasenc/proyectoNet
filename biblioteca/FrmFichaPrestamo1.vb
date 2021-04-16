Imports System.Data.SqlClient
Public Class FrmFichaPrestamo1
    Inherits System.Windows.Forms.Form
    Const spExploracion = "Ficha de Prestamo: Exploración de registros"
    Const spNuevo = "Ficha de Prestamo: Nuevo Registro"
    Const spModificacion = "Ficha de Prestamo: Modificación del Registro"
    Private TableName As String
    Dim SQLAdapter_Master As SqlDataAdapter
    Dim SQLAdapter_Sec1 As SqlDataAdapter
    Dim SQLAdapter_Sec2 As SqlDataAdapter
    Dim SQLAdapter_Sec3 As SqlDataAdapter
    Dim DataSet_Master As DataSet
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrimero As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblRegistro As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFecP As System.Windows.Forms.TextBox
    Friend WithEvents cboLibro As System.Windows.Forms.ComboBox
    Friend WithEvents cbotitulo As System.Windows.Forms.ComboBox
    Friend WithEvents cboAutor As System.Windows.Forms.ComboBox
    Friend WithEvents cboCarne As System.Windows.Forms.ComboBox
    Friend WithEvents cboEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmFichaPrestamo1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtFecP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboLibro = New System.Windows.Forms.ComboBox()
        Me.cbotitulo = New System.Windows.Forms.ComboBox()
        Me.cboAutor = New System.Windows.Forms.ComboBox()
        Me.cboCarne = New System.Windows.Forms.ComboBox()
        Me.cboEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(252, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro Ficha :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(348, 16)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo Libro :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Titulo :"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Autor :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nro Carne :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblRegistro, Me.btnUltimo, Me.btnSiguiente, Me.btnAnterior, Me.btnPrimero})
        Me.GroupBox1.Location = New System.Drawing.Point(16, 244)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 52)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'lblRegistro
        '
        Me.lblRegistro.Location = New System.Drawing.Point(176, 24)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(100, 16)
        Me.lblRegistro.TabIndex = 4
        Me.lblRegistro.Text = "lblRegistro"
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(360, 20)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.TabIndex = 3
        Me.btnUltimo.Text = "&Ultimo>>"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(284, 20)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = "&Siguiente>"
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(88, 20)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.Text = "<&Anterior"
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(12, 20)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.TabIndex = 0
        Me.btnPrimero.Text = "<<&Primero"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCancelar, Me.btnSalir, Me.btnBuscar, Me.btnEliminar, Me.btnGuardar, Me.btnEditar, Me.btnNuevo})
        Me.GroupBox2.Location = New System.Drawing.Point(16, 304)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 64)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Bitmap)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(180, 16)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 40)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Bitmap)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(360, 16)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(56, 40)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "S&alir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Bitmap)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(304, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(56, 40)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "B&uscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Bitmap)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(244, 16)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(60, 40)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "E&liminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Bitmap)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(128, 16)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(60, 40)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Bitmap)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditar.Location = New System.Drawing.Point(64, 16)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(56, 40)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "&Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Bitmap)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(8, 16)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(56, 40)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtFecP
        '
        Me.txtFecP.Location = New System.Drawing.Point(148, 172)
        Me.txtFecP.Name = "txtFecP"
        Me.txtFecP.TabIndex = 13
        Me.txtFecP.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Fecha Prestamo :"
        '
        'cboLibro
        '
        Me.cboLibro.Location = New System.Drawing.Point(148, 52)
        Me.cboLibro.Name = "cboLibro"
        Me.cboLibro.Size = New System.Drawing.Size(121, 21)
        Me.cboLibro.TabIndex = 21
        Me.cboLibro.Text = "ComboBox1"
        '
        'cbotitulo
        '
        Me.cbotitulo.Location = New System.Drawing.Point(148, 84)
        Me.cbotitulo.Name = "cbotitulo"
        Me.cbotitulo.Size = New System.Drawing.Size(244, 21)
        Me.cbotitulo.TabIndex = 22
        Me.cbotitulo.Text = "ComboBox1"
        '
        'cboAutor
        '
        Me.cboAutor.Location = New System.Drawing.Point(148, 112)
        Me.cboAutor.Name = "cboAutor"
        Me.cboAutor.Size = New System.Drawing.Size(244, 21)
        Me.cboAutor.TabIndex = 23
        Me.cboAutor.Text = "ComboBox1"
        '
        'cboCarne
        '
        Me.cboCarne.Location = New System.Drawing.Point(148, 140)
        Me.cboCarne.Name = "cboCarne"
        Me.cboCarne.Size = New System.Drawing.Size(121, 21)
        Me.cboCarne.TabIndex = 24
        Me.cboCarne.Text = "ComboBox1"
        '
        'cboEmpleado
        '
        Me.cboEmpleado.Location = New System.Drawing.Point(148, 200)
        Me.cboEmpleado.Name = "cboEmpleado"
        Me.cboEmpleado.Size = New System.Drawing.Size(76, 21)
        Me.cboEmpleado.TabIndex = 26
        Me.cboEmpleado.Text = "ComboBox1"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Cod Empleado"
        '
        'FrmFichaPrestamo1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(484, 378)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboEmpleado, Me.Label10, Me.cboCarne, Me.cboAutor, Me.cbotitulo, Me.cboLibro, Me.txtFecP, Me.Label6, Me.GroupBox2, Me.GroupBox1, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.txtCodigo, Me.Label1})
        Me.Name = "FrmFichaPrestamo1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmFichaPrestamo1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmFichaPrestamo1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ModConexion.FFPT = False
    End Sub

    ' Creando Procedimientos
    Private Sub FrmLector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModConexion.Conexion.Open()
        TableName = "OFicha_de_Prestamo"
        SQLAdapter_Master = New SqlDataAdapter("SELECT * FROM OFicha_de_Prestamo", ModConexion.Conexion)
        SQLAdapter_Sec1 = New SqlDataAdapter("SELECT * FROM Libro", ModConexion.Conexion)
        SQLAdapter_Sec2 = New SqlDataAdapter("SELECT * FROM OEmpleado", ModConexion.Conexion)
        SQLAdapter_Sec3 = New SqlDataAdapter("SELECT * FROM Carne", ModConexion.Conexion)
        DataSet_Master = New DataSet()
        Call RefillDatasets()
        'Call Actualizar()
        ModConexion.Conexion.Close()
        Call EnlazaControles()
        Call NumRegistro(TableName)
        Call ConfiguraControles(0)
    End Sub
    Private Sub ConfiguraControles(ByVal stStatus As Integer)
        btnPrimero.Enabled = (stStatus <> 1) And (stStatus <> 2)
        btnAnterior.Enabled = (stStatus <> 1) And (stStatus <> 2)
        btnSiguiente.Enabled = (stStatus <> 1) And (stStatus <> 2)
        btnUltimo.Enabled = (stStatus <> 1) And (stStatus <> 2)
        btnBuscar.Enabled = (stStatus <> 1) And (stStatus <> 2)
        btnNuevo.Enabled = (stStatus <> 1) And (stStatus <> 2)
        btnEditar.Enabled = (stStatus <> 1) And (stStatus <> 2)
        btnEliminar.Enabled = (stStatus <> 1) And (stStatus <> 2)
        btnGuardar.Enabled = (stStatus = 1) Or (stStatus = 2)
        btnCancelar.Enabled = (stStatus = 1) Or (stStatus = 2)
        txtCodigo.Enabled = False
        txtFecP.Enabled = (stStatus = 1) Or (stStatus = 2)
        cboLibro.Enabled = (stStatus = 1) Or (stStatus = 2)
        cbotitulo.Enabled = (stStatus = 1) Or (stStatus = 2)
        cboAutor.Enabled = (stStatus = 1) Or (stStatus = 2)
        cboCarne.Enabled = (stStatus = 1) Or (stStatus = 2)
        cboEmpleado.Enabled = (stStatus = 1) Or (stStatus = 2)

        Select Case stStatus
            Case 1 'Agregando nuevo registro
                Me.Text = spNuevo
                txtCodigo.Text = "<Autogenerado>"
                txtFecP.Text = ""
                cboLibro.Text = ""
                cbotitulo.Text = ""
                cboAutor.Text = ""
                cboCarne.Text = ""
                cboEmpleado.Text = ""
                txtCodigo.Focus()
            Case 2 'Modificando registro
                Me.Text = spModificacion
                txtCodigo.Focus()
            Case Else ' Exploracion de datos
                Me.Text = spExploracion
        End Select
    End Sub
    Private Sub FrmActClientes_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ModConexion.FLEC = False
    End Sub
    Private Sub RefillDatasets()
        DataSet_Master.Clear()
        SQLAdapter_Sec3.Fill(DataSet_Master, "Carne")
        SQLAdapter_Sec2.Fill(DataSet_Master, "OEmpleado")
        SQLAdapter_Sec1.Fill(DataSet_Master, "Libro")
        SQLAdapter_Master.Fill(DataSet_Master, TableName)
    End Sub

    Private Sub EnlazaControles()

        Me.txtCodigo.DataBindings.Add("Text", DataSet_Master, "OFicha_de_Prestamo.Nro_Ficha")
        Me.txtFecP.DataBindings.Add("Text", DataSet_Master, "OFicha_de_Prestamo.Fecha_Ptmo")

        Me.cboLibro.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet_Master, "OFicha_de_Prestamo.Cod_Lib"))
        Me.cboLibro.DataSource = Me.DataSet_Master.Tables("Libro")
        Me.cboLibro.DisplayMember = "Cod_Lib"
        Me.cboLibro.ValueMember = "Cod_Lib"
        Me.cboLibro.DropDownStyle = ComboBoxStyle.DropDownList

        Me.cbotitulo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet_Master, "OFicha_de_Prestamo.Cod_Lib"))
        Me.cbotitulo.DataSource = Me.DataSet_Master.Tables("Libro")
        Me.cbotitulo.DisplayMember = "Tit_Lib"
        Me.cbotitulo.ValueMember = "Cod_Lib"
        Me.cbotitulo.DropDownStyle = ComboBoxStyle.DropDownList

        Me.cboAutor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet_Master, "OFicha_de_Prestamo.Cod_Lib"))
        Me.cboAutor.DataSource = Me.DataSet_Master.Tables("Libro")
        Me.cboAutor.DisplayMember = "Aut_Lib"
        Me.cboAutor.ValueMember = "Cod_Lib"
        Me.cboAutor.DropDownStyle = ComboBoxStyle.DropDownList

        Me.cboCarne.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet_Master, "OFicha_de_Prestamo.Cod_Carne"))
        Me.cboCarne.DataSource = Me.DataSet_Master.Tables("Carne")
        Me.cboCarne.DisplayMember = "Cod_carne"
        Me.cboCarne.ValueMember = "Cod_carne"
        Me.cboCarne.DropDownStyle = ComboBoxStyle.DropDownList

        Me.cboEmpleado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet_Master, "OFicha_de_Prestamo.Cod_Emp"))
        Me.cboEmpleado.DataSource = Me.DataSet_Master.Tables("OEmpleado")
        Me.cboEmpleado.DisplayMember = "Cod_Emp"
        Me.cboEmpleado.ValueMember = "Cod_Emp"
        Me.cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub
    ' Creando Procedimientos

    Private Function ActualizarBaseDeDatos(ByVal IsInsercion As Boolean) As Integer
        Dim oCNN As System.Data.SqlClient.SqlConnection
        Dim oCMD As System.Data.SqlClient.SqlCommand
        Dim oPRM As System.Data.SqlClient.SqlParameter
        Dim Codigo As Integer
        Codigo = 0
        oCNN = New SqlConnection(Conexion.ConnectionString)
        oCNN.Open()
        If IsInsercion Then
            oCMD = NewComando(oCNN, "InsertFicha", CommandType.StoredProcedure)
            oPRM = NewParameter("FechaPtmo", True, SqlDbType.DateTime, 8, txtFecP.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("CodigoCarne", True, SqlDbType.Int, 4, cboCarne.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("CodigoLibro", True, SqlDbType.Int, 4, cboLibro.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("CodigoEmp", True, SqlDbType.Int, 4, cboEmpleado.Text)
            oCMD.Parameters.Add(oPRM)
        Else
            oCMD = NewComando(oCNN, "ActualizarLibro", CommandType.StoredProcedure)
            oPRM = NewParameter("NoFicha", True, SqlDbType.Int, 4, txtCodigo.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("FechaPtmo", True, SqlDbType.DateTime, 8, txtFecP.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("CodigoCarne", True, SqlDbType.Int, 4, cboCarne.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("CodigoLibro", True, SqlDbType.Int, 4, cboLibro.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("CodigoEmp", True, SqlDbType.Int, 4, cboEmpleado.Text)
            oCMD.Parameters.Add(oPRM)
        End If
        oPRM = NewParameter("Codigo", False, SqlDbType.Int, 4, 0)
        oCMD.Parameters.Add(oPRM)
        Try
            oCMD.ExecuteNonQuery()
            Codigo = oPRM.Value
        Catch xErr As Exception
            MsgBox(xErr.Message)
        Finally
            oCNN.Close()
            oCMD = Nothing
            oPRM = Nothing
            oCNN = Nothing
        End Try
        Return Codigo
    End Function

    Private Sub GeneraCodigo()
        Dim cmd As New SqlCommand("select max(Nro_Ficha)from OFicha_de_Prestamo", ModConexion.Conexion)
        Dim strCodigo As String
        ModConexion.Conexion.Open()
        strCodigo = cmd.ExecuteScalar
        ModConexion.Conexion.Close()
        txtCodigo.Text = Format(Val(strCodigo) + 1)
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim sql3 As String
        Dim resultado As String
        sql3 = "delete from OFicha_de_Prestamo where Nro_Ficha=@c1"
        Dim objComando As New SqlCommand(sql3, ModConexion.Conexion)
        Try
            objComando.Parameters.Add(New SqlParameter("@c1", SqlDbType.Int))
            objComando.Parameters("@c1").Value = InputBox("Ingrese el Carnet a eliminar: ")
            ModConexion.Conexion.Open()
            resultado = objComando.ExecuteNonQuery
            Call Actualizar()
            btnAnterior.PerformClick() ' Para que muestre el registro anterior luego de eliminar
            MessageBox.Show("Registros Eliminados: " & resultado, "", 0, MessageBoxIcon.Information)
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
        ModConexion.Conexion.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim strDato As String
        strDato = InputBox("Ingrese el No.de Ficha", "Buscar")
        Call MueveCursorA("Nro_Ficha", strDato, "No. de Ficha no existe")
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim cod As Integer
        cod = ActualizarBaseDeDatos(spNuevo = Me.Text)
        If cod <> 0 Then
            Actualizar()
            Call MueveCursorA("Nro_Ficha", Str(cod), "")
            Call ConfiguraControles(0)
        End If
    End Sub

    ' Codigo totalmente reutilizable (Copiar Pegar a form similares)
    Private Sub NumRegistro(ByVal iTableName As String)
        Dim num, total As Integer
        num = Me.BindingContext(DataSet_Master, iTableName).Position + 1
        total = Me.DataSet_Master.Tables(iTableName).Rows.Count
        Me.lblRegistro.Text = "Reg: " & Str(num) & " de " & Str(total)
    End Sub
    Private Sub Actualizar()
        DataSet_Master.Tables(TableName).Clear()
        SQLAdapter_Master.Fill(DataSet_Master, TableName)
    End Sub
    Private Sub MueveCursorA(ByVal FieldKey As String, ByVal FieldValue As String, ByVal msg As String)
        Dim fila As Integer
        Dim dv As New DataView()
        dv.Table = DataSet_Master.Tables(TableName)
        dv.Sort = FieldKey
        fila = dv.Find(FieldValue)
        If fila = -1 Then
            If Len(msg) > 2 Then MessageBox.Show(msg, "Cuidado")
            Exit Sub
        End If
        dv = Nothing
        Me.BindingContext(DataSet_Master, TableName).Position = fila
        Call NumRegistro(TableName)
    End Sub
    Private Sub MueveCursor(ByVal opcion As Integer)
        Select Case opcion
            Case -2 'First
                BindingContext(DataSet_Master, TableName).Position = 0
            Case -1 'Previous
                If BindingContext(DataSet_Master, TableName).Position > 0 Then
                    BindingContext(DataSet_Master, TableName).Position -= 1
                End If
            Case 0 'Cancel
                BindingContext(DataSet_Master, TableName).CancelCurrentEdit()
            Case 1 'Next
                BindingContext(DataSet_Master, TableName).Position += 1
            Case 2 ' Last
                BindingContext(DataSet_Master, TableName).Position = BindingContext(DataSet_Master, TableName).Count - 1
        End Select
        Me.NumRegistro(TableName)
    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        MueveCursor(2)
        Call ConfiguraControles(1)
        Call GeneraCodigo()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Call ConfiguraControles(2)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Call MueveCursor(0)
        Call ConfiguraControles(0)
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        ModConexion.Conexion.Close()
        Me.Close()
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        MueveCursor(-2)
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        MueveCursor(-1)
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        MueveCursor(1)
    End Sub
    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        MueveCursor(2)
    End Sub

End Class
