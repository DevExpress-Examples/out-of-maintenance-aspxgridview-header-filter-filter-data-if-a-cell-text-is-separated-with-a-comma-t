Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Public Class Data
    Public Property ID() As Integer
    Public Property Cities() As String
    Public Shared Function GetData() As List(Of Data)

        Dim data_Renamed As New List(Of Data)()
        data_Renamed.Add(New Data() With {.ID = 1, .Cities = "Anchorage,Berlin,Saint Louis"})
        data_Renamed.Add(New Data() With {.ID = 2, .Cities = "Berlin,Boston,Geneva"})
        data_Renamed.Add(New Data() With {.ID = 3, .Cities = "London"})
        Return data_Renamed
    End Function
End Class