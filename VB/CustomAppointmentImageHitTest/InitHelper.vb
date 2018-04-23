Imports DevExpress.XtraScheduler
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Text

Namespace CustomAppointmentImageHitTest
    Friend Class InitHelper
        Private Property Storage() As SchedulerStorage
        Public Shared RandomInstance As New Random()

        Private CustomResourceCollection As New List(Of CustomResource)()
        Private CustomEventList As New List(Of CustomAppointment)()

        Public Sub New(ByVal currentStorage As SchedulerStorage)
            Storage = currentStorage
        End Sub

        Public Function InitResources() As List(Of CustomResource)
        Dim mappings As ResourceMappingInfo = Me.Storage.Resources.Mappings
            mappings.Id = "ResID"
            mappings.Caption = "Name"
            mappings.Color = "ResColor"

            CustomResourceCollection.Add(CreateCustomResource(1, "Max Fowler", Color.PowderBlue))
            CustomResourceCollection.Add(CreateCustomResource(2, "Nancy Drewmore", Color.PaleVioletRed))
            CustomResourceCollection.Add(CreateCustomResource(3, "Pak Jang", Color.PeachPuff))

            Return CustomResourceCollection
        End Function

        Private Function CreateCustomResource(ByVal res_id As Integer, ByVal caption As String, ByVal resColor As Color) As CustomResource
            Dim cr As New CustomResource()
            cr.ResID = res_id
            cr.Name = caption
            cr.ResColor = resColor
            Return cr
        End Function

        Public Function InitAppointments() As List(Of CustomAppointment)
            Dim mappings As AppointmentMappingInfo = Me.Storage.Appointments.Mappings
            mappings.Start = "StartTime"
            mappings.End = "EndTime"
            mappings.Subject = "Subject"
            mappings.AllDay = "AllDay"
            mappings.Description = "Description"
            mappings.Label = "Label"
            mappings.Location = "Location"
            mappings.RecurrenceInfo = "RecurrenceInfo"
            mappings.ReminderInfo = "ReminderInfo"
            mappings.ResourceId = "OwnerId"
            mappings.Status = "Status"
            mappings.Type = "EventType"

            Me.Storage.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("ApptImage1", "Icon1", FieldValueType.Object))
            Me.Storage.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("ApptImage2", "Icon2", FieldValueType.Object))
            Me.Storage.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("ApptAddInfo", "AdditionalInfo", FieldValueType.String))

            GenerateEvents(CustomEventList, 3)

            Return CustomEventList
        End Function

        Private Sub GenerateEvents(ByVal eventList As List(Of CustomAppointment), ByVal count As Integer)

            For i As Integer = 0 To count - 1
                Dim c_Resource As CustomResource = CustomResourceCollection(i)
                Dim subjPrefix As String = c_Resource.Name & "'s "
                Dim currentAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()

                eventList.Add(CreateEvent(subjPrefix & "meeting", "The meeting will be held in the Conference Room", c_Resource.ResID, 2, 5, 14, currentAssembly.GetManifestResourceStream("Images.BOCustomer_16x16.png"), currentAssembly.GetManifestResourceStream("CustomAppointmentImageHitTest.Images.Project_32x32.png")))
                eventList.Add(CreateEvent(subjPrefix & "travel", "Book a hotel in advance", c_Resource.ResID, 3, 6, 10, currentAssembly.GetManifestResourceStream("Images.Country_16x16.png"), currentAssembly.GetManifestResourceStream("CustomAppointmentImageHitTest.Images.BOChangeHistory_32x32.png")))
                eventList.Add(CreateEvent(subjPrefix & "phone call", "Important phone call", c_Resource.ResID, 0, 4, 16, currentAssembly.GetManifestResourceStream("Images.BOContact_16x16.png"), currentAssembly.GetManifestResourceStream("CustomAppointmentImageHitTest.Images.EditTask_32x32.png")))
            Next i
        End Sub

        Private Function CreateEvent(ByVal subject As String, ByVal additionalInfo As String, ByVal resourceId As Object, ByVal status As Integer, ByVal label As Integer, ByVal sHour As Integer, ByVal icon1 As Stream, ByVal icon2 As Stream) As CustomAppointment
            Dim apt As New CustomAppointment()
            apt.Subject = subject
            apt.OwnerId = resourceId
            Dim rnd As Random = RandomInstance
            Dim rangeInMinutes As Integer = 60 * 24
            apt.StartTime = Date.Today + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes))
            apt.EndTime = apt.StartTime.Add(TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes \ 4)))
            apt.Status = status
            apt.Label = label

            Using ms As New MemoryStream()
                icon1.CopyTo(ms)
                apt.Icon1 = ms.ToArray()
            End Using
            Using ms As New MemoryStream()
                icon2.CopyTo(ms)
                apt.Icon2 = ms.ToArray()
            End Using

            apt.AdditionalInfo = additionalInfo
            Return apt
        End Function
    End Class
End Namespace
