﻿Public Class frmMC1MainPage
    Dim displayTime As Integer
    Private Sub frmMCMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modInfrmMC1MainPage = True
        frmMC1PlsLogin.Close()
        frmMC1STOP.Close()
        frmMC1StoppageType.Close()
        frmMC1OperatorStoppage.Close()
        frmMC1MachineStoppage.Close()
        frmMC1RUN.Close()
        frmMC1QAStoppage.Close()
        frmMC1QAVerification.Close()
        frmMC1TestAutoMode.Close()
        tmrDisplayON.Start()
    End Sub

    Private Sub frmMC1MainPage_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modInfrmMC1MainPage = False
        tmrDisplayON.Stop()
    End Sub

    Public Sub LoadDetailsMC1()
        lblPlanQty.Text = D2010
        lblActualQty.Text = D2032
        lblJobOrderCode.Text = "SO" & "/" & D2019 & "/" & D2020 & "/" & D2021
        lblUserID.Text = D2006
    End Sub

    Public Sub stoppageBtnsEnableDisable()
        If RxPLCM0 = True Then
            picStoppage.Enabled = False
            picQAStoppage.Enabled = False
            picTestAutoMode.Enabled = False
        Else
            picStoppage.Enabled = True
            picQAStoppage.Enabled = True
            picTestAutoMode.Enabled = True
        End If
    End Sub

    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        LoadDetailsMC1()
        displaytimeCheck()
        stoppageBtnsEnableDisable()
    End Sub

    Private Sub tmrDisplayON_Tick(sender As Object, e As EventArgs) Handles tmrDisplayON.Tick
        displayTime = displayTime + 1
    End Sub

    Public Sub displaytimeCheck()
        lblDisplayON.Text = displayTime
        If displayTime >= 10 Then
            If RxPLCM0 = False And modMC1QAStoppageSaveFlag = False And modTestAutoModeMC1Flag = False Then
                modINfrmMC1Stop = True
                Me.Close()
            ElseIf RxPLCM0 = False And modMC1QAStoppageSaveFlag = True And modTestAutoModeMC1Flag = False Then
                modINfrmMC1QAVerification = True
                Me.Close()
            ElseIf RxPLCM0 = False And (modMC1QAStoppageSaveFlag = True Or modMC1QAStoppageSaveFlag = False) And modTestAutoModeMC1Flag = True Then
                modINfrmMC1TestAutoMode = True
                Me.Close()
            Else
                modINfrmMC1Run = True
                Me.Close()
            End If
        End If

    End Sub

    Private Sub picStoppage_Click(sender As Object, e As EventArgs) Handles picStoppage.Click
        modINfrmMC1StoppageType = True
        Me.Close()
    End Sub

    Private Sub picQAStoppage_Click(sender As Object, e As EventArgs) Handles picQAStoppage.Click
        If modMC1QAStoppageSaveFlag = True Then
            modINfrmMC1QAVerification = True
            Me.Close()
        Else
            modINfrmMC1QAStoppage = True
            Me.Close()
        End If
    End Sub

    Private Sub picTestAutoMode_Click(sender As Object, e As EventArgs) Handles picTestAutoMode.Click
        modINfrmMC1TestAutoMode = True
        Me.Close()

    End Sub
End Class