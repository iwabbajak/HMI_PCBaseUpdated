﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMC1QAStoppage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblDisplayON = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlMC1 = New System.Windows.Forms.Panel()
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.btnSendSample = New FontAwesome.Sharp.IconButton()
        Me.cboCountermeasure = New System.Windows.Forms.ComboBox()
        Me.cboStoppage = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMainPage = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tmrRealTimeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRstFailFlag = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.pnlMC1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDisplayON
        '
        Me.lblDisplayON.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayON.Location = New System.Drawing.Point(385, -1)
        Me.lblDisplayON.Name = "lblDisplayON"
        Me.lblDisplayON.Size = New System.Drawing.Size(96, 15)
        Me.lblDisplayON.TabIndex = 9
        Me.lblDisplayON.Text = "0"
        Me.lblDisplayON.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pnlMC1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 386)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Machine 1"
        '
        'pnlMC1
        '
        Me.pnlMC1.Controls.Add(Me.btnClear)
        Me.pnlMC1.Controls.Add(Me.btnSendSample)
        Me.pnlMC1.Controls.Add(Me.cboCountermeasure)
        Me.pnlMC1.Controls.Add(Me.cboStoppage)
        Me.pnlMC1.Controls.Add(Me.Label2)
        Me.pnlMC1.Controls.Add(Me.btnMainPage)
        Me.pnlMC1.Controls.Add(Me.Label1)
        Me.pnlMC1.Controls.Add(Me.Label4)
        Me.pnlMC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMC1.Location = New System.Drawing.Point(3, 22)
        Me.pnlMC1.Name = "pnlMC1"
        Me.pnlMC1.Size = New System.Drawing.Size(466, 361)
        Me.pnlMC1.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnClear.IconColor = System.Drawing.Color.Black
        Me.btnClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClear.IconSize = 40
        Me.btnClear.Location = New System.Drawing.Point(9, 290)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(199, 58)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSendSample
        '
        Me.btnSendSample.BackColor = System.Drawing.Color.Yellow
        Me.btnSendSample.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSendSample.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendSample.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnSendSample.IconColor = System.Drawing.Color.Black
        Me.btnSendSample.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSendSample.IconSize = 40
        Me.btnSendSample.Location = New System.Drawing.Point(214, 290)
        Me.btnSendSample.Name = "btnSendSample"
        Me.btnSendSample.Size = New System.Drawing.Size(243, 58)
        Me.btnSendSample.TabIndex = 5
        Me.btnSendSample.Text = "Send Sample"
        Me.btnSendSample.UseVisualStyleBackColor = False
        '
        'cboCountermeasure
        '
        Me.cboCountermeasure.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCountermeasure.FormattingEnabled = True
        Me.cboCountermeasure.Location = New System.Drawing.Point(9, 206)
        Me.cboCountermeasure.Name = "cboCountermeasure"
        Me.cboCountermeasure.Size = New System.Drawing.Size(448, 33)
        Me.cboCountermeasure.TabIndex = 4
        '
        'cboStoppage
        '
        Me.cboStoppage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStoppage.FormattingEnabled = True
        Me.cboStoppage.Location = New System.Drawing.Point(9, 129)
        Me.cboStoppage.Name = "cboStoppage"
        Me.cboStoppage.Size = New System.Drawing.Size(448, 33)
        Me.cboStoppage.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Countermeasure:"
        '
        'btnMainPage
        '
        Me.btnMainPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainPage.FlatAppearance.BorderSize = 0
        Me.btnMainPage.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.btnMainPage.IconColor = System.Drawing.Color.Black
        Me.btnMainPage.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMainPage.IconSize = 60
        Me.btnMainPage.Location = New System.Drawing.Point(392, 19)
        Me.btnMainPage.Name = "btnMainPage"
        Me.btnMainPage.Size = New System.Drawing.Size(65, 56)
        Me.btnMainPage.TabIndex = 3
        Me.btnMainPage.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stoppage Details:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 39)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "QA Stoppage"
        '
        'tmrRealTimeCheck
        '
        Me.tmrRealTimeCheck.Enabled = True
        '
        'tmrRstFailFlag
        '
        Me.tmrRstFailFlag.Enabled = True
        Me.tmrRstFailFlag.Interval = 2000
        '
        'frmMC1QAStoppage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 400)
        Me.Controls.Add(Me.lblDisplayON)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMC1QAStoppage"
        Me.Text = "frmQAStoppage"
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlMC1.ResumeLayout(False)
        Me.pnlMC1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDisplayON As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pnlMC1 As Panel
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSendSample As FontAwesome.Sharp.IconButton
    Friend WithEvents cboStoppage As ComboBox
    Friend WithEvents btnMainPage As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboCountermeasure As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tmrRealTimeCheck As Timer
    Friend WithEvents tmrRstFailFlag As Timer
End Class
