<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnConsultar = New Button()
        lstProductos = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        btnAgregar = New Button()
        btnEliminar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        total = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtCedula = New TextBox()
        txtDireccion = New TextBox()
        btnGuardar = New Button()
        lstAgregados = New ListView()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' btnConsultar
        ' 
        btnConsultar.Location = New Point(21, 23)
        btnConsultar.Name = "btnConsultar"
        btnConsultar.Size = New Size(155, 27)
        btnConsultar.TabIndex = 0
        btnConsultar.Text = "Consultar Productos"
        btnConsultar.UseVisualStyleBackColor = True
        ' 
        ' lstProductos
        ' 
        lstProductos.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3})
        lstProductos.FullRowSelect = True
        lstProductos.GridLines = True
        lstProductos.Location = New Point(12, 124)
        lstProductos.Name = "lstProductos"
        lstProductos.Size = New Size(322, 204)
        lstProductos.TabIndex = 1
        lstProductos.UseCompatibleStateImageBehavior = False
        lstProductos.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Id"
        ColumnHeader1.Width = 40
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Producto"
        ColumnHeader2.Width = 100
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Valor"
        ColumnHeader3.Width = 80
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(370, 124)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(137, 41)
        btnAgregar.TabIndex = 3
        btnAgregar.Text = "Agregar Producto"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(370, 204)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(137, 49)
        btnEliminar.TabIndex = 4
        btnEliminar.Text = "Eliminar Producto"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(559, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 20)
        Label1.TabIndex = 5
        Label1.Text = "Productos Agregados"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 20)
        Label2.TabIndex = 6
        Label2.Text = "Lista de Productos"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(543, 359)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 7
        Label3.Text = "Valor Total:"
        ' 
        ' total
        ' 
        total.AutoSize = True
        total.Location = New Point(632, 359)
        total.Name = "total"
        total.Size = New Size(0, 20)
        total.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 359)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 20)
        Label4.TabIndex = 9
        Label4.Text = "Nombre:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 401)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 10
        Label5.Text = "Apellido:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 441)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 20)
        Label6.TabIndex = 11
        Label6.Text = "Cédula:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 479)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 20)
        Label7.TabIndex = 12
        Label7.Text = "Dirección:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(95, 356)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(187, 27)
        txtNombre.TabIndex = 13
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(95, 398)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(187, 27)
        txtApellido.TabIndex = 14
        ' 
        ' txtCedula
        ' 
        txtCedula.Location = New Point(95, 438)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(187, 27)
        txtCedula.TabIndex = 15
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(95, 479)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(187, 27)
        txtDireccion.TabIndex = 16
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(344, 401)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(180, 81)
        btnGuardar.TabIndex = 17
        btnGuardar.Text = "Guardar Pedido"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' lstAgregados
        ' 
        lstAgregados.Columns.AddRange(New ColumnHeader() {ColumnHeader4, ColumnHeader5, ColumnHeader6})
        lstAgregados.FullRowSelect = True
        lstAgregados.GridLines = True
        lstAgregados.Location = New Point(559, 124)
        lstAgregados.Name = "lstAgregados"
        lstAgregados.Size = New Size(352, 196)
        lstAgregados.TabIndex = 18
        lstAgregados.UseCompatibleStateImageBehavior = False
        lstAgregados.View = View.Details
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Id"
        ColumnHeader4.Width = 30
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Producto"
        ColumnHeader5.Width = 100
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Valor"
        ColumnHeader6.Width = 80
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(651, 359)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 20)
        Label8.TabIndex = 19
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1054, 547)
        Controls.Add(Label8)
        Controls.Add(lstAgregados)
        Controls.Add(btnGuardar)
        Controls.Add(txtDireccion)
        Controls.Add(txtCedula)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(total)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnEliminar)
        Controls.Add(btnAgregar)
        Controls.Add(lstProductos)
        Controls.Add(btnConsultar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnConsultar As Button
    Friend WithEvents lstProductos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents total As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lstAgregados As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label8 As Label
End Class
