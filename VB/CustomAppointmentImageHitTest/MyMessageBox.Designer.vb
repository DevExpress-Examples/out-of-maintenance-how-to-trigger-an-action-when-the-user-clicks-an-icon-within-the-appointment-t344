Namespace CustomAppointmentImageHitTest
    Partial Public Class MyMessageBox
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.button1 = New System.Windows.Forms.Button()
            DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.Location = New System.Drawing.Point(42, 12)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(100, 50)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            ' 
            ' button1
            ' 
            Me.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.button1.Location = New System.Drawing.Point(55, 73)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 1
            Me.button1.Text = "OK"
            Me.button1.UseVisualStyleBackColor = True
            ' 
            ' MyMessageBox
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.button1
            Me.ClientSize = New System.Drawing.Size(185, 107)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.pictureBox1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "MyMessageBox"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "MyMessageBox"
            DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private button1 As System.Windows.Forms.Button
    End Class
End Namespace