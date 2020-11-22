Imports System.Drawing
Imports FTC_Scouting.AppInfo
Public Class StartUp
    Private Sub StartUp_Load(sender As Object, e As EventArgs) Handles Me.Load
        Size_Form()
        PopulateForm()
    End Sub

    Private Sub Size_Form()
        Dim formRatio As Double = 0.6
        BackColor = getAppSecondaryColor()
        Size = New Size(Screen.PrimaryScreen.Bounds.Width * formRatio, Screen.PrimaryScreen.Bounds.Height * formRatio)
        Me.CenterToParent()
    End Sub

    Private Sub PopulateForm()
        Dim backgroundBorderX As Integer = 10
        Dim backgroundBorderY As Integer = 10
        Dim backgroundWidth As Integer = Me.ClientSize.Width - (2 * backgroundBorderX)
        Dim backgroundHeight As Integer = Me.ClientSize.Height - (2 * backgroundBorderY)
        Dim background As Rectangle = New Rectangle(backgroundBorderX,
                                                    backgroundBorderY,
                                                    backgroundWidth,
                                                    backgroundHeight)

        Dim fillColor As Color = getAppPrimaryColor()
        Dim g As Graphics = Me.CreateGraphics
        Dim brush1 As SolidBrush = New SolidBrush(fillColor)

        g.FillRectangle(brush1, background)
    End Sub

    Private Sub StartUp_SHown(sender As Object, e As EventArgs) Handles Me.Shown
        PopulateForm()
    End Sub
End Class
