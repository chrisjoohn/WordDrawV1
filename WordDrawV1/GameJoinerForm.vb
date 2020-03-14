
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports FireSharp.Response
Imports System.Text.RegularExpressions


Public Class GameJoinerForm
    Dim firebaseHelper As FirebaseSharp = New FirebaseSharp()
    Dim database As FirebaseHelper = New FirebaseHelper()


    Dim game_id = "f720880c-3edc-4831-bbed-37f37d21796e"


    Dim DrawColor As Color = Color.Black
    Dim DrawSize As Byte = 4
    Dim myPen As New Pen(Color.Black, 4)

    Dim bmp As Bitmap

    Dim X As New ArrayList()
    Dim Y As New ArrayList()

    Dim flag As Boolean = True

    Public Sub New()

        InitializeComponent()
        cbSize.SelectedIndex = 2
        bmp = New Bitmap(pbDraw.Width, pbDraw.Height)
        pbDraw.Image = bmp
        StreamData()
    End Sub

    Function StreamData()
        Dim whiteboardPath As String = "whiteboard/" + game_id + "/"

        Try
            Dim whiteboard = firebaseHelper.fb.Child(whiteboardPath)
            whiteboard.OrderByKey.On("value", Async Sub(snapshot, child, context)
                                                  For Each dataSnap In snapshot.Children
                                                      Dim id = dataSnap.Key
                                                      Try
                                                          Await getData(id)
                                                      Catch ex As Exception
                                                          Console.WriteLine(ex.StackTrace)
                                                      End Try
                                                      'Exit For
                                                  Next
                                              End Sub)

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try

    End Function

    Async Function getData(id) As Task
        Dim whiteboardPath As String = "whiteboard/" + game_id + "/" + id
        Dim res As FirebaseResponse = Await database.client.GetAsync(whiteboardPath)

        Dim body = res.Body

        Dim dicBody = ConvertToDictionary(body)

        Dim x_coordinate As Integer
        Dim y_coordinate As Integer
        Dim xEnd As Integer
        Dim yEnd As Integer

        For Each kvp As KeyValuePair(Of String, String) In dicBody
            If kvp.Key = "x_coordinate" Then
                x_coordinate = Convert.ToInt32(kvp.Value)
                'Console.WriteLine(kvp.Value)
            End If
            If kvp.Key = "y_coordinate" Then
                y_coordinate = Convert.ToInt32(kvp.Value)
                'Console.WriteLine(kvp.Value)
            End If

            If x_coordinate <> 0 And y_coordinate <> 0 Then
                'Console.WriteLine()
                'Console.WriteLine(x_coordinate.GetType().Name)
                'Console.WriteLine(y_coordinate.GetType().Name)
                'Console.WriteLine(xEnd)
                'Console.WriteLine(yEnd)
                X.Add(x_coordinate)
                Y.Add(y_coordinate)
            End If
            'Console.WriteLine("Awtit")
            pbDraw.Invalidate()
        Next

    End Function

    Function ConvertToDictionary(resBody As String) As Dictionary(Of String, String)
        Dim trimmedBody = resBody.Trim({"{"c, "}"c, ":"c})
        Dim arr As String() = Regex.Split(trimmedBody, ",")

        Dim dic As New Dictionary(Of String, String)
        For Each s In arr

            Dim x = Regex.Split(s, ":")
            Dim key = x(0).Replace("""", "")
            Dim val = x(1)

            dic.Add(key, val)
        Next
        Return dic
    End Function

    Private Sub pbDraw_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pbDraw.Paint
        'While flag

        'End While
        Console.WriteLine("aaaa")
        Dim pnts(X.Count - 1) As Point
        For i As Integer = 0 To X.Count - 1
            pnts(i) = New Point(X.Item(i), Y.Item(i))
        Next
        Try
            e.Graphics.DrawLines(Me.myPen, pnts)
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        bmp = New Bitmap(pbDraw.Width, pbDraw.Height)
        pbDraw.Image = bmp
    End Sub
End Class