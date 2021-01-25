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
        Me.lblAspar = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblPackSize = New System.Windows.Forms.Label()
        Me.lblPacks = New System.Windows.Forms.Label()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.txtAspar = New System.Windows.Forms.TextBox()
        Me.btnShip = New System.Windows.Forms.Button()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAspar
        '
        Me.lblAspar.AutoSize = True
        Me.lblAspar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAspar.Location = New System.Drawing.Point(12, 98)
        Me.lblAspar.Name = "lblAspar"
        Me.lblAspar.Size = New System.Drawing.Size(105, 24)
        Me.lblAspar.TabIndex = 0
        Me.lblAspar.Text = "Asparagus:"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSize.Location = New System.Drawing.Point(110, 238)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(30, 24)
        Me.lblSize.TabIndex = 1
        Me.lblSize.Text = "12"
        '
        'lblPackSize
        '
        Me.lblPackSize.AutoSize = True
        Me.lblPackSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackSize.Location = New System.Drawing.Point(12, 238)
        Me.lblPackSize.Name = "lblPackSize"
        Me.lblPackSize.Size = New System.Drawing.Size(92, 24)
        Me.lblPackSize.TabIndex = 2
        Me.lblPackSize.Text = "Pack Size"
        '
        'lblPacks
        '
        Me.lblPacks.AutoSize = True
        Me.lblPacks.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPacks.Location = New System.Drawing.Point(346, 166)
        Me.lblPacks.Name = "lblPacks"
        Me.lblPacks.Size = New System.Drawing.Size(65, 24)
        Me.lblPacks.TabIndex = 3
        Me.lblPacks.Text = "Packs:"
        '
        'lblLeft
        '
        Me.lblLeft.AutoSize = True
        Me.lblLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeft.Location = New System.Drawing.Point(346, 238)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(90, 24)
        Me.lblLeft.TabIndex = 4
        Me.lblLeft.Text = "Leftovers:"
        '
        'txtAspar
        '
        Me.txtAspar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAspar.Location = New System.Drawing.Point(123, 98)
        Me.txtAspar.Name = "txtAspar"
        Me.txtAspar.Size = New System.Drawing.Size(100, 29)
        Me.txtAspar.TabIndex = 5
        '
        'btnShip
        '
        Me.btnShip.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShip.Location = New System.Drawing.Point(350, 98)
        Me.btnShip.Name = "btnShip"
        Me.btnShip.Size = New System.Drawing.Size(100, 29)
        Me.btnShip.TabIndex = 6
        Me.btnShip.Text = "Ship Order"
        Me.btnShip.UseVisualStyleBackColor = True
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipping.Location = New System.Drawing.Point(12, 9)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(119, 31)
        Me.lblShipping.TabIndex = 7
        Me.lblShipping.Text = "Shipping"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 442)
        Me.Controls.Add(Me.lblShipping)
        Me.Controls.Add(Me.btnShip)
        Me.Controls.Add(Me.txtAspar)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.lblPacks)
        Me.Controls.Add(Me.lblPackSize)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.lblAspar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAspar As System.Windows.Forms.Label
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents lblPackSize As System.Windows.Forms.Label
    Friend WithEvents lblPacks As System.Windows.Forms.Label
    Friend WithEvents lblLeft As System.Windows.Forms.Label
    Friend WithEvents txtAspar As System.Windows.Forms.TextBox
    Friend WithEvents btnShip As System.Windows.Forms.Button
    Friend WithEvents lblShipping As System.Windows.Forms.Label

End Class
