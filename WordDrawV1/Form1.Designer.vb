<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WordDraw
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
        Me.cbSize = New System.Windows.Forms.ComboBox()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pbBlack = New System.Windows.Forms.PictureBox()
        Me.pbGray = New System.Windows.Forms.PictureBox()
        Me.pbBrown = New System.Windows.Forms.PictureBox()
        Me.pbRed = New System.Windows.Forms.PictureBox()
        Me.pbPink = New System.Windows.Forms.PictureBox()
        Me.pbOrange = New System.Windows.Forms.PictureBox()
        Me.pbPeach = New System.Windows.Forms.PictureBox()
        Me.pbYellow = New System.Windows.Forms.PictureBox()
        Me.pbGreen = New System.Windows.Forms.PictureBox()
        Me.pbDgreen = New System.Windows.Forms.PictureBox()
        Me.pbBlue = New System.Windows.Forms.PictureBox()
        Me.pbDblue = New System.Windows.Forms.PictureBox()
        Me.pbViolet = New System.Windows.Forms.PictureBox()
        Me.pbDviolet = New System.Windows.Forms.PictureBox()
        Me.pbEraser = New System.Windows.Forms.PictureBox()
        Me.guesserInput = New System.Windows.Forms.FlowLayoutPanel()
        Me.SUBMIT = New System.Windows.Forms.Button()
        Me.meDraw = New System.Windows.Forms.Button()
        Me.pbDraw = New System.Windows.Forms.PictureBox()
        Me.drawingControls = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.pbBlack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGray, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBrown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOrange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPeach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbYellow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDgreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDblue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbViolet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDviolet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEraser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.guesserInput.SuspendLayout()
        CType(Me.pbDraw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.drawingControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbSize
        '
        Me.cbSize.FormattingEnabled = True
        Me.cbSize.Items.AddRange(New Object() {"2", "4", "6", "8", "10", "12", "14"})
        Me.cbSize.Location = New System.Drawing.Point(3, 33)
        Me.cbSize.Name = "cbSize"
        Me.cbSize.Size = New System.Drawing.Size(174, 21)
        Me.cbSize.TabIndex = 1
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.clearBtn.FlatAppearance.BorderSize = 0
        Me.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(458, 3)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(149, 51)
        Me.clearBtn.TabIndex = 2
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 83)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(242, 516)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(424, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(719, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 27)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "DONE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(504, 49)
        Me.TextBox1.TabIndex = 22
        '
        'pbBlack
        '
        Me.pbBlack.BackColor = System.Drawing.Color.Transparent
        Me.pbBlack.BackgroundImage = Global.DrawingApp.My.Resources.Resources.black_selected
        Me.pbBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbBlack.Location = New System.Drawing.Point(3, 3)
        Me.pbBlack.Name = "pbBlack"
        Me.pbBlack.Size = New System.Drawing.Size(24, 24)
        Me.pbBlack.TabIndex = 6
        Me.pbBlack.TabStop = False
        '
        'pbGray
        '
        Me.pbGray.BackColor = System.Drawing.Color.Transparent
        Me.pbGray.BackgroundImage = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbGray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbGray.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbGray.Location = New System.Drawing.Point(33, 3)
        Me.pbGray.Name = "pbGray"
        Me.pbGray.Size = New System.Drawing.Size(24, 24)
        Me.pbGray.TabIndex = 7
        Me.pbGray.TabStop = False
        '
        'pbBrown
        '
        Me.pbBrown.BackColor = System.Drawing.Color.Transparent
        Me.pbBrown.BackgroundImage = Global.DrawingApp.My.Resources.Resources.brown_unselected
        Me.pbBrown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbBrown.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbBrown.Location = New System.Drawing.Point(63, 3)
        Me.pbBrown.Name = "pbBrown"
        Me.pbBrown.Size = New System.Drawing.Size(24, 24)
        Me.pbBrown.TabIndex = 8
        Me.pbBrown.TabStop = False
        '
        'pbRed
        '
        Me.pbRed.BackColor = System.Drawing.Color.Transparent
        Me.pbRed.BackgroundImage = Global.DrawingApp.My.Resources.Resources.red_unselected
        Me.pbRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbRed.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbRed.Location = New System.Drawing.Point(93, 3)
        Me.pbRed.Name = "pbRed"
        Me.pbRed.Size = New System.Drawing.Size(24, 24)
        Me.pbRed.TabIndex = 9
        Me.pbRed.TabStop = False
        '
        'pbPink
        '
        Me.pbPink.BackColor = System.Drawing.Color.Transparent
        Me.pbPink.BackgroundImage = Global.DrawingApp.My.Resources.Resources.pink_unselected
        Me.pbPink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbPink.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbPink.Location = New System.Drawing.Point(123, 3)
        Me.pbPink.Name = "pbPink"
        Me.pbPink.Size = New System.Drawing.Size(24, 24)
        Me.pbPink.TabIndex = 10
        Me.pbPink.TabStop = False
        '
        'pbOrange
        '
        Me.pbOrange.BackColor = System.Drawing.Color.Transparent
        Me.pbOrange.BackgroundImage = Global.DrawingApp.My.Resources.Resources.orange_unselected
        Me.pbOrange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbOrange.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbOrange.Location = New System.Drawing.Point(153, 3)
        Me.pbOrange.Name = "pbOrange"
        Me.pbOrange.Size = New System.Drawing.Size(24, 24)
        Me.pbOrange.TabIndex = 11
        Me.pbOrange.TabStop = False
        '
        'pbPeach
        '
        Me.pbPeach.BackColor = System.Drawing.Color.Transparent
        Me.pbPeach.BackgroundImage = Global.DrawingApp.My.Resources.Resources.peach_unselected
        Me.pbPeach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbPeach.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbPeach.Location = New System.Drawing.Point(183, 3)
        Me.pbPeach.Name = "pbPeach"
        Me.pbPeach.Size = New System.Drawing.Size(24, 24)
        Me.pbPeach.TabIndex = 12
        Me.pbPeach.TabStop = False
        '
        'pbYellow
        '
        Me.pbYellow.BackColor = System.Drawing.Color.Transparent
        Me.pbYellow.BackgroundImage = Global.DrawingApp.My.Resources.Resources.yellow_unselected
        Me.pbYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbYellow.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbYellow.Location = New System.Drawing.Point(213, 3)
        Me.pbYellow.Name = "pbYellow"
        Me.pbYellow.Size = New System.Drawing.Size(24, 24)
        Me.pbYellow.TabIndex = 13
        Me.pbYellow.TabStop = False
        '
        'pbGreen
        '
        Me.pbGreen.BackColor = System.Drawing.Color.Transparent
        Me.pbGreen.BackgroundImage = Global.DrawingApp.My.Resources.Resources.green_selected1
        Me.pbGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbGreen.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbGreen.Location = New System.Drawing.Point(243, 3)
        Me.pbGreen.Name = "pbGreen"
        Me.pbGreen.Size = New System.Drawing.Size(24, 24)
        Me.pbGreen.TabIndex = 14
        Me.pbGreen.TabStop = False
        '
        'pbDgreen
        '
        Me.pbDgreen.BackColor = System.Drawing.Color.Transparent
        Me.pbDgreen.BackgroundImage = Global.DrawingApp.My.Resources.Resources.dgreen_selected1
        Me.pbDgreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbDgreen.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbDgreen.Location = New System.Drawing.Point(273, 3)
        Me.pbDgreen.Name = "pbDgreen"
        Me.pbDgreen.Size = New System.Drawing.Size(24, 24)
        Me.pbDgreen.TabIndex = 15
        Me.pbDgreen.TabStop = False
        '
        'pbBlue
        '
        Me.pbBlue.BackColor = System.Drawing.Color.Transparent
        Me.pbBlue.BackgroundImage = Global.DrawingApp.My.Resources.Resources.blue_unselected
        Me.pbBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbBlue.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbBlue.Location = New System.Drawing.Point(303, 3)
        Me.pbBlue.Name = "pbBlue"
        Me.pbBlue.Size = New System.Drawing.Size(24, 24)
        Me.pbBlue.TabIndex = 16
        Me.pbBlue.TabStop = False
        '
        'pbDblue
        '
        Me.pbDblue.BackColor = System.Drawing.Color.Transparent
        Me.pbDblue.BackgroundImage = Global.DrawingApp.My.Resources.Resources.dblue_unselected
        Me.pbDblue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbDblue.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbDblue.Location = New System.Drawing.Point(333, 3)
        Me.pbDblue.Name = "pbDblue"
        Me.pbDblue.Size = New System.Drawing.Size(24, 24)
        Me.pbDblue.TabIndex = 17
        Me.pbDblue.TabStop = False
        '
        'pbViolet
        '
        Me.pbViolet.BackColor = System.Drawing.Color.Transparent
        Me.pbViolet.BackgroundImage = Global.DrawingApp.My.Resources.Resources.violet_unselected
        Me.pbViolet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbViolet.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbViolet.Location = New System.Drawing.Point(363, 3)
        Me.pbViolet.Name = "pbViolet"
        Me.pbViolet.Size = New System.Drawing.Size(24, 24)
        Me.pbViolet.TabIndex = 18
        Me.pbViolet.TabStop = False
        '
        'pbDviolet
        '
        Me.pbDviolet.BackColor = System.Drawing.Color.Transparent
        Me.pbDviolet.BackgroundImage = Global.DrawingApp.My.Resources.Resources.dviolet_unselected
        Me.pbDviolet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbDviolet.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbDviolet.Location = New System.Drawing.Point(393, 3)
        Me.pbDviolet.Name = "pbDviolet"
        Me.pbDviolet.Size = New System.Drawing.Size(24, 24)
        Me.pbDviolet.TabIndex = 19
        Me.pbDviolet.TabStop = False
        '
        'pbEraser
        '
        Me.pbEraser.BackColor = System.Drawing.Color.Transparent
        Me.pbEraser.BackgroundImage = Global.DrawingApp.My.Resources.Resources.eraser_unselcted
        Me.pbEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbEraser.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbEraser.Location = New System.Drawing.Point(423, 3)
        Me.pbEraser.Name = "pbEraser"
        Me.pbEraser.Size = New System.Drawing.Size(24, 24)
        Me.pbEraser.TabIndex = 20
        Me.pbEraser.TabStop = False
        '
        'guesserInput
        '
        Me.guesserInput.Controls.Add(Me.TextBox1)
        Me.guesserInput.Controls.Add(Me.SUBMIT)
        Me.guesserInput.Location = New System.Drawing.Point(260, 542)
        Me.guesserInput.Name = "guesserInput"
        Me.guesserInput.Size = New System.Drawing.Size(611, 60)
        Me.guesserInput.TabIndex = 24
        Me.guesserInput.Visible = False
        '
        'SUBMIT
        '
        Me.SUBMIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SUBMIT.FlatAppearance.BorderSize = 0
        Me.SUBMIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SUBMIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUBMIT.Location = New System.Drawing.Point(513, 3)
        Me.SUBMIT.Name = "SUBMIT"
        Me.SUBMIT.Size = New System.Drawing.Size(94, 51)
        Me.SUBMIT.TabIndex = 23
        Me.SUBMIT.Text = "SUBMIT"
        Me.SUBMIT.UseVisualStyleBackColor = False
        '
        'meDraw
        '
        Me.meDraw.Location = New System.Drawing.Point(719, 41)
        Me.meDraw.Name = "meDraw"
        Me.meDraw.Size = New System.Drawing.Size(152, 33)
        Me.meDraw.TabIndex = 25
        Me.meDraw.Text = "Me Draw"
        Me.meDraw.UseVisualStyleBackColor = True
        '
        'pbDraw
        '
        Me.pbDraw.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbDraw.Cursor = System.Windows.Forms.Cursors.Cross
        Me.pbDraw.Location = New System.Drawing.Point(260, 86)
        Me.pbDraw.Name = "pbDraw"
        Me.pbDraw.Size = New System.Drawing.Size(612, 450)
        Me.pbDraw.TabIndex = 0
        Me.pbDraw.TabStop = False
        '
        'drawingControls
        '
        Me.drawingControls.Controls.Add(Me.pbBlack)
        Me.drawingControls.Controls.Add(Me.pbGray)
        Me.drawingControls.Controls.Add(Me.clearBtn)
        Me.drawingControls.Controls.Add(Me.pbBrown)
        Me.drawingControls.Controls.Add(Me.cbSize)
        Me.drawingControls.Controls.Add(Me.pbRed)
        Me.drawingControls.Controls.Add(Me.pbEraser)
        Me.drawingControls.Controls.Add(Me.pbPink)
        Me.drawingControls.Controls.Add(Me.pbDviolet)
        Me.drawingControls.Controls.Add(Me.pbOrange)
        Me.drawingControls.Controls.Add(Me.pbViolet)
        Me.drawingControls.Controls.Add(Me.pbPeach)
        Me.drawingControls.Controls.Add(Me.pbDblue)
        Me.drawingControls.Controls.Add(Me.pbYellow)
        Me.drawingControls.Controls.Add(Me.pbBlue)
        Me.drawingControls.Controls.Add(Me.pbGreen)
        Me.drawingControls.Controls.Add(Me.pbDgreen)
        Me.drawingControls.Location = New System.Drawing.Point(261, 542)
        Me.drawingControls.Name = "drawingControls"
        Me.drawingControls.Size = New System.Drawing.Size(610, 57)
        Me.drawingControls.TabIndex = 26
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(156, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'WordDraw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 611)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.drawingControls)
        Me.Controls.Add(Me.meDraw)
        Me.Controls.Add(Me.guesserInput)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.pbDraw)
        Me.Name = "WordDraw"
        Me.Text = "Form1"
        CType(Me.pbBlack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGray, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBrown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOrange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPeach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbYellow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDgreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDblue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbViolet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDviolet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEraser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.guesserInput.ResumeLayout(False)
        Me.guesserInput.PerformLayout()
        CType(Me.pbDraw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.drawingControls.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbDraw As PictureBox
    Friend WithEvents cbSize As ComboBox
    Friend WithEvents clearBtn As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents pbBlack As PictureBox
    Friend WithEvents pbGray As PictureBox
    Friend WithEvents pbBrown As PictureBox
    Friend WithEvents pbRed As PictureBox
    Friend WithEvents pbPink As PictureBox
    Friend WithEvents pbOrange As PictureBox
    Friend WithEvents pbPeach As PictureBox
    Friend WithEvents pbYellow As PictureBox
    Friend WithEvents pbGreen As PictureBox
    Friend WithEvents pbDgreen As PictureBox
    Friend WithEvents pbBlue As PictureBox
    Friend WithEvents pbDblue As PictureBox
    Friend WithEvents pbViolet As PictureBox
    Friend WithEvents pbDviolet As PictureBox
    Friend WithEvents pbEraser As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents guesserInput As FlowLayoutPanel
    Friend WithEvents SUBMIT As Button
    Friend WithEvents meDraw As Button
    Friend WithEvents drawingControls As Panel
    Friend WithEvents Button2 As Button
End Class
