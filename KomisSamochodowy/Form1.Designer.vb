<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PlikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZakonczToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBoxCarPhoto = New System.Windows.Forms.PictureBox()
        Me.ComboBoxBrand = New System.Windows.Forms.ComboBox()
        Me.ComboBoxModel = New System.Windows.Forms.ComboBox()
        Me.ComboBoxEngine = New System.Windows.Forms.ComboBox()
        Me.ComboBoxColour = New System.Windows.Forms.ComboBox()
        Me.CheckBoxMetalic = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBoxCarPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 250)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(534, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlikToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(534, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PlikToolStripMenuItem
        '
        Me.PlikToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZakonczToolStripMenuItem})
        Me.PlikToolStripMenuItem.Name = "PlikToolStripMenuItem"
        Me.PlikToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.PlikToolStripMenuItem.Text = "Plik"
        '
        'ZakonczToolStripMenuItem
        '
        Me.ZakonczToolStripMenuItem.Name = "ZakonczToolStripMenuItem"
        Me.ZakonczToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ZakonczToolStripMenuItem.Text = "Zakończ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Marka:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Model:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Silnik:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Kolor:"
        '
        'PictureBoxCarPhoto
        '
        Me.PictureBoxCarPhoto.Location = New System.Drawing.Point(254, 51)
        Me.PictureBoxCarPhoto.Name = "PictureBoxCarPhoto"
        Me.PictureBoxCarPhoto.Size = New System.Drawing.Size(248, 170)
        Me.PictureBoxCarPhoto.TabIndex = 6
        Me.PictureBoxCarPhoto.TabStop = False
        '
        'ComboBoxBrand
        '
        Me.ComboBoxBrand.FormattingEnabled = True
        Me.ComboBoxBrand.Location = New System.Drawing.Point(15, 67)
        Me.ComboBoxBrand.Name = "ComboBoxBrand"
        Me.ComboBoxBrand.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxBrand.TabIndex = 7
        '
        'ComboBoxModel
        '
        Me.ComboBoxModel.FormattingEnabled = True
        Me.ComboBoxModel.Location = New System.Drawing.Point(15, 107)
        Me.ComboBoxModel.Name = "ComboBoxModel"
        Me.ComboBoxModel.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxModel.TabIndex = 8
        '
        'ComboBoxEngine
        '
        Me.ComboBoxEngine.FormattingEnabled = True
        Me.ComboBoxEngine.Location = New System.Drawing.Point(16, 147)
        Me.ComboBoxEngine.Name = "ComboBoxEngine"
        Me.ComboBoxEngine.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxEngine.TabIndex = 9
        '
        'ComboBoxColour
        '
        Me.ComboBoxColour.FormattingEnabled = True
        Me.ComboBoxColour.Location = New System.Drawing.Point(16, 187)
        Me.ComboBoxColour.Name = "ComboBoxColour"
        Me.ComboBoxColour.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxColour.TabIndex = 10
        '
        'CheckBoxMetalic
        '
        Me.CheckBoxMetalic.AutoSize = True
        Me.CheckBoxMetalic.Location = New System.Drawing.Point(155, 189)
        Me.CheckBoxMetalic.Name = "CheckBoxMetalic"
        Me.CheckBoxMetalic.Size = New System.Drawing.Size(60, 17)
        Me.CheckBoxMetalic.TabIndex = 11
        Me.CheckBoxMetalic.Text = "Metalic"
        Me.CheckBoxMetalic.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 272)
        Me.Controls.Add(Me.CheckBoxMetalic)
        Me.Controls.Add(Me.ComboBoxColour)
        Me.Controls.Add(Me.ComboBoxEngine)
        Me.Controls.Add(Me.ComboBoxModel)
        Me.Controls.Add(Me.ComboBoxBrand)
        Me.Controls.Add(Me.PictureBoxCarPhoto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(550, 310)
        Me.Name = "Form1"
        Me.Text = "Komis Samochodowy"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBoxCarPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PlikToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZakonczToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxCarPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBoxBrand As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxModel As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxEngine As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxColour As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxMetalic As System.Windows.Forms.CheckBox

End Class
