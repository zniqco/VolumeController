
namespace VolumeController
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VolumePanel = new System.Windows.Forms.Panel();
            this.GaugePanel = new System.Windows.Forms.Panel();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.ControllerPanel = new System.Windows.Forms.Panel();
            this.DraggingPanel = new System.Windows.Forms.Panel();
            this.VolumePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // VolumePanel
            // 
            this.VolumePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VolumePanel.Controls.Add(this.DraggingPanel);
            this.VolumePanel.Controls.Add(this.ControllerPanel);
            this.VolumePanel.Controls.Add(this.GaugePanel);
            this.VolumePanel.Location = new System.Drawing.Point(15, 17);
            this.VolumePanel.Name = "VolumePanel";
            this.VolumePanel.Size = new System.Drawing.Size(425, 30);
            this.VolumePanel.TabIndex = 0;
            // 
            // GaugePanel
            // 
            this.GaugePanel.BackColor = System.Drawing.Color.Lime;
            this.GaugePanel.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.GaugePanel.Location = new System.Drawing.Point(0, 0);
            this.GaugePanel.Name = "GaugePanel";
            this.GaugePanel.Size = new System.Drawing.Size(20, 28);
            this.GaugePanel.TabIndex = 1;
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 20;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.VolumeLabel.Location = new System.Drawing.Point(12, 60);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(119, 21);
            this.VolumeLabel.TabIndex = 1;
            this.VolumeLabel.Text = "Volume: 50";
            // 
            // ControllerPanel
            // 
            this.ControllerPanel.BackColor = System.Drawing.Color.Gray;
            this.ControllerPanel.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.ControllerPanel.Location = new System.Drawing.Point(96, 0);
            this.ControllerPanel.Name = "ControllerPanel";
            this.ControllerPanel.Size = new System.Drawing.Size(6, 28);
            this.ControllerPanel.TabIndex = 0;
            this.ControllerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControllerPanel_MouseDown);
            this.ControllerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControllerPanel_MouseMove);
            this.ControllerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControllerPanel_MouseUp);
            // 
            // DraggingPanel
            // 
            this.DraggingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DraggingPanel.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.DraggingPanel.Location = new System.Drawing.Point(209, 0);
            this.DraggingPanel.Name = "DraggingPanel";
            this.DraggingPanel.Size = new System.Drawing.Size(6, 28);
            this.DraggingPanel.TabIndex = 2;
            this.DraggingPanel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 95);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.VolumePanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VolumeController";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.VolumePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel VolumePanel;
        private System.Windows.Forms.Panel GaugePanel;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Panel DraggingPanel;
        private System.Windows.Forms.Panel ControllerPanel;
    }
}

