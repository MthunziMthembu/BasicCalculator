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
        Label1 = New Label()
        txtNum1 = New TextBox()
        Label2 = New Label()
        txtNum2 = New TextBox()
        btnAdd = New Button()
        btnDivide = New Button()
        btnSubtract = New Button()
        btnMultiply = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(207, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 32)
        Label1.TabIndex = 0
        Label1.Text = "First Number"
        ' 
        ' txtNum1
        ' 
        txtNum1.Location = New Point(425, 55)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(150, 31)
        txtNum1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(179, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(205, 32)
        Label2.TabIndex = 2
        Label2.Text = "Second Number"
        ' 
        ' txtNum2
        ' 
        txtNum2.Location = New Point(425, 104)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(150, 31)
        txtNum2.TabIndex = 3
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Algerian", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(163, 195)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(168, 52)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDivide
        ' 
        btnDivide.Font = New Font("Modern No. 20", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDivide.Location = New Point(163, 304)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(156, 53)
        btnDivide.TabIndex = 5
        btnDivide.Text = "Divide"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' btnSubtract
        ' 
        btnSubtract.Font = New Font("Modern No. 20", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSubtract.Location = New Point(609, 195)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(156, 52)
        btnSubtract.TabIndex = 6
        btnSubtract.Text = "Subtract"
        btnSubtract.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMultiply.Location = New Point(609, 304)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(156, 65)
        btnMultiply.TabIndex = 7
        btnMultiply.Text = "Multiply"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(947, 450)
        Controls.Add(btnMultiply)
        Controls.Add(btnSubtract)
        Controls.Add(btnDivide)
        Controls.Add(btnAdd)
        Controls.Add(txtNum2)
        Controls.Add(Label2)
        Controls.Add(txtNum1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMultiply As Button

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim num2 As Integer
        Dim sum As Integer
        Dim num1 As Integer
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        sum = num1 + num2
        MessageBox.Show("The Answer is:" & sum)
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim sum As Integer
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        sum = num1 - num2
        MessageBox.Show("The answer is:" & sum)

    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim sum As Integer

        num1 = txtNum1.Text
        num2 = txtNum2.Text
        sum = num1 / num2
        MessageBox.Show("The answer is:" & sum)


    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim sum As Integer

        num1 = txtNum1.Text
        num2 = txtNum2.Text
        sum = num1 * num2
        MessageBox.Show("The answer is:" & sum)

    End Sub
End Class
