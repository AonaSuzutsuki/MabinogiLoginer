Public Class PasswordClass
    Friend Shared Function ReturnPassword() As String
        Dim PWD As String

        PWD = CreatePW()

        Return PWD
    End Function

    Private Shared Function CreatePW() As String
        Dim PWD As String

        Dim baseclass As New Base64()
        PWD = baseclass.Decoding("P/sXPaSNTGjfwhHxej6K+A==")

        Return PWD
    End Function
End Class
