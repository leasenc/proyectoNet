Imports System.Data.SqlClient
Public Class FrmLector
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
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblRegistro As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFacultad As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoLector As System.Windows.Forms.ComboBox
    Friend WithEvents txtObserv As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmLector))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFacultad = New System.Windows.Forms.TextBox()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboTipoLector = New System.Windows.Forms.ComboBox()
        Me.txtObserv = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.Label1.Text = "Código :"
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
        Me.Label2.Location = New System.Drawing.Point(40, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombres :"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(128, 56)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(140, 20)
        Me.txtNombres.TabIndex = 3
        Me.txtNombres.Text = ""
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(128, 84)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(216, 20)
        Me.TxtApellidos.TabIndex = 5
        Me.TxtApellidos.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(40, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellidos :"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(128, 112)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(324, 20)
        Me.txtDireccion.TabIndex = 7
        Me.txtDireccion.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(40, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dirección :"
        '
        'txtFacultad
        '
        Me.txtFacultad.Location = New System.Drawing.Point(128, 140)
        Me.txtFacultad.Name = "txtFacultad"
        Me.txtFacultad.TabIndex = 9
        Me.txtFacultad.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(40, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Facultad:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblRegistro, Me.btnUltimo, Me.btnSiguiente, Me.btnAnterior, Me.btnPrimero})
        Me.GroupBox1.Location = New System.Drawing.Point(16, 260)
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 336)
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
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(40, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tipo Lector:"
        '
        'cboTipoLector
        '
        Me.cboTipoLector.Location = New System.Drawing.Point(128, 168)
        Me.cboTipoLector.Name = "cboTipoLector"
        Me.cboTipoLector.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoLector.TabIndex = 13
        Me.cboTipoLector.Text = "ComboBox1"
        '
        'txtObserv
        '
        Me.txtObserv.Location = New System.Drawing.Point(128, 200)
        Me.txtObserv.Multiline = True
        Me.txtObserv.Name = "txtObserv"
        Me.txtObserv.Size = New System.Drawing.Size(212, 48)
        Me.txtObserv.TabIndex = 15
        Me.txtObserv.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(40, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Observaciones ::"
        '
        'FrmLector
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(484, 406)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtObserv, Me.Label7, Me.cboTipoLector, Me.Label6, Me.GroupBox2, Me.GroupBox1, Me.txtFacultad, Me.Label5, Me.txtDireccion, Me.Label4, Me.TxtApellidos, Me.Label3, Me.txtNombres, Me.Label2, Me.txtCodigo, Me.Label1})
        Me.Name = "FrmLector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim daLector As SqlDataAdapter
    Dim daTipoLector As SqlDataAdapter
    Dim objDataSet As DataSet
    Dim flag As Integer
    Dim resultado As Integer
    Dim strCodigo As String
    
    Private Sub FrmActClientes_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ModConexion.FLEC = False
    End Sub

    Private Sub FrmLector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModConexion.Conexion.Open()
        daLector = New SqlDataAdapter("SELECT * FROM OUsuario", ModConexion.Conexion)
        daTipoLector = New SqlDataAdapter("select * from Tipo_Usuario", ModConexion.Conexion)
        objDataSet = New DataSet()
        daLector.Fill(objDataSet, "OUsuario")
        daTipoLector.Fill(objDataSet, "Tipo_Usuario")
        ModConexion.Conexion.Close()
        ' Enlazando los controles al campo correspondiente
        Me.txtCodigo.DataBindings.Add("Text", objDataSet, "OUsuario.Cod_Usuario")
        Me.txtNombres.DataBindings.Add("Text", objDataSet, "OUsuario.Nombre_usu")
        Me.TxtApellidos.DataBindings.Add("Text", objDataSet, "OUsuario.Apel_Usu")
        Me.txtDireccion.DataBindings.Add("Text", objDataSet, "OUsuario.Dir_Usu")
        Me.txtFacultad.DataBindings.Add("Text", objDataSet, "OUsuario.Facultad")
        Me.txtObserv.DataBindings.Add("Text", objDataSet, "OUsuario.Observaciones")
        Me.cboTipoLector.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.objDataSet, "OUsuario.Id_Usu"))
        Me.cboTipoLector.DataSource = Me.objDataSet.Tables("Tipo_Usuario")
        Me.cboTipoLector.DisplayMember = "Descrip_Usu"
        Me.cboTipoLector.ValueMember = "Id_Usu"
        Me.cboTipoLector.DropDownStyle = ComboBoxStyle.DropDownList
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
       
        cboTipoLector.Enabled = est
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
        num = Me.BindingContext(objDataSet, "OUsuario").Position + 1
        total = Me.objDataSet.Tables("OUsuario").Rows.Count
        Me.lblRegistro.Text = "Reg: " & Str(num) & " de " & Str(total)
    End Sub
    Private Sub Actualizar()
        objDataSet.Clear()
        daLector.Fill(objDataSet, "OUsuario")
        daTipoLector.Fill(objDataSet, "Tipo_Usuario")
    End Sub
    Private Sub GeneraCodigo()
        Dim cmd As New SqlCommand("select max(Cod_Usuario)from OUsuario", ModConexion.Conexion)
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
        txtNombres.Focus()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        flag = 2
        Call HabilitarControles(True)
        Call HabilitarBotones(False)
        txtCodigo.Enabled = False
        txtNombres.Focus()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim sql, oper As String
        If flag = 1 Then ' Nuevo
            sql = "INSERT INTO OUsuario (Cod_Usuario, Nombre_Usu, Apel_Usu, Dir_Usu, Facultad, Observaciones, Id_Usu)VALUES (@c1, @c2, @c3, @c4, @c5, @c6, @c7)"
            oper = " insertados: "
        Else ' Editar
            sql = "UPDATE OUsuario SET Cod_Usuario=@c1 , Nombre_usu=@c2 , Apel_usu=@c3 ,Dir_Usu=@c4,Facultad=@c5, Observaciones=@c6 ,Id_Usu=@c7 where Cod_Usuario = @c1"
            oper = " modificados: "
        End If
        'Creando comando
        Dim objcomando As New SqlCommand(sql, ModConexion.Conexion)
        Try
            objcomando.Parameters.Add(New SqlParameter("@c1", SqlDbType.VarChar))
            objcomando.Parameters("@c1").Value = txtCodigo.Text
            objcomando.Parameters.Add(New SqlParameter("@c2", SqlDbType.VarChar))
            objcomando.Parameters("@c2").Value = txtNombres.Text
            objcomando.Parameters.Add(New SqlParameter("@c3", SqlDbType.VarChar))
            objcomando.Parameters("@c3").Value = TxtApellidos.Text
            objcomando.Parameters.Add(New SqlParameter("@c4", SqlDbType.VarChar))
            objcomando.Parameters("@c4").Value = txtDireccion.Text
            objcomando.Parameters.Add(New SqlParameter("@c5", SqlDbType.VarChar))
            objcomando.Parameters("@c5").Value = txtFacultad.Text
            objcomando.Parameters.Add(New SqlParameter("@c6", SqlDbType.NText))
            objcomando.Parameters("@c6").Value = txtObserv.Text
            objcomando.Parameters.Add(New SqlParameter("@c7", SqlDbType.Int))
            objcomando.Parameters("@c7").Value = cboTipoLector.SelectedValue
            
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
        sql3 = "delete from OUsuario where Cod_usuario=@c1"
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
        strDato = InputBox("Ingrese codigo de Lector", "Buscar")
        dv.Table = objDataSet.Tables("OUsuario")
        dv.Sort = "Cod_Usuario"
        fila = dv.Find(strDato)
        If fila = -1 Then
            MessageBox.Show("Codigo de Lector no existe", "Cuidado")
            Exit Sub
        End If
        Me.BindingContext(objDataSet, "OUsuario").Position = fila
        Call NumRegistro()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        ModConexion.Conexion.Close()
        Me.Close()
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        Me.BindingContext(Me.objDataSet, "OUsuario").Position = 0
        Call BotonA(False)
        Call BotonB(True)
        Call NumRegistro()
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If Me.BindingContext(objDataSet, "OUsuario").Position > 0 Then
            Me.BindingContext(objDataSet, "OUsuario").Position = _
            (Me.BindingContext(objDataSet, "OUsuario").Position - 1)
            Call BotonB(True)
        Else
            Call BotonA(False)
        End If
        Me.NumRegistro()
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If Me.BindingContext(objDataSet, "OUsuario").Position < (Me.BindingContext(objDataSet, _
                "OUsuario").Count - 1) Then
            Me.BindingContext(objDataSet, "OUsuario").Position = _
            (Me.BindingContext(objDataSet, "OUsuario").Position + 1)
            Call BotonA(True)
        Else
            Call BotonB(False)
        End If
        Me.NumRegistro()
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        Me.BindingContext(Me.objDataSet, "OUsuario").Position = _
        (Me.objDataSet.Tables("OUsuario").Rows.Count - 1)
        Call BotonB(False)
        Call BotonA(True)
        Me.NumRegistro()
    End Sub

End Class
