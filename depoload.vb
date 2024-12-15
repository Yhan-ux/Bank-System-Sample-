Public Class depoload

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            ProgressBar1.Value += 1


            If ProgressBar1.Value > 100 - 1 Then
                loading.Text = "loading..."
                LOGIN_Form.Show()
                Me.Close()
                Timer1.Stop()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class