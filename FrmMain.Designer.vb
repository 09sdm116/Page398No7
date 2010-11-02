<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.btnChart = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lstChart = New System.Windows.Forms.ListBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtRemove = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblRow = New System.Windows.Forms.Label()
        Me.lblSeat = New System.Windows.Forms.Label()
        Me.txtRow = New System.Windows.Forms.TextBox()
        Me.txtSeat = New System.Windows.Forms.TextBox()
        Me.lblSeat1 = New System.Windows.Forms.Label()
        Me.lblSeat2 = New System.Windows.Forms.Label()
        Me.lblSeat3 = New System.Windows.Forms.Label()
        Me.lblSeat4 = New System.Windows.Forms.Label()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnWait = New System.Windows.Forms.Button()
        Me.txtWaiting = New System.Windows.Forms.TextBox()
        Me.lstWait = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnChart
        '
        Me.btnChart.Location = New System.Drawing.Point(87, 17)
        Me.btnChart.Name = "btnChart"
        Me.btnChart.Size = New System.Drawing.Size(75, 53)
        Me.btnChart.TabIndex = 0
        Me.btnChart.Text = "Display seating chart"
        Me.btnChart.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(87, 369)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 40)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(159, 235)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 40)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "Remove passenger"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lstChart
        '
        Me.lstChart.Font = New System.Drawing.Font("Courier New", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstChart.FormattingEnabled = True
        Me.lstChart.ItemHeight = 36
        Me.lstChart.Location = New System.Drawing.Point(304, 31)
        Me.lstChart.Name = "lstChart"
        Me.lstChart.Size = New System.Drawing.Size(253, 364)
        Me.lstChart.TabIndex = 3
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(149, 159)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 4
        '
        'txtRemove
        '
        Me.txtRemove.Location = New System.Drawing.Point(147, 294)
        Me.txtRemove.Name = "txtRemove"
        Me.txtRemove.Size = New System.Drawing.Size(100, 20)
        Me.txtRemove.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(155, 102)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 40)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add passenger to seating chart"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblRow
        '
        Me.lblRow.AutoSize = True
        Me.lblRow.Location = New System.Drawing.Point(20, 132)
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(32, 13)
        Me.lblRow.TabIndex = 7
        Me.lblRow.Text = "Row:"
        '
        'lblSeat
        '
        Me.lblSeat.AutoSize = True
        Me.lblSeat.Location = New System.Drawing.Point(20, 168)
        Me.lblSeat.Name = "lblSeat"
        Me.lblSeat.Size = New System.Drawing.Size(32, 13)
        Me.lblSeat.TabIndex = 8
        Me.lblSeat.Text = "Seat:"
        '
        'txtRow
        '
        Me.txtRow.Location = New System.Drawing.Point(59, 128)
        Me.txtRow.Name = "txtRow"
        Me.txtRow.Size = New System.Drawing.Size(36, 20)
        Me.txtRow.TabIndex = 9
        '
        'txtSeat
        '
        Me.txtSeat.Location = New System.Drawing.Point(59, 164)
        Me.txtSeat.Name = "txtSeat"
        Me.txtSeat.Size = New System.Drawing.Size(36, 20)
        Me.txtSeat.TabIndex = 10
        '
        'lblSeat1
        '
        Me.lblSeat1.AutoSize = True
        Me.lblSeat1.Location = New System.Drawing.Point(325, 12)
        Me.lblSeat1.Name = "lblSeat1"
        Me.lblSeat1.Size = New System.Drawing.Size(38, 13)
        Me.lblSeat1.TabIndex = 11
        Me.lblSeat1.Text = "Seat 1"
        '
        'lblSeat2
        '
        Me.lblSeat2.AutoSize = True
        Me.lblSeat2.Location = New System.Drawing.Point(384, 12)
        Me.lblSeat2.Name = "lblSeat2"
        Me.lblSeat2.Size = New System.Drawing.Size(38, 13)
        Me.lblSeat2.TabIndex = 12
        Me.lblSeat2.Text = "Seat 2"
        '
        'lblSeat3
        '
        Me.lblSeat3.AutoSize = True
        Me.lblSeat3.Location = New System.Drawing.Point(441, 12)
        Me.lblSeat3.Name = "lblSeat3"
        Me.lblSeat3.Size = New System.Drawing.Size(38, 13)
        Me.lblSeat3.TabIndex = 13
        Me.lblSeat3.Text = "Seat 3"
        '
        'lblSeat4
        '
        Me.lblSeat4.AutoSize = True
        Me.lblSeat4.Location = New System.Drawing.Point(499, 12)
        Me.lblSeat4.Name = "lblSeat4"
        Me.lblSeat4.Size = New System.Drawing.Size(38, 13)
        Me.lblSeat4.TabIndex = 14
        Me.lblSeat4.Text = "Seat 4"
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.Location = New System.Drawing.Point(12, 99)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(122, 13)
        Me.lblChoose.TabIndex = 15
        Me.lblChoose.Text = "Choose a row and seat: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(257, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Row 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Row 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(257, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Row 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Row 4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Row 5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(257, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Row 6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(257, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Row 7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(257, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Row 8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(257, 332)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Row 9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(251, 367)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Row 10"
        '
        'btnWait
        '
        Me.btnWait.Location = New System.Drawing.Point(17, 236)
        Me.btnWait.Name = "btnWait"
        Me.btnWait.Size = New System.Drawing.Size(88, 40)
        Me.btnWait.TabIndex = 26
        Me.btnWait.Text = "Add passenger to waiting list"
        Me.btnWait.UseVisualStyleBackColor = True
        '
        'txtWaiting
        '
        Me.txtWaiting.Location = New System.Drawing.Point(10, 293)
        Me.txtWaiting.Name = "txtWaiting"
        Me.txtWaiting.Size = New System.Drawing.Size(100, 20)
        Me.txtWaiting.TabIndex = 27
        '
        'lstWait
        '
        Me.lstWait.FormattingEnabled = True
        Me.lstWait.Location = New System.Drawing.Point(563, 31)
        Me.lstWait.Name = "lstWait"
        Me.lstWait.Size = New System.Drawing.Size(96, 355)
        Me.lstWait.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(-3, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(247, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "________________________________________"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(-3, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(247, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "________________________________________"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(-4, 331)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(247, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "________________________________________"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 469)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lstWait)
        Me.Controls.Add(Me.txtWaiting)
        Me.Controls.Add(Me.btnWait)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblChoose)
        Me.Controls.Add(Me.lblSeat4)
        Me.Controls.Add(Me.lblSeat3)
        Me.Controls.Add(Me.lblSeat2)
        Me.Controls.Add(Me.lblSeat1)
        Me.Controls.Add(Me.txtSeat)
        Me.Controls.Add(Me.txtRow)
        Me.Controls.Add(Me.lblSeat)
        Me.Controls.Add(Me.lblRow)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtRemove)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lstChart)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnChart)
        Me.Name = "Form1"
        Me.Text = "Airline Reservations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChart As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lstChart As System.Windows.Forms.ListBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtRemove As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblRow As System.Windows.Forms.Label
    Friend WithEvents lblSeat As System.Windows.Forms.Label
    Friend WithEvents txtRow As System.Windows.Forms.TextBox
    Friend WithEvents txtSeat As System.Windows.Forms.TextBox
    Friend WithEvents lblSeat1 As System.Windows.Forms.Label
    Friend WithEvents lblSeat2 As System.Windows.Forms.Label
    Friend WithEvents lblSeat3 As System.Windows.Forms.Label
    Friend WithEvents lblSeat4 As System.Windows.Forms.Label
    Friend WithEvents lblChoose As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnWait As System.Windows.Forms.Button
    Friend WithEvents txtWaiting As System.Windows.Forms.TextBox
    Friend WithEvents lstWait As System.Windows.Forms.ListBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label

End Class
