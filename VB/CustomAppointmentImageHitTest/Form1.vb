Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms

Namespace CustomAppointmentImageHitTest
    Partial Public Class Form1
        Inherits Form

        Public ImagePath As String = Application.ExecutablePath & "\Images"

        Public Sub New()
            InitializeComponent()
            Me.dateNavigator1.CellPadding = New System.Windows.Forms.Padding(2)

            'this.schedulerStorage1.Resources.ColorSaving = ColorSavingType.Color;
            AddHandler schedulerControl1.InitAppointmentDisplayText, AddressOf schedulerControl1_InitAppointmentDisplayText
            AddHandler schedulerControl1.InitAppointmentImages, AddressOf schedulerControl1_InitAppointmentImages
            AddHandler schedulerControl1.MouseUp, AddressOf schedulerControl1_MouseUp
        End Sub

        #Region "#SchedulerMouseUp"
        Private Sub schedulerControl1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button = System.Windows.Forms.MouseButtons.Left Then
                Dim viewInfo As SchedulerViewInfoBase = schedulerControl1.ActiveView.ViewInfo
                Dim hitInfo As SchedulerHitInfo = viewInfo.CalcHitInfo(e.Location, False)
                If hitInfo.HitTest = SchedulerHitTest.AppointmentContent Then
                    Dim info As AppointmentViewInfo = CType(hitInfo.ViewInfo, AppointmentViewInfo)
                    For Each item As ViewInfoItem In info.Items
                        Dim imageItemInfo As ViewInfoImageItem = TryCast(item, ViewInfoImageItem)
                        If imageItemInfo Is Nothing Then
                            Continue For
                        End If
                        Dim itemBounds As Rectangle = info.ConvertToVisualBounds(item.Bounds)
                        If itemBounds.Contains(e.Location) Then
                            Dim mb As New MyMessageBox(CType(item, ViewInfoImageItem).Image, "Got it!")
                            mb.ShowDialog()
                        End If
                    Next item
                End If
            End If
        End Sub
        #End Region ' #SchedulerMouseUp

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim helper As New InitHelper(Me.schedulerStorage1)

            schedulerStorage1.BeginUpdate()
            Try
                schedulerStorage1.Resources.DataSource = helper.InitResources()
                schedulerStorage1.Appointments.DataSource = helper.InitAppointments()
            Finally
                schedulerStorage1.EndUpdate()
            End Try

            schedulerControl1.Start = Date.Now.AddDays(-5)
            schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource

            schedulerControl1.TimelineView.Scales.Clear()
            schedulerControl1.TimelineView.Scales.Add(New TimeScaleDay())
            schedulerControl1.TimelineView.Scales.Add(New TimeScaleHour())

            schedulerControl1.TimelineView.AppointmentDisplayOptions.AppointmentAutoHeight = True

            schedulerControl1.ActiveViewType = SchedulerViewType.Day
        End Sub

        #Region "#initappointmentimages"
        Private Sub schedulerControl1_InitAppointmentImages(ByVal sender As Object, ByVal e As AppointmentImagesEventArgs)
            If e.Appointment.CustomFields("ApptImage1") IsNot Nothing Then
                Dim imageBytes() As Byte = CType(e.Appointment.CustomFields("ApptImage1"), Byte())
                If imageBytes IsNot Nothing Then
                    Dim info As New AppointmentImageInfo()
                    Using ms As New MemoryStream(imageBytes)
                        info.Image = Image.FromStream(ms)
                        info.Image.Tag = e.ImageInfoList.Add(info)
                    End Using
                End If
            End If

            If e.Appointment.CustomFields("ApptImage2") IsNot Nothing Then
                Dim imageBytes() As Byte = CType(e.Appointment.CustomFields("ApptImage2"), Byte())
                If imageBytes IsNot Nothing Then
                    Dim info As New AppointmentImageInfo()
                    Using ms As New MemoryStream(imageBytes)
                        info.Image = Image.FromStream(ms)
                        e.ImageInfoList.Add(info)
                    End Using
                End If
            End If
        End Sub
        #End Region ' #initappointmentimages

        #Region "#initappointmentdisplaytext"
        Private Sub schedulerControl1_InitAppointmentDisplayText(ByVal sender As Object, ByVal e As AppointmentDisplayTextEventArgs)
            ' Display custom text in Day and WorkWeek views only (VerticalAppointmentViewInfo).
            If TypeOf e.ViewInfo Is VerticalAppointmentViewInfo AndAlso e.Appointment.CustomFields("ApptAddInfo") IsNot Nothing Then
                e.Text = e.Appointment.Subject & ControlChars.CrLf
                e.Text &= "------" & ControlChars.CrLf
                e.Text += e.Appointment.CustomFields("ApptAddInfo").ToString()
            End If
        End Sub
        #End Region ' #initappointmentdisplaytext
    End Class
End Namespace
