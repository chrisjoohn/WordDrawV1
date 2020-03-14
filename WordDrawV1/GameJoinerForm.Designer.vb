<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameJoinerForm
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
        Me.pbDraw = New System.Windows.Forms.PictureBox()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.cbSize = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.pbDraw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbDraw
        '
        Me.pbDraw.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbDraw.Cursor = System.Windows.Forms.Cursors.Cross
        Me.pbDraw.Location = New System.Drawing.Point(104, 44)
        Me.pbDraw.Name = "pbDraw"
        Me.pbDraw.Size = New System.Drawing.Size(612, 450)
        Me.pbDraw.TabIndex = 1
        Me.pbDraw.TabStop = False
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.clearBtn.FlatAppearance.BorderSize = 0
        Me.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(751, 44)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(149, 51)
        Me.clearBtn.TabIndex = 3
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'cbSize
        '
        Me.cbSize.FormattingEnabled = True
        Me.cbSize.Items.AddRange(New Object() {"2", "4", "6", "8", "10", "12", "14"})
        Me.cbSize.Location = New System.Drawing.Point(732, 101)
        Me.cbSize.Name = "cbSize"
        Me.cbSize.Size = New System.Drawing.Size(174, 21)
        Me.cbSize.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(784, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GameJoinerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 558)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbSize)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.pbDraw)
        Me.Name = "GameJoinerForm"
        Me.Text = "GameJoinerForm"
        CType(Me.pbDraw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbDraw As PictureBox
    Friend WithEvents clearBtn As Button
    Friend WithEvents cbSize As ComboBox
    Friend WithEvents Button1 As Button
End Class
