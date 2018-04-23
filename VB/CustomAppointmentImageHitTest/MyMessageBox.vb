Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace CustomAppointmentImageHitTest
    Partial Public Class MyMessageBox
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
        Public Sub New(ByVal img As Image, ByVal s As String)
            InitializeComponent()
            Me.pictureBox1.Image = img
            Me.Text = s
        End Sub
    End Class
End Namespace
