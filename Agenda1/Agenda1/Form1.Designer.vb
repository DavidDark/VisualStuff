<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.Agenda01BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Agenda01DataSet = New Agenda1.Agenda01DataSet()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblMovil = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblEmailEmp = New System.Windows.Forms.Label()
        Me.lblFoto = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtMovil = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtEmailEmp = New System.Windows.Forms.TextBox()
        Me.Agenda01TableAdapter = New Agenda1.Agenda01DataSetTableAdapters.Agenda01TableAdapter()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agenda01BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agenda01DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFoto
        '
        Me.picFoto.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Agenda01BindingSource, "Fotografia", True))
        Me.picFoto.Location = New System.Drawing.Point(652, 63)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(269, 253)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFoto.TabIndex = 0
        Me.picFoto.TabStop = False
        '
        'Agenda01BindingSource
        '
        Me.Agenda01BindingSource.DataMember = "Agenda01"
        Me.Agenda01BindingSource.DataSource = Me.Agenda01DataSet
        '
        'Agenda01DataSet
        '
        Me.Agenda01DataSet.DataSetName = "Agenda01DataSet"
        Me.Agenda01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(16, 34)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(28, 22)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "ID"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(16, 63)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(67, 22)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(16, 92)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(67, 22)
        Me.lblApellido.TabIndex = 3
        Me.lblApellido.Text = "Apellido"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalle.Location = New System.Drawing.Point(16, 123)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(117, 22)
        Me.lblCalle.TabIndex = 4
        Me.lblCalle.Text = "Calle y Numero"
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblColonia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColonia.Location = New System.Drawing.Point(16, 152)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(64, 22)
        Me.lblColonia.TabIndex = 5
        Me.lblColonia.Text = "Colonia"
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiudad.Location = New System.Drawing.Point(16, 181)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(61, 22)
        Me.lblCiudad.TabIndex = 6
        Me.lblCiudad.Text = "Ciudad"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(16, 210)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(133, 22)
        Me.lblTelefono.TabIndex = 7
        Me.lblTelefono.Text = "Telefono de casa"
        '
        'lblMovil
        '
        Me.lblMovil.AutoSize = True
        Me.lblMovil.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMovil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMovil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovil.Location = New System.Drawing.Point(16, 239)
        Me.lblMovil.Name = "lblMovil"
        Me.lblMovil.Size = New System.Drawing.Size(112, 22)
        Me.lblMovil.TabIndex = 8
        Me.lblMovil.Text = "Telefono Movil"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(16, 269)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(50, 22)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email"
        '
        'lblEmailEmp
        '
        Me.lblEmailEmp.AutoSize = True
        Me.lblEmailEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblEmailEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmailEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailEmp.Location = New System.Drawing.Point(16, 296)
        Me.lblEmailEmp.Name = "lblEmailEmp"
        Me.lblEmailEmp.Size = New System.Drawing.Size(138, 22)
        Me.lblEmailEmp.TabIndex = 10
        Me.lblEmailEmp.Text = "Email Empresarial"
        '
        'lblFoto
        '
        Me.lblFoto.AutoSize = True
        Me.lblFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoto.Location = New System.Drawing.Point(751, 23)
        Me.lblFoto.Name = "lblFoto"
        Me.lblFoto.Size = New System.Drawing.Size(84, 22)
        Me.lblFoto.TabIndex = 11
        Me.lblFoto.Text = "Fotografia"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(20, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 34)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Cargar Datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(148, 414)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 34)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Primero"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(275, 414)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 34)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Anterior"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(402, 414)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 34)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Siguiente"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(529, 414)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(111, 34)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Ultimo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(781, 414)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(111, 34)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Salir"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Id", True))
        Me.txtId.Location = New System.Drawing.Point(178, 34)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(418, 20)
        Me.txtId.TabIndex = 18
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(178, 65)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(418, 20)
        Me.txtNombre.TabIndex = 19
        '
        'txtApellido
        '
        Me.txtApellido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Apellido", True))
        Me.txtApellido.Location = New System.Drawing.Point(178, 94)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(418, 20)
        Me.txtApellido.TabIndex = 20
        '
        'txtCalle
        '
        Me.txtCalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Calle y Numero", True))
        Me.txtCalle.Location = New System.Drawing.Point(178, 125)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(418, 20)
        Me.txtCalle.TabIndex = 21
        '
        'txtColonia
        '
        Me.txtColonia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Colonia", True))
        Me.txtColonia.Location = New System.Drawing.Point(178, 154)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(418, 20)
        Me.txtColonia.TabIndex = 22
        '
        'txtCiudad
        '
        Me.txtCiudad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Ciudad", True))
        Me.txtCiudad.Location = New System.Drawing.Point(178, 183)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(418, 20)
        Me.txtCiudad.TabIndex = 23
        '
        'txtTelefono
        '
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Telefono de Casa", True))
        Me.txtTelefono.Location = New System.Drawing.Point(178, 212)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(418, 20)
        Me.txtTelefono.TabIndex = 24
        '
        'txtMovil
        '
        Me.txtMovil.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Telefono Movil", True))
        Me.txtMovil.Location = New System.Drawing.Point(178, 241)
        Me.txtMovil.Name = "txtMovil"
        Me.txtMovil.Size = New System.Drawing.Size(418, 20)
        Me.txtMovil.TabIndex = 25
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Email", True))
        Me.txtEmail.Location = New System.Drawing.Point(178, 271)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(418, 20)
        Me.txtEmail.TabIndex = 26
        '
        'txtEmailEmp
        '
        Me.txtEmailEmp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Email Empresarial", True))
        Me.txtEmailEmp.Location = New System.Drawing.Point(178, 298)
        Me.txtEmailEmp.Name = "txtEmailEmp"
        Me.txtEmailEmp.Size = New System.Drawing.Size(418, 20)
        Me.txtEmailEmp.TabIndex = 27
        '
        'Agenda01TableAdapter
        '
        Me.Agenda01TableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Agenda1.My.Resources.Resources._72829_449132568508914_2110143416_n
        Me.ClientSize = New System.Drawing.Size(948, 482)
        Me.Controls.Add(Me.txtEmailEmp)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtMovil)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.txtColonia)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblFoto)
        Me.Controls.Add(Me.lblEmailEmp)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblMovil)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblCiudad)
        Me.Controls.Add(Me.lblColonia)
        Me.Controls.Add(Me.lblCalle)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.picFoto)
        Me.Name = "Form1"
        Me.Text = "Agenda"
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agenda01BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agenda01DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents lblId As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblCalle As Label
    Friend WithEvents lblColonia As Label
    Friend WithEvents lblCiudad As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblMovil As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblEmailEmp As Label
    Friend WithEvents lblFoto As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtMovil As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtEmailEmp As TextBox
    Friend WithEvents Agenda01DataSet As Agenda01DataSet
    Friend WithEvents Agenda01BindingSource As BindingSource
    Friend WithEvents Agenda01TableAdapter As Agenda01DataSetTableAdapters.Agenda01TableAdapter
End Class
