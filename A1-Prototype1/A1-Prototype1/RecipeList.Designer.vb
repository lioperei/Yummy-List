<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecipeList
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.RecipeItemPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddRecipeItem = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.Import = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ImportPanel = New System.Windows.Forms.Panel()
        Me.ImportNames = New System.Windows.Forms.ListBox()
        Me.ImportConfirm = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ImportPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RecipeItemPanel
        '
        Me.RecipeItemPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.RecipeItemPanel.Location = New System.Drawing.Point(10, 36)
        Me.RecipeItemPanel.Name = "RecipeItemPanel"
        Me.RecipeItemPanel.Size = New System.Drawing.Size(300, 183)
        Me.RecipeItemPanel.TabIndex = 0
        '
        'AddRecipeItem
        '
        Me.AddRecipeItem.Location = New System.Drawing.Point(91, 225)
        Me.AddRecipeItem.Name = "AddRecipeItem"
        Me.AddRecipeItem.Size = New System.Drawing.Size(31, 23)
        Me.AddRecipeItem.TabIndex = 1
        Me.AddRecipeItem.Text = "+"
        Me.AddRecipeItem.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(235, 225)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 0
        Me.Save.Text = "SAVE"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Import
        '
        Me.Import.Location = New System.Drawing.Point(10, 225)
        Me.Import.Name = "Import"
        Me.Import.Size = New System.Drawing.Size(75, 23)
        Me.Import.TabIndex = 2
        Me.Import.Text = "IMPORT"
        Me.Import.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(154, 225)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 3
        Me.Cancel.Text = "CANCEL"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ITEM NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(185, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "QUANTITY"
        '
        'ImportPanel
        '
        Me.ImportPanel.Controls.Add(Me.ImportNames)
        Me.ImportPanel.Controls.Add(Me.ImportConfirm)
        Me.ImportPanel.Controls.Add(Me.Label3)
        Me.ImportPanel.Location = New System.Drawing.Point(10, 255)
        Me.ImportPanel.Name = "ImportPanel"
        Me.ImportPanel.Size = New System.Drawing.Size(300, 117)
        Me.ImportPanel.TabIndex = 5
        '
        'ImportNames
        '
        Me.ImportNames.FormattingEnabled = True
        Me.ImportNames.Location = New System.Drawing.Point(46, 4)
        Me.ImportNames.Name = "ImportNames"
        Me.ImportNames.Size = New System.Drawing.Size(170, 95)
        Me.ImportNames.TabIndex = 4
        '
        'ImportConfirm
        '
        Me.ImportConfirm.BackColor = System.Drawing.Color.Lime
        Me.ImportConfirm.Location = New System.Drawing.Point(222, 0)
        Me.ImportConfirm.Name = "ImportConfirm"
        Me.ImportConfirm.Size = New System.Drawing.Size(75, 23)
        Me.ImportConfirm.TabIndex = 3
        Me.ImportConfirm.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Import"
        '
        'RecipeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ImportPanel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Import)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.AddRecipeItem)
        Me.Controls.Add(Me.RecipeItemPanel)
        Me.Name = "RecipeList"
        Me.Size = New System.Drawing.Size(321, 378)
        Me.ImportPanel.ResumeLayout(False)
        Me.ImportPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RecipeItemPanel As FlowLayoutPanel
    Friend WithEvents AddRecipeItem As Button
    Friend WithEvents Save As Button
    Friend WithEvents Import As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ImportPanel As Panel
    Friend WithEvents ImportNames As ListBox
    Friend WithEvents ImportConfirm As Button
    Friend WithEvents Label3 As Label
End Class
