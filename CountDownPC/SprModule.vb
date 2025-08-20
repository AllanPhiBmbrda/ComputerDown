Imports System.Runtime.InteropServices

Module SprModule
    <StructLayout(LayoutKind.Sequential)>
    Public Structure LASTINPUTINFO
        Public cbSize As Integer
        Public dwTime As Integer
    End Structure




    <DllImport("user32.dll")>
    Public Function GetLastInputInfo(ByRef plii As LASTINPUTINFO) As Boolean
    End Function

    <DllImport("kernel32.dll")>
    Public Function GetTickCount() As UInteger
    End Function

End Module

