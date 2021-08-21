Public Class frmAirports

    Dim db As New bit3444_airports
    Private Sub frmAirports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bit3444_dataset.tblAirports' table. You can move, or remove it, as needed.
        Me.TblAirportsTableAdapter.Fill(Me.Bit3444_dataset.tblAirports)

        'The below code pulls the selected data from the BIT3444 dataset and populates the datagrid with it
        Dim query = (From airport In Bit3444_dataset.tblAirports
                     Select New With {.Code = airport.Code, .City = airport.City, .Name = airport.Name, .Active = airport.Active, .Lat = airport.Lat, ._Long = airport._Long})
        dgAirports.DataSource = query.ToList

    End Sub

    Private Sub btnGetFlights_Click(sender As Object, e As EventArgs) Handles btnGetFlights.Click

        Dim flightForm As New frmFlight(dgAirports.CurrentRow.Cells(0).Value)
        flightForm.Show()


        ' HOMEWORK #3 Requirement #2 ---------------------------------

        ' This initiates flightForm accepting the data grid's current cell as a parameter

        '----------------------------------------------------------
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.TblAirportsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bit3444_dataset)
    End Sub

End Class