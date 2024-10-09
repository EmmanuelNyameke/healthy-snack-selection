Public Class frmInternationalSnacks
    Private Sub btnBurrito_Click(sender As Object, e As EventArgs) Handles btnBurrito.Click
        picBeanBurrito.Visible = True
        picFalafel.Visible = False
        picGreekYoghurt.Visible = False
        picSpringRolls.Visible = False
        btnSelect.Enabled = True
    End Sub

    Private Sub btnFalafel_Click(sender As Object, e As EventArgs) Handles btnFalafel.Click
        picFalafel.Visible = True
        picBeanBurrito.Visible = False
        picGreekYoghurt.Visible = False
        picSpringRolls.Visible = False
        btnSelect.Enabled = True
    End Sub

    Private Sub btnYoghurt_Click(sender As Object, e As EventArgs) Handles btnYoghurt.Click
        picGreekYoghurt.Visible = True
        picBeanBurrito.Visible = False
        picFalafel.Visible = False
        picSpringRolls.Visible = False
        btnSelect.Enabled = True
    End Sub

    Private Sub btnRolls_Click(sender As Object, e As EventArgs) Handles btnRolls.Click
        picSpringRolls.Visible = True
        picBeanBurrito.Visible = False
        picGreekYoghurt.Visible = False
        picFalafel.Visible = False
        btnSelect.Enabled = True
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        btnBurrito.Enabled = False
        btnFalafel.Enabled = False
        btnYoghurt.Enabled = False
        btnRolls.Enabled = False
        lblQuestion.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
