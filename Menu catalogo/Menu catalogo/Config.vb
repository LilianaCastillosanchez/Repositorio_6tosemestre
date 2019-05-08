Imports System.Data.SqlClient
Imports System.Data

Module config
    Public ConnSql As SqlConnection

    Public Property ConnectionString As String

    Public Sub IniciarConexion()
        ConnSql = New SqlConnection("Data Source=LILIANA;Initial Catalog=PIZZERIAPALITROCHE;Integrated Security=True")
        ConnSql.Open()
    End Sub


End Module
