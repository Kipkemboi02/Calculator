<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        LCD = New TextBox()
        n1 = New Button()
        n2 = New Button()
        n4 = New Button()
        n5 = New Button()
        n7 = New Button()
        n6 = New Button()
        n3 = New Button()
        n8 = New Button()
        n9 = New Button()
        n0 = New Button()
        bdiv = New Button()
        bmult = New Button()
        bsub = New Button()
        bad = New Button()
        Button5 = New Button()
        bequal = New Button()
        b0 = New Button()
        SuspendLayout()
        ' 
        ' LCD
        ' 
        LCD.BackColor = Color.GhostWhite
        LCD.Location = New Point(220, 31)
        LCD.Name = "LCD"
        LCD.ReadOnly = True
        LCD.Size = New Size(285, 23)
        LCD.TabIndex = 0
        LCD.Text = "0"
        LCD.TextAlign = HorizontalAlignment.Right
        ' 
        ' n1
        ' 
        n1.AccessibleRole = AccessibleRole.MenuBar
        n1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n1.Font = New Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        n1.Location = New Point(220, 70)
        n1.Name = "n1"
        n1.Size = New Size(62, 48)
        n1.TabIndex = 1
        n1.Text = "1"
        n1.UseVisualStyleBackColor = False
        ' 
        ' n2
        ' 
        n2.AccessibleRole = AccessibleRole.MenuBar
        n2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n2.Font = New Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        n2.Location = New Point(297, 70)
        n2.Name = "n2"
        n2.Size = New Size(62, 48)
        n2.TabIndex = 1
        n2.Text = "2"
        n2.UseVisualStyleBackColor = False
        ' 
        ' n4
        ' 
        n4.AccessibleRole = AccessibleRole.MenuBar
        n4.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n4.Font = New Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        n4.Location = New Point(220, 141)
        n4.Name = "n4"
        n4.Size = New Size(62, 48)
        n4.TabIndex = 1
        n4.Text = "4"
        n4.UseVisualStyleBackColor = False
        ' 
        ' n5
        ' 
        n5.AccessibleRole = AccessibleRole.MenuBar
        n5.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n5.Font = New Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        n5.Location = New Point(297, 141)
        n5.Name = "n5"
        n5.Size = New Size(62, 48)
        n5.TabIndex = 1
        n5.Text = "5"
        n5.UseVisualStyleBackColor = False
        ' 
        ' n7
        ' 
        n7.AccessibleRole = AccessibleRole.MenuBar
        n7.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n7.Font = New Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        n7.Location = New Point(220, 211)
        n7.Name = "n7"
        n7.Size = New Size(62, 48)
        n7.TabIndex = 1
        n7.Text = "7"
        n7.UseVisualStyleBackColor = False
        ' 
        ' n6
        ' 
        n6.AccessibleRole = AccessibleRole.MenuBar
        n6.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n6.Font = New Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        n6.Location = New Point(375, 141)
        n6.Name = "n6"
        n6.Size = New Size(62, 48)
        n6.TabIndex = 1
        n6.Text = "6"
        n6.UseVisualStyleBackColor = False
        ' 
        ' n3
        ' 
        n3.AccessibleRole = AccessibleRole.MenuBar
        n3.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n3.Font = New Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        n3.Location = New Point(375, 70)
        n3.Name = "n3"
        n3.Size = New Size(62, 48)
        n3.TabIndex = 1
        n3.Text = "3"
        n3.UseVisualStyleBackColor = False
        ' 
        ' n8
        ' 
        n8.AccessibleRole = AccessibleRole.MenuBar
        n8.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n8.Font = New Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        n8.Location = New Point(297, 211)
        n8.Name = "n8"
        n8.Size = New Size(62, 48)
        n8.TabIndex = 1
        n8.Text = "8"
        n8.UseVisualStyleBackColor = False
        ' 
        ' n9
        ' 
        n9.AccessibleRole = AccessibleRole.MenuBar
        n9.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n9.Font = New Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        n9.Location = New Point(375, 211)
        n9.Name = "n9"
        n9.Size = New Size(62, 48)
        n9.TabIndex = 1
        n9.Text = "9"
        n9.UseVisualStyleBackColor = False
        ' 
        ' n0
        ' 
        n0.AccessibleRole = AccessibleRole.MenuBar
        n0.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n0.Font = New Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        n0.Location = New Point(297, 278)
        n0.Name = "n0"
        n0.Size = New Size(62, 48)
        n0.TabIndex = 1
        n0.Text = "0"
        n0.UseVisualStyleBackColor = False
        ' 
        ' bdiv
        ' 
        bdiv.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        bdiv.Font = New Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bdiv.Location = New Point(443, 278)
        bdiv.Name = "bdiv"
        bdiv.Size = New Size(62, 48)
        bdiv.TabIndex = 2
        bdiv.Text = "/"
        bdiv.UseVisualStyleBackColor = False
        ' 
        ' bmult
        ' 
        bmult.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        bmult.Font = New Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bmult.Location = New Point(443, 211)
        bmult.Name = "bmult"
        bmult.Size = New Size(62, 48)
        bmult.TabIndex = 2
        bmult.Text = "*"
        bmult.UseVisualStyleBackColor = False
        ' 
        ' bsub
        ' 
        bsub.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        bsub.Font = New Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bsub.Location = New Point(443, 141)
        bsub.Name = "bsub"
        bsub.Size = New Size(62, 48)
        bsub.TabIndex = 2
        bsub.Text = "-"
        bsub.UseVisualStyleBackColor = False
        ' 
        ' bad
        ' 
        bad.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        bad.Font = New Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bad.Location = New Point(443, 70)
        bad.Name = "bad"
        bad.Size = New Size(62, 48)
        bad.TabIndex = 2
        bad.Text = "+"
        bad.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Button5.Font = New Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(220, 486)
        Button5.Name = "Button5"
        Button5.Size = New Size(62, 48)
        Button5.TabIndex = 2
        Button5.Text = "C"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' bequal
        ' 
        bequal.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        bequal.Font = New Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bequal.Location = New Point(220, 278)
        bequal.Name = "bequal"
        bequal.Size = New Size(62, 48)
        bequal.TabIndex = 2
        bequal.Text = "="
        bequal.UseVisualStyleBackColor = False
        ' 
        ' b0
        ' 
        b0.AccessibleRole = AccessibleRole.MenuBar
        b0.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        b0.Font = New Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        b0.Location = New Point(375, 278)
        b0.Name = "b0"
        b0.Size = New Size(62, 48)
        b0.TabIndex = 1
        b0.Text = "C"
        b0.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(680, 450)
        Controls.Add(bequal)
        Controls.Add(bad)
        Controls.Add(bsub)
        Controls.Add(Button5)
        Controls.Add(bmult)
        Controls.Add(bdiv)
        Controls.Add(n9)
        Controls.Add(n6)
        Controls.Add(n8)
        Controls.Add(b0)
        Controls.Add(n0)
        Controls.Add(n5)
        Controls.Add(n3)
        Controls.Add(n4)
        Controls.Add(n7)
        Controls.Add(n2)
        Controls.Add(n1)
        Controls.Add(LCD)
        Name = "Form1"
        Text = "My Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LCD As TextBox
    Friend WithEvents n1 As Button
    Friend WithEvents n2 As Button
    Friend WithEvents n4 As Button
    Friend WithEvents n5 As Button
    Friend WithEvents n7 As Button
    Friend WithEvents n6 As Button
    Friend WithEvents n3 As Button
    Friend WithEvents n8 As Button
    Friend WithEvents n9 As Button
    Friend WithEvents n0 As Button
    Public Property bc As Button
    Dim FirstNumber As Long
    Dim Operation As String
    Private Sub n1_Click(sender As Object, e As EventArgs) Handles n1.Click
        If LCD.Text = "0" Then
            LCD.Text = "1"
        Else
            LCD.Text = LCD.Text & "1"
        End If

    End Sub

    Private Sub n2_Click(sender As Object, e As EventArgs) Handles n2.Click
        If LCD.Text = "0" Then
            LCD.Text = "2"
        Else
            LCD.Text = LCD.Text & "2"
        End If

    End Sub

    Private Sub n3_Click(sender As Object, e As EventArgs) Handles n3.Click
        If LCD.Text = "0" Then
            LCD.Text = "3"
        Else
            LCD.Text = LCD.Text & "3"
        End If
    End Sub

    Private Sub n4_Click(sender As Object, e As EventArgs) Handles n4.Click
        If LCD.Text = "0" Then
            LCD.Text = "4"
        Else
            LCD.Text = LCD.Text & "4"
        End If
    End Sub

    Private Sub n5_Click(sender As Object, e As EventArgs) Handles n5.Click
        If LCD.Text = "0" Then
            LCD.Text = "5"
        Else
            LCD.Text = LCD.Text & "5"
        End If

    End Sub

    Private Sub n6_Click(sender As Object, e As EventArgs) Handles n6.Click
        If LCD.Text = "0" Then
            LCD.Text = "6"
        Else
            LCD.Text = LCD.Text & "6"
        End If

    End Sub

    Private Sub n7_Click(sender As Object, e As EventArgs) Handles n7.Click
        If LCD.Text = "0" Then
            LCD.Text = "7"
        Else
            LCD.Text = LCD.Text & "7"
        End If


    End Sub

    Private Sub n8_Click(sender As Object, e As EventArgs) Handles n8.Click
        If LCD.Text = "0" Then
            LCD.Text = "8"
        Else
            LCD.Text = LCD.Text & "8"
        End If

    End Sub

    Private Sub n9_Click(sender As Object, e As EventArgs) Handles n9.Click
        If LCD.Text = "0" Then
            LCD.Text = "9"
        Else
            LCD.Text = LCD.Text & "9"
            En
    Private Sub n0_Cl()d If

    End Sub
