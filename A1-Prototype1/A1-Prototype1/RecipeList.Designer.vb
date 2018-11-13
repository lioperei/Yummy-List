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
        'RecipeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Import)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.AddRecipeItem)
        Me.Controls.Add(Me.RecipeItemPanel)
        Me.Name = "RecipeList"
        Me.Size = New System.Drawing.Size(321, 269)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RecipeItemPanel As FlowLayoutPanel
    Friend WithEvents AddRecipeItem As Button
    Friend WithEvents Save As Button
    Friend WithEvents Import As Button
    Friend WithEvents Cancel As Button
End Class
