<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnErsterLink = New System.Windows.Forms.Button()
        Me.tbNetzlaufwerk = New System.Windows.Forms.TextBox()
        Me.tbZweiterLink = New System.Windows.Forms.TextBox()
        Me.tbURL = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbErsterLink = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnErsterLink
        '
        Me.btnErsterLink.Location = New System.Drawing.Point(23, 72)
        Me.btnErsterLink.Name = "btnErsterLink"
        Me.btnErsterLink.Size = New System.Drawing.Size(387, 29)
        Me.btnErsterLink.TabIndex = 2
        Me.btnErsterLink.Text = "Link generieren und in Zwischenablage kopieren"
        Me.btnErsterLink.UseVisualStyleBackColor = True
        '
        'tbNetzlaufwerk
        '
        Me.tbNetzlaufwerk.Location = New System.Drawing.Point(216, 39)
        Me.tbNetzlaufwerk.Name = "tbNetzlaufwerk"
        Me.tbNetzlaufwerk.Size = New System.Drawing.Size(194, 27)
        Me.tbNetzlaufwerk.TabIndex = 1
        '
        'tbZweiterLink
        '
        Me.tbZweiterLink.AcceptsReturn = True
        Me.tbZweiterLink.Location = New System.Drawing.Point(23, 204)
        Me.tbZweiterLink.Multiline = True
        Me.tbZweiterLink.Name = "tbZweiterLink"
        Me.tbZweiterLink.Size = New System.Drawing.Size(722, 88)
        Me.tbZweiterLink.TabIndex = 6
        '
        'tbURL
        '
        Me.tbURL.AcceptsReturn = True
        Me.tbURL.Location = New System.Drawing.Point(23, 75)
        Me.tbURL.Multiline = True
        Me.tbURL.Name = "tbURL"
        Me.tbURL.Size = New System.Drawing.Size(722, 88)
        Me.tbURL.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(23, 169)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(387, 29)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Neuen Link generieren und in Zwischenablage kopieren"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Netzlaufwerkbezeichnung"
        '
        'tbErsterLink
        '
        Me.tbErsterLink.AcceptsReturn = True
        Me.tbErsterLink.Location = New System.Drawing.Point(23, 117)
        Me.tbErsterLink.Multiline = True
        Me.tbErsterLink.Name = "tbErsterLink"
        Me.tbErsterLink.Size = New System.Drawing.Size(722, 46)
        Me.tbErsterLink.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbErsterLink)
        Me.GroupBox1.Controls.Add(Me.btnErsterLink)
        Me.GroupBox1.Controls.Add(Me.tbNetzlaufwerk)
        Me.GroupBox1.Location = New System.Drawing.Point(89, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(836, 196)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1. Schritt           "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbURL)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.tbZweiterLink)
        Me.GroupBox2.Location = New System.Drawing.Point(89, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(836, 311)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "2. Schritt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(419, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Kopieren Sie ihre aktuelle URL Ihres Browsers in dieses Texfeld"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1019, 588)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Token erneuern"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnErsterLink As Button
    Friend WithEvents tbNetzlaufwerk As TextBox
    Friend WithEvents tbZweiterLink As TextBox
    Friend WithEvents tbURL As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbErsterLink As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
End Class
