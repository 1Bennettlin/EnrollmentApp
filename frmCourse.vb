Public Class frmCourse
    Public Sub setMode(strMode As String)
        'CONTROL THE DISPLAY OF LIST VS DETAIL OF CourseS

        If strMode = "L" Then
            'MODE IS LIST

            Me.gbCourseDetail.Hide()
            Me.gbCourseList.Left = 0
            Me.gbCourseList.Top = 0
            Me.Width = gbCourseList.Width + 50
            Me.Height = gbCourseList.Height + 50

            Me.gbCourseList.Visible = True
        Else
            'MODE IS DETAIL

            Me.gbCourseList.Hide()
            Me.gbCourseDetail.Left = 0
            Me.gbCourseDetail.Top = 0
            Me.Width = gbCourseDetail.Width + 50
            Me.Height = gbCourseDetail.Height + 50

            Me.gbCourseDetail.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clsValidator.Validator()
        'POPULATE CORSES
        Dim courseDetail As New clsCourse

        courseDetail.courseID = Me.COURSE_IDTextBox.Text
        courseDetail.decript = Me.DESCRIPTIONTextBox.Text
        courseDetail.units = Me.UNITSTextBox.Text


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        setMode("D")
        COURSE_IDTextBox.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'CLEAR ALL CONTROLS
        For Each ctrl In gbCourseDetail.Controls
            If TypeOf (ctrl) Is TextBox Then
                TryCast(ctrl, TextBox).Clear()
            End If
        Next

        'SET SAVE BUTTON TO DEFAULT 

    End Sub
End Class