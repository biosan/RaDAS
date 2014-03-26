<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataForm))
        Me.serialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraphToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelUnit2 = New System.Windows.Forms.Label()
        Me.LabelUnit1 = New System.Windows.Forms.Label()
        Me.velocityLabel2 = New System.Windows.Forms.Label()
        Me.timeLabel3 = New System.Windows.Forms.Label()
        Me.lenghtText2 = New System.Windows.Forms.NumericUpDown()
        Me.velocityLabel3 = New System.Windows.Forms.Label()
        Me.timeLabel4 = New System.Windows.Forms.Label()
        Me.velocityLabel4 = New System.Windows.Forms.Label()
        Me.lenghtText3 = New System.Windows.Forms.NumericUpDown()
        Me.velocityLabel5 = New System.Windows.Forms.Label()
        Me.timeLabel5 = New System.Windows.Forms.Label()
        Me.lenghtText4 = New System.Windows.Forms.NumericUpDown()
        Me.lenghtText5 = New System.Windows.Forms.NumericUpDown()
        Me.timeLabel2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelUnit3 = New System.Windows.Forms.Label()
        Me.timeLabel1 = New System.Windows.Forms.Label()
        Me.velocityLabel1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lenghtText1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.lenghtText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lenghtText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lenghtText4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lenghtText5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.lenghtText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'serialPort
        '
        Me.serialPort.PortName = "COM6"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.GraphToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportDataToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExportDataToolStripMenuItem
        '
        Me.ExportDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToFileToolStripMenuItem, Me.ToExcelToolStripMenuItem})
        Me.ExportDataToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.upload_512
        Me.ExportDataToolStripMenuItem.Name = "ExportDataToolStripMenuItem"
        Me.ExportDataToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExportDataToolStripMenuItem.Text = "Export Data"
        '
        'ToFileToolStripMenuItem
        '
        Me.ToFileToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.save_512
        Me.ToFileToolStripMenuItem.Name = "ToFileToolStripMenuItem"
        Me.ToFileToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ToFileToolStripMenuItem.Text = "To File"
        '
        'ToExcelToolStripMenuItem
        '
        Me.ToExcelToolStripMenuItem.Enabled = False
        Me.ToExcelToolStripMenuItem.Name = "ToExcelToolStripMenuItem"
        Me.ToExcelToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ToExcelToolStripMenuItem.Text = "To Excel"
        '
        'GraphToolStripMenuItem
        '
        Me.GraphToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem})
        Me.GraphToolStripMenuItem.Name = "GraphToolStripMenuItem"
        Me.GraphToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.GraphToolStripMenuItem.Text = "Chart"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Enabled = False
        Me.ShowToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.area_chart_512
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.InfoToolStripMenuItem.Text = "Credits"
        '
        'LabelUnit2
        '
        Me.LabelUnit2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelUnit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUnit2.Location = New System.Drawing.Point(824, 56)
        Me.LabelUnit2.Name = "LabelUnit2"
        Me.LabelUnit2.Size = New System.Drawing.Size(118, 33)
        Me.LabelUnit2.TabIndex = 40
        Me.LabelUnit2.Text = "m/sec"
        Me.LabelUnit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelUnit1
        '
        Me.LabelUnit1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelUnit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUnit1.Location = New System.Drawing.Point(824, 22)
        Me.LabelUnit1.Name = "LabelUnit1"
        Me.LabelUnit1.Size = New System.Drawing.Size(118, 33)
        Me.LabelUnit1.TabIndex = 39
        Me.LabelUnit1.Text = "sec"
        Me.LabelUnit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'velocityLabel2
        '
        Me.velocityLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.velocityLabel2.AutoSize = True
        Me.velocityLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.velocityLabel2.Location = New System.Drawing.Point(230, 64)
        Me.velocityLabel2.Name = "velocityLabel2"
        Me.velocityLabel2.Size = New System.Drawing.Size(32, 16)
        Me.velocityLabel2.TabIndex = 19
        Me.velocityLabel2.Text = "0.00"
        Me.velocityLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timeLabel3
        '
        Me.timeLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.timeLabel3.AutoSize = True
        Me.timeLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel3.Location = New System.Drawing.Point(391, 30)
        Me.timeLabel3.Name = "timeLabel3"
        Me.timeLabel3.Size = New System.Drawing.Size(39, 16)
        Me.timeLabel3.TabIndex = 3
        Me.timeLabel3.Text = "0.000"
        Me.timeLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lenghtText2
        '
        Me.lenghtText2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lenghtText2.DecimalPlaces = 1
        Me.lenghtText2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.lenghtText2.Location = New System.Drawing.Point(213, 130)
        Me.lenghtText2.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.lenghtText2.Name = "lenghtText2"
        Me.lenghtText2.Size = New System.Drawing.Size(67, 20)
        Me.lenghtText2.TabIndex = 35
        '
        'velocityLabel3
        '
        Me.velocityLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.velocityLabel3.AutoSize = True
        Me.velocityLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.velocityLabel3.Location = New System.Drawing.Point(394, 64)
        Me.velocityLabel3.Name = "velocityLabel3"
        Me.velocityLabel3.Size = New System.Drawing.Size(32, 16)
        Me.velocityLabel3.TabIndex = 20
        Me.velocityLabel3.Text = "0.00"
        Me.velocityLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timeLabel4
        '
        Me.timeLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.timeLabel4.AutoSize = True
        Me.timeLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel4.Location = New System.Drawing.Point(555, 30)
        Me.timeLabel4.Name = "timeLabel4"
        Me.timeLabel4.Size = New System.Drawing.Size(39, 16)
        Me.timeLabel4.TabIndex = 4
        Me.timeLabel4.Text = "0.000"
        Me.timeLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'velocityLabel4
        '
        Me.velocityLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.velocityLabel4.AutoSize = True
        Me.velocityLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.velocityLabel4.Location = New System.Drawing.Point(558, 64)
        Me.velocityLabel4.Name = "velocityLabel4"
        Me.velocityLabel4.Size = New System.Drawing.Size(32, 16)
        Me.velocityLabel4.TabIndex = 21
        Me.velocityLabel4.Text = "0.00"
        Me.velocityLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lenghtText3
        '
        Me.lenghtText3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lenghtText3.DecimalPlaces = 1
        Me.lenghtText3.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.lenghtText3.Location = New System.Drawing.Point(377, 130)
        Me.lenghtText3.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.lenghtText3.Name = "lenghtText3"
        Me.lenghtText3.Size = New System.Drawing.Size(67, 20)
        Me.lenghtText3.TabIndex = 36
        '
        'velocityLabel5
        '
        Me.velocityLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.velocityLabel5.AutoSize = True
        Me.velocityLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.velocityLabel5.Location = New System.Drawing.Point(722, 64)
        Me.velocityLabel5.Name = "velocityLabel5"
        Me.velocityLabel5.Size = New System.Drawing.Size(32, 16)
        Me.velocityLabel5.TabIndex = 22
        Me.velocityLabel5.Text = "0.00"
        Me.velocityLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timeLabel5
        '
        Me.timeLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.timeLabel5.AutoSize = True
        Me.timeLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel5.Location = New System.Drawing.Point(719, 30)
        Me.timeLabel5.Name = "timeLabel5"
        Me.timeLabel5.Size = New System.Drawing.Size(39, 16)
        Me.timeLabel5.TabIndex = 5
        Me.timeLabel5.Text = "0.000"
        Me.timeLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lenghtText4
        '
        Me.lenghtText4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lenghtText4.DecimalPlaces = 1
        Me.lenghtText4.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.lenghtText4.Location = New System.Drawing.Point(541, 130)
        Me.lenghtText4.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.lenghtText4.Name = "lenghtText4"
        Me.lenghtText4.Size = New System.Drawing.Size(67, 20)
        Me.lenghtText4.TabIndex = 37
        '
        'lenghtText5
        '
        Me.lenghtText5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lenghtText5.DecimalPlaces = 1
        Me.lenghtText5.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.lenghtText5.Location = New System.Drawing.Point(705, 130)
        Me.lenghtText5.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.lenghtText5.Name = "lenghtText5"
        Me.lenghtText5.Size = New System.Drawing.Size(67, 20)
        Me.lenghtText5.TabIndex = 38
        '
        'timeLabel2
        '
        Me.timeLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.timeLabel2.AutoSize = True
        Me.timeLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel2.Location = New System.Drawing.Point(227, 30)
        Me.timeLabel2.Name = "timeLabel2"
        Me.timeLabel2.Size = New System.Drawing.Size(39, 16)
        Me.timeLabel2.TabIndex = 2
        Me.timeLabel2.Text = "0.000"
        Me.timeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelUnit3, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.timeLabel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.timeLabel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lenghtText5, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.velocityLabel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lenghtText4, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.timeLabel5, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.velocityLabel5, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lenghtText3, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.velocityLabel4, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.timeLabel4, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lenghtText1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.velocityLabel3, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lenghtText2, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.timeLabel3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.velocityLabel2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelUnit1, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelUnit2, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 4, 0)
        Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(182, 320)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(946, 158)
        Me.TableLayoutPanel1.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(832, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Second segment"
        '
        'LabelUnit3
        '
        Me.LabelUnit3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelUnit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUnit3.Location = New System.Drawing.Point(824, 124)
        Me.LabelUnit3.Name = "LabelUnit3"
        Me.LabelUnit3.Size = New System.Drawing.Size(118, 33)
        Me.LabelUnit3.TabIndex = 40
        Me.LabelUnit3.Text = "cm"
        Me.LabelUnit3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timeLabel1
        '
        Me.timeLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.timeLabel1.AutoSize = True
        Me.timeLabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.timeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel1.Location = New System.Drawing.Point(63, 30)
        Me.timeLabel1.Name = "timeLabel1"
        Me.timeLabel1.Size = New System.Drawing.Size(39, 16)
        Me.timeLabel1.TabIndex = 1
        Me.timeLabel1.Text = "0.000"
        Me.timeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'velocityLabel1
        '
        Me.velocityLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.velocityLabel1.AutoSize = True
        Me.velocityLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.velocityLabel1.Location = New System.Drawing.Point(66, 64)
        Me.velocityLabel1.Name = "velocityLabel1"
        Me.velocityLabel1.Size = New System.Drawing.Size(32, 16)
        Me.velocityLabel1.TabIndex = 18
        Me.velocityLabel1.Text = "0.00"
        Me.velocityLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label6, 6)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(938, 33)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Segment lenght:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lenghtText1
        '
        Me.lenghtText1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lenghtText1.DecimalPlaces = 1
        Me.lenghtText1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.lenghtText1.Location = New System.Drawing.Point(51, 130)
        Me.lenghtText1.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.lenghtText1.Name = "lenghtText1"
        Me.lenghtText1.Size = New System.Drawing.Size(62, 20)
        Me.lenghtText1.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "First segment"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(196, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Second segment"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(367, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Third segment"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(527, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Fourth segment"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(697, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Fifth segment"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.AddExtension = False
        Me.SaveFileDialog1.Title = "Save data to file"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.rect2989_9
        Me.PictureBox1.Location = New System.Drawing.Point(39, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1199, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(200, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "First segment"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(384, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Second segment"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(603, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Third segment"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(792, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Fourth segment"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(997, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Fifth segment"
        '
        'DataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1284, 751)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DataForm"
        Me.Text = "Rail Data Acquisition Software (RaDAS)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.lenghtText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lenghtText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lenghtText4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lenghtText5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.lenghtText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents serialPort As System.IO.Ports.SerialPort
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GraphToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelUnit2 As System.Windows.Forms.Label
    Friend WithEvents LabelUnit1 As System.Windows.Forms.Label
    Friend WithEvents velocityLabel2 As System.Windows.Forms.Label
    Friend WithEvents timeLabel3 As System.Windows.Forms.Label
    Friend WithEvents lenghtText2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents velocityLabel3 As System.Windows.Forms.Label
    Friend WithEvents timeLabel4 As System.Windows.Forms.Label
    Friend WithEvents velocityLabel4 As System.Windows.Forms.Label
    Friend WithEvents lenghtText3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents velocityLabel5 As System.Windows.Forms.Label
    Friend WithEvents timeLabel5 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents timeLabel2 As System.Windows.Forms.Label
    Friend WithEvents lenghtText5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lenghtText4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelUnit3 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents timeLabel1 As System.Windows.Forms.Label
    Friend WithEvents velocityLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lenghtText1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
