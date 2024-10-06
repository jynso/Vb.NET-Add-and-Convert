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
        Label1 = New Label()
        txtfirstnum = New TextBox()
        txtsecondnum = New TextBox()
        btnsum = New Button()
        btnpercent = New Button()
        txtsum = New TextBox()
        txtpercent = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("JetBrains Mono", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label1.Location = New Point(43, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(364, 31)
        Label1.TabIndex = 0
        Label1.Text = "Please enter your numbers"
        ' 
        ' txtfirstnum
        ' 
        txtfirstnum.Location = New Point(69, 117)
        txtfirstnum.Name = "txtfirstnum"
        txtfirstnum.Size = New Size(70, 31)
        txtfirstnum.TabIndex = 1
        ' 
        ' txtsecondnum
        ' 
        txtsecondnum.Location = New Point(300, 117)
        txtsecondnum.Name = "txtsecondnum"
        txtsecondnum.Size = New Size(63, 31)
        txtsecondnum.TabIndex = 2
        ' 
        ' btnsum
        ' 
        btnsum.BackColor = Color.Transparent
        btnsum.Font = New Font("JetBrains Mono", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnsum.ForeColor = Color.Black
        btnsum.Location = New Point(114, 190)
        btnsum.Name = "btnsum"
        btnsum.Size = New Size(209, 34)
        btnsum.TabIndex = 3
        btnsum.Text = "Get the sum!"
        btnsum.UseVisualStyleBackColor = False
        ' 
        ' btnpercent
        ' 
        btnpercent.Font = New Font("JetBrains Mono", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnpercent.Location = New Point(114, 308)
        btnpercent.Name = "btnpercent"
        btnpercent.Size = New Size(209, 34)
        btnpercent.TabIndex = 4
        btnpercent.Text = "Get the 30%"
        btnpercent.UseVisualStyleBackColor = True
        ' 
        ' txtsum
        ' 
        txtsum.Location = New Point(94, 246)
        txtsum.Name = "txtsum"
        txtsum.Size = New Size(244, 31)
        txtsum.TabIndex = 5
        txtsum.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtpercent
        ' 
        txtpercent.Location = New Point(94, 368)
        txtpercent.Name = "txtpercent"
        txtpercent.Size = New Size(244, 31)
        txtpercent.TabIndex = 6
        txtpercent.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("JetBrains Mono", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(171, 424)
        Button1.Name = "Button1"
        Button1.Size = New Size(98, 34)
        Button1.TabIndex = 7
        Button1.Text = "Retry?"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(441, 490)
        Controls.Add(Button1)
        Controls.Add(txtpercent)
        Controls.Add(txtsum)
        Controls.Add(btnpercent)
        Controls.Add(btnsum)
        Controls.Add(txtsecondnum)
        Controls.Add(txtfirstnum)
        Controls.Add(Label1)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtfirstnum As TextBox
    Friend WithEvents txtsecondnum As TextBox
    Friend WithEvents btnsum As Button
    Friend WithEvents btnpercent As Button
    Friend WithEvents txtsum As TextBox
    Friend WithEvents txtpercent As TextBox
    Friend WithEvents Button1 As Button

End Class
