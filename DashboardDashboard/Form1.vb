Imports System.Configuration

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sEnv As String = System.Configuration.ConfigurationManager.AppSettings.Get("EnvironmentIs").ToUpper
        Select Case sEnv
            Case "LIVE"
                lEnvironment.Text = "LIVE"
            Case "SHADOW"
                lEnvironment.Text = "SHADOW"
            Case "USER"
                lEnvironment.Text = "USER TESTING"
            Case "DEV"
                lEnvironment.Text = "DEVELOPMENT"
            Case "UAT"
                lEnvironment.Text = "UAT"
            Case Else
                lEnvironment.Text = "Unrecognised Environment"
        End Select
    End Sub

    Private Sub bFinance_Click(sender As Object, e As EventArgs) Handles bFinance.Click
        Dim AppPath As String = ConfigurationManager.AppSettings.Get("FinanceApp")
        Dim proc As Process = Process.Start(AppPath)
    End Sub

    Private Sub bOMA_Click(sender As Object, e As EventArgs) Handles bOMA.Click
        Dim AppPath As String = ConfigurationManager.AppSettings.Get("OMAApp")
        Dim proc As Process = Process.Start(AppPath)
    End Sub

    Private Sub bMandates_Click(sender As Object, e As EventArgs) Handles bMandates.Click
        Dim AppPath As String = ConfigurationManager.AppSettings.Get("MandatesApp")
        Dim proc As Process = Process.Start(AppPath)
    End Sub

    Private Sub bSupport_Click(sender As Object, e As EventArgs) Handles bSupport.Click
        Dim AppPath As String = ConfigurationManager.AppSettings.Get("SupportApp")
        Dim proc As Process = Process.Start(AppPath)
    End Sub

    Private Sub bOperations_Click(sender As Object, e As EventArgs) Handles bOperations.Click
        Dim AppPath As String = ConfigurationManager.AppSettings.Get("OperationsApp")
        Dim proc As Process = Process.Start(AppPath)
    End Sub

    Private Sub bOfflineLender_Click(sender As Object, e As EventArgs) Handles bOfflineLender.Click
        Dim AppPath As String = ConfigurationManager.AppSettings.Get("OfflineLenderApp")
        Dim proc As Process = Process.Start(AppPath)
    End Sub
End Class
