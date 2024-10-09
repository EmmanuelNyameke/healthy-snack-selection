<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInternationalSnacks
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
        picFalafel = New PictureBox()
        btnBurrito = New Button()
        btnFalafel = New Button()
        btnYoghurt = New Button()
        btnRolls = New Button()
        lblQuestion = New Label()
        btnSelect = New Button()
        btnExit = New Button()
        picSpringRolls = New PictureBox()
        picGreekYoghurt = New PictureBox()
        picBeanBurrito = New PictureBox()
        lblConfirmation = New Label()
        lblHeading = New Label()
        CType(picFalafel, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSpringRolls, ComponentModel.ISupportInitialize).BeginInit()
        CType(picGreekYoghurt, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBeanBurrito, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picFalafel
        ' 
        picFalafel.Image = My.Resources.Resources.falafel
        picFalafel.Location = New Point(282, 161)
        picFalafel.Name = "picFalafel"
        picFalafel.Size = New Size(257, 184)
        picFalafel.SizeMode = PictureBoxSizeMode.StretchImage
        picFalafel.TabIndex = 0
        picFalafel.TabStop = False
        picFalafel.Visible = False
        ' 
        ' btnBurrito
        ' 
        btnBurrito.FlatStyle = FlatStyle.Popup
        btnBurrito.Font = New Font("Tahoma", 8.25F)
        btnBurrito.ForeColor = Color.Coral
        btnBurrito.Location = New Point(79, 368)
        btnBurrito.Name = "btnBurrito"
        btnBurrito.Size = New Size(122, 23)
        btnBurrito.TabIndex = 1
        btnBurrito.Text = "Bean Burrito"
        btnBurrito.UseVisualStyleBackColor = True
        ' 
        ' btnFalafel
        ' 
        btnFalafel.FlatStyle = FlatStyle.Popup
        btnFalafel.Font = New Font("Tahoma", 8.25F)
        btnFalafel.ForeColor = Color.Coral
        btnFalafel.Location = New Point(360, 368)
        btnFalafel.Name = "btnFalafel"
        btnFalafel.Size = New Size(122, 23)
        btnFalafel.TabIndex = 2
        btnFalafel.Text = "Falafel"
        btnFalafel.UseVisualStyleBackColor = True
        ' 
        ' btnYoghurt
        ' 
        btnYoghurt.FlatStyle = FlatStyle.Popup
        btnYoghurt.Font = New Font("Tahoma", 8.25F)
        btnYoghurt.ForeColor = Color.Coral
        btnYoghurt.Location = New Point(609, 368)
        btnYoghurt.Name = "btnYoghurt"
        btnYoghurt.Size = New Size(122, 23)
        btnYoghurt.TabIndex = 3
        btnYoghurt.Text = "Greek Yoghurt"
        btnYoghurt.UseVisualStyleBackColor = True
        ' 
        ' btnRolls
        ' 
        btnRolls.FlatStyle = FlatStyle.Popup
        btnRolls.Font = New Font("Tahoma", 8.25F)
        btnRolls.ForeColor = Color.Coral
        btnRolls.Location = New Point(893, 368)
        btnRolls.Name = "btnRolls"
        btnRolls.Size = New Size(122, 23)
        btnRolls.TabIndex = 4
        btnRolls.Text = "Spring Rolls"
        btnRolls.UseVisualStyleBackColor = True
        ' 
        ' lblQuestion
        ' 
        lblQuestion.AutoSize = True
        lblQuestion.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblQuestion.Location = New Point(463, 127)
        lblQuestion.Name = "lblQuestion"
        lblQuestion.Size = New Size(169, 16)
        lblQuestion.TabIndex = 5
        lblQuestion.Text = "Which Snack Do You Prefer?"
        ' 
        ' btnSelect
        ' 
        btnSelect.Enabled = False
        btnSelect.FlatStyle = FlatStyle.Flat
        btnSelect.Font = New Font("Tahoma", 8.25F)
        btnSelect.ForeColor = Color.Brown
        btnSelect.Location = New Point(476, 439)
        btnSelect.Name = "btnSelect"
        btnSelect.Size = New Size(111, 23)
        btnSelect.TabIndex = 6
        btnSelect.Text = "Select Snack"
        btnSelect.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Enabled = False
        btnExit.Font = New Font("Tahoma", 8.25F)
        btnExit.Location = New Point(476, 608)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(143, 23)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit Window"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' picSpringRolls
        ' 
        picSpringRolls.Image = My.Resources.Resources.spring_rolls
        picSpringRolls.Location = New Point(818, 161)
        picSpringRolls.Name = "picSpringRolls"
        picSpringRolls.Size = New Size(257, 184)
        picSpringRolls.SizeMode = PictureBoxSizeMode.StretchImage
        picSpringRolls.TabIndex = 8
        picSpringRolls.TabStop = False
        picSpringRolls.Visible = False
        ' 
        ' picGreekYoghurt
        ' 
        picGreekYoghurt.Image = My.Resources.Resources.greek_yoghurt
        picGreekYoghurt.Location = New Point(545, 161)
        picGreekYoghurt.Name = "picGreekYoghurt"
        picGreekYoghurt.Size = New Size(257, 184)
        picGreekYoghurt.SizeMode = PictureBoxSizeMode.StretchImage
        picGreekYoghurt.TabIndex = 9
        picGreekYoghurt.TabStop = False
        picGreekYoghurt.Visible = False
        ' 
        ' picBeanBurrito
        ' 
        picBeanBurrito.Image = My.Resources.Resources.bean_burrito
        picBeanBurrito.Location = New Point(19, 161)
        picBeanBurrito.Name = "picBeanBurrito"
        picBeanBurrito.Size = New Size(257, 184)
        picBeanBurrito.SizeMode = PictureBoxSizeMode.StretchImage
        picBeanBurrito.TabIndex = 10
        picBeanBurrito.TabStop = False
        picBeanBurrito.Visible = False
        ' 
        ' lblConfirmation
        ' 
        lblConfirmation.AutoSize = True
        lblConfirmation.Font = New Font("Tahoma", 8.25F)
        lblConfirmation.Location = New Point(485, 544)
        lblConfirmation.Name = "lblConfirmation"
        lblConfirmation.Size = New Size(112, 13)
        lblConfirmation.TabIndex = 12
        lblConfirmation.Text = "Enjoy your free snack"
        lblConfirmation.Visible = False
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.ForeColor = Color.SandyBrown
        lblHeading.Location = New Point(472, 66)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(240, 23)
        lblHeading.TabIndex = 13
        lblHeading.Text = "Healthy Snack Selection"
        ' 
        ' frmInternationalSnacks
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1094, 749)
        Controls.Add(lblHeading)
        Controls.Add(lblConfirmation)
        Controls.Add(picBeanBurrito)
        Controls.Add(picGreekYoghurt)
        Controls.Add(picSpringRolls)
        Controls.Add(btnExit)
        Controls.Add(btnSelect)
        Controls.Add(lblQuestion)
        Controls.Add(btnRolls)
        Controls.Add(btnYoghurt)
        Controls.Add(btnFalafel)
        Controls.Add(btnBurrito)
        Controls.Add(picFalafel)
        Name = "frmInternationalSnacks"
        Text = "International Snacks "
        CType(picFalafel, ComponentModel.ISupportInitialize).EndInit()
        CType(picSpringRolls, ComponentModel.ISupportInitialize).EndInit()
        CType(picGreekYoghurt, ComponentModel.ISupportInitialize).EndInit()
        CType(picBeanBurrito, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFalafel As PictureBox
    Friend WithEvents btnBurrito As Button
    Friend WithEvents btnFalafel As Button
    Friend WithEvents btnYoghurt As Button
    Friend WithEvents btnRolls As Button
    Friend WithEvents lblQuestion As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picSpringRolls As PictureBox
    Friend WithEvents picGreekYoghurt As PictureBox
    Friend WithEvents picBeanBurrito As PictureBox
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents lblHeading As Label

End Class
