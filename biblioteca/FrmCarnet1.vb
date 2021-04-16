Imports System.Data.SqlClient
Public Class FrmCarnet1
    Inherits System.Windows.Forms.Form
    Const spExploracion = "Carnet de Lector: Exploración de registros"
    Const spNuevo = "Carnet de Lector: Nuevo Registro"
    Const spModificacion = "Carnet de Lector: Modificación del Registro"
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCarnet1))
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
        Me.btnGuardar.Location = New System.Drawing.Point(120, 16)
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
        'FrmCarnet1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(484, 354)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboCodigo, Me.cboNombre, Me.cboApellido, Me.Label6, Me.txtFecVto, Me.Label5, Me.GroupBox2, Me.GroupBox1, Me.txtFecEx, Me.Label4, Me.Label3, Me.Label2, Me.txtCarne, Me.Label1})
        Me.Name = "FrmCarnet1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCarnet1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmActArticulos_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ModConexion.FCARNE = False
    End Sub

    Private Sub FrmLector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModConexion.Conexion.Open()
        TableName = "Carne"
        SQLAdapter_Master = New SqlDataAdapter("SELECT * FROM Carne", ModConexion.Conexion)
        SQLAdapter_Sec1 = New SqlDataAdapter("SELECT * FROM OUsuario", ModConexion.Conexion)
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
        txtCarne.Enabled = False
        txtFecEx.Enabled = (stStatus = 1) Or (stStatus = 2)
        txtFecVto.Enabled = (stStatus = 1) Or (stStatus = 2)
        cboCodigo.Enabled = (stStatus = 1) Or (stStatus = 2)
        cboNombre.Enabled = (stStatus = 1) Or (stStatus = 2)
        cboApellido.Enabled = (stStatus = 1) Or (stStatus = 2)

        Select Case stStatus
            Case 1 'Agregando nuevo registro
                Me.Text = spNuevo
                txtCarne.Text = "<Autogenerado>"
                txtFecEx.Text = ""
                txtFecVto.Text = ""
                cboCodigo.Text = ""
                txtCarne.Focus()
            Case 2 'Modificando registro
                Me.Text = spModificacion
                txtCarne.Focus()
            Case Else ' Exploracion de datos
                Me.Text = spExploracion
        End Select
    End Sub
    Private Sub FrmActClientes_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ModConexion.FLEC = False
    End Sub
    Private Sub RefillDatasets()
        DataSet_Master.Clear()
        SQLAdapter_Sec1.Fill(DataSet_Master, "OUsuario")
        SQLAdapter_Master.Fill(DataSet_Master, TableName)
    End Sub

    Private Sub EnlazaControles()

        Me.txtCarne.DataBindings.Add("Text", DataSet_Master, "Carne.Cod_carne")
        Me.txtFecEx.DataBindings.Add("Text", DataSet_Master, "Carne.Fecha_Exp")
        Me.txtFecVto.DataBindings.Add("Text", DataSet_Master, "Carne.Fecha_Vcto")

        Me.cboCodigo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet_Master, "Carne.Cod_Usuario"))
        Me.cboCodigo.DataSource = Me.DataSet_Master.Tables("OUsuario")
        Me.cboCodigo.DisplayMember = "Cod_Usuario"
        Me.cboCodigo.ValueMember = "Cod_Usuario"
        Me.cboCodigo.DropDownStyle = ComboBoxStyle.DropDownList

        Me.cboApellido.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet_Master, "Carne.Cod_Usuario"))
        Me.cboApellido.DataSource = Me.DataSet_Master.Tables("OUsuario")
        Me.cboApellido.DisplayMember = "Apel_Usu"
        Me.cboApellido.ValueMember = "Cod_Usuario"
        Me.cboApellido.DropDownStyle = ComboBoxStyle.DropDownList

        Me.cboNombre.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet_Master, "Carne.Cod_Usuario"))
        Me.cboNombre.DataSource = Me.DataSet_Master.Tables("OUsuario")
        Me.cboNombre.DisplayMember = "Nombre_Usu"
        Me.cboNombre.ValueMember = "Cod_Usuario"
        Me.cboNombre.DropDownStyle = ComboBoxStyle.DropDownList
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
            oCMD = NewComando(oCNN, "InsertCarne", CommandType.StoredProcedure)
            oPRM = NewParameter("FechaExp", True, SqlDbType.DateTime, 8, txtFecEx.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("FechaVcto", True, SqlDbType.DateTime, 8, txtFecVto.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("CodigoUsu", True, SqlDbType.Int, 4, cboCodigo.SelectedValue)
            oCMD.Parameters.Add(oPRM)
        Else
            oCMD = NewComando(oCNN, "ActualizarCarne", CommandType.StoredProcedure)
            oPRM = NewParameter("Cod_Carne", True, SqlDbType.Int, 4, txtCarne.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("FechaExp", True, SqlDbType.DateTime, 8, txtFecEx.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("FechaVcto", True, SqlDbType.DateTime, 8, txtFecVto.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("CodigoUsu", True, SqlDbType.Int, 4, cboCodigo.SelectedValue)
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
        Dim cmd As New SqlCommand("select max(Cod_Carne)from Carne", ModConexion.Conexion)
        Dim strCodigo As String
        ModConexion.Conexion.Open()
        strCodigo = cmd.ExecuteScalar
        ModConexion.Conexion.Close()
        txtCarne.Text = Format(Val(strCodigo) + 1)
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim sql3 As String
        Dim resultado As String
        sql3 = "delete from Carne where Cod_Carne=@c1"
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
        strDato = InputBox("Ingrese Carnet del Usuario", "Buscar")
        Call MueveCursorA("Cod_Carne", strDato, "Carnet de Usuario no existe")
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim cod As Integer
        cod = ActualizarBaseDeDatos(spNuevo = Me.Text)
        If cod <> 0 Then
            Actualizar()
            Call MueveCursorA("Cod_Carne", Str(cod), "")
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
