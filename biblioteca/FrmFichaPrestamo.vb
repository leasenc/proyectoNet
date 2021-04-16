Imports System.Data.SqlClient
Public Class FrmFichaPrestamo
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFecP As System.Windows.Forms.TextBox
    Friend WithEvents txtFecD As System.Windows.Forms.TextBox
    Friend WithEvents TxtFecDR As System.Windows.Forms.TextBox
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents cboLibro As System.Windows.Forms.ComboBox
    Friend WithEvents cbotitulo As System.Windows.Forms.ComboBox
    Friend WithEvents cboAutor As System.Windows.Forms.ComboBox
    Friend WithEvents cboCarne As System.Windows.Forms.ComboBox
    Friend WithEvents cboEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmFichaPrestamo))
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
        Me.txtFecD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtFecDR = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
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
        Me.GroupBox1.Location = New System.Drawing.Point(20, 272)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 52)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
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
        Me.GroupBox2.Location = New System.Drawing.Point(24, 328)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 64)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
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
        Me.txtFecP.Location = New System.Drawing.Point(152, 192)
        Me.txtFecP.Name = "txtFecP"
        Me.txtFecP.TabIndex = 13
        Me.txtFecP.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(20, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Fecha Prestamo :"
        '
        'txtFecD
        '
        Me.txtFecD.Location = New System.Drawing.Point(152, 220)
        Me.txtFecD.Name = "txtFecD"
        Me.txtFecD.TabIndex = 15
        Me.txtFecD.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(20, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Fecha DevEstimada :"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "¿Se presta? :"
        '
        'TxtFecDR
        '
        Me.TxtFecDR.Location = New System.Drawing.Point(152, 248)
        Me.TxtFecDR.Name = "TxtFecDR"
        Me.TxtFecDR.TabIndex = 19
        Me.TxtFecDR.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(20, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Fecha Devolucion :"
        '
        'chkEstado
        '
        Me.chkEstado.Location = New System.Drawing.Point(152, 168)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(108, 20)
        Me.chkEstado.TabIndex = 20
        Me.chkEstado.Text = "CheckBox1"
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
        Me.cboEmpleado.Location = New System.Drawing.Point(400, 187)
        Me.cboEmpleado.Name = "cboEmpleado"
        Me.cboEmpleado.Size = New System.Drawing.Size(76, 21)
        Me.cboEmpleado.TabIndex = 26
        Me.cboEmpleado.Text = "ComboBox1"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(284, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Cod Empleado"
        '
        'FrmFichaPrestamo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(484, 394)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboEmpleado, Me.Label10, Me.cboCarne, Me.cboAutor, Me.cbotitulo, Me.cboLibro, Me.chkEstado, Me.TxtFecDR, Me.Label9, Me.Label8, Me.txtFecD, Me.Label7, Me.txtFecP, Me.Label6, Me.GroupBox2, Me.GroupBox1, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.txtCodigo, Me.Label1})
        Me.Name = "FrmFichaPrestamo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmFichaPrestamo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim daCarne As SqlDataAdapter
    Dim daFicha As SqlDataAdapter
    Dim daEmpleado As SqlDataAdapter
    Dim daLibro As SqlDataAdapter
    Dim objDataSet As DataSet
    Dim flag As Integer
    Dim resultado As Integer
    Dim strCodigo As String
    
    Private Sub FrmActClientes_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ModConexion.FFPT = False
    End Sub

    Private Sub FrmFichaPrestamo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModConexion.Conexion.Open()
        daEmpleado = New SqlDataAdapter("SELECT * FROM OEmpleado", ModConexion.Conexion)
        daFicha = New SqlDataAdapter("select * from OFicha_de_Prestamo", ModConexion.Conexion)
        daCarne = New SqlDataAdapter("SELECT * FROM Carne", ModConexion.Conexion)
        daLibro = New SqlDataAdapter("SELECT * FROM Libro", ModConexion.Conexion)
        objDataSet = New DataSet()
        daEmpleado.Fill(objDataSet, "OEmpleado")
        daFicha.Fill(objDataSet, "OFicha_de_Prestamo")
        daCarne.Fill(objDataSet, "Carne")
        daLibro.Fill(objDataSet, "Libro")
        ModConexion.Conexion.Close()
        ' Enlazando los controles al campo correspondiente
        Me.txtCodigo.DataBindings.Add("Text", objDataSet, "OFicha_de_Prestamo.Nro_Ficha")
        Me.txtFecP.DataBindings.Add("Text", objDataSet, "OFicha_de_Prestamo.Fecha_ptmo")
        Me.TxtFecD.DataBindings.Add("Text", objDataSet, "OFicha_de_Prestamo.Fecha_Dev")
        Me.chkEstado.DataBindings.Add("checked", objDataSet, "OFicha_de_Prestamo.EstPtmo")
        Me.TxtFecDR.DataBindings.Add("Text", objDataSet, "OFicha_de_Prestamo.Fech_DevReal")
        
        Me.cboLibro.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.objDataSet, "OFicha_de_Prestamo.Cod_Lib"))
        Me.cboLibro.DataSource = Me.objDataSet.Tables("Libro")
        Me.cboLibro.DisplayMember = "Cod_Lib"
        Me.cboLibro.ValueMember = "Cod_Lib"
        Me.cboLibro.DropDownStyle = ComboBoxStyle.DropDownList

        Me.cbotitulo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.objDataSet, "OFicha_de_Prestamo.Cod_Lib"))
        Me.cbotitulo.DataSource = Me.objDataSet.Tables("Libro")
        Me.cbotitulo.DisplayMember = "Tit_Lib"
        Me.cbotitulo.ValueMember = "Cod_Lib"
        Me.cbotitulo.DropDownStyle = ComboBoxStyle.DropDownList

        Me.cboAutor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.objDataSet, "OFicha_de_Prestamo.Cod_Lib"))
        Me.cboAutor.DataSource = Me.objDataSet.Tables("Libro")
        Me.cboAutor.DisplayMember = "Aut_Lib"
        Me.cboAutor.ValueMember = "Cod_Lib"
        Me.cboAutor.DropDownStyle = ComboBoxStyle.DropDownList

        Me.cboCarne.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.objDataSet, "OFicha_de_Prestamo.Cod_Carne"))
        Me.cboCarne.DataSource = Me.objDataSet.Tables("Carne")
        Me.cboCarne.DisplayMember = "Cod_carne"
        Me.cboCarne.ValueMember = "Cod_carne"
        Me.cboCarne.DropDownStyle = ComboBoxStyle.DropDownList

        Me.cboEmpleado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.objDataSet, "OFicha_de_Prestamo.Cod_Emp"))
        Me.cboEmpleado.DataSource = Me.objDataSet.Tables("OEmpleado")
        Me.cboEmpleado.DisplayMember = "Cod_Emp"
        Me.cboEmpleado.ValueMember = "Cod_Emp"
        Me.cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList
        Call NumRegistro()
        Call HabilitarControles(False)
        Call HabilitarBotones(True)
        Call Me.chkEstado_CheckedChanged(sender, e)
    End Sub
    ' Creando Procedimientos
    Private Sub HabilitarControles(ByVal est As Boolean)
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox Then ctrl.Enabled = est
        Next
        chkEstado.Enabled = est
        cboLibro.Enabled = est
        cbotitulo.Enabled = est
        cboAutor.Enabled = est
        cboCarne.Enabled = est
        cboEmpleado.Enabled = est
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
        num = Me.BindingContext(objDataSet, "OFicha_de_Prestamo").Position + 1
        total = Me.objDataSet.Tables("OFicha_de_Prestamo").Rows.Count
        Me.lblRegistro.Text = "Reg: " & Str(num) & " de " & Str(total)
    End Sub
    Private Sub Actualizar()
        objDataSet.Clear()
        daEmpleado.Fill(objDataSet, "OEmpleado")
        daFicha.Fill(objDataSet, "OFicha_de_Prestamo")
        daCarne.Fill(objDataSet, "Carne")
        daLibro.Fill(objDataSet, "Libro")
    End Sub
    Private Sub GeneraCodigo()
        Dim cmd As New SqlCommand("select max(Nro_Ficha)from OFicha_de_Prestamo", ModConexion.Conexion)
        ModConexion.Conexion.Open()
        strCodigo = cmd.ExecuteScalar
        ModConexion.Conexion.Close()
        txtCodigo.Text = Format(Val(strCodigo) + 1)
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
        txtCodigo.Enabled = False
        cboLibro.Focus()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        flag = 2
        Call HabilitarControles(True)
        Call HabilitarBotones(False)
        txtCodigo.Enabled = False
        cboLibro.Focus()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim sql, oper As String
        If flag = 1 Then ' Nuevo
            sql = "INSERT INTO OFicha_de_Prestamo (Nro_Ficha, Cod_Lib, Cod_carne, Cod_emp, Fecha_ptmo, Fecha_Dev, Fech_DevReal,EstPtmo)VALUES (@c1, @c2, @c3, @c4, @c5, @c6, @c7,@c8)"
            oper = " insertados: "
        Else ' Editar
            sql = "UPDATE OFicha_de_Prestamo SET Nro_Ficha=@c1,Cod_Lib=@c2 ,Cod_carne=@c3 , Cod_emp=@c4 ,Fecha_ptmo=@c5 , Fecha_Dev=@c6,Fech_DevReal=@c7,EstPtmo=@c8 where Nro_Ficha = @c1"
            oper = " modificados: "
        End If
        'Creando comando
        Dim objcomando As New SqlCommand(sql, ModConexion.Conexion)
        Try
            objcomando.Parameters.Add(New SqlParameter("@c1", SqlDbType.VarChar))
            objcomando.Parameters("@c1").Value = txtCodigo.Text
            objcomando.Parameters.Add(New SqlParameter("@c2", SqlDbType.VarChar))
            objcomando.Parameters("@c2").Value = cboLibro.Text
            objcomando.Parameters.Add(New SqlParameter("@c3", SqlDbType.VarChar))
            objcomando.Parameters("@c3").Value = cboCarne.Text
            objcomando.Parameters.Add(New SqlParameter("@c4", SqlDbType.VarChar))
            objcomando.Parameters("@c4").Value = cboEmpleado.Text
            objcomando.Parameters.Add(New SqlParameter("@c5", SqlDbType.DateTime))
            objcomando.Parameters("@c5").Value = txtFecP.Text
            objcomando.Parameters.Add(New SqlParameter("@c6", SqlDbType.DateTime))
            objcomando.Parameters("@c6").Value = txtFecD.Text
            objcomando.Parameters.Add(New SqlParameter("@c7", SqlDbType.DateTime))
            objcomando.Parameters("@c7").Value = TxtFecDR.Text
            objcomando.Parameters.Add(New SqlParameter("@c8", SqlDbType.Bit))
            objcomando.Parameters("@c8").Value = chkEstado.CheckState
            ModConexion.Conexion.Open()
            resultado = objcomando.ExecuteNonQuery
            'Ejecuta una instrucción de Transact-SQL en Connection y devuelve el número de filas afectadas.
            Call Actualizar()
            'Para actualizar posición
            Call NumRegistro()
            MessageBox.Show("Registros " & oper & resultado, "", 0, MessageBoxIcon.Information)
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
        sql3 = "delete from OFicha_de_Prestamo where Nro_Ficha=@c1"
        Dim objComando As New SqlCommand(sql3, ModConexion.Conexion)
        Try
            objComando.Parameters.Add(New SqlParameter("@C1", SqlDbType.VarChar))
            objComando.Parameters("@c1").Value = InputBox("Ingrese Ficha de Prestamo a eliminar: ")
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
        strDato = InputBox("Ingrese Ficha de Prestamo", "Buscar")
        dv.Table = objDataSet.Tables("OFicha_de_Prestamo")
        dv.Sort = "Nro_Ficha"
        fila = dv.Find(strDato)
        If fila = -1 Then
            MessageBox.Show("Ficha de Prestamo no existe", "Cuidado")
            Exit Sub
        End If
        Me.BindingContext(objDataSet, "OFicha_de_Prestamo").Position = fila
        Call NumRegistro()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        ModConexion.Conexion.Close()
        Me.Close()
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        Me.BindingContext(Me.objDataSet, "OFicha_de_Prestamo").Position = 0
        Call BotonA(False)
        Call BotonB(True)
        Call NumRegistro()
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If Me.BindingContext(objDataSet, "OFicha_de_Prestamo").Position > 0 Then
            Me.BindingContext(objDataSet, "OFicha_de_Prestamo").Position = _
            (Me.BindingContext(objDataSet, "OFicha_de_Prestamo").Position - 1)
            Call BotonB(True)
        Else
            Call BotonA(False)
        End If
        Me.NumRegistro()
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If Me.BindingContext(objDataSet, "OFicha_de_Prestamo").Position < (Me.BindingContext(objDataSet, _
                "OFicha_de_Prestamo").Count - 1) Then
            Me.BindingContext(objDataSet, "OFicha_de_Prestamo").Position = _
            (Me.BindingContext(objDataSet, "OFicha_de_Prestamo").Position + 1)
            Call BotonA(True)
        Else
            Call BotonB(False)
        End If
        Me.NumRegistro()
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        Me.BindingContext(Me.objDataSet, "OFicha_de_Prestamo").Position = _
        (Me.objDataSet.Tables("OFicha_de_Prestamo").Rows.Count - 1)
        Call BotonB(False)
        Call BotonA(True)
        Me.NumRegistro()
    End Sub

    Private Sub chkEstado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEstado.CheckedChanged
        If Me.chkEstado.Checked = False Then
            Me.chkEstado.Text = "No"
        Else
            Me.chkEstado.Text = "Si"
        End If
    End Sub


End Class
