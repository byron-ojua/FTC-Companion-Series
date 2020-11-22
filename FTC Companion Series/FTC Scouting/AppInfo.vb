Public Class AppInfo
    Public Shared appPrimaryColor As Color = Color.FromArgb(7, 63, 96)
    Public Shared appSecondaryColor As Color = Color.FromArgb(234, 251, 111)

    Public Shared Function getAppPrimaryColor() As Color
        Return appPrimaryColor
    End Function
    Public Shared Function getAppSecondaryColor() As Color
        Return appSecondaryColor
    End Function
End Class
