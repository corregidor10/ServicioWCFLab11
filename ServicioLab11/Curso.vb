'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Curso
    Public Property idCurso As Integer
    Public Property nombre As String
    Public Property inicio As Date
    Public Property fin As Nullable(Of Date)
    Public Property duracion As Integer

    Public Overridable Property AlumnoCurso As ICollection(Of AlumnoCurso) = New HashSet(Of AlumnoCurso)

End Class
