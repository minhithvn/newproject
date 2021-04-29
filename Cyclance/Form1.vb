Imports System.Threading
Public Class Form1
    'Dim a As New Process
    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim a As String
            a = "1yip6ve8EJPmS0RvLMXZSvoVA"
            Process.Start("..\Debug\x64\x64.msi")
            Thread.Sleep(1000)
            SendKeys.SendWait("1yip6ve8EJPmS0RvLMXZSvoVA")
            Thread.Sleep(1000)
            SendKeys.Send("{ENTER}")
            Thread.Sleep(1000)
            SendKeys.Send("{ENTER}")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class
