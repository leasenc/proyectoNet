Imports System.Data.SqlClient
Public Class frmBibliotecario
    Inherits System.Windows.Forms.Form
    Dim daEmpleado As SqlDataAdapter
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
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombres As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
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
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBibliotecario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
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
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Label2.Text = "Nombres :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(36, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellidos :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(36, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dirección :"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(36, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Teléfono :"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(292, 0)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.TabIndex = 8
        Me.TxtCodigo.Text = ""
        '
        'TxtNombres
        '
        Me.TxtNombres.Location = New System.Drawing.Point(156, 28)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(236, 20)
        Me.TxtNombres.TabIndex = 9
        Me.TxtNombres.Text = ""
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(156, 52)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(236, 20)
        Me.TxtApellidos.TabIndex = 10
        Me.TxtApellidos.Text = ""
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(156, 76)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(236, 20)
        Me.TxtDireccion.TabIndex = 12
        Me.TxtDireccion.Text = ""
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(156, 100)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(116, 20)
        Me.TxtFecha.TabIndex = 13
        Me.TxtFecha.Text = ""
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(156, 124)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(120, 20)
        Me.TxtTelefono.TabIndex = 14
        Me.TxtTelefono.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblRegistro, Me.btnUltimo, Me.btnSiguiente, Me.btnAnterior, Me.btnPrimero})
        Me.GroupBox1.Location = New System.Drawing.Point(12, 204)
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 288)
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
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(36, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Fecha Ingreso :"
        '
        'frmBibliotecario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(468, 386)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.GroupBox2, Me.GroupBox1, Me.TxtTelefono, Me.TxtFecha, Me.TxtDireccion, Me.TxtApellidos, Me.TxtNombres, Me.TxtCodigo, Me.Label6, Me.Label5, Me.Label3, Me.Label2, Me.Label1})
        Me.Name = "frmBibliotecario"
        Me.Text = "frmBibiliotecario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    

    Private Sub frmActempleados_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ModConexion.FBIBLI = False
    End Sub

    Private Sub frmBibliotecario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModConexion.Conexion.Open()
        daEmpleado = New SqlDataAdapter("SELECT * FROM OEmpleado", ModConexion.Conexion)
        objDataSet = New DataSet()
        daEmpleado.Fill(objDataSet, "OEmpleado")

        ModConexion.Conexion.Close()
        ' Enlazando los controles al campo correspondiente
        Me.TxtCodigo.DataBindings.Add("Text", objDataSet, "OEmpleado.Cod_Emp")
        Me.TxtNombres.DataBindings.Add("Text", objDataSet, "OEmpleado.Nom_Emp")
        Me.TxtApellidos.DataBindings.Add("Text", objDataSet, "OEmpleado.Ape_Emp")
        Me.TxtDireccion.DataBindings.Add("Text", objDataSet, "OEmpleado.Dir_Emp")
        Me.TxtFecha.DataBindings.Add("Text", objDataSet, "OEmpleado.Fecha_Ingreso")
        Me.TxtTelefono.DataBindings.Add("Text", objDataSet, "OEmpleado.Telefono")
        'Me.TxtPassword.DataBindings.Add("Text", objDataSet, "OEmpleado.Password")
        Call HabilitarControles(False)
        Call HabilitarBotones(True)

    End Sub
    ' Creando Procedimientos
    Private Sub HabilitarControles(ByVal est As Boolean)
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox Then ctrl.Enabled = est
        Next

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
        num = Me.BindingContext(objDataSet, "OEmpleado").Position + 1
        total = Me.objDataSet.Tables("OEmpleado").Rows.Count
        Me.lblRegistro.Text = "Reg: " & Str(num) & " de " & Str(total)
    End Sub
    Private Sub Actualizar()
        objDataSet.Clear()
        daEmpleado.Fill(objDataSet, "Libro")

    End Sub
    Private Sub GeneraCodigo()
        Dim cmd As New SqlCommand("select max(Cod_Emp)from OEmpleado", ModConexion.Conexion)
        ModConexion.Conexion.Open()
        strCodigo = cmd.ExecuteScalar
        ModConexion.Conexion.Close()
        TxtCodigo.Text = Format(Val(strCodigo) + 1, "00000")
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
        Call HabilitarControles(True)
        Call HabilitarBotones(False)
        Call LimpiarControles()
        Call GeneraCodigo()
        TxtNombres.Focus()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        flag = 2
        Call HabilitarControles(True)
        Call HabilitarBotones(False)
        TxtCodigo.Enabled = False
        TxtNombres.Focus()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim sql, oper As String
        If flag = 1 Then ' Nuevo
            sql = "INSERT INTO OEmpleado (Cod_Emp, Nom_Emp,Ape_Emp, Dir_Emp, Fecha_Ingreso, Telefono)VALUES (@c1, @c2, @c3, @c4, @c5, @c6)"
            oper = " insertados: "
        Else ' Editar
            sql = "UPDATE OEmpleado SET Cod_Emp=@c1 , Nom_Emp=@c2 , Ape_Emp=@c3,Dir_Emp=@c4 ,Fecha_Ingreso=@c5,Telefono=@c6"
            oper = " modificados: "
        End If
        'Creando comando
        Dim objcomando As New SqlCommand(sql, ModConexion.Conexion)
        Try
            objcomando.Parameters.Add(New SqlParameter("@c1", SqlDbType.VarChar))
            objcomando.Parameters("@c1").Value = TxtCodigo.Text
            objcomando.Parameters.Add(New SqlParameter("@c2", SqlDbType.VarChar))
            objcomando.Parameters("@c2").Value = TxtNombres.Text
            objcomando.Parameters.Add(New SqlParameter("@c3", SqlDbType.VarChar))
            objcomando.Parameters("@c3").Value = TxtApellidos.Text
            objcomando.Parameters.Add(New SqlParameter("@c4", SqlDbType.VarChar))
            objcomando.Parameters("@c4").Value = TxtDireccion.Text
            objcomando.Parameters.Add(New SqlParameter("@c5", SqlDbType.VarChar))
            objcomando.Parameters("@c5").Value = txtFecha.Text
            objcomando.Parameters.Add(New SqlParameter("@c6", SqlDbType.VarChar))
            objcomando.Parameters("@c6").Value = TxtTelefono.Text
            

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
        sql3 = "delete from OEmpleado where Cod_Emp=@c1"
        Dim objComando As New SqlCommand(sql3, ModConexion.Conexion)
        Try
            objComando.Parameters.Add(New SqlParameter("@c1", SqlDbType.VarChar))
            objComando.Parameters("@c1").Value = InputBox("Ingrese el código del Bibliotecario a eliminar: ")
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
        strDato = InputBox("Ingrese codigo de Bibliotecario", "Buscar")
        dv.Table = objDataSet.Tables("OEmpleado")
        dv.Sort = "Cod_Emp"
        fila = dv.Find(strDato)
        If fila = -1 Then
            MessageBox.Show("Codigo de Bibliotecario no existe", "Cuidado")
            Exit Sub
        End If
        Me.BindingContext(objDataSet, "OEmpleado").Position = fila
        Call NumRegistro()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        ModConexion.Conexion.Close()
        Me.Close()
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        Me.BindingContext(Me.objDataSet, "OEmpleado").Position = 0
        Call BotonA(False)
        Call BotonB(True)
        Call NumRegistro()
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If Me.BindingContext(objDataSet, "OEmpleado").Position > 0 Then
            Me.BindingContext(objDataSet, "OEmpleado").Position = _
            (Me.BindingContext(objDataSet, "OEmpleado").Position - 1)
            Call BotonB(True)
        Else
            Call BotonA(False)
        End If
        Me.NumRegistro()
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If Me.BindingContext(objDataSet, "OEmpleado").Position < (Me.BindingContext(objDataSet, _
                "OEmpleado").Count - 1) Then
            Me.BindingContext(objDataSet, "OEmpleado").Position = _
            (Me.BindingContext(objDataSet, "OEmpleado").Position + 1)
            Call BotonA(True)
        Else
            Call BotonB(False)
        End If
        Me.NumRegistro()
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        Me.BindingContext(Me.objDataSet, "OEmpleado").Position = _
        (Me.objDataSet.Tables("OEmpleado").Rows.Count - 1)
        Call BotonB(False)
        Call BotonA(True)
        Me.NumRegistro()
    End Sub

End Class
