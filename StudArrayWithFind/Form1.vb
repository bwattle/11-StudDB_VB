﻿Public Class Form1
    'set up a record or "class" for a student

    Class STUDENT
        Public firstname As String
        Public lastname As String
        Public DOB As Date
        Public gender As Char
        Public avMk As Single
        Public phoneNo As String
        Public paid As Boolean
    End Class
    Dim students(20) As STUDENT
    Dim studentCount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'allocate memory
        For i = 0 To 20
            students(i) = New STUDENT
        Next
        'load test records
        students(0).firstname = "Johnny"
        students(0).lastname = "Depp"
        students(0).DOB = "9/6/63"
        students(0).gender = "m"
        students(0).avMk = 78.2
        students(0).phoneNo = "0123456789"
        students(0).paid = False
        students(1).firstname = "Jennifer"
        students(1).lastname = "Lawrence"
        students(1).DOB = "15/8/90"
        students(1).gender = "f"
        students(1).avMk = 88.2
        students(1).phoneNo = "0987654321"
        students(1).paid = True
        students(2).firstname = "George"
        students(2).lastname = "Clooney"
        students(2).DOB = "6/5/61"
        students(2).gender = "f"
        students(2).avMk = 68.2
        students(3).firstname = "Scarlett"
        students(3).lastname = "Johansson"
        students(3).DOB = "22/11/84"
        students(3).gender = "f"
        students(3).avMk = 72.2
        students(4).firstname = "Johnny"
        students(4).lastname = "Deppy"
        students(4).DOB = "9/6/68"
        students(4).gender = "m"
        students(4).avMk = 78.2
        students(4).phoneNo = "0123456789"
        students(4).paid = False
        students(5).firstname = "Fred"
        students(5).lastname = "Bear"
        students(5).DOB = "9/4/63"
        students(5).gender = "m"
        students(5).avMk = 78.2
        students(5).phoneNo = "0123456789"
        students(5).paid = False
        students(6).firstname = "Mickey"
        students(6).lastname = "Mouse"
        students(6).DOB = "28/12/98"
        students(6).gender = "m"
        students(6).avMk = 78.2
        students(6).phoneNo = "0123456789"
        students(6).paid = False
        students(7).firstname = "Fred"
        students(7).lastname = "Flintstone"
        students(7).DOB = "4/11/03"
        students(7).gender = "m"
        students(7).avMk = 78.2
        students(7).phoneNo = "0123456789"
        students(7).paid = False
        students(8).firstname = "Minnie"
        students(8).lastname = "Mouse"
        students(8).DOB = "9/6/63"
        students(8).gender = "f"
        students(8).avMk = 78.2
        students(8).phoneNo = "0123455555"
        students(8).paid = True
        students(9).firstname = "Boo"
        students(9).lastname = "Depp"
        students(9).DOB = "9/6/01"
        students(9).gender = "m"
        students(9).avMk = 99
        students(9).phoneNo = "0123456789"
        students(9).paid = False
        students(10).firstname = "Lori Anne"
        students(10).lastname = "Allison"
        students(10).DOB = "9/6/63"
        students(10).gender = "f"
        students(10).avMk = 66
        students(10).phoneNo = "0123456789"
        students(10).paid = False
        students(11).firstname = "Amber"
        students(11).lastname = "Heard"
        students(11).DOB = "28/2/00"
        students(11).gender = "f"
        students(11).avMk = 77
        students(11).phoneNo = "0123456789"
        students(11).paid = False
        students(12).firstname = "Pistol"
        students(12).lastname = "Depp"
        students(12).DOB = "9/6/98"
        students(12).gender = "m"
        students(12).avMk = 3
        students(12).phoneNo = "0123456789"
        students(12).paid = False
        'set the student count to the number of students which have been entered
        studentCount = 13
        displayList()
    End Sub
    Private Sub btnAddStud_Click(sender As Object, e As EventArgs) Handles btnAddStud.Click
        'Validate that the first name field is NOT blank
        If txtFirstName.Text = "" Then
            MsgBox("Please enter a 'first name'", MsgBoxStyle.Exclamation, "Check First Name field")
            'MessageBox.Show("Please enter a 'first name'", "Check First Name field", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtFirstName.Focus()
            Exit Sub
        End If
        'Validate that the first name field is NOT more than 20 characters
        If Len(txtFirstName.Text) > 20 Then
            MsgBox("Please enter a 'first name' less than 20 characters", MsgBoxStyle.Exclamation, "Check First Name field")
            txtFirstName.Focus()
            Exit Sub
        End If
        'Validate that the last name field is NOT blank
        If txtLastName.Text = "" Then
            MsgBox("Please enter a 'last name'", MsgBoxStyle.Exclamation, "Check Last Name field")
            txtLastName.Focus()
            Exit Sub
        End If
        'Validate that the last name field is NOT more than 20 characters
        If Len(txtLastName.Text) > 20 Then
            MsgBox("Please enter a 'last name' less than 20 characters", MsgBoxStyle.Exclamation, "Check Last Name field")
            txtLastName.Focus()
            Exit Sub
        End If
        'Validate that the DoB field is in date format
        If Not IsDate(txtDOB.Text) Then
            MsgBox("Please enter in the format 'd/mm/yy'", MsgBoxStyle.Exclamation, "Check Date Of Birth field")
            txtDOB.Focus()
            Exit Sub
        End If
        'Validate that the DoB field is between year 1960 and year 2010
        If Not (txtDOB.Text >= #1/1/1998# AndAlso txtDOB.Text < #1/1/2005#) Then
            MsgBox("Please enter a DoB between 1998 and 2004 in the format 'd/mm/yy'", MsgBoxStyle.Exclamation, "Check Date Of Birth field")
            txtDOB.Focus()
            Exit Sub
        End If

        'Validate that the gender field holds "m" of "f"
        If Not (LCase(txtGender.Text) = "m" Or LCase(txtGender.Text) = "f") Then
            MsgBox("Please enter 'f' or 'm' ", MsgBoxStyle.Exclamation, "Check Gender field")
            txtGender.Focus()
            Exit Sub
        End If
        'Validate that the average mark field is a number
        If Not IsNumeric(txtAvMk.Text) Then
            MsgBox("Please ensure Average Mark is a number", MsgBoxStyle.Exclamation, "Check the Average Mark field")
            txtAvMk.Focus()
            Exit Sub
        End If
        'Validate that the average mark field is betweem 0 and 100 inclusive
        If Not (txtAvMk.Text >= 0 And txtAvMk.Text <= 100) Then
            MsgBox("Please ensure Average Mark is between 0 and 100", MsgBoxStyle.Exclamation, "Check the Average Mark field")
            txtAvMk.Focus()
            Exit Sub
        End If
        'Validate that the phone # field has 10 digits (in fact 12, with the 2 dashes)
        If Not Len(Trim(txtPhone.Text)) = 12 Then
            MsgBox("Please enter 10 digits for the phone number", MsgBoxStyle.Exclamation, "Check Phone # field")
            txtPhone.Focus()
            Exit Sub
        End If

        'place text from text boxes into the array - first students(0), then students(1), students(2) etc
        students(studentCount).firstname = txtFirstName.Text
        students(studentCount).lastname = txtLastName.Text
        students(studentCount).DOB = txtDOB.Text
        students(studentCount).gender = LCase(txtGender.Text)
        students(studentCount).avMk = txtAvMk.Text
        students(studentCount).phoneNo = txtPhone.Text
        students(studentCount).paid = chkPaid.Checked
        studentCount += 1
        'return text boxes to blank ready for next entry
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtDOB.Text = #1/01/2003#
        txtGender.Text = ""
        txtAvMk.Text = ""
        txtPhone.Text = ""
        chkPaid.Checked = False
        displayList()

        txtFirstName.Focus()
    End Sub
    Private Sub displayList()
        'clear the list box as it keeps the earlier loop
        lstStud.Items.Clear()
        'loop through the array to print all rows
        For i = 0 To studentCount - 1
            lstStud.Items.Add(students(i).firstname & " - " & students(i).lastname & " - " &
                              students(i).DOB & " - " & students(i).gender & " - " &
                              students(i).avMk & " - " & students(i).phoneNo & " - " &
                              students(i).paid & ".")
        Next
        lstStud.SelectedIndex = studentCount - 1
    End Sub

    Private Sub btnFindStud_Click(sender As Object, e As EventArgs) Handles btnFindStud.Click
        If txtLastName.Text = "" Then
            lstStud.ClearSelected()
            MsgBox("Please add a 'Last Name' to be searched", MsgBoxStyle.Exclamation, "Add search name to 'Last Name'.")
            Exit Sub
        End If
        Dim foundStud = False
        Dim searchCount As Integer = 0
        While searchCount < studentCount And foundStud = False
            If LCase(students(searchCount).lastname) = LCase(txtLastName.Text) Then
                foundStud = True
                lstStud.SelectedIndex = searchCount
            End If
            searchCount = searchCount + 1 'note the ... and VS message which appears on compile
        End While
        If foundStud = False Then
            lstStud.ClearSelected()
            txtTestItem.Text = "This student cannot be found! "
        End If
    End Sub

    Private Sub lstStud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStud.SelectedIndexChanged
        txtTestItem.Text = lstStud.SelectedItem
        txtTestIndex.Text = lstStud.SelectedIndex
    End Sub
End Class
