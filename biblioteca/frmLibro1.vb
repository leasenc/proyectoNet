Imports System.Data.SqlClient
Public Class frmLibro1
    Inherits System.Windows.Forms.Form
    Const spExploracion = "Libro : Exploración de registros"
    Const spNuevo = "Libro : Nuevo Registro"
    Const spModificacion = "Libro : Modificación del Registro"
    Private TableName As String
    Dim SQLAdapter_Master As SqlDataAdapter
    Dim SQLAdapter_Sec1 As SqlDataAdapter
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrimero As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents lblRegistro As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents TxtAutor As System.Windows.Forms.TextBox
    Friend WithEvents TxtNPag As System.Windows.Forms.TextBox
    Friend WithEvents TxtEditorial As System.Windows.Forms.TextBox
    Friend WithEvents TxtEdicion As System.Windows.Forms.TextBox
    Friend WithEvents TxtFecReg As System.Windows.Forms.TextBox
    Friend WithEvents txtDocI As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboTema As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLibro1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtTitulo = New System.Windows.Forms.TextBox()
        Me.TxtAutor = New System.Windows.Forms.TextBox()
        Me.TxtNPag = New System.Windows.Forms.TextBox()
        Me.TxtEditorial = New System.Windows.Forms.TextBox()
        Me.TxtEdicion = New System.Windows.Forms.TextBox()
        Me.cboTema = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.TxtFecReg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDocI = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(200, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(36, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Titulo :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(36, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Autor :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(36, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nro Paginas :"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(36, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Editorial :"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(36, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Edicion :"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(36, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tema :"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(292, 0)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.TabIndex = 8
        Me.TxtCodigo.Text = ""
        '
        'TxtTitulo
        '
        Me.TxtTitulo.Location = New System.Drawing.Point(156, 28)
        Me.TxtTitulo.Name = "TxtTitulo"
        Me.TxtTitulo.Size = New System.Drawing.Size(236, 20)
        Me.TxtTitulo.TabIndex = 9
        Me.TxtTitulo.Text = ""
        '
        'TxtAutor
        '
        Me.TxtAutor.Location = New System.Drawing.Point(156, 52)
        Me.TxtAutor.Name = "TxtAutor"
        Me.TxtAutor.Size = New System.Drawing.Size(236, 20)
        Me.TxtAutor.TabIndex = 10
        Me.TxtAutor.Text = ""
        '
        'TxtNPag
        '
        Me.TxtNPag.Location = New System.Drawing.Point(156, 76)
        Me.TxtNPag.Name = "TxtNPag"
        Me.TxtNPag.Size = New System.Drawing.Size(236, 20)
        Me.TxtNPag.TabIndex = 12
        Me.TxtNPag.Text = ""
        '
        'TxtEditorial
        '
        Me.TxtEditorial.Location = New System.Drawing.Point(156, 100)
        Me.TxtEditorial.Name = "TxtEditorial"
        Me.TxtEditorial.Size = New System.Drawing.Size(80, 20)
        Me.TxtEditorial.TabIndex = 13
        Me.TxtEditorial.Text = ""
        '
        'TxtEdicion
        '
        Me.TxtEdicion.Location = New System.Drawing.Point(156, 124)
        Me.TxtEdicion.Name = "TxtEdicion"
        Me.TxtEdicion.Size = New System.Drawing.Size(120, 20)
        Me.TxtEdicion.TabIndex = 14
        Me.TxtEdicion.Text = ""
        '
        'cboTema
        '
        Me.cboTema.Location = New System.Drawing.Point(156, 172)
        Me.cboTema.Name = "cboTema"
        Me.cboTema.Size = New System.Drawing.Size(121, 21)
        Me.cboTema.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblRegistro, Me.btnUltimo, Me.btnSiguiente, Me.btnAnterior, Me.btnPrimero})
        Me.GroupBox1.Location = New System.Drawing.Point(12, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 64)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'lblRegistro
        '
        Me.lblRegistro.Location = New System.Drawing.Point(188, 28)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(72, 16)
        Me.lblRegistro.TabIndex = 4
        Me.lblRegistro.Text = "lblRegistro"
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(356, 24)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.TabIndex = 3
        Me.btnUltimo.Text = "&Ultimo>>"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(276, 24)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = "&Siguiente>"
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(92, 24)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.Text = "<<&Anterior"
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(12, 24)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.TabIndex = 0
        Me.btnPrimero.Text = "<<&Primero"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnSalir, Me.btnBuscar, Me.btnEliminar, Me.btnCancelar, Me.btnGuardar, Me.btnEditar, Me.btnNuevo})
        Me.GroupBox2.Location = New System.Drawing.Point(12, 328)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 76)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Bitmap)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(384, 24)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(56, 44)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Bitmap)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(324, 24)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(56, 44)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Bitmap)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(260, 24)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(60, 44)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Bitmap)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(192, 24)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 44)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Bitmap)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(128, 24)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(60, 44)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Bitmap)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditar.Location = New System.Drawing.Point(68, 24)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(56, 44)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "&Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Bitmap)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(8, 24)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(56, 44)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TxtFecReg
        '
        Me.TxtFecReg.Location = New System.Drawing.Point(156, 148)
        Me.TxtFecReg.Name = "TxtFecReg"
        Me.TxtFecReg.Size = New System.Drawing.Size(120, 20)
        Me.TxtFecReg.TabIndex = 21
        Me.TxtFecReg.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(36, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Fecha Registro :"
        '
        'txtDocI
        '
        Me.txtDocI.Location = New System.Drawing.Point(156, 200)
        Me.txtDocI.Multiline = True
        Me.txtDocI.Name = "txtDocI"
        Me.txtDocI.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtDocI.Size = New System.Drawing.Size(208, 36)
        Me.txtDocI.TabIndex = 25
        Me.txtDocI.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(36, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Docto.Ing."
        '
        'frmLibro1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(476, 418)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtDocI, Me.Label10, Me.TxtFecReg, Me.Label4, Me.GroupBox2, Me.GroupBox1, Me.cboTema, Me.TxtEdicion, Me.TxtEditorial, Me.TxtNPag, Me.TxtAutor, Me.TxtTitulo, Me.TxtCodigo, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label3, Me.Label2, Me.Label1})
        Me.Name = "frmLibro1"
        Me.Text = "frmLibro1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmActempleados_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ModConexion.FLIB = False
    End Sub

    ' Creando Procedimientos
    Private Sub FrmLector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModConexion.Conexion.Open()
        TableName = "Libro"
        SQLAdapter_Master = New SqlDataAdapter("SELECT * FROM Libro", ModConexion.Conexion)
        SQLAdapter_Sec1 = New SqlDataAdapter("SELECT * FROM Tema", ModConexion.Conexion)
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
        TxtCodigo.Enabled = False
        TxtTitulo.Enabled = (stStatus = 1) Or (stStatus = 2)
        TxtAutor.Enabled = (stStatus = 1) Or (stStatus = 2)
        TxtNPag.Enabled = (stStatus = 1) Or (stStatus = 2)
        TxtEditorial.Enabled = (stStatus = 1) Or (stStatus = 2)
        TxtEdicion.Enabled = (stStatus = 1) Or (stStatus = 2)
        TxtFecReg.Enabled = (stStatus = 1) Or (stStatus = 2)
        cboTema.Enabled = (stStatus = 1) Or (stStatus = 2)
        txtDocI.Enabled = (stStatus = 1) Or (stStatus = 2)

        Select Case stStatus
            Case 1 'Agregando nuevo registro
                Me.Text = spNuevo
                TxtCodigo.Text = "<Autogenerado>"
                TxtTitulo.Text = ""
                TxtAutor.Text = ""
                TxtNPag.Text = ""
                TxtEditorial.Text = ""
                TxtEdicion.Text = ""
                TxtFecReg.Text = ""
                cboTema.Text = ""
                txtDocI.Text = ""
                TxtCodigo.Focus()
            Case 2 'Modificando registro
                Me.Text = spModificacion
                TxtCodigo.Focus()
            Case Else ' Exploracion de datos
                Me.Text = spExploracion
        End Select
    End Sub
    Private Sub FrmActClientes_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ModConexion.FLEC = False
    End Sub
    Private Sub RefillDatasets()
        DataSet_Master.Clear()
        SQLAdapter_Sec1.Fill(DataSet_Master, "Tema")
        SQLAdapter_Master.Fill(DataSet_Master, TableName)
    End Sub

    Private Sub EnlazaControles()

        Me.TxtCodigo.DataBindings.Add("Text", DataSet_Master, "Libro.Cod_Lib")
        Me.TxtTitulo.DataBindings.Add("Text", DataSet_Master, "Libro.Tit_Lib")
        Me.TxtAutor.DataBindings.Add("Text", DataSet_Master, "Libro.Aut_Lib")
        Me.TxtNPag.DataBindings.Add("Text", DataSet_Master, "Libro.NoPag_Lib")
        Me.TxtEditorial.DataBindings.Add("Text", DataSet_Master, "Libro.Edit_Lib")
        Me.TxtEdicion.DataBindings.Add("Text", DataSet_Master, "Libro.NoEdic_Lib")
        Me.TxtFecReg.DataBindings.Add("Text", DataSet_Master, "Libro.FechaIngreso")
        Me.txtDocI.DataBindings.Add("Text", DataSet_Master, "Libro.Docto_Ing")

        Me.cboTema.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet_Master, "Libro.Cod_Tema"))
        Me.cboTema.DataSource = Me.DataSet_Master.Tables("Tema")
        Me.cboTema.DisplayMember = "Descripcion"
        Me.cboTema.ValueMember = "Cod_Tema"
        Me.cboTema.DropDownStyle = ComboBoxStyle.DropDownList

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
            oCMD = NewComando(oCNN, "InsertLibro", CommandType.StoredProcedure)
            oPRM = NewParameter("TitLib", True, SqlDbType.VarChar, 45, TxtTitulo.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("AutLib", True, SqlDbType.VarChar, 35, TxtAutor.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("NoPag", True, SqlDbType.Int, 4, TxtNPag.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("EditLib", True, SqlDbType.VarChar, 30, TxtEditorial.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("NoEdic", True, SqlDbType.VarChar, 4, TxtEdicion.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("Fecha", True, SqlDbType.DateTime, 8, TxtFecReg.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("DoctoIng", True, SqlDbType.Text, 16, txtDocI.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("CodTema", True, SqlDbType.Int, 4, cboTema.Text)
            oCMD.Parameters.Add(oPRM)

        Else
            oCMD = NewComando(oCNN, "ActualizarLibro", CommandType.StoredProcedure)
            oPRM = NewParameter("CodLib", True, SqlDbType.Int, 4, TxtTitulo.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("TitLib", True, SqlDbType.VarChar, 45, TxtTitulo.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("AutLib", True, SqlDbType.VarChar, 35, TxtAutor.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("NoPag", True, SqlDbType.Int, 4, TxtNPag.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("EditLib", True, SqlDbType.VarChar, 30, TxtEditorial.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("NoEdic", True, SqlDbType.VarChar, 4, TxtEdicion.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("Fecha", True, SqlDbType.DateTime, 8, TxtFecReg.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("DoctoIng", True, SqlDbType.Text, 16, txtDocI.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("CodTema", True, SqlDbType.Int, 4, cboTema.Text)
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
        Dim cmd As New SqlCommand("select max(Cod_Lib)from Libro", ModConexion.Conexion)
        Dim strCodigo As String
        ModConexion.Conexion.Open()
        strCodigo = cmd.ExecuteScalar
        ModConexion.Conexion.Close()
        TxtCodigo.Text = Format(Val(strCodigo) + 1)
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim sql3 As String
        Dim resultado As String
        sql3 = "delete from Libro where Cod_Lib=@c1"
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
        strDato = InputBox("Ingrese el Codigo del Libro", "Buscar")
        Call MueveCursorA("Cod_Lib", strDato, "Codigo de Libro no existe")
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim cod As Integer
        cod = ActualizarBaseDeDatos(spNuevo = Me.Text)
        If cod <> 0 Then
            Actualizar()
            Call MueveCursorA("Cod_Lib", Str(cod), "")
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
