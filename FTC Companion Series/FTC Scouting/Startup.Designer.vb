<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartUp
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UGLogo = New System.Windows.Forms.PictureBox()
        CType(Me.UGLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(57, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'UGLogo
        '
        Me.UGLogo.Image = Global.FTC_Scouting.My.Resources.Resources.UltimateGoal_RGB_full_color_reversed1
        Me.UGLogo.Location = New System.Drawing.Point(12, 12)
        Me.UGLogo.Name = "UGLogo"
        Me.UGLogo.Size = New System.Drawing.Size(478, 338)
        Me.UGLogo.TabIndex = 1
        Me.UGLogo.TabStop = False
        '
        'StartUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 362)
        Me.Controls.Add(Me.UGLogo)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StartUp"
        Me.Text = "Form1"
        CType(Me.UGLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UGLogo As PictureBox
End Class
