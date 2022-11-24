﻿namespace youtube_dl_gui;
using System.Windows.Forms;
using System.Threading;
public partial class ExitQueueHandler : Form {
    private readonly Thread AwaitTasksThread;
    public ExitQueueHandler() {
        this.AutoScaleDimensions = new(6F, 13F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new(100, 100);
        this.ControlBox = false;
        this.Font = new("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        this.FormBorderStyle = FormBorderStyle.None;
        this.Icon = Properties.Resources.ProgramIcon;
        this.MaximumSize = new(1, 1);
        this.Name = Program.ProgramGUID;
        this.Opacity = 0D;
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.Text = Program.ProgramGUID;
        this.WindowState = FormWindowState.Minimized;

        //Label l = new();
        //l.Text = "??";
        //this.Controls.Add(l);
        //l.Location = Point.Empty;

        AwaitTasksThread = new(() => {
            Log.Write("Awaiting for the rest of the download actions.");
            while (Program.RunningActions.Count > 0) {
                //l.Invoke(() => l.Text = $"{Program.RunningActions.Count} items.");
                Thread.Sleep(500);
            }

            Log.Write("Idle form no longer required.");
            this.Invoke(() => this.Dispose());
        }) {
            Name = "Awaiting actions"
        };

        this.Load += (s, e) => AwaitTasksThread.Start();
    }
    protected override void WndProc(ref Message m) {
        switch (m.Msg) {
            case CopyData.WM_COPYDATA: {
                Log.Write("Retrieved data");
                var Data = CopyData.GetParam<SentData>(m.LParam);
                string[] ReceivedArguments = Data.Argument.Split('|');
                if (ReceivedArguments.Length > 0) {
                    var RetrievedArguments = Arguments.RetrieveArguments(ReceivedArguments);
                    if (RetrievedArguments.Count > 0)
                        Program.CheckArgs(RetrievedArguments);
                }
                m.Result = IntPtr.Zero;
            } break;

            case CopyData.WM_SHOWFORM: {
                m.Result = IntPtr.Zero;
            } break;

            default: {
                base.WndProc(ref m);
            } break;
        }
    }
}