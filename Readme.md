# How to trigger an action when the user clicks an icon within the appointment


This example illustrates how to handle the SchedulerControl's <strong>MouseUp</strong> event and use the <a href="http://help.devexpress.com/#WindowsForms/DevExpressXtraSchedulerDrawingSchedulerViewInfoBase_CalcHitInfotopic">SchedulerViewInfoBase.CalcHitInfo</a> method to determine the visual element being clicked.  If an appointment is hit, the method returns the <a href="http://help.devexpress.com/#WindowsForms/clsDevExpressXtraSchedulerDrawingAppointmentViewInfotopic">AppointmentViewInfo</a> object. To obtain the element under the mouse cursor, the <strong>AppointmentViewInfo.Items</strong> collection is analyzed. The coordinates provided by the <strong>Bounds</strong> property of a collection item are mapped to the coordinate system used in mouse events and subsequently compared with the cursor position.<br><br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-trigger-an-action-when-the-user-clicks-an-icon-within-the-appointment-t344966/15.2.7+/media/d2d5f8bf-d186-11e5-80bf-00155d62480c.png">


<h3>Description</h3>

Starting from the v2015 vol.2.7 the <a href="http://help.devexpress.com/#WindowsForms/DevExpressXtraSchedulerDrawingAppointmentViewInfo_ConvertToVisualBoundstopic">DevExpress.XtraScheduler.Drawing.AppointmentViewInfo.ConvertToVisualBounds</a>&nbsp;method is required to map coordinates obtained with the <strong>ViewInfoItem.Bounds</strong> property to the coordinate system used in mouse events.<br>The&nbsp;<strong>ViewInfoItem.Bounds</strong> property returns a rectangle whose Y coordinate is relative to the upper left corner of the Scheduler view and independent of the scroll position. The&nbsp;<strong>ConvertToVisualBounds</strong>&nbsp;method calculates the coordinate relative to the upper-left corner of the visible area of the Scheduler view which may change with vertical scrolling.

<br/>


