Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Kamar_

    Private IdKamar As Integer
    Private idjenisKamar As Integer
    Private namakamar As String
    Private status As String
    Private Jenis As New List(Of String)
    Private DataTable As New ArrayList()
    Private jenisItem As New List(Of String)

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Public ReadOnly Property getjenisItem() As List(Of String)
        Get
            Return jenisItem
        End Get
    End Property

    Public Property GSIdKamar() As String
        Get
            Return IdKamar
        End Get
        Set(ByVal value As String)
            IdKamar = value
        End Set
    End Property

    Public Property GSidjeniskamar() As String
        Get
            Return idjenisKamar
        End Get
        Set(ByVal value As String)
            idjenisKamar = value
        End Set
    End Property

    Public Property GSnamakamar() As String
        Get
            Return namakamar
        End Get
        Set(ByVal value As String)
            namakamar = value
        End Set
    End Property

    Public Property GSstatus() As String
        Get
            Return status
        End Get
        Set(ByVal value As String)
            namakamar = value
        End Set
    End Property



End Class
