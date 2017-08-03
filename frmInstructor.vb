Public Class frmInstructor

    Public Sub setMode(strMode As String)
        'CONTROL THE DISPLAY OF LIST VS DETAIL OF InstructorS

        If strMode = "L" Then
            'MODE IS LIST

            Me.gbInstructorDetail.Hide()
            Me.gbInstructorList.Left = 0
            Me.gbInstructorList.Top = 0
            Me.Width = gbInstructorList.Width + 50
            Me.Height = gbInstructorList.Height + 50

            Me.gbInstructorList.Visible = True
        Else
            'MODE IS DETAIL

            Me.gbInstructorList.Hide()
            Me.gbInstructorDetail.Left = 0
            Me.gbInstructorDetail.Top = 0
            Me.Width = gbInstructorDetail.Width + 50
            Me.Height = gbInstructorDetail.Height + 50

            Me.gbInstructorDetail.Visible = True
        End If
    End Sub
End Class