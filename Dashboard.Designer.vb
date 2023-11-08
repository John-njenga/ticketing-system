<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnManPass = New System.Windows.Forms.Button()
        Me.btnNewJou = New System.Windows.Forms.Button()
        Me.btnViewJou = New System.Windows.Forms.Button()
        Me.btnRegBus = New System.Windows.Forms.Button()
        Me.btnBusRep = New System.Windows.Forms.Button()
        Me.btnBookTicket = New System.Windows.Forms.Button()
        Me.btnCanTicket = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(159, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Register Passenger"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnManPass
        '
        Me.btnManPass.Location = New System.Drawing.Point(294, 275)
        Me.btnManPass.Name = "btnManPass"
        Me.btnManPass.Size = New System.Drawing.Size(129, 40)
        Me.btnManPass.TabIndex = 1
        Me.btnManPass.Text = "Manage Passengers"
        Me.btnManPass.UseVisualStyleBackColor = True
        '
        'btnNewJou
        '
        Me.btnNewJou.Location = New System.Drawing.Point(429, 275)
        Me.btnNewJou.Name = "btnNewJou"
        Me.btnNewJou.Size = New System.Drawing.Size(129, 40)
        Me.btnNewJou.TabIndex = 2
        Me.btnNewJou.Text = "Add New Journey"
        Me.btnNewJou.UseVisualStyleBackColor = True
        '
        'btnViewJou
        '
        Me.btnViewJou.Location = New System.Drawing.Point(564, 275)
        Me.btnViewJou.Name = "btnViewJou"
        Me.btnViewJou.Size = New System.Drawing.Size(129, 40)
        Me.btnViewJou.TabIndex = 3
        Me.btnViewJou.Text = "View Journeys"
        Me.btnViewJou.UseVisualStyleBackColor = True
        '
        'btnRegBus
        '
        Me.btnRegBus.Location = New System.Drawing.Point(159, 229)
        Me.btnRegBus.Name = "btnRegBus"
        Me.btnRegBus.Size = New System.Drawing.Size(129, 40)
        Me.btnRegBus.TabIndex = 4
        Me.btnRegBus.Text = "Register Bus"
        Me.btnRegBus.UseVisualStyleBackColor = True
        '
        'btnBusRep
        '
        Me.btnBusRep.Location = New System.Drawing.Point(294, 229)
        Me.btnBusRep.Name = "btnBusRep"
        Me.btnBusRep.Size = New System.Drawing.Size(129, 40)
        Me.btnBusRep.TabIndex = 5
        Me.btnBusRep.Text = "Bus Reports"
        Me.btnBusRep.UseVisualStyleBackColor = True
        '
        'btnBookTicket
        '
        Me.btnBookTicket.Location = New System.Drawing.Point(429, 229)
        Me.btnBookTicket.Name = "btnBookTicket"
        Me.btnBookTicket.Size = New System.Drawing.Size(129, 40)
        Me.btnBookTicket.TabIndex = 6
        Me.btnBookTicket.Text = "Book Ticket"
        Me.btnBookTicket.UseVisualStyleBackColor = True
        '
        'btnCanTicket
        '
        Me.btnCanTicket.Location = New System.Drawing.Point(564, 229)
        Me.btnCanTicket.Name = "btnCanTicket"
        Me.btnCanTicket.Size = New System.Drawing.Size(129, 40)
        Me.btnCanTicket.TabIndex = 7
        Me.btnCanTicket.Text = "Cancel Ticket"
        Me.btnCanTicket.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Logged in :-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Admin"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCanTicket)
        Me.Controls.Add(Me.btnBookTicket)
        Me.Controls.Add(Me.btnBusRep)
        Me.Controls.Add(Me.btnRegBus)
        Me.Controls.Add(Me.btnViewJou)
        Me.Controls.Add(Me.btnNewJou)
        Me.Controls.Add(Me.btnManPass)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnManPass As Button
    Friend WithEvents btnNewJou As Button
    Friend WithEvents btnViewJou As Button
    Friend WithEvents btnRegBus As Button
    Friend WithEvents btnBusRep As Button
    Friend WithEvents btnBookTicket As Button
    Friend WithEvents btnCanTicket As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
