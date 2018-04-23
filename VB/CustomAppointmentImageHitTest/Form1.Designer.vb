Namespace CustomAppointmentImageHitTest
    Partial Public Class Form1
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
            Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.dateNavigator1)
            Me.layoutControl1.Controls.Add(Me.schedulerControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(700, 429, 803, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(628, 382)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' dateNavigator1
            ' 
            Me.dateNavigator1.Location = New System.Drawing.Point(406, 12)
            Me.dateNavigator1.Name = "dateNavigator1"
            Me.dateNavigator1.SchedulerControl = Me.schedulerControl1
            Me.dateNavigator1.Size = New System.Drawing.Size(210, 358)
            Me.dateNavigator1.TabIndex = 5
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline
            Me.schedulerControl1.Location = New System.Drawing.Point(12, 12)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.OptionsView.ResourceHeaders.RotateCaption = False
            Me.schedulerControl1.Size = New System.Drawing.Size(378, 358)
            Me.schedulerControl1.Start = New Date(2016, 2, 12, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 4
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.AppointmentDisplayOptions.ColumnPadding.Right = 0
            Me.schedulerControl1.Views.DayView.ShowAllAppointmentsAtTimeCells = True
            timeRuler1.AlwaysShowTopRowTime = True
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.DayView.VisibleTimeSnapMode = True
            Me.schedulerControl1.Views.FullWeekView.Enabled = True
            Me.schedulerControl1.Views.GanttView.Enabled = False
            Me.schedulerControl1.Views.MonthView.DateTimeScrollbarVisible = False
            Me.schedulerControl1.Views.WeekView.Enabled = False
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.splitterItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(628, 382)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.schedulerControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(104, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(382, 362)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.dateNavigator1
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(394, 0)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(54, 247)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(214, 362)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' splitterItem1
            ' 
            Me.splitterItem1.AllowHotTrack = True
            Me.splitterItem1.Location = New System.Drawing.Point(382, 0)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(12, 362)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(628, 382)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
        Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator
        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

