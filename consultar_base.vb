Public Class consultar_base

    Private Sub DocumentosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DocumentosBindingSource.EndEdit()
        Me.DocumentosTableAdapter.Update(Me.IntegraDataSet.Documentos)

    End Sub

    Private Sub consultar_base_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'IntegraDataSet.pagos_detalle' Puede moverla o quitarla según sea necesario.
        Me.Pagos_detalleTableAdapter.Fill(Me.IntegraDataSet.pagos_detalle)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'TODO: esta línea de código carga datos en la tabla 'IntegraDataSet.Pagos' Puede moverla o quitarla según sea necesario.
        Me.PagosTableAdapter.FillByfechacaja(Me.IntegraDataSet.Pagos, cajatxt.Text, fecha.Text)
        'TODO: esta línea de código carga datos en la tabla 'IntegraDataSet.movimientos' Puede moverla o quitarla según sea necesario.
        Me.MovimientosTableAdapter.FillByfechacaja(Me.IntegraDataSet.movimientos, fecha.Text, cajatxt.Text)
        'TODO: esta línea de código carga datos en la tabla 'IntegraDataSet.Documentos' Puede moverla o quitarla según sea necesario.
        Me.DocumentosTableAdapter.FillByfechacaja(Me.IntegraDataSet.Documentos, fecha.Text, cajatxt.Text)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class