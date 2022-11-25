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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FenetrePrincipale))
        Me.plan = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.showAll = New System.Windows.Forms.CheckBox()
        Me.nbSegements = New System.Windows.Forms.NumericUpDown()
        Me.pbCouleur = New System.Windows.Forms.PictureBox()
        Me.btnCouleur = New System.Windows.Forms.Button()
        Me.lblLongueur = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnTfin = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnTdeb = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnFin = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnDeb = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pointData = New System.Windows.Forms.ListView()
        Me.Ytfin = New System.Windows.Forms.NumericUpDown()
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
        Me.supprimer = New System.Windows.Forms.Button()
        Me.modifier = New System.Windows.Forms.Button()
        Me.ajouter = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMouse = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.gpPlan = New System.Windows.Forms.GroupBox()
        CType(Me.plan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nbSegements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCouleur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ytfin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Xtfin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Yfin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Xtdeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ytdeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Xfin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ydeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Xdeb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.gpPlan.SuspendLayout()
        Me.SuspendLayout()
        '
        'plan
        '
        resources.ApplyResources(Me.plan, "plan")
        Me.plan.BackColor = System.Drawing.Color.White
        Me.plan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.plan.Cursor = System.Windows.Forms.Cursors.Cross
        Me.plan.Name = "plan"
        Me.plan.TabStop = False
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.showAll)
        Me.GroupBox1.Controls.Add(Me.nbSegements)
        Me.GroupBox1.Controls.Add(Me.pbCouleur)
        Me.GroupBox1.Controls.Add(Me.btnCouleur)
        Me.GroupBox1.Controls.Add(Me.lblLongueur)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnTfin)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.btnTdeb)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btnFin)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnDeb)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.pointData)
        Me.GroupBox1.Controls.Add(Me.Ytfin)
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
        Me.GroupBox1.Controls.Add(Me.supprimer)
        Me.GroupBox1.Controls.Add(Me.modifier)
        Me.GroupBox1.Controls.Add(Me.ajouter)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'showAll
        '
        resources.ApplyResources(Me.showAll, "showAll")
        Me.showAll.Name = "showAll"
        Me.showAll.UseVisualStyleBackColor = True
        '
        'nbSegements
        '
        resources.ApplyResources(Me.nbSegements, "nbSegements")
        Me.nbSegements.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nbSegements.Name = "nbSegements"
        Me.nbSegements.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'pbCouleur
        '
        resources.ApplyResources(Me.pbCouleur, "pbCouleur")
        Me.pbCouleur.BackColor = System.Drawing.Color.White
        Me.pbCouleur.Name = "pbCouleur"
        Me.pbCouleur.TabStop = False
        '
        'btnCouleur
        '
        resources.ApplyResources(Me.btnCouleur, "btnCouleur")
        Me.btnCouleur.Name = "btnCouleur"
        Me.btnCouleur.UseVisualStyleBackColor = True
        '
        'lblLongueur
        '
        resources.ApplyResources(Me.lblLongueur, "lblLongueur")
        Me.lblLongueur.Name = "lblLongueur"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'btnTfin
        '
        resources.ApplyResources(Me.btnTfin, "btnTfin")
        Me.btnTfin.Name = "btnTfin"
        Me.btnTfin.UseVisualStyleBackColor = True
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnTdeb
        '
        resources.ApplyResources(Me.btnTdeb, "btnTdeb")
        Me.btnTdeb.Name = "btnTdeb"
        Me.btnTdeb.UseVisualStyleBackColor = True
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnFin
        '
        resources.ApplyResources(Me.btnFin, "btnFin")
        Me.btnFin.Name = "btnFin"
        Me.btnFin.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnDeb
        '
        resources.ApplyResources(Me.btnDeb, "btnDeb")
        Me.btnDeb.Name = "btnDeb"
        Me.btnDeb.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pointData
        '
        resources.ApplyResources(Me.pointData, "pointData")
        Me.pointData.FullRowSelect = True
        Me.pointData.HideSelection = False
        Me.pointData.MultiSelect = False
        Me.pointData.Name = "pointData"
        Me.pointData.UseCompatibleStateImageBehavior = False
        '
        'Ytfin
        '
        resources.ApplyResources(Me.Ytfin, "Ytfin")
        Me.Ytfin.DecimalPlaces = 2
        Me.Ytfin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Ytfin.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Ytfin.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.Ytfin.Name = "Ytfin"
        '
        'Xtfin
        '
        resources.ApplyResources(Me.Xtfin, "Xtfin")
        Me.Xtfin.DecimalPlaces = 2
        Me.Xtfin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Xtfin.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Xtfin.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.Xtfin.Name = "Xtfin"
        '
        'Yfin
        '
        resources.ApplyResources(Me.Yfin, "Yfin")
        Me.Yfin.DecimalPlaces = 2
        Me.Yfin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Yfin.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Yfin.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.Yfin.Name = "Yfin"
        '
        'Xtdeb
        '
        resources.ApplyResources(Me.Xtdeb, "Xtdeb")
        Me.Xtdeb.DecimalPlaces = 2
        Me.Xtdeb.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Xtdeb.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Xtdeb.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.Xtdeb.Name = "Xtdeb"
        '
        'Ytdeb
        '
        resources.ApplyResources(Me.Ytdeb, "Ytdeb")
        Me.Ytdeb.DecimalPlaces = 2
        Me.Ytdeb.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Ytdeb.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Ytdeb.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.Ytdeb.Name = "Ytdeb"
        '
        'Xfin
        '
        resources.ApplyResources(Me.Xfin, "Xfin")
        Me.Xfin.DecimalPlaces = 2
        Me.Xfin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Xfin.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Xfin.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.Xfin.Name = "Xfin"
        '
        'Ydeb
        '
        resources.ApplyResources(Me.Ydeb, "Ydeb")
        Me.Ydeb.DecimalPlaces = 2
        Me.Ydeb.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Ydeb.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Ydeb.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.Ydeb.Name = "Ydeb"
        '
        'Xdeb
        '
        resources.ApplyResources(Me.Xdeb, "Xdeb")
        Me.Xdeb.DecimalPlaces = 2
        Me.Xdeb.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Xdeb.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Xdeb.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.Xdeb.Name = "Xdeb"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'supprimer
        '
        resources.ApplyResources(Me.supprimer, "supprimer")
        Me.supprimer.Name = "supprimer"
        Me.supprimer.UseVisualStyleBackColor = True
        '
        'modifier
        '
        resources.ApplyResources(Me.modifier, "modifier")
        Me.modifier.Name = "modifier"
        Me.modifier.UseVisualStyleBackColor = True
        '
        'ajouter
        '
        resources.ApplyResources(Me.ajouter, "ajouter")
        Me.ajouter.Name = "ajouter"
        Me.ajouter.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'lblMouse
        '
        resources.ApplyResources(Me.lblMouse, "lblMouse")
        Me.lblMouse.BackColor = System.Drawing.Color.White
        Me.lblMouse.Name = "lblMouse"
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.InfoToolStripMenuItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem, Me.SaveAsToolStripMenuItem1, Me.SaveAsToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        '
        'LoadToolStripMenuItem
        '
        resources.ApplyResources(Me.LoadToolStripMenuItem, "LoadToolStripMenuItem")
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        '
        'SaveAsToolStripMenuItem1
        '
        resources.ApplyResources(Me.SaveAsToolStripMenuItem1, "SaveAsToolStripMenuItem1")
        Me.SaveAsToolStripMenuItem1.Name = "SaveAsToolStripMenuItem1"
        '
        'SaveAsToolStripMenuItem
        '
        resources.ApplyResources(Me.SaveAsToolStripMenuItem, "SaveAsToolStripMenuItem")
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        '
        'InfoToolStripMenuItem
        '
        resources.ApplyResources(Me.InfoToolStripMenuItem, "InfoToolStripMenuItem")
        Me.InfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem1})
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        '
        'InfoToolStripMenuItem1
        '
        resources.ApplyResources(Me.InfoToolStripMenuItem1, "InfoToolStripMenuItem1")
        Me.InfoToolStripMenuItem1.Name = "InfoToolStripMenuItem1"
        '
        'gpPlan
        '
        resources.ApplyResources(Me.gpPlan, "gpPlan")
        Me.gpPlan.Controls.Add(Me.lblMouse)
        Me.gpPlan.Controls.Add(Me.plan)
        Me.gpPlan.Name = "gpPlan"
        Me.gpPlan.TabStop = False
        '
        'FenetrePrincipale
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gpPlan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FenetrePrincipale"
        CType(Me.plan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nbSegements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCouleur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ytfin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Xtfin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Yfin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Xtdeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ytdeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Xfin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ydeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Xdeb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gpPlan.ResumeLayout(False)
        Me.gpPlan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ajouter As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents supprimer As Button
    Friend WithEvents Ytfin As NumericUpDown
    Friend WithEvents Xtfin As NumericUpDown
    Friend WithEvents Yfin As NumericUpDown
    Friend WithEvents Xtdeb As NumericUpDown
    Friend WithEvents Ytdeb As NumericUpDown
    Friend WithEvents Xfin As NumericUpDown
    Friend WithEvents Ydeb As NumericUpDown
    Friend WithEvents Xdeb As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents modifier As Button
    Friend WithEvents pointData As ListView
    Friend WithEvents btnTfin As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnTdeb As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnFin As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnDeb As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents lblLongueur As TextBox
    Friend WithEvents lblMouse As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btnCouleur As Button
    Friend WithEvents pbCouleur As PictureBox
    Friend WithEvents nbSegements As NumericUpDown
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents plan As PictureBox
    Friend WithEvents gpPlan As GroupBox
    Friend WithEvents showAll As CheckBox
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem1 As ToolStripMenuItem
End Class
