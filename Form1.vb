Public Class Form1
    Dim MatrizPrincipal(7, 7) As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtvMatrizPrincipal.ColumnCount = 7
        dtvMatrizPrincipal.Rows.Add(7)
        For i = 0 To 6
            dtvMatrizPrincipal.Columns(i).Width = 40
        Next


        dtvNuevaMatriz.ColumnCount = 4
        dtvNuevaMatriz.Rows.Add(3)
        For i = 0 To 3
            dtvNuevaMatriz.Columns(i).Width = 40

        Next
        dtvVector.ColumnCount = 5
        dtvVector.Rows.Add(1)
        For i = 0 To 4
            dtvVector.Columns(i).Width = 40

        Next
    End Sub
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click


        Dim b As Integer
        Dim c As Integer
        Dim f As Integer
        Dim i As Integer
        Dim Paso As Boolean
        Dim MatrizPrincipal(7, 7) As Integer
        Dim NuevaMatriz(3, 4) As Integer
        Dim Vector(5) As Integer
        b = 2
        For f = 0 To 6
            For c = 0 To 6
                MatrizPrincipal(f, c) = New Random().Next(100)
                dtvMatrizPrincipal.Item(c, f).Value = MatrizPrincipal(f, c)

                If f <> 0 Then
                    If c >= b Then
                        If Paso = True Then
                            Vector(c - 2) = MatrizPrincipal(f, c)
                            b = b + 1
                            Paso = False
                        End If
                    End If
                End If
            Next c
            Paso = True

        Next f
        For f = 0 To 6
            For c = 0 To 6
                If f >= 3 Then
                    If f <> 6 Then
                        If c >= 2 Then
                            If c <> 6 Then
                                NuevaMatriz(f - 3, c - 2) = MatrizPrincipal(f, c)
                            End If
                        End If
                    End If
                End If
            Next c

        Next f
        For f = 0 To 2
            For c = 0 To 3
                dtvNuevaMatriz.Item(c, f).Value = NuevaMatriz(f, c)
            Next c

        Next f


        For i = 0 To 4
            dtvVector.Item(i, 0).Value = Vector(i)
        Next i
    End Sub


End Class
