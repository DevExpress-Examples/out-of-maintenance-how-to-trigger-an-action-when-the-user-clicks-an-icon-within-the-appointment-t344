<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128636226/15.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T344966)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomAppointmentImageHitTest/Form1.cs) (VB: [Form1.vb](./VB/CustomAppointmentImageHitTest/Form1.vb))
<!-- default file list end -->
# How to trigger an action when the user clicks an icon within the appointment


This example illustrates how to handle the SchedulerControl's <strong>MouseUp</strong> event and use the <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraScheduler.Drawing.SchedulerViewInfoBase.CalcHitInfo(System.Drawing.Point-System.Boolean)">SchedulerViewInfoBase.CalcHitInfo</a> method to determine the visual element being clicked.  If an appointment is hit, the method returns the <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraScheduler.Drawing.AppointmentViewInfo">AppointmentViewInfo</a> object. To obtain the element under the mouse cursor, the <strong>AppointmentViewInfo.Items</strong> collection is analyzed. The coordinates provided by the <strong>Bounds</strong> property of a collection item are mapped to the coordinate system used in mouse events and subsequently compared with the cursor position.<br><br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-trigger-an-action-when-the-user-clicks-an-icon-within-the-appointment-t344966/15.2.7+/media/d2d5f8bf-d186-11e5-80bf-00155d62480c.png">


<h3>Description</h3>

Starting from the v2015 vol.2.7 the <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraScheduler.Drawing.AppointmentViewInfo.ConvertToVisualBounds(System.Drawing.Rectangle)">DevExpress.XtraScheduler.Drawing.AppointmentViewInfo.ConvertToVisualBounds</a>&nbsp;method is required to map coordinates obtained with the <strong>ViewInfoItem.Bounds</strong> property to the coordinate system used in mouse events.<br>The&nbsp;<strong>ViewInfoItem.Bounds</strong> property returns a rectangle whose Y coordinate is relative to the upper left corner of the Scheduler view and independent of the scroll position. The&nbsp;<strong>ConvertToVisualBounds</strong>&nbsp;method calculates the coordinate relative to the upper-left corner of the visible area of the Scheduler view which may change with vertical scrolling.

<br/>


