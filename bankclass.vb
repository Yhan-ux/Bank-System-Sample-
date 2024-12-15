Imports System.Data.OleDb
Public Class bankclass
    'Data Members
    Public con As New OleDbConnection
    Public dbprovider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Public dbsourse As String = "Data Source=C:\Users\USER\Desktop\BANK Engr. Ryan\BankSystem.DataBase.v2.0\Database.accdb"


    Public balAvail As Single
    Public maintainFixedbal As Single = 500
    Public currbalance As Single
    Public newbal As Single
    Public depAmount As Single
    Public WdrawAmount As Single
    'Methods
    Public Sub Conn()
        con.ConnectionString = dbprovider & dbsourse
    End Sub
    Public Sub maintain_bal()
        balAvail = currbalance - maintainFixedbal
    End Sub

    Public Sub DepositCount()
        newbal = currbalance + depAmount

      
    End Sub
    Public Sub withdraw()

        newbal = currbalance - WdrawAmount


    End Sub
End Class
'Public Class bankclass
'    Public Shared AdminMain
'    Public con As New OleDbConnection
'    Public dbprovider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
'    Public dbsourse As String = "Data Source=C:\Users\USER\Desktop\Ryan F\BankSystem.DataBase.v2.0\BankSystem.DataBase.v2.0\Database.accdb"

'    Public displaylbl As String
'    Public query As New OleDbCommand("SELECT * FROM member WHERE USERNAME='" & displaylbl & "'", con)
'    Public read As OleDbDataReader

'    Public Fname As String
'    Public Mname As String
'    Public Lname As String




'    Public Sub displaydata()
'        Try
'            displaylbl = AdminMain
'            con.ConnectionString = dbprovider & dbsourse
'            con.Open()
'            ' Dim query As New OleDbCommand("SELECT * FROM member WHERE USERNAME='" & lbluser.Text & "'", con)
'            'Dim read As OleDbDataReader
'            read = query.ExecuteReader
'            If read.HasRows Then
'                If read.Read() Then
'                    Fname = (read("FNAME"))
'                    Lname = (read("LNAME"))
'                    Mname = (read("MNAME"))
'                End If
'            End If
'        Catch ex As Exception
'        Finally
'            con.Close()

'        End Try
'    End Sub
'End Class
