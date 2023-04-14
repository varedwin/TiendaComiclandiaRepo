Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports Newtonsoft.Json
Imports RestSharp

Public Class Form1

    Private lstProd As List(Of Productos)
    Private indexSelProd As Boolean
    Private indexSelAdicion As Boolean
    Private indexProd As Integer
    Private indexSel As Integer
    Private valorTotal As Decimal
    Private Const url As String = "http://localhost:5116/api/Productos"

    Private Async Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Dim resp As String = Await ObtenerProductos()
        lstProd = JsonConvert.DeserializeObject(Of List(Of Productos))(resp)

        If lstProductos IsNot Nothing Then

            lstProductos.Items.Clear()

        End If


        If lstProd IsNot Nothing Then

            For Each prod As Productos In lstProd

                With lstProductos.Items.Add(prod.Id)
                    .SubItems.Add(prod.NombreProducto)
                    .SubItems.Add(prod.Valor)
                End With

            Next

        End If

    End Sub




    Private Sub lstProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProductos.SelectedIndexChanged

        If lstProductos IsNot Nothing And lstProductos.FocusedItem IsNot Nothing Then
            indexProd = lstProductos.FocusedItem.Index
            indexSelProd = True
        End If


    End Sub

    Private Sub lstAgregados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAgregados.SelectedIndexChanged

        If lstAgregados IsNot Nothing And lstAgregados.FocusedItem IsNot Nothing Then
            indexSel = lstAgregados.FocusedItem.Index
            indexSelAdicion = True
        End If


    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If indexSelProd Then

            With lstAgregados.Items.Add(lstProductos.Items(indexProd).SubItems(0).Text)
                .SubItems.Add(lstProductos.Items(indexProd).SubItems(1).Text)
                .SubItems.Add(lstProductos.Items(indexProd).SubItems(2).Text)
            End With

            indexSelProd = False
            Label8.Text = CalcularPrecioTotal()

        Else

            MessageBox.Show("Debe seleccionar un Item")

        End If

    End Sub



    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If indexSelAdicion Then

            lstAgregados.Items.RemoveAt(indexSel)
            indexSelAdicion = False
            Label8.Text = CalcularPrecioTotal()
        Else

            MessageBox.Show("Debe seleccionar un Item")

        End If

    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtNombre IsNot Nothing And txtNombre IsNot Nothing And txtNombre IsNot Nothing And txtNombre IsNot Nothing And lstAgregados.Items.Count > 0 Then

            Dim ped = New Pedido()
            ped.Nombre = txtNombre.Text
            ped.Apellido = txtApellido.Text
            ped.Cedula = txtCedula.Text
            ped.Direccion = txtDireccion.Text

            GuardarProductos(ped)

        Else
            MessageBox.Show("No están los datos completos")

        End If

    End Sub


    Private Function CalcularPrecioTotal() As Decimal

        Dim tot As Decimal

        For Each prodActuales As ListViewItem In lstAgregados.Items

            tot = tot + Decimal.Parse(prodActuales.SubItems(2).Text)

        Next

        Return tot

    End Function


    Private Async Function ObtenerProductos() As Task(Of String)

        Dim req As WebRequest = WebRequest.Create(url)
        Dim resp As WebResponse = req.GetResponse()
        Dim sr As StreamReader = New StreamReader(resp.GetResponseStream())
        Return Await sr.ReadToEndAsync()

    End Function

    Private Sub GuardarProductos(pedido As Pedido)

        MessageBox.Show("Información enviada a la base de datos")

    End Sub



End Class
