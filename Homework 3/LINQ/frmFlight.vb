Public Class frmFlight

    Dim orig As tblAirport

    Dim db As New bit3444_airports

    Public Sub New(ByVal orgAirport As String)

        ' This call is required by the designer.



        'The below code pulls the code and city for the datagrid's current cell and populates the flightForm's origin label
        orig = (From origin In db.tblAirports
                Where origin.Code = orgAirport).Single
        originLbl.Text = orig.Code + " - " + orig.City
    End Sub

    Private Sub frmFlight_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Populate the list once the form is shown. The where clause ensures that only the active flights are pulled from the active flights list. 
        Dim listFlights As List(Of vwActiveFlights2) = (From flight In db.vwActiveFlights2
                                                        Where flight.departFROM = orig.Code).ToList
        'Adds each potential destination
        For Each flight In listFlights
            listFlightsBox.Items.Add(flight.arriveAT)
        Next
        'If there are no flights in listFlights, listFlights.Count will return zero and the list box will return "No active flights"
        If listFlights.Count = 0 Then
            listFlightsBox.Items.Add("No active flights.")
        End If

    End Sub

    ' HOMEWORK #3 Requirement #3 ---------------------------------
    'Change labels on the form when you change the values of your listbox.






    '----------------------------------------------------------

    'The code below actively keeps track of when items in the list box are selected, and updates the labels accordingly in the instance that a different .arriveAT is selected
    Private Sub listFlightsBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listFlightsBox.SelectedIndexChanged

        Dim dist As String = (From flight In db.vwActiveFlights2
                              Where flight.arriveAT = listFlightsBox.SelectedItem.ToString
                              Select flight.Distance).FirstOrDefault

        Dim currentArrival = getAirportCity(listFlightsBox.SelectedItem.ToString)
        arriveLabel.Text = listFlightsBox.SelectedItem.ToString + " - " + currentArrival
        distanceLabel.Text = dist.ToString + " Miles"
        departLabel.Text = originLbl.Text


    End Sub



    'You might need a function to get the Airport City to populate code & city
    Private Function getAirportCity(ByVal code As String) As String
        'this function returns the city that is associated with the input code 
        Dim cityCode = (From city In db.tblAirports
                        Where city.Code = code
                        Select city.City).Single

        Return cityCode

    End Function




    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


End Class