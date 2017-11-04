Imports System.Runtime.CompilerServices
Imports System.IO
Imports System

Module PubMod

    <Extension()>
    Public Function HUpper(ByVal Txt As String) As String

        Return Txt.ToUpper

    End Function

    <Extension()>
    Public Function MD5Hash(ByVal iFile As FileInfo, ByVal Key_AES As String) As String

        Return "Ancdhsahofiose"

    End Function

End Module
