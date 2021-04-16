Imports System.Data.SqlClient
Module ModConexion
    Public Conexion As SqlConnection = New SqlConnection("Data Source=JESUS;user id=sa;password=;Initial Catalog=BD_Biblioteca;")
    Public nivel As Boolean, usuario As String
    Public FRELOJ, FTLEC, FLIB, FFPT, FCARNE, FLEC, FESTLIB, FBIBLI, FRPV, FREP, FCL, FCLEC, FCBLI, FCFP, FDEV, FAD As Boolean
    ' -------------------------------------------------------------------
    Public Sub Main()
        Dim objForm As New FrmClave()
        objForm.ShowDialog()
        Application.Run()
    End Sub
    Public Function NewComando(ByVal cnn As SqlClient.SqlConnection, ByVal _CommandText As String, ByVal _CommandType As CommandType) As SqlClient.SqlCommand
        Dim cmm As SqlClient.SqlCommand
        cmm = New SqlClient.SqlCommand()
        cmm.CommandText = _CommandText 'SP, sólo trae: codigo, nombre de los alumnos.
        cmm.CommandType = _CommandType
        cmm.Connection = cnn
        Return cmm
    End Function

    Public Function NewParameter(ByVal nombre As String, ByVal input As Boolean, ByVal sqlTipo As SqlDbType, ByVal prmsize As Integer, ByVal valor As Object) As SqlClient.SqlParameter
        Dim oPrm As SqlClient.SqlParameter
        oPrm = New SqlClient.SqlParameter()
        oPrm.ParameterName = "@" & nombre '"@patalum"
        If input Then
            oPrm.Direction = ParameterDirection.Input
        Else
            oPrm.Direction = ParameterDirection.Output
        End If
        oPrm.SqlDbType = sqlTipo
        oPrm.Size = prmsize
        oPrm.Value = valor
        Return oPrm
    End Function


End Module
