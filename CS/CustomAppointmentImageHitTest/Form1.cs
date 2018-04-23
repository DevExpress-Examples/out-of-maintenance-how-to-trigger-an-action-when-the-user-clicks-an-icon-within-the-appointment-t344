using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CustomAppointmentImageHitTest {
    public partial class Form1 : Form {
        public string ImagePath = Application.ExecutablePath + "\\Images";

        public Form1() {
            InitializeComponent();
            this.dateNavigator1.CellPadding = new System.Windows.Forms.Padding(2);

            //this.schedulerStorage1.Resources.ColorSaving = ColorSavingType.Color;
            schedulerControl1.InitAppointmentDisplayText += schedulerControl1_InitAppointmentDisplayText;
            schedulerControl1.InitAppointmentImages += schedulerControl1_InitAppointmentImages;
            schedulerControl1.MouseUp += schedulerControl1_MouseUp;
        }
		
        #region #SchedulerMouseUp
        private void schedulerControl1_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == System.Windows.Forms.MouseButtons.Left) {
                SchedulerViewInfoBase viewInfo = schedulerControl1.ActiveView.ViewInfo;
                SchedulerHitInfo hitInfo = viewInfo.CalcHitInfo(e.Location, false);
                if (hitInfo.HitTest == SchedulerHitTest.AppointmentContent) {
                    AppointmentViewInfo info = (AppointmentViewInfo)hitInfo.ViewInfo;
                    foreach (ViewInfoItem item in info.Items) {
                        ViewInfoImageItem imageItemInfo = item as ViewInfoImageItem;
                        if (imageItemInfo == null)
                            continue;
                        Rectangle itemBounds = info.ConvertToVisualBounds(item.Bounds);
                        if (itemBounds.Contains(e.Location)) {
                            MyMessageBox mb = new MyMessageBox(((ViewInfoImageItem)item).Image, "Got it!");
                            mb.ShowDialog();
                        }
                    }
                }
            }
        }
        #endregion #SchedulerMouseUp
		
        private void Form1_Load(object sender, EventArgs e) {
            InitHelper helper = new InitHelper(this.schedulerStorage1);

            schedulerStorage1.BeginUpdate();
            try {
                schedulerStorage1.Resources.DataSource = helper.InitResources();
                schedulerStorage1.Appointments.DataSource = helper.InitAppointments();
            }
            finally {
                schedulerStorage1.EndUpdate();
            }

            schedulerControl1.Start = DateTime.Now.AddDays(-5);
            schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;

            schedulerControl1.TimelineView.Scales.Clear();
            schedulerControl1.TimelineView.Scales.Add(new TimeScaleDay());
            schedulerControl1.TimelineView.Scales.Add(new TimeScaleHour());

            schedulerControl1.TimelineView.AppointmentDisplayOptions.AppointmentAutoHeight = true;

            schedulerControl1.ActiveViewType = SchedulerViewType.Day;
        }

        #region #initappointmentimages
        private void schedulerControl1_InitAppointmentImages(object sender, AppointmentImagesEventArgs e) {
            if (e.Appointment.CustomFields["ApptImage1"] != null) {
                byte[] imageBytes = (byte[])e.Appointment.CustomFields["ApptImage1"];
                if (imageBytes != null) {
                    AppointmentImageInfo info = new AppointmentImageInfo();
                    using (MemoryStream ms = new MemoryStream(imageBytes)) {
                        info.Image = Image.FromStream(ms);
                        info.Image.Tag = 
                        e.ImageInfoList.Add(info);
                    }
                }
            }

            if (e.Appointment.CustomFields["ApptImage2"] != null) {
                byte[] imageBytes = (byte[])e.Appointment.CustomFields["ApptImage2"];
                if (imageBytes != null) {
                    AppointmentImageInfo info = new AppointmentImageInfo();
                    using (MemoryStream ms = new MemoryStream(imageBytes)) {
                        info.Image = Image.FromStream(ms);
                        e.ImageInfoList.Add(info);
                    }
                }
            }
        }
        #endregion #initappointmentimages

        #region #initappointmentdisplaytext
        private void schedulerControl1_InitAppointmentDisplayText(object sender, AppointmentDisplayTextEventArgs e) {
            // Display custom text in Day and WorkWeek views only (VerticalAppointmentViewInfo).
            if (e.ViewInfo is VerticalAppointmentViewInfo && e.Appointment.CustomFields["ApptAddInfo"] != null) {
                e.Text = e.Appointment.Subject + "\r\n";
                e.Text += "------\r\n";
                e.Text += e.Appointment.CustomFields["ApptAddInfo"].ToString();
            }
        }
        #endregion #initappointmentdisplaytext
    }
}
