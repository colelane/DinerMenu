﻿'Lane Coleman
'RCET0265
'Fall 2020
'Diner Menu Form
'https://github.com/colelane/DinerMenu.git

Public Class DinerMenuForm

    'The follwing subs are basically saying "If (button) is clicked then do this"

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = "Mystery Meat Soup"
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = "Lettuce"
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = $"Wild caught, Alaskan, Purebred, Cage-Free, Non-GMO, Gluten Free, Locally Sourced, Hand Picked, Whole Grain, Antibiotic Free, Unpastuerized, Always Frozen, Farm Fresh, 75% cod 25% other.
*may be unsafe for consumption*"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
        'closes form.
    End Sub
End Class
