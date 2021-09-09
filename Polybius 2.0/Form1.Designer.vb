<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Start
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Start))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Chk_Scorr = New System.Windows.Forms.CheckBox()
        Me.CMD_Open = New System.Windows.Forms.Button()
        Me.Cmd_Save = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Btn_Estesa = New System.Windows.Forms.RadioButton()
        Me.Btn_Semplice = New System.Windows.Forms.RadioButton()
        Me.Cmd_Decripta = New System.Windows.Forms.Button()
        Me.CMD_Cripta = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Index = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtInput = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtOutput = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LblIndexExt = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblIndexSim = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cmd_Load = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumGroup = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.NumGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Chk_Scorr)
        Me.GroupBox1.Controls.Add(Me.CMD_Open)
        Me.GroupBox1.Controls.Add(Me.Cmd_Save)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Cmd_Decripta)
        Me.GroupBox1.Controls.Add(Me.CMD_Cripta)
        Me.GroupBox1.Location = New System.Drawing.Point(453, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Controllo"
        '
        'Chk_Scorr
        '
        Me.Chk_Scorr.AutoSize = True
        Me.Chk_Scorr.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Chk_Scorr.Location = New System.Drawing.Point(238, 19)
        Me.Chk_Scorr.Name = "Chk_Scorr"
        Me.Chk_Scorr.Size = New System.Drawing.Size(82, 17)
        Me.Chk_Scorr.TabIndex = 5
        Me.Chk_Scorr.Text = "Scorrimento"
        Me.Chk_Scorr.UseVisualStyleBackColor = True
        '
        'CMD_Open
        '
        Me.CMD_Open.Location = New System.Drawing.Point(119, 19)
        Me.CMD_Open.Name = "CMD_Open"
        Me.CMD_Open.Size = New System.Drawing.Size(107, 40)
        Me.CMD_Open.TabIndex = 4
        Me.CMD_Open.Text = "Apri File"
        Me.CMD_Open.UseVisualStyleBackColor = True
        '
        'Cmd_Save
        '
        Me.Cmd_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Cmd_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Save.Location = New System.Drawing.Point(6, 19)
        Me.Cmd_Save.Name = "Cmd_Save"
        Me.Cmd_Save.Size = New System.Drawing.Size(107, 40)
        Me.Cmd_Save.TabIndex = 3
        Me.Cmd_Save.Text = "Salva su file"
        Me.Cmd_Save.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btn_Estesa)
        Me.GroupBox4.Controls.Add(Me.Btn_Semplice)
        Me.GroupBox4.Location = New System.Drawing.Point(232, 41)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(105, 64)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Codifica"
        '
        'Btn_Estesa
        '
        Me.Btn_Estesa.AutoSize = True
        Me.Btn_Estesa.Location = New System.Drawing.Point(6, 41)
        Me.Btn_Estesa.Name = "Btn_Estesa"
        Me.Btn_Estesa.Size = New System.Drawing.Size(57, 17)
        Me.Btn_Estesa.TabIndex = 1
        Me.Btn_Estesa.Text = "Estesa"
        Me.Btn_Estesa.UseVisualStyleBackColor = True
        '
        'Btn_Semplice
        '
        Me.Btn_Semplice.AutoSize = True
        Me.Btn_Semplice.Checked = True
        Me.Btn_Semplice.Location = New System.Drawing.Point(6, 19)
        Me.Btn_Semplice.Name = "Btn_Semplice"
        Me.Btn_Semplice.Size = New System.Drawing.Size(68, 17)
        Me.Btn_Semplice.TabIndex = 0
        Me.Btn_Semplice.TabStop = True
        Me.Btn_Semplice.Text = "Semplice"
        Me.Btn_Semplice.UseVisualStyleBackColor = True
        '
        'Cmd_Decripta
        '
        Me.Cmd_Decripta.Location = New System.Drawing.Point(119, 65)
        Me.Cmd_Decripta.Name = "Cmd_Decripta"
        Me.Cmd_Decripta.Size = New System.Drawing.Size(107, 40)
        Me.Cmd_Decripta.TabIndex = 1
        Me.Cmd_Decripta.Text = "Decripta"
        Me.Cmd_Decripta.UseVisualStyleBackColor = True
        '
        'CMD_Cripta
        '
        Me.CMD_Cripta.Location = New System.Drawing.Point(6, 65)
        Me.CMD_Cripta.Name = "CMD_Cripta"
        Me.CMD_Cripta.Size = New System.Drawing.Size(107, 40)
        Me.CMD_Cripta.TabIndex = 0
        Me.CMD_Cripta.Text = "Cripta"
        Me.CMD_Cripta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Indice di codifica:"
        '
        'Txt_Index
        '
        Me.Txt_Index.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Index.Location = New System.Drawing.Point(202, 32)
        Me.Txt_Index.Name = "Txt_Index"
        Me.Txt_Index.Size = New System.Drawing.Size(105, 20)
        Me.Txt_Index.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtInput)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(791, 264)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input:"
        '
        'TxtInput
        '
        Me.TxtInput.Location = New System.Drawing.Point(6, 19)
        Me.TxtInput.Multiline = True
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtInput.Size = New System.Drawing.Size(779, 239)
        Me.TxtInput.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtOutput)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 403)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(791, 264)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Output:"
        '
        'TxtOutput
        '
        Me.TxtOutput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtOutput.Location = New System.Drawing.Point(6, 19)
        Me.TxtOutput.Multiline = True
        Me.TxtOutput.Name = "TxtOutput"
        Me.TxtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtOutput.Size = New System.Drawing.Size(779, 239)
        Me.TxtOutput.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "txt"
        Me.OpenFileDialog1.Filter = "file di testo(*.txt)|*.txt"
        Me.OpenFileDialog1.InitialDirectory = "C:\Users\Utente\Desktop"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.FileName = "output.txt"
        Me.SaveFileDialog1.Filter = "File di testo (*.txt)|*.txt"
        Me.SaveFileDialog1.InitialDirectory = "C:\Users\Utente\Desktop"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.NumGroup)
        Me.GroupBox5.Controls.Add(Me.LblIndexExt)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.LblIndexSim)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Cmd_Load)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.LblStatus)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Txt_Index)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(435, 115)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Impostazioni"
        '
        'LblIndexExt
        '
        Me.LblIndexExt.AutoSize = True
        Me.LblIndexExt.Location = New System.Drawing.Point(325, 86)
        Me.LblIndexExt.Name = "LblIndexExt"
        Me.LblIndexExt.Size = New System.Drawing.Size(39, 13)
        Me.LblIndexExt.TabIndex = 12
        Me.LblIndexExt.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Indice Matrice Estesa"
        '
        'LblIndexSim
        '
        Me.LblIndexSim.AutoSize = True
        Me.LblIndexSim.Location = New System.Drawing.Point(325, 62)
        Me.LblIndexSim.Name = "LblIndexSim"
        Me.LblIndexSim.Size = New System.Drawing.Size(39, 13)
        Me.LblIndexSim.TabIndex = 10
        Me.LblIndexSim.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(199, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Indice Matrice Semplice"
        '
        'Cmd_Load
        '
        Me.Cmd_Load.Location = New System.Drawing.Point(90, 57)
        Me.Cmd_Load.Name = "Cmd_Load"
        Me.Cmd_Load.Size = New System.Drawing.Size(75, 23)
        Me.Cmd_Load.TabIndex = 8
        Me.Cmd_Load.Text = "Carica"
        Me.Cmd_Load.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.ForeColor = System.Drawing.Color.Red
        Me.LblStatus.Location = New System.Drawing.Point(53, 33)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(72, 13)
        Me.LblStatus.TabIndex = 1
        Me.LblStatus.Text = "MODIFICATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Matrici:"
        '
        'NumGroup
        '
        Me.NumGroup.Location = New System.Drawing.Point(104, 82)
        Me.NumGroup.Name = "NumGroup"
        Me.NumGroup.Size = New System.Drawing.Size(61, 20)
        Me.NumGroup.TabIndex = 13
        Me.NumGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumGroup.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Raggruppamento:"
        '
        'Form_Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 675)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Start"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Polybius 2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.NumGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Estesa As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_Semplice As System.Windows.Forms.RadioButton
    Friend WithEvents Cmd_Decripta As System.Windows.Forms.Button
    Friend WithEvents CMD_Cripta As System.Windows.Forms.Button
    Friend WithEvents CMD_Open As System.Windows.Forms.Button
    Friend WithEvents Cmd_Save As System.Windows.Forms.Button
    Friend WithEvents TxtInput As System.Windows.Forms.TextBox
    Friend WithEvents TxtOutput As System.Windows.Forms.TextBox
    Friend WithEvents Chk_Scorr As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_Index As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblIndexExt As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblIndexSim As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cmd_Load As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumGroup As System.Windows.Forms.NumericUpDown

End Class
