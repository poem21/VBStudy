Imports System
Imports System.IO
Imports System.Threading
Imports System.Linq
Imports System.Runtime.CompilerServices

Module Module1

    Private Function Dtest(ByVal a As Integer,
                           ByVal b As String,
                           ByVal c As Long,
                           ByVal d As String,
                           ByVal z As KorMan) As String
        Dim sql = "
                    select * 
                    from tab 
                    where name = '홍성호' 
                    order by name desc
                   "
        Dim sql1 = "    select  *"

        Return "yyy"

    End Function


    Sub Main()

        '기본명령1()
        '기본명령2()

        'Linq_proc()


        'List_proc()
        'Dim SUM = Function(ByVal I As Integer, ByVal J As Integer)
        '              Return I + J
        '          End Function

        'Dim GUGUDAN = Function(ByVal I As Integer, ByVal J As Integer) As Integer
        '                  Return I * J
        '              End Function


        'Console.WriteLine(SUM(1, 10).ToString)
        'Console.WriteLine(GUGUDAN(1, 10).ToString)

        'Console.WriteLine("aBc".ToString.HUpper)

        'Console.WriteLine(My.Computer.FileSystem.GetFileInfo("c:\temp\test.jpg").MD5Hash("HSH"))



    End Sub

    Private Sub 기본명령1()

        Dim c As Long = 0

        Console.WriteLine("홍성호")

        If c > 10 Then
            Console.WriteLine("10보다 크다")
        ElseIf c = 0 Then
            Console.WriteLine("영이다.")
        Else
            Console.WriteLine("나도 모르겠음")
        End If

        If c = 10 Then Console.WriteLine(True) Else Console.WriteLine(False)

        Select Case c
            Case 0
                Console.WriteLine("홍성호")
            Case 10
                Console.WriteLine("김정일")
            Case Else
                Console.WriteLine("모름")
        End Select

    End Sub



    Private Sub 기본명령2()

        'for( 초기값; 비교치; 증가치)
        For J = 0 To 10

            If J < 2 Then
                Continue For
            End If

            Console.WriteLine(J)

            If J = 5 Then
                Exit For
            End If

        Next

        'For i As Integer = 10 To 0 Step -1
        '    Console.WriteLine(i)
        'Next

        Dim i = 10

        Do While True
            i += 1

            If i < 15 Then Continue Do

            Console.WriteLine("무한반복")

            If i = 20 Then Exit Do

        Loop

    End Sub

    Private Sub Linq_proc()

        Dim Temp() As Integer = {1, 2, 3, 4, 5}

        'For i As Integer = 0 To Temp.Length - 1
        '    Console.WriteLine(Temp(i))
        'Next

        'For Each tmp As Integer In Temp
        '    Console.WriteLine(tmp)
        'Next

        For Each tmp As Integer In Temp

            If tmp > 4 Then
                Console.WriteLine(tmp)
            End If

        Next

        'Linq ==> SQL

        For Each TMP As Integer In (
                                        From A In Temp
                                        Where A > 4
                                    )
            Console.WriteLine(TMP)

        Next

        Dim TEMP2 = From A In Temp
                    Where A > 3

        For Each TMP In TEMP2
            Console.WriteLine(TMP)
        Next

        Console.WriteLine("조인")

        Dim TEMP3 = (From A In Temp Join B In TEMP2
                       On A Equals B
                     Where B < 5
                     Select A)

        Dim TEMP4 = (From A In Temp, B In TEMP2
                     Where A = B And B < 5
                     Select A)

        For Each TMP In TEMP3
            Console.WriteLine(TMP)
        Next


        For Each iproc As Process In (From a In Process.GetProcesses
                                      Where a.ProcessName = "svchost"
                                      Order By a.PrivateMemorySize64)
            Console.WriteLine(iproc.ProcessName & "-" & iproc.PrivateMemorySize64)
        Next

    End Sub



    Private Sub List_Proc()

        Dim User As List(Of KorMan) = New List(Of KorMan)
        'Dim kMan As KorMan = New KorMan With {.SN = 1, .Name = "홍성호", .Age = 43}
        Dim kMan As KorMan

        kMan = New KorMan With {.SN = 1, .Name = "홍성호", .Age = 43}
        User.Add(kMan)
        kMan = New KorMan With {.SN = 2, .Name = "유종배", .Age = 32}
        User.Add(kMan)
        kMan = New KorMan With {.SN = 3, .Name = "김동혁", .Age = 37}
        User.Add(kMan)
        kMan = New KorMan With {.SN = 4, .Name = "현주섭", .Age = 33}
        User.Add(kMan)
        kMan = New KorMan With {.SN = 5, .Name = "김형준", .Age = 30}

        User.Add(kMan)

        Console.WriteLine("삭제전 : " & User.Count.ToString)

        User.Remove(New KorMan With {.SN = 2, .Name = "유종배", .Age = 32})

        For Each TMP In (From A In User Where A.Name = "홍성호")
            User.Remove(TMP)
            Exit For
        Next
        Console.WriteLine("삭제후 : " & User.Count.ToString)


        For Each tmp As KorMan In (From A In User Where A.Age > 35 Order By A.Name)
            Console.WriteLine("{0} - {1}", tmp.Name, tmp.Age)
        Next

    End Sub

End Module


Class KorMan

    Property SN As Integer
    Property Name As String
    Property Age As Integer

    Public Sub New()
        Console.WriteLine("시작")
    End Sub

End Class