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
        txtFirstnum = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtSecondnum = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' txtFirstnum
        ' 
        txtFirstnum.Location = New Point(113, 73)
        txtFirstnum.Name = "txtFirstnum"
        txtFirstnum.Size = New Size(100, 23)
        txtFirstnum.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(144, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(144, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 1
        Label2.Text = "1st num"
        ' 
        ' txtSecondnum
        ' 
        txtSecondnum.Location = New Point(113, 138)
        txtSecondnum.Name = "txtSecondnum"
        txtSecondnum.Size = New Size(100, 23)
        txtSecondnum.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(144, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 1
        Label3.Text = "Label1"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(144, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 1
        Label4.Text = "2nd num"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(125, 184)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "Try"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(113, 238)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(58, 15)
        lblResult.TabIndex = 3
        lblResult.Text = "out come"
        ' 
        ' Form1
        ' 
        AcceptButton = Button1
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(340, 367)
        Controls.Add(lblResult)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtSecondnum)
        Controls.Add(Label1)
        Controls.Add(txtFirstnum)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstnum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSecondnum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblResult As Label
End Class
