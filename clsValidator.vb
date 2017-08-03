Public Class clsValidator
    Public Shared Sub Validator()

        'VALIDATE ALL INPUTS FOR CATALOG FORM

        If Application.OpenForms().OfType(Of frmCatalog).Any Then
            If frmCatalog.CATALOG_IDTextBox.Text = "" Then
                MessageBox.Show("Invalid input!" & vbCrLf & "Catalog ID is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf frmCatalog.COURSE_IDComboBox.Text = "" Then
                MessageBox.Show("Invalid input!" & vbCrLf & "Course ID is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf frmCatalog.YEARTextBox.Text = "" Then
                MessageBox.Show("Invalid input!" & vbCrLf & "The year is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If

        'VALIDATE ALL INPUTS FOR COURSE FORM

        If Application.OpenForms().OfType(Of frmCourse).Any Then

            If frmCourse.COURSE_IDTextBox.Text = "" Then
                MessageBox.Show("Invalid input!" & vbCrLf & "Course ID is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf frmCourse.UNITSTextBox.Text = "" Then
                MessageBox.Show("Invalid input!" & vbCrLf & "Unit name is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            ElseIf frmCourse.DESCRIPTIONTextBox.Text = "" Then
                MessageBox.Show("Invalid input!" & vbCrLf & "Description is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If

        'VALIDATE ALL ENROLLMENT FORM INPUTS

        If Application.OpenForms().OfType(Of frmEnrollment).Any Then
            If frmEnrollment.BRONCO_IDComboBox.Text = "" Then
                MessageBox.Show("Invalid input!" & vbCrLf & "Bronco ID is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            ElseIf frmEnrollment.CATALOG_IDComboBox.Text = "" Then
                MessageBox.Show("Invalid input!" & vbCrLf & "Catalog ID is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        End If

        'VALIDATE STUDENT INPUT
        If Application.OpenForms().OfType(Of frmStudent).Any Then
            If frmStudent.BRONCO_IDTextBox.Text = "" Then
                MessageBox.Show("Invalid input!" & vbCrLf & "Student Bronco ID is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf frmStudent.EMAILTextBox.Text = "" Then
                MessageBox.Show("Invalid input!" & vbCrLf & "Enter a valid email!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf frmStudent.FIRST_NAMETextBox.Text = "" Then
                MessageBox.Show("Invalid input!" & vbCrLf & "First name is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf frmStudent.LAST_NAMETextBox.Text = "" Then
                MessageBox.Show("Invalid input!" & vbCrLf & "Last name is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf frmStudent.PHONETextBox.Text = "" Or IsNumeric(frmStudent.PHONETextBox.Text) Then
                MessageBox.Show("Invalid input!" & vbCrLf & "Phone number is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf Not IsNumeric(frmStudent.PHONETextBox.Text) Then
                MessageBox.Show("Invalid input!" & vbCrLf & "Enter a valid phone number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            End If
        End If
    End Sub
End Class
