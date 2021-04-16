Imports System.Data.SqlClient
Public Class FrmTipoUsuario
    Inherits System.Windows.Forms.Form
    Const spExploracion = "Tipo de Lector : Exploración de registros"
    Const spNuevo = "Tipo de Lector: Nuevo Registro"
    Const spModificacion = "Tipo de Lector : Modificación del Registro"
    Private TableName As String
    Dim SQLAdapter_Master As SqlDataAdapter
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
    Friend WithEvents lblRegistro As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTipoUsuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Lector :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(216, 20)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripcion Tipo  de Lector :"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(216, 56)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(140, 20)
        Me.txtNombres.TabIndex = 3
        Me.txtNombres.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblRegistro, Me.btnUltimo, Me.btnSiguiente, Me.btnAnterior, Me.btnPrimero})
        Me.GroupBox1.Location = New System.Drawing.Point(16, 108)
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
        Me.GroupBox2.Location = New System.Drawing.Point(16, 176)
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
        'FrmTipoUsuario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(484, 270)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox2, Me.GroupBox1, Me.txtNombres, Me.Label2, Me.txtCodigo, Me.Label1})
        Me.Name = "FrmTipoUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTipoLector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Dim daCliente As SqlDataAdapter
    'Dim objDataSet As DataSet
    'Dim flag As Integer
    'Dim resultado As Integer
    'Dim strCodigo As String

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
        txtNombres.Enabled = (stStatus = 1) Or (stStatus = 2)
        Select Case stStatus
            Case 1 'Agregando nuevo registro
                Me.Text = spNuevo
                txtCodigo.Text = "<Autogenerado>"
                txtNombres.Text = ""
                txtNombres.Focus()
            Case 2 'Modificando registro
                Me.Text = spModificacion
                txtNombres.Focus()
            Case Else ' Exploracion de datos
                Me.Text = spExploracion
        End Select
    End Sub

    Private Sub FrmActClientes_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ModConexion.FTLEC = False
    End Sub
    Private Sub EnlazaControles()
        ' Enlazando los controles al campo correspondiente
        Me.txtCodigo.DataBindings.Add("Text", DataSet_Master, "Tipo_Usuario.Id_Usu")
        Me.txtNombres.DataBindings.Add("Text", DataSet_Master, "Tipo_Usuario.Descrip_Usu")
    End Sub

    Private Sub FrmTipoLector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModConexion.Conexion.Open()
        TableName = "Tipo_Usuario"
        SQLAdapter_Master = New SqlDataAdapter("SELECT * FROM Tipo_Usuario", ModConexion.Conexion)
        DataSet_Master = New DataSet()
        Call Actualizar()
        ModConexion.Conexion.Close()
        Call EnlazaControles()
        Call NumRegistro(TableName)
        Call ConfiguraControles(0)
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
            oCMD = NewComando(oCNN, "InsertTipoUsuario", CommandType.StoredProcedure)
            oPRM = NewParameter("Descrip_Usu", True, SqlDbType.VarChar, 20, txtNombres.Text)
            oCMD.Parameters.Add(oPRM)
        Else
            oCMD = NewComando(oCNN, "ActualizarTipoUsuario", CommandType.StoredProcedure)
            oPRM = NewParameter("Id_Usu", True, SqlDbType.Int, 4, txtCodigo.Text)
            oCMD.Parameters.Add(oPRM)
            oPRM = NewParameter("DUsu", True, SqlDbType.VarChar, 20, txtNombres.Text)
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
        Dim cmd As New SqlCommand("select max(Id_Usu)from Tipo_Usuario", ModConexion.Conexion)
        Dim strCodigo As String
        ModConexion.Conexion.Open()
        strCodigo = cmd.ExecuteScalar
        ModConexion.Conexion.Close()
        txtCodigo.Text = Format(Val(strCodigo) + 1)
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim sql3 As String
        Dim resultado As String
        sql3 = "delete from Tipo_Usuario where Id_Usu=@c1"
        Dim objComando As New SqlCommand(sql3, ModConexion.Conexion)
        Try
            objComando.Parameters.Add(New SqlParameter("@c1", SqlDbType.Int))
            objComando.Parameters("@c1").Value = InputBox("Ingrese el Tipo de Usuario a eliminar: ")
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
        strDato = InputBox("Ingrese Tipo de Usuario", "Buscar")
        Call MueveCursorA("Id_Usu", strDato, "Tipo de Usuario no existe")
    End Sub


    ' Codigo totalmente reutilizable (Copiar Pegar a form similares)
    Private Sub NumRegistro(ByVal iTableName As String)
        Dim num, total As Integer
        num = Me.BindingContext(DataSet_Master, iTableName).Position + 1
        total = Me.DataSet_Master.Tables(iTableName).Rows.Count
        Me.lblRegistro.Text = "Reg: " & Str(num) & " de " & Str(total)
    End Sub
    Private Sub Actualizar()
        DataSet_Master.Clear()
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
        Call ConfiguraControles(1)
        Call GeneraCodigo()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Call ConfiguraControles(2)
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim cod As Integer
        cod = ActualizarBaseDeDatos(spNuevo = Me.Text)
        If cod <> 0 Then
            Actualizar()
            Call MueveCursorA("Id_Usu", Str(cod), "")
            Call ConfiguraControles(0)
        End If
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
