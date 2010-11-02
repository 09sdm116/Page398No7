Public Class FrmMain

    Dim arrayChart(9, 4) As String
    ''' <summary>
    ''' Closes the program
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click

        Me.Close()

    End Sub
    ''' <summary>
    ''' Displays seating chart
    ''' "X" = Reserved
    ''' "O" = Available
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChart.Click


        Dim fmtStr0 As String = "{0,3}{1,3}{2,3}{3,3}"

        Dim str0 As String = ""
        Dim str1 As String = ""
        Dim str2 As String = ""
        Dim str3 As String = ""
        Dim str4 As String = ""

        'Random names to put in seating chart
        arrayChart(8, 3) = "Tim"
        arrayChart(9, 0) = "John"
        arrayChart(1, 0) = "Frank"
        arrayChart(8, 0) = "Mike"

        lstChart.Items.Clear()

        Try

            For i As Integer = 0 To 9
                For x As Integer = 0 To 4

                    If arrayChart(i, x) = "" And x = 0 Then
                        str0 = "O"
                    ElseIf arrayChart(i, x) <> "" And x = 0 Then
                        str0 = "X"
                    ElseIf arrayChart(i, x) = "" And x = 1 Then
                        str1 = "O"
                    ElseIf arrayChart(i, x) <> "" And x = 1 Then
                        str1 = "X"
                    ElseIf arrayChart(i, x) = "" And x = 2 Then
                        str2 = "O"
                    ElseIf arrayChart(i, x) <> "" And x = 2 Then
                        str2 = "X"
                    ElseIf arrayChart(i, x) = "" And x = 3 Then
                        str3 = "O"
                    ElseIf arrayChart(i, x) <> "" And x = 3 Then
                        str3 = "X"
                    ElseIf arrayChart(i, x) = "" And x = 4 Then
                        str4 = "O"

                        lstChart.Items.Add(String.Format(fmtStr0, str0, str1, str2, str3))

                    End If

                Next
            Next

        Catch ex As InvalidCastException
            MessageBox.Show("Invalid Data")
        Catch ex As Exception
            MessageBox.Show("Error occurred")
        End Try

    End Sub
    ''' <summary>
    ''' Removes passenger from seating chart
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        Dim strRemove As String = txtRemove.Text

        Try
            For i As Integer = 0 To 9

                For x As Integer = 0 To 4

                    If arrayChart(i, x) = strRemove Then

                        arrayChart(i, x) = ""

                    End If

                Next

            Next

        Catch ex As InvalidCastException
            MessageBox.Show("Invalid Data")
        Catch ex As Exception
            MessageBox.Show("Error occurred")
        End Try

    End Sub
    ''' <summary>
    ''' Adds passenger to seating chart
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim intRow As Integer = CInt(txtRow.Text) - 1
        Dim intSeat As Integer = CInt(txtSeat.Text) - 1

        Try

            arrayChart(intRow, intSeat) = txtPass.Text

        Catch ex As InvalidCastException
            MessageBox.Show("Invalid Data")
        Catch ex As Exception
            MessageBox.Show("Error occurred")
        End Try

    End Sub
    ''' <summary>
    ''' Adds passenger to waiting list
    ''' and adds name to seating chart
    ''' when seat becomes available
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnWait_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWait.Click

        Dim strNames As New List(Of String)
        strNames.Add("Brandon")
        strNames.Add("Andrea")
        strNames.Add("Shad")
        strNames.Add("Nick")
        strNames.Add(txtWaiting.Text)

        Try

            For i As Integer = 0 To 9

                For x As Integer = 0 To 3

                    If arrayChart(i, x) = "" Then

                        arrayChart(i, x) = strNames.First

                    End If

                Next

            Next

        Catch ex As InvalidCastException
            MessageBox.Show("Invalid Data")
        Catch ex As Exception
            MessageBox.Show("Error occurred")
        End Try

    End Sub
End Class
