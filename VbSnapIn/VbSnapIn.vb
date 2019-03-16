Imports System.Windows.Forms
Imports CommonSnappableTypes

<CompanyInfo(CompanyName:="Chuky's software", CompanyUrl:="www.chukysoft.com")>
Public Class VbSnapIn
    Implements IAppFunctionality

    Public Sub DoIt() Implements IAppFunctionality.DoIt
        MessageBox.Show("You've just used the VB snap-in!")
    End Sub
End Class
