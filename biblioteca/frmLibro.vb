Imports System.Data.SqlClient
Public Class frmLibro
    Inherits System.Windows.Forms.Form
    Dim daLibro As SqlDataAdapter
    Dim daEstadoLibro As SqlDataAdapter
    Dim objDataSet As DataSet
    Dim flag As Integer
    Dim resultado As Integer
    Dim strCodigo As String
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents TxtAutor As System.Windows.Forms.TextBox
    Friend WithEvents TxtNPag As System.Windows.Forms.TextBox
    Friend WithEvents TxtEditorial As System.Windows.Forms.TextBox
    Friend WithEvents TxtEdicion As System.Windows.Forms.TextBox
    Friend WithEvents TxtFecReg As System.Windows.Forms.TextBox
    Friend WithEvents TxtTema As System.Windows.Forms.TextBox
    Friend WithEvents txtDocI As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboEstadoLibro As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLibro))
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
        Me.cboEstadoLibro = New System.Windows.Forms.ComboBox()
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
        Me.TxtTema = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.Label8.Text = "Estado :"
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
        'cboEstadoLibro
        '
        Me.cboEstadoLibro.Location = New System.Drawing.Point(156, 172)
        Me.cboEstadoLibro.Name = "cboEstadoLibro"
        Me.cboEstadoLibro.Size = New System.Drawing.Size(121, 21)
        Me.cboEstadoLibro.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblRegistro, Me.btnUltimo, Me.btnSiguiente, Me.btnAnterior, Me.btnPrimero})
        Me.GroupBox1.Location = New System.Drawing.Point(12, 316)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 64)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 392)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 76)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
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
        'TxtTema
        '
        Me.TxtTema.Location = New System.Drawing.Point(156, 196)
        Me.TxtTema.Multiline = True
        Me.TxtTema.Name = "TxtTema"
        Me.TxtTema.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TxtTema.Size = New System.Drawing.Size(208, 60)
        Me.TxtTema.TabIndex = 23
        Me.TxtTema.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(36, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Temas :"
        '
        'txtDocI
        '
        Me.txtDocI.Location = New System.Drawing.Point(156, 260)
        Me.txtDocI.Multiline = True
        Me.txtDocI.Name = "txtDocI"
        Me.txtDocI.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtDocI.Size = New System.Drawing.Size(208, 36)
        Me.txtDocI.TabIndex = 25
        Me.txtDocI.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(36, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Docto.Ing."
        '
        'frmLibro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(476, 482)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtDocI, Me.Label10, Me.TxtTema, Me.Label9, Me.TxtFecReg, Me.Label4, Me.GroupBox2, Me.GroupBox1, Me.cboEstadoLibro, Me.TxtEdicion, Me.TxtEditorial, Me.TxtNPag, Me.TxtAutor, Me.TxtTitulo, Me.TxtCodigo, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label3, Me.Label2, Me.Label1})
        Me.Name = "frmLibro"
        Me.Text = "frmLibro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    

    Private Sub frmActempleados_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ModConexion.FLIB = False
    End Sub

    
    Private Sub frmLibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModConexion.Conexion.Open()
        daLibro = New SqlDataAdapter("SELECT * FROM Libro", ModConexion.Conexion)
        daEstadoLibro = New SqlDataAdapter("select * from Estado_Libro", ModConexion.Conexion)
        objDataSet = New DataSet()
        daLibro.Fill(objDataSet, "Libro")
        daEstadoLibro.Fill(objDataSet, "Estado_Libro")
        ModConexion.Conexion.Close()
        ' Enlazando los controles al campo correspondiente
        Me.TxtCodigo.DataBindings.Add("Text", objDataSet, "Libro.Cod_Lib")
        Me.TxtTitulo.DataBindings.Add("Text", objDataSet, "Libro.Tit_Lib")
        Me.TxtAutor.DataBindings.Add("Text", objDataSet, "Libro.Aut_Lib")
        Me.TxtNPag.DataBindings.Add("Text", objDataSet, "Libro.NoPag_Lib")
        Me.TxtEditorial.DataBindings.Add("Text", objDataSet, "Libro.Edit_Lib")
        Me.TxtEdicion.DataBindings.Add("Text", objDataSet, "Libro.NoEdic_Lib")
        Me.TxtFecReg.DataBindings.Add("Text", objDataSet, "Libro.FechaIngreso")
        Me.TxtTema.DataBindings.Add("Text", objDataSet, "Libro.Temas_Lib")
        Me.txtDocI.DataBindings.Add("Text", objDataSet, "Libro.Docto_Ing")
        Me.cboEstadoLibro.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.objDataSet, "Libro.Id_EstLib"))
        Me.cboEstadoLibro.DataSource = Me.objDataSet.Tables("Estado_Libro")
        Me.cboEstadoLibro.DisplayMember = "Descrip_EstLib"
        Me.cboEstadoLibro.ValueMember = "Id_EstLib"
        Me.cboEstadoLibro.DropDownStyle = ComboBoxStyle.DropDownList
        Call NumRegistro()
        Call HabilitarControles(False)
        Call HabilitarBotones(True)

    End Sub
    ' Creando Procedimientos
    Private Sub HabilitarControles(ByVal est As Boolean)
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox Then ctrl.Enabled = est
        Next

        cboEstadoLibro.Enabled = est
    End Sub
    Private Sub HabilitarBotones(ByVal est As Boolean)
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is Button Then ctrl.Enabled = est
        Next
        btnGuardar.Enabled = Not est
        btnCancelar.Enabled = Not est
    End Sub
    Private Sub LimpiarControles()
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox Then ctrl.Text = ""
        Next
    End Sub
    Private Sub NumRegistro()
        Dim num, total As Integer
        num = Me.BindingContext(objDataSet, "Libro").Position + 1
        total = Me.objDataSet.Tables("Libro").Rows.Count
        Me.lblRegistro.Text = "Reg: " & Str(num) & " de " & Str(total)
    End Sub
    Private Sub Actualizar()
        objDataSet.Clear()
        daLibro.Fill(objDataSet, "Libro")
        daEstadoLibro.Fill(objDataSet, "Estado_Libro")
    End Sub
    Private Sub GeneraCodigo()
        Dim cmd As New SqlCommand("select max(Cod_Lib)from Libro", ModConexion.Conexion)
        ModConexion.Conexion.Open()
        strCodigo = cmd.ExecuteScalar
        ModConexion.Conexion.Close()
        TxtCodigo.Text = Format(Val(strCodigo) + 1)
    End Sub
    Private Sub BotonB(ByVal VarX As Boolean)
        btnSiguiente.Enabled = VarX
        btnUltimo.Enabled = VarX
    End Sub
    Private Sub BotonA(ByVal VarX As Boolean)
        btnPrimero.Enabled = VarX
        btnAnterior.Enabled = VarX
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        flag = 1
        btnUltimo.PerformClick()
        Call HabilitarControles(True)
        Call HabilitarBotones(False)
        Call LimpiarControles()
        Call GeneraCodigo()
        TxtTitulo.Focus()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        flag = 2
        Call HabilitarControles(True)
        Call HabilitarBotones(False)
        TxtCodigo.Enabled = False
        TxtTitulo.Focus()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim sql, oper As String
        If flag = 1 Then ' Nuevo
            sql = "INSERT INTO Libro (Cod_Lib, Tit_Lib, Aut_Lib, NoPag_Lib, Edit_Lib, NoEdic_Lib,Temas_Lib,FechaIngreso,Docto_Ing,Id_EstLib) VALUES (@c1, @c2, @c3, @c4, @c5, @c6, @c7,@c8,@c9,@c10)"
            oper = " insertados: "
        Else ' Editar
            sql = "UPDATE Libro SET Cod_Lib=@c1 , Tit_Lib=@c2 , Aut_Lib=@c3 ,NoPag_Lib=@c4,Edit_Lib=@c5, NoEdic_Lib=@c6,Temas_Lib=@c7,FechaIngreso=@c8 ,Docto_Ing=@c9,Id_EstLib=@c10 where Cod_Lib = @c1"
            oper = " modificados: "
        End If
        'Creando comando
        Dim objcomando As New SqlCommand(sql, ModConexion.Conexion)
        Try
            objcomando.Parameters.Add(New SqlParameter("@c1", SqlDbType.VarChar))
            objcomando.Parameters("@c1").Value = TxtCodigo.Text
            objcomando.Parameters.Add(New SqlParameter("@c2", SqlDbType.VarChar))
            objcomando.Parameters("@c2").Value = TxtTitulo.Text
            objcomando.Parameters.Add(New SqlParameter("@c3", SqlDbType.VarChar))
            objcomando.Parameters("@c3").Value = TxtAutor.Text
            objcomando.Parameters.Add(New SqlParameter("@c4", SqlDbType.Int))
            objcomando.Parameters("@c4").Value = TxtNPag.Text
            objcomando.Parameters.Add(New SqlParameter("@c5", SqlDbType.VarChar))
            objcomando.Parameters("@c5").Value = TxtEditorial.Text
            objcomando.Parameters.Add(New SqlParameter("@c6", SqlDbType.VarChar))
            objcomando.Parameters("@c6").Value = TxtEdicion.Text
            objcomando.Parameters.Add(New SqlParameter("@c7", SqlDbType.Text))
            objcomando.Parameters("@c7").Value = TxtTema.Text
            objcomando.Parameters.Add(New SqlParameter("@c9", SqlDbType.Text))
            objcomando.Parameters("@c9").Value = txtDocI.Text
            objcomando.Parameters.Add(New SqlParameter("@c8", SqlDbType.DateTime))
            objcomando.Parameters("@c8").Value = TxtFecReg.Text
            objcomando.Parameters.Add(New SqlParameter("@c10", SqlDbType.Int))
            objcomando.Parameters("@c10").Value = cboEstadoLibro.SelectedValue

            ModConexion.Conexion.Open()
            resultado = objcomando.ExecuteNonQuery
            'Ejecuta una instrucción de Transact-SQL en Connection y devuelve el número de filas afectadas.
            Call Actualizar()
            'Para actualizar posición
            Call NumRegistro()
            MessageBox.Show("Registros " & oper & resultado, "", 0, MessageBoxIcon.Information)
            Call HabilitarControles(True)
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
        Call HabilitarControles(False)
        Call HabilitarBotones(True)
        ModConexion.Conexion.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        ModConexion.Conexion.Open()
        objDataSet.RejectChanges()
        ModConexion.Conexion.Close()
        btnAnterior.PerformClick()
        Call HabilitarControles(False)
        Call HabilitarBotones(True)
        Call LimpiarControles()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim sql3 As String
        sql3 = "delete from Libro where Cod_Lib=@c1"
        Dim objComando As New SqlCommand(sql3, ModConexion.Conexion)
        Try
            objComando.Parameters.Add(New SqlParameter("@c1", SqlDbType.VarChar))
            objComando.Parameters("@c1").Value = InputBox("Ingrese el código del Lector a eliminar: ")
            ModConexion.Conexion.Open()
            resultado = objComando.ExecuteNonQuery
            Call Actualizar()
            btnAnterior.PerformClick() ' Para que muestre el registro anterior luego de eliminar
            MessageBox.Show("Registros Eliminados: " & resultado, "", 0, MessageBoxIcon.Information)
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
        ModConexion.Conexion.Close()
        Call HabilitarControles(False)
        Call HabilitarBotones(True)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim strDato As String
        Dim fila As Integer
        Dim dv As New DataView()
        strDato = InputBox("Ingrese codigo de Libro", "Buscar")
        dv.Table = objDataSet.Tables("Libro")
        dv.Sort = "Cod_Lib"
        fila = dv.Find(strDato)
        If fila = -1 Then
            MessageBox.Show("Codigo de Libro no existe", "Cuidado")
            Exit Sub
        End If
        Me.BindingContext(objDataSet, "Libro").Position = fila
        Call NumRegistro()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        ModConexion.Conexion.Close()
        Me.Close()
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        Me.BindingContext(Me.objDataSet, "Libro").Position = 0
        Call BotonA(False)
        Call BotonB(True)
        Call NumRegistro()
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If Me.BindingContext(objDataSet, "Libro").Position > 0 Then
            Me.BindingContext(objDataSet, "Libro").Position = _
            (Me.BindingContext(objDataSet, "Libro").Position - 1)
            Call BotonB(True)
        Else
            Call BotonA(False)
        End If
        Me.NumRegistro()
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If Me.BindingContext(objDataSet, "Libro").Position < (Me.BindingContext(objDataSet, _
                "Libro").Count - 1) Then
            Me.BindingContext(objDataSet, "Libro").Position = _
            (Me.BindingContext(objDataSet, "Libro").Position + 1)
            Call BotonA(True)
        Else
            Call BotonB(False)
        End If
        Me.NumRegistro()
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        Me.BindingContext(Me.objDataSet, "Libro").Position = _
        (Me.objDataSet.Tables("Libro").Rows.Count - 1)
        Call BotonB(False)
        Call BotonA(True)
        Me.NumRegistro()
    End Sub

End Class
