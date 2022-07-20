Public Class frm_mainmenu_a176426

    Private Sub frm_mainmenu_a176426_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click

        frm_products_a176426.Show()
        'Me.Hide()

    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click

        frm_orders_a176426.Show()


    End Sub

    Private Sub btn_customers_Click(sender As Object, e As EventArgs) Handles btn_customers.Click
        frm_customers_a176426.Show()

    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staff_a176426.Show()

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub
End Class