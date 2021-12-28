<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton6 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyURLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenWithVLCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameChannelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.MetroPanel4 = New MetroFramework.Controls.MetroPanel()
        Me.radio_all = New System.Windows.Forms.RadioButton()
        Me.radio_offline = New System.Windows.Forms.RadioButton()
        Me.radio_online = New System.Windows.Forms.RadioButton()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.MetroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MetroPanel3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel4.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(9, 8)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(133, 29)
        Me.MetroButton1.TabIndex = 0
        Me.MetroButton1.Text = "Open *.m3u8"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.MetroButton5)
        Me.MetroPanel1.Controls.Add(Me.MetroButton6)
        Me.MetroPanel1.Controls.Add(Me.MetroButton3)
        Me.MetroPanel1.Controls.Add(Me.MetroButton2)
        Me.MetroPanel1.Controls.Add(Me.MetroButton1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(10, 61)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(153, 188)
        Me.MetroPanel1.TabIndex = 1
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroButton5
        '
        Me.MetroButton5.Location = New System.Drawing.Point(9, 148)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(133, 29)
        Me.MetroButton5.TabIndex = 5
        Me.MetroButton5.Text = "Save"
        Me.MetroButton5.UseSelectable = True
        '
        'MetroButton6
        '
        Me.MetroButton6.Location = New System.Drawing.Point(9, 113)
        Me.MetroButton6.Name = "MetroButton6"
        Me.MetroButton6.Size = New System.Drawing.Size(133, 29)
        Me.MetroButton6.TabIndex = 4
        Me.MetroButton6.Text = "Add From Text"
        Me.MetroButton6.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(9, 78)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(133, 29)
        Me.MetroButton3.TabIndex = 3
        Me.MetroButton3.Text = "Stop Check"
        Me.MetroButton3.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(9, 43)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(133, 29)
        Me.MetroButton2.TabIndex = 2
        Me.MetroButton2.Text = "Check IPTV"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel2.Controls.Add(Me.MetroGrid1)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(169, 61)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(683, 316)
        Me.MetroPanel2.TabIndex = 2
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.MetroGrid1.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(0, 0)
        Me.MetroGrid1.MultiSelect = False
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = True
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.RowHeadersVisible = False
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(681, 314)
        Me.MetroGrid1.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.FillWeight = 30.0!
        Me.Column1.HeaderText = "Channel Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.FillWeight = 20.0!
        Me.Column2.HeaderText = "Status"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "URL"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyURLToolStripMenuItem, Me.OpenWithVLCToolStripMenuItem, Me.RenameChannelToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(131, 92)
        '
        'CopyURLToolStripMenuItem
        '
        Me.CopyURLToolStripMenuItem.Name = "CopyURLToolStripMenuItem"
        Me.CopyURLToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CopyURLToolStripMenuItem.Text = "Copy URL"
        '
        'OpenWithVLCToolStripMenuItem
        '
        Me.OpenWithVLCToolStripMenuItem.Name = "OpenWithVLCToolStripMenuItem"
        Me.OpenWithVLCToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.OpenWithVLCToolStripMenuItem.Text = "Open With VLC"
        '
        'RenameChannelToolStripMenuItem
        '
        Me.RenameChannelToolStripMenuItem.Name = "RenameChannelToolStripMenuItem"
        Me.RenameChannelToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.RenameChannelToolStripMenuItem.Text = "Rename"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'MetroPanel3
        '
        Me.MetroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel3.Controls.Add(Me.Label2)
        Me.MetroPanel3.Controls.Add(Me.NumericUpDown1)
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(10, 255)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(153, 42)
        Me.MetroPanel3.TabIndex = 3
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Threads"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(65, 10)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(77, 21)
        Me.NumericUpDown1.TabIndex = 16
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'MetroLink1
        '
        Me.MetroLink1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MetroLink1.Location = New System.Drawing.Point(783, 400)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.TabIndex = 4
        Me.MetroLink1.Text = "MONSTER"
        Me.MetroLink1.UseCustomForeColor = True
        Me.MetroLink1.UseSelectable = True
        '
        'MetroPanel4
        '
        Me.MetroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel4.Controls.Add(Me.radio_all)
        Me.MetroPanel4.Controls.Add(Me.radio_offline)
        Me.MetroPanel4.Controls.Add(Me.radio_online)
        Me.MetroPanel4.HorizontalScrollbarBarColor = True
        Me.MetroPanel4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.HorizontalScrollbarSize = 10
        Me.MetroPanel4.Location = New System.Drawing.Point(10, 303)
        Me.MetroPanel4.Name = "MetroPanel4"
        Me.MetroPanel4.Size = New System.Drawing.Size(153, 74)
        Me.MetroPanel4.TabIndex = 5
        Me.MetroPanel4.VerticalScrollbarBarColor = True
        Me.MetroPanel4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.VerticalScrollbarSize = 10
        '
        'radio_all
        '
        Me.radio_all.AutoSize = True
        Me.radio_all.Location = New System.Drawing.Point(9, 47)
        Me.radio_all.Name = "radio_all"
        Me.radio_all.Size = New System.Drawing.Size(74, 17)
        Me.radio_all.TabIndex = 5
        Me.radio_all.TabStop = True
        Me.radio_all.Text = "Show ALL"
        Me.radio_all.UseVisualStyleBackColor = True
        '
        'radio_offline
        '
        Me.radio_offline.AutoSize = True
        Me.radio_offline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.radio_offline.Location = New System.Drawing.Point(9, 27)
        Me.radio_offline.Name = "radio_offline"
        Me.radio_offline.Size = New System.Drawing.Size(55, 17)
        Me.radio_offline.TabIndex = 4
        Me.radio_offline.TabStop = True
        Me.radio_offline.Text = "Offline"
        Me.radio_offline.UseVisualStyleBackColor = True
        '
        'radio_online
        '
        Me.radio_online.AutoSize = True
        Me.radio_online.ForeColor = System.Drawing.Color.Green
        Me.radio_online.Location = New System.Drawing.Point(9, 7)
        Me.radio_online.Name = "radio_online"
        Me.radio_online.Size = New System.Drawing.Size(55, 17)
        Me.radio_online.TabIndex = 3
        Me.radio_online.TabStop = True
        Me.radio_online.Text = "Online"
        Me.radio_online.UseVisualStyleBackColor = True
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(261, 522)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown2.TabIndex = 19
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown2.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'MetroProgressBar1
        '
        Me.MetroProgressBar1.Location = New System.Drawing.Point(169, 383)
        Me.MetroProgressBar1.Name = "MetroProgressBar1"
        Me.MetroProgressBar1.Size = New System.Drawing.Size(683, 15)
        Me.MetroProgressBar1.TabIndex = 20
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "m3u8 Files|*.m3u8|m3u Files|*.m3u|TXT Files|*.txt"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "m3u8 File|*.m3u8|cfg File|*.cfg"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 382)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Channels Found: 0"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.MONSTERM_IPTV_Checker_1._0.My.Resources.Resources._2635454_email_mail_social_telegram_icon
        Me.PictureBox1.Location = New System.Drawing.Point(756, 402)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 17)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.MONSTERM_IPTV_Checker_1._0.My.Resources.Resources._437944_youtube_player_screen_technology_tv_icon
        Me.PictureBox2.Location = New System.Drawing.Point(728, 402)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 17)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.MONSTERM_IPTV_Checker_1._0.My.Resources.Resources.DISCORD
        Me.PictureBox3.Location = New System.Drawing.Point(700, 402)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(22, 17)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 421)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MetroProgressBar1)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.MetroPanel4)
        Me.Controls.Add(Me.MetroLink1)
        Me.Controls.Add(Me.MetroPanel3)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Resizable = False
        Me.Text = "MONSTERMC IPTV Checker 1.0"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel2.ResumeLayout(False)
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel4.ResumeLayout(False)
        Me.MetroPanel4.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton6 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents MetroPanel4 As MetroFramework.Controls.MetroPanel
    Friend WithEvents radio_all As RadioButton
    Friend WithEvents radio_offline As RadioButton
    Friend WithEvents radio_online As RadioButton
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents MetroProgressBar1 As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RenameChannelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyURLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenWithVLCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
