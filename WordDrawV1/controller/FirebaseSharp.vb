Imports FirebaseSharp.Portable

Public Class FirebaseSharp

    Dim rootURI As String = "https://guessing-game-acf18.firebaseio.com/"
    Dim authToken As String = "KrLf3KMrM2sfU1KuZHHB6CUyYTu0jQE3Z3XBdSC6"

    Public fb As FirebaseApp
    Dim URI As Uri

    Public Sub New()

        Try
            URI = New Uri(rootURI)
            fb = New FirebaseApp(URI, authToken)
        Catch ex As Exception
            Console.WriteLine("Error in FirebaseSharp.vb")
            Console.WriteLine(ex.Data)
            Console.WriteLine(ex.StackTrace)
            Console.WriteLine(ex.Message)
        End Try

    End Sub


    Public Function streamData() As Boolean
        Console.WriteLine("streamData() invoked")


        Try
            URI = New Uri(rootURI)

            Try
                fb = New FirebaseApp(URI, authToken)

                Dim path As String = "/round"
                Dim rounds = fb.Child(path)

                rounds.OrderByValue().On("value", Function(snapshot, child, context)
                                                      For Each datasnap In snapshot.Children
                                                          Console.WriteLine("data key" + datasnap.Key)
                                                          Console.WriteLine("data value" + datasnap.Value)
                                                      Next
                                                      Return False
                                                  End Function)

            Catch ex As Exception
                Console.WriteLine(ex.Data)
            End Try


        Catch ex As Exception
            Console.WriteLine(ex.Data)
        End Try

        Return False

    End Function
End Class
