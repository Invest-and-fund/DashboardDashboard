Imports System.Configuration

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sEnv As String = System.Configuration.ConfigurationManager.AppSettings.Get("EnvironmentIs").ToUpper
        Select Case sEnv
            Case "LIVE"
                lEnvironment.Text = "LIVE SERVER"
            Case "SHADOW"
                lEnvironment.Text = "SHADOW SERVER"
            Case "USER"
                lEnvironment.Text = "USER TESTING SERVER"
            Case "DEV"
                lEnvironment.Text = "DEVELOPMENT SERVER"
            Case "UAT"
                lEnvironment.Text = "UAT SERVER"
            Case "TESTING"
                lEnvironment.Text = "TESTING SERVER"
            Case Else
                lEnvironment.Text = "Unrecognised Environment"
        End Select
    End Sub

    Private Sub bFinance_Click(sender As Object, e As EventArgs) Handles bFinance.Click
        Dim AppPath As String = ConfigurationManager.AppSettings.Get("FinanceApp")
        Dim appEnv As String = AppPath.Replace("\" & AppPath.Split("\").Last, "")
        Dim proc As New ProcessStartInfo()
        proc.FileName = AppPath
        proc.WorkingDirectory = appEnv
        Process.Start(proc)

    End Sub

    Private Sub bOMA_Click(sender As Object, e As EventArgs) Handles bOMA.Click
        Dim AppPath As String = ConfigurationManager.AppSettings.Get("OMAApp")
        Dim appEnv As String = AppPath.Replace("\" & AppPath.Split("\").Last, "")
        Dim proc As New ProcessStartInfo()
        proc.FileName = AppPath
        proc.WorkingDirectory = appEnv
        Process.Start(proc)
    End Sub

    Private Sub bMandates_Click(sender As Object, e As EventArgs) Handles bMandates.Click
        Dim AppPath As String = ConfigurationManager.AppSettings.Get("MandatesApp")
        Dim appEnv As String = AppPath.Replace("\" & AppPath.Split("\").Last, "")
        Dim proc As New ProcessStartInfo()
        proc.FileName = AppPath
        proc.WorkingDirectory = appEnv
        Process.Start(proc)
    End Sub

    Private Sub bSupport_Click(sender As Object, e As EventArgs) Handles bSupport.Click
        Dim AppPath As String = ConfigurationManager.AppSettings.Get("SupportApp")
        Dim appEnv As String = AppPath.Replace("\" & AppPath.Split("\").Last, "")
        Dim proc As New ProcessStartInfo()
        proc.FileName = AppPath
        proc.WorkingDirectory = appEnv
        Process.Start(proc)
    End Sub

    Private Sub bOperations_Click(sender As Object, e As EventArgs) Handles bOperations.Click
        Dim AppPath As String = ConfigurationManager.AppSettings.Get("OperationsApp")
        Dim appEnv As String = AppPath.Replace("\" & AppPath.Split("\").Last, "")
        Dim proc As New ProcessStartInfo()
        proc.FileName = AppPath
        proc.WorkingDirectory = appEnv
        Process.Start(proc)
    End Sub

    Private Sub bOfflineLender_Click(sender As Object, e As EventArgs) Handles bOfflineLender.Click
        Dim AppPath As String = ConfigurationManager.AppSettings.Get("OfflineLenderApp")
        Dim appEnv As String = AppPath.Replace("\" & AppPath.Split("\").Last, "")
        Dim proc As New ProcessStartInfo()
        proc.FileName = AppPath
        proc.WorkingDirectory = appEnv
        Process.Start(proc)
    End Sub

    Private Sub bMailchimp_Click(sender As Object, e As EventArgs) Handles bMailchimp.Click
        Dim AppPath As String = ConfigurationManager.AppSettings.Get("MailchimpCurator")
        Dim appEnv As String = AppPath.Replace("\" & AppPath.Split("\").Last, "")
        Dim proc As New ProcessStartInfo()
        proc.FileName = AppPath
        proc.WorkingDirectory = appEnv
        Process.Start(proc)
    End Sub
End Class
