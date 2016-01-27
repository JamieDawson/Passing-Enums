Public Class Form1
    Private Enum Sports As Integer
        baseball = 0
        basketball = 1
        football = 2

    End Enum

    Private mySport As Sports

    Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
        clearList()
        For Each item As Integer In System.Enum.GetValues(GetType(Sports))
            listEnumValues.Items.Add(item.ToString())
        Next




        For Each item As String In System.Enum.GetNames(GetType(Sports))
            listEnumNames.Items.Add(item)
        Next

        analyzeSport(mySport)
    End Sub

    Private Sub comboSports_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSports.SelectedIndexChanged
        If comboSports.SelectedIndex <> -1 Then
            mySport = comboSports.SelectedIndex
        End If


    End Sub

    Private Sub clearList()
        listEnumNames.Items.Clear()
        listEnumValues.Items.Clear()


    End Sub

    Private Sub analyzeSport(ByVal sportsList As Sports)
        Select Case sportsList
            Case Is = Sports.baseball
                MessageBox.Show("Your sport is baseball")
            Case Is = Sports.football
                MessageBox.Show("Your sport is football")
            Case Is = Sports.basketball
                MsgBox("Your sport is basketball")
            Case Else
                MsgBox("You don't have a sport")
        End Select
    End Sub
End Class
