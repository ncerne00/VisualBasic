
Public Class frmLINQ


    Private Sub btnLINQExample1_Click(sender As Object, e As EventArgs) Handles btnLINQExample1.Click
        lstReturn.Items.Clear()

        Dim db As New bit3444_airports

        Dim airports As List(Of tblAirport) = (From airport In db.tblAirports
                                               Where airport.City.Contains("New York")).ToList

        For Each airport In airports
            lstReturn.Items.Add(airport.Code & " - " & airport.Name)
        Next

    End Sub

    Private Sub btnLINQExample2_Click(sender As Object, e As EventArgs) Handles btnLINQExample2.Click
        lstReturn.Items.Clear()

        Dim db As New bit3444_airports
        Try
            Dim mi As Integer = txtMiles.Text

            Dim flights As List(Of tblFlight) = (From flight In db.tblFlights
                                                 Where flight.distance >= mi
                                                 Order By flight.arriveAT).Take(100).ToList

            For Each flight In flights
                lstReturn.Items.Add(flight.departFROM & " to " & flight.arriveAT & " - " & flight.distance)
            Next



        Catch ex As Exception
            MessageBox.Show(ex, "Error")
        End Try




    End Sub
End Class
