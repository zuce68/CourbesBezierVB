<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FenetrePrincipale
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FenetrePrincipale))
        Me.plan = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pointData = New System.Windows.Forms.ListBox()
        Me.Ytfin = New System.Windows.Forms.NumericUpDown()
        Me.nbSegements = New System.Windows.Forms.NumericUpDown()
        Me.Xtfin = New System.Windows.Forms.NumericUpDown()
        Me.Yfin = New System.Windows.Forms.NumericUpDown()
        Me.Xtdeb = New System.Windows.Forms.NumericUpDown()
        Me.Ytdeb = New System.Windows.Forms.NumericUpDown()
        Me.Xfin = New System.Windows.Forms.NumericUpDown()
        Me.Ydeb = New System.Windows.Forms.NumericUpDown()
        Me.Xdeb = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.modifierButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CourbeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.plan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Ytfin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nbSegements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Xtfin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Yfin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Xtdeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ytdeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Xfin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ydeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Xdeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourbeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'plan
        '
        Me.plan.BackColor = System.Drawing.Color.White
        Me.plan.BackgroundImage = CType(resources.GetObject("plan.BackgroundImage"), System.Drawing.Image)
        Me.plan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.plan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.plan.Location = New System.Drawing.Point(15, 32)
        Me.plan.Name = "plan"
        Me.plan.Size = New System.Drawing.Size(408, 406)
        Me.plan.TabIndex = 0
        Me.plan.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Plan "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pointData)
        Me.GroupBox1.Controls.Add(Me.Ytfin)
        Me.GroupBox1.Controls.Add(Me.nbSegements)
        Me.GroupBox1.Controls.Add(Me.Xtfin)
        Me.GroupBox1.Controls.Add(Me.Yfin)
        Me.GroupBox1.Controls.Add(Me.Xtdeb)
        Me.GroupBox1.Controls.Add(Me.Ytdeb)
        Me.GroupBox1.Controls.Add(Me.Xfin)
        Me.GroupBox1.Controls.Add(Me.Ydeb)
        Me.GroupBox1.Controls.Add(Me.Xdeb)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.modifierButton)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(429, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 340)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Coordonées"
        '
        'pointData
        '
        Me.pointData.FormattingEnabled = True
        Me.pointData.Location = New System.Drawing.Point(33, 206)
        Me.pointData.Name = "pointData"
        Me.pointData.Size = New System.Drawing.Size(287, 121)
        Me.pointData.TabIndex = 25
        '
        'Ytfin
        '
        Me.Ytfin.DecimalPlaces = 2
        Me.Ytfin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Ytfin.Location = New System.Drawing.Point(221, 100)
        Me.Ytfin.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Ytfin.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.Ytfin.Name = "Ytfin"
        Me.Ytfin.Size = New System.Drawing.Size(99, 20)
        Me.Ytfin.TabIndex = 24
        '
        'nbSegements
        '
        Me.nbSegements.Location = New System.Drawing.Point(159, 141)
        Me.nbSegements.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nbSegements.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nbSegements.Name = "nbSegements"
        Me.nbSegements.Size = New System.Drawing.Size(161, 20)
        Me.nbSegements.TabIndex = 23
        Me.nbSegements.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Xtfin
        '
        Me.Xtfin.DecimalPlaces = 2
        Me.Xtfin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Xtfin.Location = New System.Drawing.Point(68, 98)
        Me.Xtfin.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Xtfin.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.Xtfin.Name = "Xtfin"
        Me.Xtfin.Size = New System.Drawing.Size(99, 20)
        Me.Xtfin.TabIndex = 23
        '
        'Yfin
        '
        Me.Yfin.DecimalPlaces = 2
        Me.Yfin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Yfin.Location = New System.Drawing.Point(221, 48)
        Me.Yfin.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Yfin.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.Yfin.Name = "Yfin"
        Me.Yfin.Size = New System.Drawing.Size(99, 20)
        Me.Yfin.TabIndex = 22
        '
        'Xtdeb
        '
        Me.Xtdeb.DecimalPlaces = 2
        Me.Xtdeb.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Xtdeb.Location = New System.Drawing.Point(68, 72)
        Me.Xtdeb.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Xtdeb.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.Xtdeb.Name = "Xtdeb"
        Me.Xtdeb.Size = New System.Drawing.Size(99, 20)
        Me.Xtdeb.TabIndex = 21
        '
        'Ytdeb
        '
        Me.Ytdeb.DecimalPlaces = 2
        Me.Ytdeb.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Ytdeb.Location = New System.Drawing.Point(221, 74)
        Me.Ytdeb.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Ytdeb.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.Ytdeb.Name = "Ytdeb"
        Me.Ytdeb.Size = New System.Drawing.Size(99, 20)
        Me.Ytdeb.TabIndex = 20
        '
        'Xfin
        '
        Me.Xfin.DecimalPlaces = 2
        Me.Xfin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Xfin.Location = New System.Drawing.Point(68, 46)
        Me.Xfin.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Xfin.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.Xfin.Name = "Xfin"
        Me.Xfin.Size = New System.Drawing.Size(99, 20)
        Me.Xfin.TabIndex = 19
        '
        'Ydeb
        '
        Me.Ydeb.DecimalPlaces = 2
        Me.Ydeb.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Ydeb.Location = New System.Drawing.Point(221, 20)
        Me.Ydeb.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Ydeb.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.Ydeb.Name = "Ydeb"
        Me.Ydeb.Size = New System.Drawing.Size(99, 20)
        Me.Ydeb.TabIndex = 18
        '
        'Xdeb
        '
        Me.Xdeb.DecimalPlaces = 2
        Me.Xdeb.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Xdeb.Location = New System.Drawing.Point(68, 20)
        Me.Xdeb.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Xdeb.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.Xdeb.Name = "Xdeb"
        Me.Xdeb.Size = New System.Drawing.Size(99, 20)
        Me.Xdeb.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(183, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Yfin"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Xfin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(183, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Ytdeb"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Xtdeb"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(183, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ytfin"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Nombre de segements :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Xtfin"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(227, 177)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Supprimer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'modifierButton
        '
        Me.modifierButton.Location = New System.Drawing.Point(130, 177)
        Me.modifierButton.Name = "modifierButton"
        Me.modifierButton.Size = New System.Drawing.Size(96, 23)
        Me.modifierButton.TabIndex = 4
        Me.modifierButton.Text = "Modifier"
        Me.modifierButton.UseVisualStyleBackColor = True
        Me.modifierButton.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ydeb"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Xdeb"
        '
        'CourbeBindingSource
        '
        Me.CourbeBindingSource.DataSource = GetType(CourbesBezier.Courbe)
        '
        'FenetrePrincipale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.plan)
        Me.Name = "FenetrePrincipale"
        Me.Text = "Courbe de Bézier"
        CType(Me.plan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Ytfin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nbSegements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Xtfin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Yfin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Xtdeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ytdeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Xfin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ydeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Xdeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourbeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents plan As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Ytfin As NumericUpDown
    Friend WithEvents Xtfin As NumericUpDown
    Friend WithEvents Yfin As NumericUpDown
    Friend WithEvents Xtdeb As NumericUpDown
    Friend WithEvents Ytdeb As NumericUpDown
    Friend WithEvents Xfin As NumericUpDown
    Friend WithEvents Ydeb As NumericUpDown
    Friend WithEvents Xdeb As NumericUpDown
    Friend WithEvents nbSegements As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents modifierButton As Button
    Friend WithEvents CourbeBindingSource As BindingSource
    Friend WithEvents pointData As ListBox
End Class
