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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        chkSmall = New CheckBox()
        chkMedium = New CheckBox()
        chkLarge = New CheckBox()
        chkCreamy = New CheckBox()
        chkChunky = New CheckBox()
        chkUnsalted = New CheckBox()
        btnSubmit = New Button()
        numQuantity = New NumericUpDown()
        listTransactions = New ListBox()
        txtAmountGiven = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        CType(numQuantity, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' chkSmall
        ' 
        chkSmall.AutoSize = True
        chkSmall.BackColor = Color.IndianRed
        chkSmall.Location = New Point(46, 130)
        chkSmall.Name = "chkSmall"
        chkSmall.Size = New Size(85, 19)
        chkSmall.TabIndex = 0
        chkSmall.Text = "Small (₱75)"
        chkSmall.UseVisualStyleBackColor = False
        ' 
        ' chkMedium
        ' 
        chkMedium.AutoSize = True
        chkMedium.BackColor = Color.IndianRed
        chkMedium.Location = New Point(46, 165)
        chkMedium.Name = "chkMedium"
        chkMedium.Size = New Size(107, 19)
        chkMedium.TabIndex = 1
        chkMedium.Text = "Medium (₱150)"
        chkMedium.UseVisualStyleBackColor = False
        ' 
        ' chkLarge
        ' 
        chkLarge.AutoSize = True
        chkLarge.BackColor = Color.IndianRed
        chkLarge.Location = New Point(46, 200)
        chkLarge.Name = "chkLarge"
        chkLarge.Size = New Size(91, 19)
        chkLarge.TabIndex = 2
        chkLarge.Text = "Large (₱200)"
        chkLarge.UseVisualStyleBackColor = False
        ' 
        ' chkCreamy
        ' 
        chkCreamy.AutoSize = True
        chkCreamy.BackColor = Color.IndianRed
        chkCreamy.Location = New Point(172, 130)
        chkCreamy.Name = "chkCreamy"
        chkCreamy.Size = New Size(91, 19)
        chkCreamy.TabIndex = 3
        chkCreamy.Text = "Creamy (₱5)"
        chkCreamy.UseVisualStyleBackColor = False
        ' 
        ' chkChunky
        ' 
        chkChunky.AutoSize = True
        chkChunky.BackColor = Color.IndianRed
        chkChunky.Location = New Point(172, 165)
        chkChunky.Name = "chkChunky"
        chkChunky.Size = New Size(97, 19)
        chkChunky.TabIndex = 4
        chkChunky.Text = "Chunky (₱10)"
        chkChunky.UseVisualStyleBackColor = False
        ' 
        ' chkUnsalted
        ' 
        chkUnsalted.AutoSize = True
        chkUnsalted.BackColor = Color.IndianRed
        chkUnsalted.Location = New Point(172, 200)
        chkUnsalted.Name = "chkUnsalted"
        chkUnsalted.Size = New Size(96, 19)
        chkUnsalted.TabIndex = 5
        chkUnsalted.Text = "Unsalted (₱5)"
        chkUnsalted.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.IndianRed
        btnSubmit.Location = New Point(172, 321)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(104, 38)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "SUBMIT ORDER"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' numQuantity
        ' 
        numQuantity.BackColor = Color.IndianRed
        numQuantity.Location = New Point(312, 128)
        numQuantity.Name = "numQuantity"
        numQuantity.Size = New Size(97, 23)
        numQuantity.TabIndex = 7
        ' 
        ' listTransactions
        ' 
        listTransactions.BackColor = Color.IndianRed
        listTransactions.FormattingEnabled = True
        listTransactions.ItemHeight = 15
        listTransactions.Location = New Point(12, 237)
        listTransactions.Name = "listTransactions"
        listTransactions.Size = New Size(427, 64)
        listTransactions.TabIndex = 8
        ' 
        ' txtAmountGiven
        ' 
        txtAmountGiven.BackColor = Color.IndianRed
        txtAmountGiven.Location = New Point(309, 184)
        txtAmountGiven.Name = "txtAmountGiven"
        txtAmountGiven.Size = New Size(100, 23)
        txtAmountGiven.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.IndianRed
        Label1.Location = New Point(327, 156)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 15)
        Label1.TabIndex = 10
        Label1.Text = "Quantity"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.IndianRed
        Label2.Location = New Point(325, 210)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 11
        Label2.Text = "Amount Given"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(451, 386)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtAmountGiven)
        Controls.Add(listTransactions)
        Controls.Add(numQuantity)
        Controls.Add(btnSubmit)
        Controls.Add(chkUnsalted)
        Controls.Add(chkChunky)
        Controls.Add(chkCreamy)
        Controls.Add(chkLarge)
        Controls.Add(chkMedium)
        Controls.Add(chkSmall)
        Name = "Form1"
        Text = "Form1"
        CType(numQuantity, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents chkSmall As CheckBox
    Friend WithEvents chkMedium As CheckBox
    Friend WithEvents chkLarge As CheckBox
    Friend WithEvents chkCreamy As CheckBox
    Friend WithEvents chkChunky As CheckBox
    Friend WithEvents chkUnsalted As CheckBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents listTransactions As ListBox
    Friend WithEvents txtAmountGiven As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