(sender As Object, e As EventArgs) Handles n0.Click
        If LCD.Text = "0" Then Tickhen T
        End Ifhen
            LCD.Text = "0"
        Else
        LCD.Text = LCD.Text & "0"

    End Sub

    Private Sub bc_Click(sender As Object, e As EventArgs) Handles bad.Click
        FirstNumber = LCD.Text
        LCD.Text = "0"
        Operation = "+"
    End Sub

    Friend WithEvents bdiv As Button
    Friend WithEvents bmult As Button
    Friend WithEvents bsub As Button
    Friend WithEvents bad As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents bequal As Button
    Friend WithEvents b0 As Button

    Private Sub b0_Click(sender As Object, e As EventArgs) Handles b0.Click
        LCD.Text = "0"
    End Sub

    Private Sub bsub_Click(sender As Object, e As EventArgs) Handles bsub.Click
        FirstNumber = LCD.Text
        LCD.Text = "0"
        Operation = "-"
    End Sub

    Private Sub bmult_Click(sender As Object, e As EventArgs) Handles bmult.Click
        FirstNumber = LCD.Text
        LCD.Text = "0"
        Operation = "*"
    End Sub

    Private Sub bdiv_Click(sender As Object, e As EventArgs) Handles bdiv.Click
        FirstNumber = LCD.Text
        LCD.Text = "0"
        Operation = "/"

    End Sub

    Private Sub bequal_Click(sender As Object, e As EventArgs) Handles bequal.Click
        Dim SecondNumber As Long
        Dim Result As Long

        SecondNumber = LCD.Text

        If Operation = "+" Then
            Result = FirstNumber + SecondNumber
        ElseIf Operation = "-" Then
            Result = FirstNumber - SecondNumber
        ElseIf Operation = "*" Then
            Result = FirstNumber * SecondNumber
        ElseIf Operation = "/" Then
            Result = FirstNumber / SecondNumber
        End If

        FirstNumber = Result
        LCD.Text = Result
    End Sub
End Class
