Public Class Formload

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' Dim iVar As Integer

        'iVar = iVar + 1
        'If iVar > 3 Then
        'Timer1.Enabled = False
        ' Home.Show()
        'Me.Hide()
        ' End If
        Try
            ProgressBar1.Value += 1
            lblload.Text = ProgressBar1.Value & "%"
            If ProgressBar1.Value > 20 Then
                loading.Text = "Loading please wait..."
            End If
            If ProgressBar1.Value > 80 Then
                loading.Text = "preparing to open the application..."
            End If
            If ProgressBar1.Value > 100 - 1 Then
                loading.Text = "Lunching the Application..."
                Home.Show()
                Me.Hide()
                Timer1.Stop()
                MsgBox(" Welcome to PNB... Please click [Ok] to procced...>>>", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Formload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class