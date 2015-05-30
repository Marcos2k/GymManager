Imports System.Data.SqlClient

Public Class FReporte
    ''' <summary>
    ''' Genera el ultimo pago, busca su ID  e imprimiendolo en Reportviewer
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Generar_Pago()
        Try
            Dim Pago As New FPagos
            Dim ID As Integer = Pago.ObtenerUltimoPago
            Return ID
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
