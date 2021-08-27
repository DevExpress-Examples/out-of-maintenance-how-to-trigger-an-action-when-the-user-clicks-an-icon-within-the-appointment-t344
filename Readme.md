<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128636226/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T344966)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomAppointmentImageHitTest/Form1.cs) (VB: [Form1.vb](./VB/CustomAppointmentImageHitTest/Form1.vb))
<!-- default file list end -->
# How to trigger an action when the user clicks an icon within the appointment


This example illustrates how to handle the SchedulerControl's <strong>MouseUp</strong> event and use the <a href="http://help.devexpress.com/#WindowsForms/DevExpressXtraSchedulerDrawingSchedulerViewInfoBase_CalcHitInfotopic">SchedulerViewInfoBase.CalcHitInfo</a> method to determine the visual element being clicked.  If an appointment is hit, the method returns the <a href="http://help.devexpress.com/#WindowsForms/clsDevExpressXtraSchedulerDrawingAppointmentViewInfotopic">AppointmentViewInfo</a> object. To obtain the element under the mouse cursor, the <strong>AppointmentViewInfo.Items</strong> collection is analyzed. The coordinates provided by the <strong>Bounds</strong> property of a collection item are mapped to the coordinate system used in mouse events and subsequently compared with the cursor position.<br><br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-trigger-an-action-when-the-user-clicks-an-icon-within-the-appointment-t344966/15.1.3+/media/d2d5f8bf-d186-11e5-80bf-00155d62480c.png">

<br/>


