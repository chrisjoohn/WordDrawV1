Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces

Public Class FirebaseHelper

    Public ifc As New FirebaseConfig With
    {
        .AuthSecret = "KrLf3KMrM2sfU1KuZHHB6CUyYTu0jQE3Z3XBdSC6",
        .BasePath = "https://guessing-game-acf18.firebaseio.com/"
    }

    Public client As IFirebaseClient = New FireSharp.FirebaseClient(ifc)

End Class
