Imports System.Data.SqlClient
Public Class FrmCarnet
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
    Friend WithEvents lblRegistro As System.Windows.Forms.Label
    Friend WithEvents txtFecVto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCarne As System.Windows.Forms.TextBox
    Friend WithEvents txtFecEx As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboNombre As System.Windows.Forms.ComboBox
    Friend WithEvents cboApellido As System.Windows.Forms.ComboBox
    Friend WithEvents cboCodigo As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCarnet))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCarne = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFecEx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.txtFecVto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboApellido = New System.Windows.Forms.ComboBox()
        Me.cboNombre = New System.Windows.Forms.ComboBox()
        Me.cboCodigo = New System.Windows.Forms.ComboBox()
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
        Me.Label1.Text = "Nro Carne :"
        '
        'txtCarne
        '
        Me.txtCarne.Location = New System.Drawing.Point(348, 16)
        Me.txtCarne.Name = "txtCarne"
        Me.txtCarne.TabIndex = 1
        Me.txtCarne.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Usuario :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellidos :"
        '
        'txtFecEx
        '
        Me.txtFecEx.Location = New System.Drawing.Point(128, 132)
        Me.txtFecEx.Name = "txtFecEx"
        Me.txtFecEx.Size = New System.Drawing.Size(88, 20)
        Me.txtFecEx.TabIndex = 7
        Me.txtFecEx.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha Expedicion :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblRegistro, Me.btnUltimo, Me.btnSiguiente, Me.btnAnterior, Me.btnPrimero})
        Me.GroupBox1.Location = New System.Drawing.Point(24, 200)
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
        Me.GroupBox2.Location = New System.Drawing.Point(24, 260)
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
        'txtFecVto
        '
        Me.txtFecVto.Location = New System.Drawing.Point(128, 168)
        Me.txtFecVto.Name = "txtFecVto"
        Me.txtFecVto.Size = New System.Drawing.Size(88, 20)
        Me.txtFecVto.TabIndex = 13
        Me.txtFecVto.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Fecha Vencimiento"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Codigo Lector :"
        '
        'cboApellido
        '
        Me.cboApellido.Location = New System.Drawing.Point(128, 96)
        Me.cboApellido.Name = "cboApellido"
        Me.cboApellido.Size = New System.Drawing.Size(196, 21)
        Me.cboApellido.TabIndex = 15
        Me.cboApellido.Text = "ComboBox1"
        '
        'cboNombre
        '
        Me.cboNombre.Location = New System.Drawing.Point(128, 68)
        Me.cboNombre.Name = "cboNombre"
        Me.cboNombre.Size = New System.Drawing.Size(124, 21)
        Me.cboNombre.TabIndex = 16
        Me.cboNombre.Text = "ComboBox1"
        '
        'cboCodigo
        '
        Me.cboCodigo.Location = New System.Drawing.Point(128, 40)
        Me.cboCodigo.Name = "cboCodigo"
        Me.cboCodigo.Size = New System.Drawing.Size(124, 21)
        Me.cboCodigo.TabIndex = 17
        Me.cboCodigo.Text = "ComboBox1"
        '
        'FrmCarnet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(484, 354)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboCodigo, Me.cboNombre, Me.cboApellido, Me.Label6, Me.txtFecVto, Me.Label5, Me.GroupBox2, Me.GroupBox1, Me.txtFecEx, Me.Label4, Me.Label3, Me.Label2, Me.txtCarne, Me.Label1})
        Me.Name = "FrmCarnet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCarnet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim daCarne As SqlDataAdapter
    Dim daUsuario As SqlDataAdapter
    Dim objDataSet As DataSet
    Dim flag As Integer
    Dim resultado As Integer
    Dim strCodigo As String
    
    Private Sub FrmActArticulos_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ModConexion.FCARNE = False
    End Sub

    Private Sub FrmCarnet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModConexion.Conexion.Open()
        daCarne = New SqlDataAdapter("SELECT * FROM Carne", ModConexion.Conexion)
        daUsuario = New SqlDataAdapter("select * from OUsuario", ModConexion.Conexion)
        objDataSet = New DataSet()
        daCarne.Fill(objDataSet, "Carne")
        daUsuario.Fill(objDataSet, "OUsuario")
        ModConexion.Conexion.Close()
        ' Enlazando los controles al campo correspondiente
        Me.txtCarne.DataBindings.Add("Text", objDataSet, "Carne.Cod_carne")
        Me.txtFecEx.DataBindings.Add("Text", objDataSet, "Carne.Fecha_Exp")
        Me.txtFecVto.DataBindings.Add("Text", objDataSet, "Carne.Fecha_Vcto")

        Me.cboCodigo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.objDataSet, "Carne.Cod_Usuario"))
        Me.cboCodigo.DataSource = Me.objDataSet.Tables("OUsuario")
        Me.cboCodigo.DisplayMember = "Cod_Usuario"
        Me.cboCodigo.ValueMember = "Cod_Usuario"
        Me.cboCodigo.DropDownStyle = ComboBoxStyle.DropDownList

        Me.cboApellido.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.objDataSet, "Carne.Cod_Usuario"))
        Me.cboApellido.DataSource = Me.objDataSet.Tables("OUsuario")
        Me.cboApellido.DisplayMember = "Apel_Usu"
        Me.cboApellido.ValueMember = "Cod_Usuario"
        Me.cboApellido.DropDownStyle = ComboBoxStyle.DropDownList

        Me.cboNombre.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.objDataSet, "Carne.Cod_Usuario"))
        Me.cboNombre.DataSource = Me.objDataSet.Tables("OUsuario")
        Me.cboNombre.DisplayMember = "Nombre_Usu"
        Me.cboNombre.ValueMember = "Cod_Usuario"
        Me.cboNombre.DropDownStyle = ComboBoxStyle.DropDownList

        Call HabilitarControles(False)
        Call HabilitarBotones(True)

    End Sub
    ' Creando Procedimientos
    Private Sub HabilitarControles(ByVal est As Boolean)
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox Then ctrl.Enabled = est
        Next

        'cboEstadoLibro.Enabled = est
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
        num = Me.BindingContext(objDataSet, "Carne").Position + 1
        total = Me.objDataSet.Tables("carne").Rows.Count
        Me.lblRegistro.Text = "Reg: " & Str(num) & " de " & Str(total)
    End Sub
    Private Sub Actualizar()
        objDataSet.Clear()
        daCarne.Fill(objDataSet, "Carne")
        daUsuario.Fill(objDataSet, "OUsuario")
    End Sub
    Private Sub GeneraCodigo()
        Dim cmd As New SqlCommand("select max(Cod_carne)from Carne", ModConexion.Conexion)
        ModConexion.Conexion.Open()
        strCodigo = cmd.ExecuteScalar
        ModConexion.Conexion.Close()
        txtCarne.Text = Format(Val(strCodigo) + 1, "00000")
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
        cboCodigo.Focus()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        flag = 2
        Call HabilitarControles(True)
        Call HabilitarBotones(False)
        txtCarne.Enabled = False
        cboCodigo.Focus()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim sql, oper As String
        If flag = 1 Then ' Nuevo
            sql = "INSERT INTO Carne (Cod_Carne, Fecha_Exp, Fecha_Vcto, Cod_Usuario)VALUES (@c1, @c2, @c3, @c4)"
            oper = " insertados: "
        Else ' Editar
            sql = "UPDATE Carne SET Cod_Carne=@c1 , Fecha_Exp=@c2 , Fecha_Vcto=@c3 ,Cod_Usuario=@c4 where Cod_Carne = @c1"
            oper = " modificados: "
        End If
        'Creando comando
        Dim objcomando As New SqlCommand(sql, ModConexion.Conexion)
        Try
            objcomando.Parameters.Add(New SqlParameter("@c1", SqlDbType.VarChar))
            objcomando.Parameters("@c1").Value = txtCarne.Text
            objcomando.Parameters.Add(New SqlParameter("@c2", SqlDbType.DateTime))
            objcomando.Parameters("@c2").Value = txtFecEx.Text
            objcomando.Parameters.Add(New SqlParameter("@c3", SqlDbType.DateTime))
            objcomando.Parameters("@c3").Value = txtFecVto.Text
            objcomando.Parameters.Add(New SqlParameter("@c4", SqlDbType.VarChar))
            objcomando.Parameters("@c4").Value = cboCodigo.SelectedValue

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
        sql3 = "delete from Carne where Cod_Carne=@c1"
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
        strDato = InputBox("Ingrese codigo del Carné", "Buscar")
        dv.Table = objDataSet.Tables("Carne")
        dv.Sort = "Cod_carne"
        fila = dv.Find(strDato)
        If fila = -1 Then
            MessageBox.Show("Codigo de Carné no existe", "Cuidado")
            Exit Sub
        End If
        Me.BindingContext(objDataSet, "Carne").Position = fila
        Call NumRegistro()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        ModConexion.Conexion.Close()
        Me.Close()
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        Me.BindingContext(Me.objDataSet, "Carne").Position = 0
        Call BotonA(False)
        Call BotonB(True)
        Call NumRegistro()
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If Me.BindingContext(objDataSet, "Carne").Position > 0 Then
            Me.BindingContext(objDataSet, "Carne").Position = _
            (Me.BindingContext(objDataSet, "Carne").Position - 1)
            Call BotonB(True)
        Else
            Call BotonA(False)
        End If
        Me.NumRegistro()
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If Me.BindingContext(objDataSet, "Carne").Position < (Me.BindingContext(objDataSet, _
                "Carne").Count - 1) Then
            Me.BindingContext(objDataSet, "Carne").Position = _
            (Me.BindingContext(objDataSet, "Carne").Position + 1)
            Call BotonA(True)
        Else
            Call BotonB(False)
        End If
        Me.NumRegistro()
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        Me.BindingContext(Me.objDataSet, "Carne").Position = _
        (Me.objDataSet.Tables("Carne").Rows.Count - 1)
        Call BotonB(False)
        Call BotonA(True)
        Me.NumRegistro()
    End Sub

End Class
