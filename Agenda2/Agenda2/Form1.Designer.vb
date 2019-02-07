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
        Dim IdLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim Calle_y_NumeroLabel As System.Windows.Forms.Label
        Dim ColoniaLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim Telefono_de_CasaLabel As System.Windows.Forms.Label
        Dim Telefono_MovilLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Email_EmpresarialLabel As System.Windows.Forms.Label
        Dim FotografiaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Agenda01BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Agenda01BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Agenda01DataSet = New Agenda2.Agenda01DataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Agenda01BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.Calle_y_NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.ColoniaTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.Telefono_de_CasaTextBox = New System.Windows.Forms.TextBox()
        Me.Telefono_MovilTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Email_EmpresarialTextBox = New System.Windows.Forms.TextBox()
        Me.FotografiaPictureBox = New System.Windows.Forms.PictureBox()
        Me.Agenda01TableAdapter = New Agenda2.Agenda01DataSetTableAdapters.Agenda01TableAdapter()
        Me.TableAdapterManager = New Agenda2.Agenda01DataSetTableAdapters.TableAdapterManager()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        Calle_y_NumeroLabel = New System.Windows.Forms.Label()
        ColoniaLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        Telefono_de_CasaLabel = New System.Windows.Forms.Label()
        Telefono_MovilLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Email_EmpresarialLabel = New System.Windows.Forms.Label()
        FotografiaLabel = New System.Windows.Forms.Label()
        CType(Me.Agenda01BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agenda01BindingNavigator.SuspendLayout()
        CType(Me.Agenda01BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agenda01DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotografiaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(73, 62)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 18)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(36, 99)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(66, 18)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidoLabel.Location = New System.Drawing.Point(39, 134)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(63, 18)
        ApellidoLabel.TabIndex = 5
        ApellidoLabel.Text = "Apellido:"
        '
        'Calle_y_NumeroLabel
        '
        Calle_y_NumeroLabel.AutoSize = True
        Calle_y_NumeroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Calle_y_NumeroLabel.Location = New System.Drawing.Point(2, 169)
        Calle_y_NumeroLabel.Name = "Calle_y_NumeroLabel"
        Calle_y_NumeroLabel.Size = New System.Drawing.Size(114, 18)
        Calle_y_NumeroLabel.TabIndex = 7
        Calle_y_NumeroLabel.Text = "Calle y Numero:"
        '
        'ColoniaLabel
        '
        ColoniaLabel.AutoSize = True
        ColoniaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColoniaLabel.Location = New System.Drawing.Point(39, 205)
        ColoniaLabel.Name = "ColoniaLabel"
        ColoniaLabel.Size = New System.Drawing.Size(63, 18)
        ColoniaLabel.TabIndex = 9
        ColoniaLabel.Text = "Colonia:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CiudadLabel.Location = New System.Drawing.Point(44, 241)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(58, 18)
        CiudadLabel.TabIndex = 11
        CiudadLabel.Text = "Ciudad:"
        '
        'Telefono_de_CasaLabel
        '
        Telefono_de_CasaLabel.AutoSize = True
        Telefono_de_CasaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telefono_de_CasaLabel.Location = New System.Drawing.Point(2, 275)
        Telefono_de_CasaLabel.Name = "Telefono_de_CasaLabel"
        Telefono_de_CasaLabel.Size = New System.Drawing.Size(129, 18)
        Telefono_de_CasaLabel.TabIndex = 13
        Telefono_de_CasaLabel.Text = "Telefono de Casa:"
        '
        'Telefono_MovilLabel
        '
        Telefono_MovilLabel.AutoSize = True
        Telefono_MovilLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telefono_MovilLabel.Location = New System.Drawing.Point(7, 316)
        Telefono_MovilLabel.Name = "Telefono_MovilLabel"
        Telefono_MovilLabel.Size = New System.Drawing.Size(109, 18)
        Telefono_MovilLabel.TabIndex = 15
        Telefono_MovilLabel.Text = "Telefono Movil:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(53, 355)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(49, 18)
        EmailLabel.TabIndex = 17
        EmailLabel.Text = "Email:"
        '
        'Email_EmpresarialLabel
        '
        Email_EmpresarialLabel.AutoSize = True
        Email_EmpresarialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Email_EmpresarialLabel.Location = New System.Drawing.Point(2, 388)
        Email_EmpresarialLabel.Name = "Email_EmpresarialLabel"
        Email_EmpresarialLabel.Size = New System.Drawing.Size(132, 18)
        Email_EmpresarialLabel.TabIndex = 19
        Email_EmpresarialLabel.Text = "Email Empresarial:"
        '
        'FotografiaLabel
        '
        FotografiaLabel.AutoSize = True
        FotografiaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FotografiaLabel.Location = New System.Drawing.Point(446, 77)
        FotografiaLabel.Name = "FotografiaLabel"
        FotografiaLabel.Size = New System.Drawing.Size(79, 18)
        FotografiaLabel.TabIndex = 21
        FotografiaLabel.Text = "Fotografia:"
        '
        'Agenda01BindingNavigator
        '
        Me.Agenda01BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Agenda01BindingNavigator.BindingSource = Me.Agenda01BindingSource
        Me.Agenda01BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Agenda01BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Agenda01BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Agenda01BindingNavigatorSaveItem})
        Me.Agenda01BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Agenda01BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Agenda01BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Agenda01BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Agenda01BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Agenda01BindingNavigator.Name = "Agenda01BindingNavigator"
        Me.Agenda01BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Agenda01BindingNavigator.Size = New System.Drawing.Size(838, 25)
        Me.Agenda01BindingNavigator.TabIndex = 0
        Me.Agenda01BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Agenda01BindingNavigatorSaveItem
        '
        Me.Agenda01BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Agenda01BindingNavigatorSaveItem.Image = CType(resources.GetObject("Agenda01BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Agenda01BindingNavigatorSaveItem.Name = "Agenda01BindingNavigatorSaveItem"
        Me.Agenda01BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Agenda01BindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(122, 59)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(63, 24)
        Me.IdTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(122, 96)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(249, 24)
        Me.NombreTextBox.TabIndex = 4
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Apellido", True))
        Me.ApellidoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(122, 131)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(249, 24)
        Me.ApellidoTextBox.TabIndex = 6
        '
        'Calle_y_NumeroTextBox
        '
        Me.Calle_y_NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Calle y Numero", True))
        Me.Calle_y_NumeroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calle_y_NumeroTextBox.Location = New System.Drawing.Point(122, 166)
        Me.Calle_y_NumeroTextBox.Name = "Calle_y_NumeroTextBox"
        Me.Calle_y_NumeroTextBox.Size = New System.Drawing.Size(249, 24)
        Me.Calle_y_NumeroTextBox.TabIndex = 8
        '
        'ColoniaTextBox
        '
        Me.ColoniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Colonia", True))
        Me.ColoniaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColoniaTextBox.Location = New System.Drawing.Point(122, 202)
        Me.ColoniaTextBox.Name = "ColoniaTextBox"
        Me.ColoniaTextBox.Size = New System.Drawing.Size(249, 24)
        Me.ColoniaTextBox.TabIndex = 10
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Ciudad", True))
        Me.CiudadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiudadTextBox.Location = New System.Drawing.Point(122, 238)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(249, 24)
        Me.CiudadTextBox.TabIndex = 12
        '
        'Telefono_de_CasaTextBox
        '
        Me.Telefono_de_CasaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Telefono de Casa", True))
        Me.Telefono_de_CasaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefono_de_CasaTextBox.Location = New System.Drawing.Point(137, 272)
        Me.Telefono_de_CasaTextBox.Name = "Telefono_de_CasaTextBox"
        Me.Telefono_de_CasaTextBox.Size = New System.Drawing.Size(234, 24)
        Me.Telefono_de_CasaTextBox.TabIndex = 14
        '
        'Telefono_MovilTextBox
        '
        Me.Telefono_MovilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Telefono Movil", True))
        Me.Telefono_MovilTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefono_MovilTextBox.Location = New System.Drawing.Point(122, 313)
        Me.Telefono_MovilTextBox.Name = "Telefono_MovilTextBox"
        Me.Telefono_MovilTextBox.Size = New System.Drawing.Size(249, 24)
        Me.Telefono_MovilTextBox.TabIndex = 16
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(122, 349)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(249, 24)
        Me.EmailTextBox.TabIndex = 18
        '
        'Email_EmpresarialTextBox
        '
        Me.Email_EmpresarialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda01BindingSource, "Email Empresarial", True))
        Me.Email_EmpresarialTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_EmpresarialTextBox.Location = New System.Drawing.Point(140, 382)
        Me.Email_EmpresarialTextBox.Name = "Email_EmpresarialTextBox"
        Me.Email_EmpresarialTextBox.Size = New System.Drawing.Size(231, 24)
        Me.Email_EmpresarialTextBox.TabIndex = 20
        '
        'FotografiaPictureBox
        '
        Me.FotografiaPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Agenda01BindingSource, "Fotografia", True))
        Me.FotografiaPictureBox.Location = New System.Drawing.Point(531, 77)
        Me.FotografiaPictureBox.Name = "FotografiaPictureBox"
        Me.FotografiaPictureBox.Size = New System.Drawing.Size(241, 256)
        Me.FotografiaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotografiaPictureBox.TabIndex = 22
        Me.FotografiaPictureBox.TabStop = False
        '
        'Agenda01TableAdapter
        '
        Me.Agenda01TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Agenda01TableAdapter = Me.Agenda01TableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(715, 418)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(111, 34)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "Salir"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(715, 352)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(111, 34)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "Ultimo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(587, 352)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 34)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Siguiente"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(470, 352)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 34)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Anterior"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(470, 418)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 34)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Primero"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(587, 418)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 34)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Cargar Datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Agenda2.My.Resources.Resources._13348699_1001907106524727_1621033011_n
        Me.ClientSize = New System.Drawing.Size(838, 464)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(FotografiaLabel)
        Me.Controls.Add(Me.FotografiaPictureBox)
        Me.Controls.Add(Email_EmpresarialLabel)
        Me.Controls.Add(Me.Email_EmpresarialTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Telefono_MovilLabel)
        Me.Controls.Add(Me.Telefono_MovilTextBox)
        Me.Controls.Add(Telefono_de_CasaLabel)
        Me.Controls.Add(Me.Telefono_de_CasaTextBox)
        Me.Controls.Add(CiudadLabel)
        Me.Controls.Add(Me.CiudadTextBox)
        Me.Controls.Add(ColoniaLabel)
        Me.Controls.Add(Me.ColoniaTextBox)
        Me.Controls.Add(Calle_y_NumeroLabel)
        Me.Controls.Add(Me.Calle_y_NumeroTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.Agenda01BindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Agenda"
        CType(Me.Agenda01BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agenda01BindingNavigator.ResumeLayout(False)
        Me.Agenda01BindingNavigator.PerformLayout()
        CType(Me.Agenda01BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agenda01DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotografiaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Agenda01DataSet As Agenda01DataSet
    Friend WithEvents Agenda01BindingSource As BindingSource
    Friend WithEvents Agenda01TableAdapter As Agenda01DataSetTableAdapters.Agenda01TableAdapter
    Friend WithEvents TableAdapterManager As Agenda01DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Agenda01BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Agenda01BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents Calle_y_NumeroTextBox As TextBox
    Friend WithEvents ColoniaTextBox As TextBox
    Friend WithEvents CiudadTextBox As TextBox
    Friend WithEvents Telefono_de_CasaTextBox As TextBox
    Friend WithEvents Telefono_MovilTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Email_EmpresarialTextBox As TextBox
    Friend WithEvents FotografiaPictureBox As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
