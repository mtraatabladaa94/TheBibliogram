﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrestamo
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
        Dim GradientBlend13 As Klik.Windows.Forms.v1.Common.GradientBlend = New Klik.Windows.Forms.v1.Common.GradientBlend()
        Dim GradientBlend14 As Klik.Windows.Forms.v1.Common.GradientBlend = New Klik.Windows.Forms.v1.Common.GradientBlend()
        Dim GradientBlend15 As Klik.Windows.Forms.v1.Common.GradientBlend = New Klik.Windows.Forms.v1.Common.GradientBlend()
        Dim GradientBlend16 As Klik.Windows.Forms.v1.Common.GradientBlend = New Klik.Windows.Forms.v1.Common.GradientBlend()
        Dim GradientBlend17 As Klik.Windows.Forms.v1.Common.GradientBlend = New Klik.Windows.Forms.v1.Common.GradientBlend()
        Dim GradientBlend18 As Klik.Windows.Forms.v1.Common.GradientBlend = New Klik.Windows.Forms.v1.Common.GradientBlend()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KFormManager1 = New Klik.Windows.Forms.v1.Common.KFormManager(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btEditar = New System.Windows.Forms.ToolStripButton()
        Me.btEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btImprimir = New System.Windows.Forms.ToolStripButton()
        Me.pnPrestamo = New DevComponents.DotNetBar.PanelEx()
        Me.ElGroupBox1 = New Klik.Windows.Forms.v1.EntryLib.ELGroupBox()
        Me.txtIdPersona = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNombrePersona = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btAgregarPersona = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btBuscarPersona = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.txtPersona = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnTitulo = New DevComponents.DotNetBar.PanelEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ElGroupBox6 = New Klik.Windows.Forms.v1.EntryLib.ELGroupBox()
        Me.txtDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbTipo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNPrestamo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnDetalle = New DevComponents.DotNetBar.PanelEx()
        Me.pnSeleccionar = New DevComponents.DotNetBar.PanelEx()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLibro = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dtRegistro = New DevComponents.DotNetBar.Controls.DataGridViewX()
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.pnPrestamo.SuspendLayout()
        CType(Me.ElGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElGroupBox1.SuspendLayout()
        CType(Me.btAgregarPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btBuscarPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnTitulo.SuspendLayout()
        CType(Me.ElGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElGroupBox6.SuspendLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnDetalle.SuspendLayout()
        Me.pnSeleccionar.SuspendLayout()
        CType(Me.dtRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KFormManager1
        '
        Me.KFormManager1.BackgroundImageStyle.Alpha = 100
        Me.KFormManager1.BackgroundImageStyle.ImageEffect = Klik.Windows.Forms.v1.Common.ImageEffect.Mirror
        Me.KFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.FormOffice2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack
        Me.KFormManager1.MainContainer = Me
        Me.KFormManager1.ToolStripOffice2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btNuevo, Me.btGuardar, Me.btEditar, Me.btEliminar, Me.ToolStripSeparator1, Me.btBuscar, Me.btImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(786, 39)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btNuevo
        '
        Me.btNuevo.ForeColor = System.Drawing.Color.Black
        Me.btNuevo.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Nuevo
        Me.btNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(101, 36)
        Me.btNuevo.Text = "F1 - Nuevo"
        '
        'btGuardar
        '
        Me.btGuardar.ForeColor = System.Drawing.Color.Black
        Me.btGuardar.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Guardar
        Me.btGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(108, 36)
        Me.btGuardar.Text = "F2 - Guardar"
        '
        'btEditar
        '
        Me.btEditar.Enabled = False
        Me.btEditar.ForeColor = System.Drawing.Color.Black
        Me.btEditar.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Editar
        Me.btEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(96, 36)
        Me.btEditar.Text = "F3 - Editar"
        Me.btEditar.Visible = False
        '
        'btEliminar
        '
        Me.btEliminar.Enabled = False
        Me.btEliminar.ForeColor = System.Drawing.Color.Black
        Me.btEliminar.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Eliminar
        Me.btEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(101, 36)
        Me.btEliminar.Text = "F4 - Anular"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btBuscar
        '
        Me.btBuscar.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Buscar
        Me.btBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(101, 36)
        Me.btBuscar.Text = "F5 - Buscar"
        '
        'btImprimir
        '
        Me.btImprimir.Enabled = False
        Me.btImprimir.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Imprimir
        Me.btImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(112, 36)
        Me.btImprimir.Text = "F6 - Imprimir"
        '
        'pnPrestamo
        '
        Me.pnPrestamo.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnPrestamo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnPrestamo.Controls.Add(Me.ElGroupBox1)
        Me.pnPrestamo.Controls.Add(Me.pnTitulo)
        Me.pnPrestamo.Controls.Add(Me.ElGroupBox6)
        Me.pnPrestamo.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnPrestamo.Location = New System.Drawing.Point(0, 39)
        Me.pnPrestamo.Name = "pnPrestamo"
        Me.pnPrestamo.Size = New System.Drawing.Size(256, 442)
        Me.pnPrestamo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnPrestamo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnPrestamo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnPrestamo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnPrestamo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnPrestamo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnPrestamo.Style.GradientAngle = 90
        Me.pnPrestamo.TabIndex = 1
        '
        'ElGroupBox1
        '
        Me.ElGroupBox1.BackgroundStyle.GradientAngle = 45.0!
        Me.ElGroupBox1.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox1.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox1.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaption
        Me.ElGroupBox1.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox1.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox1.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox1.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox1.CaptionStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox1.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox1.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElGroupBox1.CaptionStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox1.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox1.CaptionStyle.TextStyle.Text = "Solicitante"
        Me.ElGroupBox1.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox1.Controls.Add(Me.txtIdPersona)
        Me.ElGroupBox1.Controls.Add(Me.txtNombrePersona)
        Me.ElGroupBox1.Controls.Add(Me.Panel1)
        Me.ElGroupBox1.Controls.Add(Me.btAgregarPersona)
        Me.ElGroupBox1.Controls.Add(Me.btBuscarPersona)
        Me.ElGroupBox1.Controls.Add(Me.txtPersona)
        Me.ElGroupBox1.Controls.Add(Me.Label6)
        Me.ElGroupBox1.Location = New System.Drawing.Point(6, 260)
        Me.ElGroupBox1.Name = "ElGroupBox1"
        Me.ElGroupBox1.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox1.Padding = New System.Windows.Forms.Padding(4, 27, 4, 3)
        Me.ElGroupBox1.Size = New System.Drawing.Size(243, 173)
        Me.ElGroupBox1.TabIndex = 3
        '
        'txtIdPersona
        '
        '
        '
        '
        Me.txtIdPersona.Border.Class = "TextBoxBorder"
        Me.txtIdPersona.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdPersona.Location = New System.Drawing.Point(109, 12)
        Me.txtIdPersona.Name = "txtIdPersona"
        Me.txtIdPersona.Size = New System.Drawing.Size(10, 20)
        Me.txtIdPersona.TabIndex = 55
        Me.txtIdPersona.Visible = False
        '
        'txtNombrePersona
        '
        Me.txtNombrePersona.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombrePersona.Border.Class = "TextBoxBorder"
        Me.txtNombrePersona.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombrePersona.Location = New System.Drawing.Point(12, 88)
        Me.txtNombrePersona.Name = "txtNombrePersona"
        Me.txtNombrePersona.ReadOnly = True
        Me.txtNombrePersona.Size = New System.Drawing.Size(220, 20)
        Me.txtNombrePersona.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(12, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 4)
        Me.Panel1.TabIndex = 54
        '
        'btAgregarPersona
        '
        Me.btAgregarPersona.BackgroundStyle.GradientEndColor = System.Drawing.Color.LimeGreen
        Me.btAgregarPersona.BackgroundStyle.GradientStartColor = System.Drawing.Color.PaleGreen
        Me.btAgregarPersona.BorderStyle.EdgeRadius = 25
        Me.btAgregarPersona.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btAgregarPersona.BorderStyle.SolidColor = System.Drawing.Color.Green
        Me.btAgregarPersona.DropDownArrowColor = System.Drawing.Color.Green
        Me.btAgregarPersona.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btAgregarPersona.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btAgregarPersona.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btAgregarPersona.Location = New System.Drawing.Point(12, 138)
        Me.btAgregarPersona.Name = "btAgregarPersona"
        Me.btAgregarPersona.Size = New System.Drawing.Size(220, 23)
        Me.btAgregarPersona.StateStyles.FocusStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btAgregarPersona.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.LimeGreen
        GradientBlend13.Factor = 0.0!
        GradientBlend13.Position = 0.0!
        GradientBlend14.Factor = 0.0!
        GradientBlend14.Position = 0.5!
        GradientBlend15.Factor = 1.0!
        GradientBlend15.Position = 1.0!
        Me.btAgregarPersona.StateStyles.HoverStyle.BackgroundGradientBlend.Add(GradientBlend13)
        Me.btAgregarPersona.StateStyles.HoverStyle.BackgroundGradientBlend.Add(GradientBlend14)
        Me.btAgregarPersona.StateStyles.HoverStyle.BackgroundGradientBlend.Add(GradientBlend15)
        Me.btAgregarPersona.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.PaleGreen
        Me.btAgregarPersona.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.LimeGreen
        Me.btAgregarPersona.TabIndex = 12
        Me.btAgregarPersona.TextStyle.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btAgregarPersona.TextStyle.ForeColor = System.Drawing.Color.DarkGreen
        Me.btAgregarPersona.TextStyle.Text = "¿Eres Nuevo? Regístrate"
        Me.btAgregarPersona.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btAgregarPersona.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'btBuscarPersona
        '
        Me.btBuscarPersona.BackgroundStyle.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.btBuscarPersona.BackgroundStyle.GradientStartColor = System.Drawing.Color.White
        Me.btBuscarPersona.BorderStyle.EdgeRadius = 25
        Me.btBuscarPersona.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btBuscarPersona.BorderStyle.SolidColor = System.Drawing.Color.SteelBlue
        Me.btBuscarPersona.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btBuscarPersona.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btBuscarPersona.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btBuscarPersona.Location = New System.Drawing.Point(12, 113)
        Me.btBuscarPersona.Name = "btBuscarPersona"
        Me.btBuscarPersona.Size = New System.Drawing.Size(220, 23)
        Me.btBuscarPersona.StateStyles.DisabledStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btBuscarPersona.StateStyles.DisabledStyle.BackgroundSolidColor = System.Drawing.Color.LightSteelBlue
        Me.btBuscarPersona.StateStyles.FocusStyle.BackgroundGradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.btBuscarPersona.StateStyles.FocusStyle.BackgroundGradientStartColor = System.Drawing.Color.SteelBlue
        GradientBlend16.Factor = 0.0!
        GradientBlend16.Position = 0.0!
        GradientBlend17.Factor = 0.0!
        GradientBlend17.Position = 0.5!
        GradientBlend18.Factor = 1.0!
        GradientBlend18.Position = 1.0!
        Me.btBuscarPersona.StateStyles.HoverStyle.BackgroundGradientBlend.Add(GradientBlend16)
        Me.btBuscarPersona.StateStyles.HoverStyle.BackgroundGradientBlend.Add(GradientBlend17)
        Me.btBuscarPersona.StateStyles.HoverStyle.BackgroundGradientBlend.Add(GradientBlend18)
        Me.btBuscarPersona.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.White
        Me.btBuscarPersona.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.LightSteelBlue
        Me.btBuscarPersona.TabIndex = 11
        Me.btBuscarPersona.TextStyle.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btBuscarPersona.TextStyle.ForeColor = System.Drawing.Color.SteelBlue
        Me.btBuscarPersona.TextStyle.Text = "¡Ya estas registrado!"
        Me.btBuscarPersona.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btBuscarPersona.TextStyle.TextType = Klik.Windows.Forms.v1.Common.TextTypes.BlockShadow
        Me.btBuscarPersona.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'txtPersona
        '
        Me.txtPersona.BackColor = System.Drawing.Color.Gray
        '
        '
        '
        Me.txtPersona.Border.Class = "TextBoxBorder"
        Me.txtPersona.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPersona.Font = New System.Drawing.Font("League Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersona.ForeColor = System.Drawing.Color.White
        Me.txtPersona.Location = New System.Drawing.Point(100, 35)
        Me.txtPersona.Name = "txtPersona"
        Me.txtPersona.Size = New System.Drawing.Size(132, 36)
        Me.txtPersona.TabIndex = 9
        Me.txtPersona.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("League Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 29)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Solicitante:"
        '
        'pnTitulo
        '
        Me.pnTitulo.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnTitulo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnTitulo.Controls.Add(Me.Label1)
        Me.pnTitulo.Location = New System.Drawing.Point(6, 6)
        Me.pnTitulo.Name = "pnTitulo"
        Me.pnTitulo.Size = New System.Drawing.Size(243, 73)
        Me.pnTitulo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnTitulo.Style.BackColor1.Color = System.Drawing.Color.Black
        Me.pnTitulo.Style.BackColor2.Color = System.Drawing.Color.Gray
        Me.pnTitulo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnTitulo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnTitulo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnTitulo.Style.GradientAngle = 90
        Me.pnTitulo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("League Gothic", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-1, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 41)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Prestamo de Bibliografía"
        '
        'ElGroupBox6
        '
        Me.ElGroupBox6.BackgroundStyle.GradientAngle = 45.0!
        Me.ElGroupBox6.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox6.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox6.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaption
        Me.ElGroupBox6.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox6.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox6.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox6.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox6.CaptionStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox6.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox6.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElGroupBox6.CaptionStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox6.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox6.CaptionStyle.TextStyle.Text = "Prestamo"
        Me.ElGroupBox6.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox6.Controls.Add(Me.txtDescripcion)
        Me.ElGroupBox6.Controls.Add(Me.Label5)
        Me.ElGroupBox6.Controls.Add(Me.cmbTipo)
        Me.ElGroupBox6.Controls.Add(Me.Label4)
        Me.ElGroupBox6.Controls.Add(Me.dtpFecha)
        Me.ElGroupBox6.Controls.Add(Me.Label2)
        Me.ElGroupBox6.Controls.Add(Me.txtNPrestamo)
        Me.ElGroupBox6.Controls.Add(Me.Label3)
        Me.ElGroupBox6.Location = New System.Drawing.Point(6, 84)
        Me.ElGroupBox6.Name = "ElGroupBox6"
        Me.ElGroupBox6.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox6.Padding = New System.Windows.Forms.Padding(4, 27, 4, 3)
        Me.ElGroupBox6.Size = New System.Drawing.Size(243, 170)
        Me.ElGroupBox6.TabIndex = 2
        '
        'txtDescripcion
        '
        '
        '
        '
        Me.txtDescripcion.Border.Class = "TextBoxBorder"
        Me.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 113)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(220, 45)
        Me.txtDescripcion.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(203, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Observación / Descripción / Información:"
        '
        'cmbTipo
        '
        Me.cmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipo.DisplayMember = "Text"
        Me.cmbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.ItemHeight = 14
        Me.cmbTipo.Location = New System.Drawing.Point(152, 72)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(80, 20)
        Me.cmbTipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbTipo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(122, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tipo:"
        '
        'dtpFecha
        '
        '
        '
        '
        Me.dtpFecha.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpFecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtpFecha.ButtonDropDown.Visible = True
        Me.dtpFecha.Location = New System.Drawing.Point(49, 72)
        '
        '
        '
        Me.dtpFecha.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpFecha.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtpFecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpFecha.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpFecha.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtpFecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpFecha.MonthCalendar.DisplayMonth = New Date(2015, 7, 1, 0, 0, 0, 0)
        Me.dtpFecha.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtpFecha.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpFecha.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpFecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpFecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpFecha.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtpFecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpFecha.MonthCalendar.TodayButtonVisible = True
        Me.dtpFecha.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(70, 20)
        Me.dtpFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtpFecha.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha:"
        '
        'txtNPrestamo
        '
        Me.txtNPrestamo.BackColor = System.Drawing.Color.Gray
        '
        '
        '
        Me.txtNPrestamo.Border.Class = "TextBoxBorder"
        Me.txtNPrestamo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNPrestamo.Font = New System.Drawing.Font("League Gothic", 18.0!)
        Me.txtNPrestamo.ForeColor = System.Drawing.Color.White
        Me.txtNPrestamo.Location = New System.Drawing.Point(100, 29)
        Me.txtNPrestamo.Name = "txtNPrestamo"
        Me.txtNPrestamo.Size = New System.Drawing.Size(132, 36)
        Me.txtNPrestamo.TabIndex = 2
        Me.txtNPrestamo.Text = "0000000000"
        Me.txtNPrestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("League Gothic", 18.0!)
        Me.Label3.Location = New System.Drawing.Point(9, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Préstamo:"
        '
        'pnDetalle
        '
        Me.pnDetalle.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnDetalle.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnDetalle.Controls.Add(Me.pnSeleccionar)
        Me.pnDetalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnDetalle.Location = New System.Drawing.Point(256, 39)
        Me.pnDetalle.Name = "pnDetalle"
        Me.pnDetalle.Size = New System.Drawing.Size(530, 90)
        Me.pnDetalle.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnDetalle.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnDetalle.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnDetalle.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnDetalle.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnDetalle.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnDetalle.Style.GradientAngle = 90
        Me.pnDetalle.TabIndex = 2
        '
        'pnSeleccionar
        '
        Me.pnSeleccionar.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnSeleccionar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnSeleccionar.Controls.Add(Me.Label9)
        Me.pnSeleccionar.Controls.Add(Me.txtLibro)
        Me.pnSeleccionar.Location = New System.Drawing.Point(6, 6)
        Me.pnSeleccionar.Name = "pnSeleccionar"
        Me.pnSeleccionar.Size = New System.Drawing.Size(521, 73)
        Me.pnSeleccionar.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnSeleccionar.Style.BackColor1.Color = System.Drawing.Color.Black
        Me.pnSeleccionar.Style.BackColor2.Color = System.Drawing.Color.Gray
        Me.pnSeleccionar.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnSeleccionar.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnSeleccionar.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnSeleccionar.Style.GradientAngle = 90
        Me.pnSeleccionar.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("League Gothic", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(246, 41)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Seleccionar Bibliografía:"
        '
        'txtLibro
        '
        Me.txtLibro.BackColor = System.Drawing.Color.Gray
        '
        '
        '
        Me.txtLibro.Border.Class = "TextBoxBorder"
        Me.txtLibro.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLibro.Font = New System.Drawing.Font("League Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLibro.ForeColor = System.Drawing.Color.White
        Me.txtLibro.Location = New System.Drawing.Point(255, 21)
        Me.txtLibro.Name = "txtLibro"
        Me.txtLibro.Size = New System.Drawing.Size(254, 39)
        Me.txtLibro.TabIndex = 14
        Me.txtLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtRegistro
        '
        Me.dtRegistro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtRegistro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtRegistro.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtRegistro.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dtRegistro.Location = New System.Drawing.Point(256, 129)
        Me.dtRegistro.MultiSelect = False
        Me.dtRegistro.Name = "dtRegistro"
        Me.dtRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtRegistro.Size = New System.Drawing.Size(530, 352)
        Me.dtRegistro.TabIndex = 15
        '
        'frmPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(786, 481)
        Me.Controls.Add(Me.dtRegistro)
        Me.Controls.Add(Me.pnDetalle)
        Me.Controls.Add(Me.pnPrestamo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmPrestamo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prestamos de Bibliografía"
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnPrestamo.ResumeLayout(False)
        CType(Me.ElGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElGroupBox1.ResumeLayout(False)
        Me.ElGroupBox1.PerformLayout()
        CType(Me.btAgregarPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btBuscarPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnTitulo.ResumeLayout(False)
        Me.pnTitulo.PerformLayout()
        CType(Me.ElGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElGroupBox6.ResumeLayout(False)
        Me.ElGroupBox6.PerformLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnDetalle.ResumeLayout(False)
        Me.pnSeleccionar.ResumeLayout(False)
        Me.pnSeleccionar.PerformLayout()
        CType(Me.dtRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KFormManager1 As Klik.Windows.Forms.v1.Common.KFormManager
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnPrestamo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ElGroupBox1 As Klik.Windows.Forms.v1.EntryLib.ELGroupBox
    Friend WithEvents pnTitulo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ElGroupBox6 As Klik.Windows.Forms.v1.EntryLib.ELGroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnDetalle As DevComponents.DotNetBar.PanelEx
    Friend WithEvents dtRegistro As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLibro As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents pnSeleccionar As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtNPrestamo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbTipo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPersona As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btAgregarPersona As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btBuscarPersona As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNombrePersona As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtIdPersona As DevComponents.DotNetBar.Controls.TextBoxX
End Class
