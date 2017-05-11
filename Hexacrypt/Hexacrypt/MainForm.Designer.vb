<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.HexacryptLogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.InputLabel = New System.Windows.Forms.Label()
        Me.KeyLabel = New System.Windows.Forms.Label()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.KeyTextBox = New System.Windows.Forms.TextBox()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.EncryptButton = New System.Windows.Forms.Button()
        Me.DecryptButton = New System.Windows.Forms.Button()
        Me.LoadingLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        CType(Me.HexacryptLogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HexacryptLogoPictureBox
        '
        Me.HexacryptLogoPictureBox.Image = Global.Hexacrypt.My.Resources.Resources.Hexacrypt_logo
        Me.HexacryptLogoPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.HexacryptLogoPictureBox.Name = "HexacryptLogoPictureBox"
        Me.HexacryptLogoPictureBox.Size = New System.Drawing.Size(461, 93)
        Me.HexacryptLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HexacryptLogoPictureBox.TabIndex = 0
        Me.HexacryptLogoPictureBox.TabStop = False
        '
        'InputLabel
        '
        Me.InputLabel.AutoSize = True
        Me.InputLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel.Location = New System.Drawing.Point(210, 129)
        Me.InputLabel.Name = "InputLabel"
        Me.InputLabel.Size = New System.Drawing.Size(65, 25)
        Me.InputLabel.TabIndex = 1
        Me.InputLabel.Text = "Input:"
        '
        'KeyLabel
        '
        Me.KeyLabel.AutoSize = True
        Me.KeyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyLabel.Location = New System.Drawing.Point(63, 281)
        Me.KeyLabel.Name = "KeyLabel"
        Me.KeyLabel.Size = New System.Drawing.Size(55, 25)
        Me.KeyLabel.TabIndex = 2
        Me.KeyLabel.Text = "Key:"
        '
        'OutputLabel
        '
        Me.OutputLabel.AutoSize = True
        Me.OutputLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputLabel.Location = New System.Drawing.Point(201, 334)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(82, 25)
        Me.OutputLabel.TabIndex = 3
        Me.OutputLabel.Text = "Output:"
        '
        'InputTextBox
        '
        Me.InputTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.InputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputTextBox.ForeColor = System.Drawing.Color.Lime
        Me.InputTextBox.Location = New System.Drawing.Point(43, 164)
        Me.InputTextBox.Multiline = True
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(399, 96)
        Me.InputTextBox.TabIndex = 4
        '
        'KeyTextBox
        '
        Me.KeyTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.KeyTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyTextBox.ForeColor = System.Drawing.Color.Lime
        Me.KeyTextBox.Location = New System.Drawing.Point(123, 281)
        Me.KeyTextBox.MaxLength = 32768
        Me.KeyTextBox.Name = "KeyTextBox"
        Me.KeyTextBox.Size = New System.Drawing.Size(240, 31)
        Me.KeyTextBox.TabIndex = 5
        '
        'OutputTextBox
        '
        Me.OutputTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OutputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputTextBox.ForeColor = System.Drawing.Color.Lime
        Me.OutputTextBox.Location = New System.Drawing.Point(43, 367)
        Me.OutputTextBox.Multiline = True
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.Size = New System.Drawing.Size(399, 96)
        Me.OutputTextBox.TabIndex = 6
        '
        'EncryptButton
        '
        Me.EncryptButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EncryptButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EncryptButton.Location = New System.Drawing.Point(25, 508)
        Me.EncryptButton.Name = "EncryptButton"
        Me.EncryptButton.Size = New System.Drawing.Size(131, 44)
        Me.EncryptButton.TabIndex = 7
        Me.EncryptButton.Text = "Encrypt"
        Me.EncryptButton.UseVisualStyleBackColor = False
        '
        'DecryptButton
        '
        Me.DecryptButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DecryptButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecryptButton.Location = New System.Drawing.Point(183, 508)
        Me.DecryptButton.Name = "DecryptButton"
        Me.DecryptButton.Size = New System.Drawing.Size(131, 44)
        Me.DecryptButton.TabIndex = 8
        Me.DecryptButton.Text = "Decrypt"
        Me.DecryptButton.UseVisualStyleBackColor = False
        '
        'LoadingLabel
        '
        Me.LoadingLabel.AutoSize = True
        Me.LoadingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadingLabel.Location = New System.Drawing.Point(170, 477)
        Me.LoadingLabel.Name = "LoadingLabel"
        Me.LoadingLabel.Size = New System.Drawing.Size(145, 16)
        Me.LoadingLabel.TabIndex = 9
        Me.LoadingLabel.Text = "Loading, Please Wait..."
        Me.LoadingLabel.Visible = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(341, 508)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(131, 44)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(485, 573)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.LoadingLabel)
        Me.Controls.Add(Me.DecryptButton)
        Me.Controls.Add(Me.EncryptButton)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.KeyTextBox)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.OutputLabel)
        Me.Controls.Add(Me.KeyLabel)
        Me.Controls.Add(Me.InputLabel)
        Me.Controls.Add(Me.HexacryptLogoPictureBox)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hexacrypt"
        CType(Me.HexacryptLogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HexacryptLogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents InputLabel As System.Windows.Forms.Label
    Friend WithEvents KeyLabel As System.Windows.Forms.Label
    Friend WithEvents OutputLabel As System.Windows.Forms.Label
    Friend WithEvents InputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KeyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OutputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EncryptButton As System.Windows.Forms.Button
    Friend WithEvents DecryptButton As System.Windows.Forms.Button
    Friend WithEvents LoadingLabel As System.Windows.Forms.Label
    Friend WithEvents ClearButton As System.Windows.Forms.Button

End Class
