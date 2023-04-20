Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Net.Http.Json
Imports System.Reflection.Metadata
Imports System.Text
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

        Try
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
        Catch ex As Exception

            MessageBox.Show("Ocurrió un error al consultar los productos")

        End Try
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

        Try

            If txtNombre IsNot Nothing And txtNombre IsNot Nothing And txtNombre IsNot Nothing And txtNombre IsNot Nothing And lstAgregados.Items.Count > 0 Then

                Dim pedido = CrearObjetoAGuardar()
                GuardarPedido(pedido)


            Else
                MessageBox.Show("No están los datos completos")

            End If
        Catch ex As Exception

            MessageBox.Show("Ocurrió un error al tratar de Guardar el pedido")

        End Try
    End Sub


    Private Function CalcularPrecioTotal() As Decimal

        Dim tot As Decimal

        For Each prodActuales As ListViewItem In lstAgregados.Items

            tot = tot + Decimal.Parse(prodActuales.SubItems(2).Text)

        Next

        Return tot

    End Function


    Private Async Function ObtenerProductos() As Task(Of String)

        Dim httpClient As New HttpClient()
        Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)
        response.EnsureSuccessStatusCode()
        Dim responseString As String = Await response.Content.ReadAsStringAsync()
        Return responseString

    End Function

    Private Async Sub GuardarPedido(pedido As Pedido)


        Dim postData As String = JsonConvert.SerializeObject(pedido)
        Dim httpClient = New HttpClient()
        httpClient.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))
        Dim httpContent As New StringContent(postData, Encoding.UTF8, "application/json")
        Dim response As HttpResponseMessage = Await httpClient.PostAsync(url, httpContent)

        If response.StatusCode = HttpStatusCode.OK Then

            InicializarCampos()
            MessageBox.Show("Pedido guardado Exitosamente")

        End If

        If response.StatusCode = HttpStatusCode.InternalServerError Then

            MessageBox.Show("Ocurrió un error al guardar el pedido")

        End If

    End Sub

    Private Function CrearObjetoAGuardar() As Pedido

        Dim pedido = New Pedido()
        pedido.Nombre = txtNombre.Text
        pedido.Apellido = txtApellido.Text
        pedido.Cedula = txtCedula.Text
        pedido.Direccion = txtDireccion.Text
        pedido.IdProductos = New List(Of String)()

        For Each prodActuales As ListViewItem In lstAgregados.Items

            pedido.IdProductos.Add(prodActuales.SubItems(0).Text)

        Next

        Return pedido

    End Function

    Private Sub InicializarCampos()

        lstAgregados.Items.Clear()
        txtNombre.Text = String.Empty
        txtApellido.Text = String.Empty
        txtCedula.Text = String.Empty
        txtDireccion.Text = String.Empty
        Label8.Text = String.Empty


    End Sub

End Class
