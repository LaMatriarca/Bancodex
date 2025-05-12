<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Button1 = New Button()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        ImageList1 = New ImageList(components)
        LinkLabel1 = New LinkLabel()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(219, 95)
        Button1.Name = "Button1"
        Button1.Size = New Size(339, 208)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(92, 348)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 1
        Label2.Text = "Label2"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(169, 248)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 125)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(618, 337)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(79, 20)
        LinkLabel1.TabIndex = 3
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "LinkLabel1"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(583, 52)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 4
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(LinkLabel1)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button2 As Button

End Class
