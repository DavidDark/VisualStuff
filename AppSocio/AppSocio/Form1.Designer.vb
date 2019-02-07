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
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.nuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.consultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.agregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.modificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.salirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.menuStrip1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nuevoToolStripMenuItem, Me.consultarToolStripMenuItem, Me.agregarToolStripMenuItem, Me.modificarToolStripMenuItem, Me.eliminarToolStripMenuItem, Me.salirToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(770, 28)
        Me.menuStrip1.TabIndex = 2
        Me.menuStrip1.Text = "menuStrip1"
        '
        'nuevoToolStripMenuItem
        '
        Me.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem"
        Me.nuevoToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.nuevoToolStripMenuItem.Text = "Nuevo"
        '
        'consultarToolStripMenuItem
        '
        Me.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem"
        Me.consultarToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.consultarToolStripMenuItem.Text = "Consultar"
        '
        'agregarToolStripMenuItem
        '
        Me.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem"
        Me.agregarToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.agregarToolStripMenuItem.Text = "Agregar"
        '
        'modificarToolStripMenuItem
        '
        Me.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem"
        Me.modificarToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.modificarToolStripMenuItem.Text = "Modificar"
        '
        'eliminarToolStripMenuItem
        '
        Me.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem"
        Me.eliminarToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.eliminarToolStripMenuItem.Text = "Eliminar"
        '
        'salirToolStripMenuItem
        '
        Me.salirToolStripMenuItem.Name = "salirToolStripMenuItem"
        Me.salirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.salirToolStripMenuItem.Text = "Salir"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(40, 174)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(75, 18)
        Me.label5.TabIndex = 8
        Me.label5.Text = "Dirección:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(40, 221)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(70, 18)
        Me.label4.TabIndex = 7
        Me.label4.Text = "Teléfono:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(40, 126)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(63, 18)
        Me.label3.TabIndex = 6
        Me.label3.Text = "Apellido:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(40, 82)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(66, 18)
        Me.label2.TabIndex = 5
        Me.label2.Text = "Nombre:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(40, 38)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(23, 18)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Id:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(155, 35)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(195, 24)
        Me.txtId.TabIndex = 0
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(155, 218)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(195, 24)
        Me.txtTelefono.TabIndex = 4
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(155, 171)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(195, 24)
        Me.txtDireccion.TabIndex = 3
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(155, 123)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(195, 24)
        Me.txtApellido.TabIndex = 2
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.txtTelefono)
        Me.groupBox1.Controls.Add(Me.txtDireccion)
        Me.groupBox1.Controls.Add(Me.txtApellido)
        Me.groupBox1.Controls.Add(Me.txtNombre)
        Me.groupBox1.Controls.Add(Me.txtId)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(30, 64)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(372, 272)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Socio"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(155, 79)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(195, 24)
        Me.txtNombre.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 388)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents nuevoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents consultarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents agregarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents modificarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents eliminarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents salirToolStripMenuItem As ToolStripMenuItem
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents txtId As TextBox
    Private WithEvents txtTelefono As TextBox
    Private WithEvents txtDireccion As TextBox
    Private WithEvents txtApellido As TextBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents txtNombre As TextBox
End Class
