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
        Me.AddRecipeButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ImportButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RecipeItemPanel
        '
        Me.RecipeItemPanel.AutoScroll = True
        Me.RecipeItemPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.RecipeItemPanel.Location = New System.Drawing.Point(10, 36)
        Me.RecipeItemPanel.Name = "RecipeItemPanel"
        Me.RecipeItemPanel.Size = New System.Drawing.Size(300, 183)
        Me.RecipeItemPanel.TabIndex = 0
        '
        'AddRecipeButton
        '
        Me.AddRecipeButton.Location = New System.Drawing.Point(91, 225)
        Me.AddRecipeButton.Name = "AddRecipeButton"
        Me.AddRecipeButton.Size = New System.Drawing.Size(31, 23)
        Me.AddRecipeButton.TabIndex = 1
        Me.AddRecipeButton.Text = "+"
        Me.AddRecipeButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(235, 225)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.Text = "SAVE"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ImportButton
        '
        Me.ImportButton.Location = New System.Drawing.Point(10, 225)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(75, 23)
        Me.ImportButton.TabIndex = 2
        Me.ImportButton.Text = "IMPORT"
        Me.ImportButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(154, 225)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 3
        Me.CancelButton.Text = "CANCEL"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'RecipeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ImportButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.AddRecipeButton)
        Me.Controls.Add(Me.RecipeItemPanel)
        Me.Name = "RecipeList"
        Me.Size = New System.Drawing.Size(321, 269)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RecipeItemPanel As FlowLayoutPanel
    Friend WithEvents AddRecipeButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents ImportButton As Button
    Friend WithEvents CancelButton As Button
End Class
