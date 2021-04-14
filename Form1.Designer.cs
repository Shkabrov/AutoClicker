
namespace AutoClicker
{
    partial class AutoClicker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClicker));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MinButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.buttonInfinityClick = new System.Windows.Forms.Button();
            this.ClickOptions = new System.Windows.Forms.Label();
            this.groupBoxDcOc = new System.Windows.Forms.GroupBox();
            this.buttonDouble = new System.Windows.Forms.RadioButton();
            this.buttonOne = new System.Windows.Forms.RadioButton();
            this.groupBoxLeftRight = new System.Windows.Forms.GroupBox();
            this.buttonRight = new System.Windows.Forms.RadioButton();
            this.buttonLeft = new System.Windows.Forms.RadioButton();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxForY = new System.Windows.Forms.TextBox();
            this.textBoxForX = new System.Windows.Forms.TextBox();
            this.buttonPickLocation = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelMilSecs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxForSecs = new System.Windows.Forms.TextBox();
            this.labelSecs = new System.Windows.Forms.Label();
            this.textBoxForMilSecs = new System.Windows.Forms.TextBox();
            this.ClickInterval = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.groupBoxDcOc.SuspendLayout();
            this.groupBoxLeftRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.MinButton);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.Title);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(300, 30);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // MinButton
            // 
            this.MinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinButton.Image = ((System.Drawing.Image)(resources.GetObject("MinButton.Image")));
            this.MinButton.Location = new System.Drawing.Point(241, 2);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(25, 25);
            this.MinButton.TabIndex = 2;
            this.MinButton.TabStop = false;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(272, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(5, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(106, 20);
            this.Title.TabIndex = 0;
            this.Title.Text = "AutoClicker";
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.buttonInfinityClick);
            this.MainPanel.Controls.Add(this.ClickOptions);
            this.MainPanel.Controls.Add(this.groupBoxDcOc);
            this.MainPanel.Controls.Add(this.groupBoxLeftRight);
            this.MainPanel.Controls.Add(this.labelY);
            this.MainPanel.Controls.Add(this.labelX);
            this.MainPanel.Controls.Add(this.textBoxForY);
            this.MainPanel.Controls.Add(this.textBoxForX);
            this.MainPanel.Controls.Add(this.buttonPickLocation);
            this.MainPanel.Controls.Add(this.buttonStop);
            this.MainPanel.Controls.Add(this.buttonStart);
            this.MainPanel.Controls.Add(this.labelMilSecs);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.textBoxForSecs);
            this.MainPanel.Controls.Add(this.labelSecs);
            this.MainPanel.Controls.Add(this.textBoxForMilSecs);
            this.MainPanel.Controls.Add(this.ClickInterval);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(300, 300);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // buttonInfinityClick
            // 
            this.buttonInfinityClick.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInfinityClick.Location = new System.Drawing.Point(83, 265);
            this.buttonInfinityClick.Name = "buttonInfinityClick";
            this.buttonInfinityClick.Size = new System.Drawing.Size(135, 30);
            this.buttonInfinityClick.TabIndex = 16;
            this.buttonInfinityClick.Text = "Inf Click (F9)";
            this.buttonInfinityClick.UseVisualStyleBackColor = true;
            this.buttonInfinityClick.Click += new System.EventHandler(this.buttonInfinityClick_Click);
            // 
            // ClickOptions
            // 
            this.ClickOptions.AutoSize = true;
            this.ClickOptions.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClickOptions.Location = new System.Drawing.Point(0, 90);
            this.ClickOptions.Name = "ClickOptions";
            this.ClickOptions.Size = new System.Drawing.Size(205, 45);
            this.ClickOptions.TabIndex = 1;
            this.ClickOptions.Text = "Click options";
            // 
            // groupBoxDcOc
            // 
            this.groupBoxDcOc.Controls.Add(this.buttonDouble);
            this.groupBoxDcOc.Controls.Add(this.buttonOne);
            this.groupBoxDcOc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxDcOc.Location = new System.Drawing.Point(153, 129);
            this.groupBoxDcOc.Name = "groupBoxDcOc";
            this.groupBoxDcOc.Size = new System.Drawing.Size(135, 40);
            this.groupBoxDcOc.TabIndex = 15;
            this.groupBoxDcOc.TabStop = false;
            // 
            // buttonDouble
            // 
            this.buttonDouble.AutoSize = true;
            this.buttonDouble.Location = new System.Drawing.Point(55, 12);
            this.buttonDouble.Name = "buttonDouble";
            this.buttonDouble.Size = new System.Drawing.Size(79, 24);
            this.buttonDouble.TabIndex = 3;
            this.buttonDouble.Text = "Double";
            this.buttonDouble.UseVisualStyleBackColor = true;
            // 
            // buttonOne
            // 
            this.buttonOne.AutoSize = true;
            this.buttonOne.Checked = true;
            this.buttonOne.Location = new System.Drawing.Point(2, 12);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(57, 24);
            this.buttonOne.TabIndex = 2;
            this.buttonOne.TabStop = true;
            this.buttonOne.Text = "One";
            this.buttonOne.UseVisualStyleBackColor = true;
            // 
            // groupBoxLeftRight
            // 
            this.groupBoxLeftRight.Controls.Add(this.buttonRight);
            this.groupBoxLeftRight.Controls.Add(this.buttonLeft);
            this.groupBoxLeftRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxLeftRight.Location = new System.Drawing.Point(12, 129);
            this.groupBoxLeftRight.Name = "groupBoxLeftRight";
            this.groupBoxLeftRight.Size = new System.Drawing.Size(135, 40);
            this.groupBoxLeftRight.TabIndex = 14;
            this.groupBoxLeftRight.TabStop = false;
            // 
            // buttonRight
            // 
            this.buttonRight.AutoSize = true;
            this.buttonRight.Location = new System.Drawing.Point(68, 13);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(65, 24);
            this.buttonRight.TabIndex = 1;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            // 
            // buttonLeft
            // 
            this.buttonLeft.AutoSize = true;
            this.buttonLeft.Checked = true;
            this.buttonLeft.Location = new System.Drawing.Point(3, 13);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(55, 24);
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.TabStop = true;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelY.Location = new System.Drawing.Point(104, 165);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(23, 28);
            this.labelY.TabIndex = 13;
            this.labelY.Text = "Y";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX.Location = new System.Drawing.Point(33, 165);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(24, 28);
            this.labelX.TabIndex = 12;
            this.labelX.Text = "X";
            // 
            // textBoxForY
            // 
            this.textBoxForY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxForY.Location = new System.Drawing.Point(83, 193);
            this.textBoxForY.MaxLength = 2;
            this.textBoxForY.Name = "textBoxForY";
            this.textBoxForY.ReadOnly = true;
            this.textBoxForY.Size = new System.Drawing.Size(64, 30);
            this.textBoxForY.TabIndex = 11;
            this.textBoxForY.Text = "0";
            this.textBoxForY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxForX
            // 
            this.textBoxForX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxForX.Location = new System.Drawing.Point(12, 193);
            this.textBoxForX.MaxLength = 2;
            this.textBoxForX.Name = "textBoxForX";
            this.textBoxForX.ReadOnly = true;
            this.textBoxForX.Size = new System.Drawing.Size(64, 30);
            this.textBoxForX.TabIndex = 10;
            this.textBoxForX.Text = "0";
            this.textBoxForX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPickLocation
            // 
            this.buttonPickLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPickLocation.Location = new System.Drawing.Point(153, 193);
            this.buttonPickLocation.Name = "buttonPickLocation";
            this.buttonPickLocation.Size = new System.Drawing.Size(135, 30);
            this.buttonPickLocation.TabIndex = 9;
            this.buttonPickLocation.Text = "Pick location (F4)";
            this.buttonPickLocation.UseVisualStyleBackColor = true;
            this.buttonPickLocation.Click += new System.EventHandler(this.buttonPickLocation_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStop.Location = new System.Drawing.Point(153, 229);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(135, 30);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Stop (F10)";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Location = new System.Drawing.Point(12, 229);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(135, 30);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start (F2)";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelMilSecs
            // 
            this.labelMilSecs.AutoSize = true;
            this.labelMilSecs.Location = new System.Drawing.Point(243, 62);
            this.labelMilSecs.Name = "labelMilSecs";
            this.labelMilSecs.Size = new System.Drawing.Size(51, 20);
            this.labelMilSecs.TabIndex = 6;
            this.labelMilSecs.Text = "mSecs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mins";
            // 
            // textBoxForSecs
            // 
            this.textBoxForSecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxForSecs.Location = new System.Drawing.Point(11, 49);
            this.textBoxForSecs.MaxLength = 3;
            this.textBoxForSecs.Name = "textBoxForSecs";
            this.textBoxForSecs.Size = new System.Drawing.Size(88, 38);
            this.textBoxForSecs.TabIndex = 4;
            this.textBoxForSecs.Text = "0";
            this.textBoxForSecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxForSecs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxForSecs_KeyPress);
            // 
            // labelSecs
            // 
            this.labelSecs.AutoSize = true;
            this.labelSecs.Location = new System.Drawing.Point(105, 62);
            this.labelSecs.Name = "labelSecs";
            this.labelSecs.Size = new System.Drawing.Size(38, 20);
            this.labelSecs.TabIndex = 3;
            this.labelSecs.Text = "Secs";
            // 
            // textBoxForMilSecs
            // 
            this.textBoxForMilSecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxForMilSecs.Location = new System.Drawing.Point(149, 49);
            this.textBoxForMilSecs.MaxLength = 3;
            this.textBoxForMilSecs.Name = "textBoxForMilSecs";
            this.textBoxForMilSecs.Size = new System.Drawing.Size(88, 38);
            this.textBoxForMilSecs.TabIndex = 2;
            this.textBoxForMilSecs.Text = "40";
            this.textBoxForMilSecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxForMilSecs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxForMilSecs_KeyPress);
            // 
            // ClickInterval
            // 
            this.ClickInterval.AutoSize = true;
            this.ClickInterval.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClickInterval.Location = new System.Drawing.Point(0, 0);
            this.ClickInterval.Name = "ClickInterval";
            this.ClickInterval.Size = new System.Drawing.Size(203, 45);
            this.ClickInterval.TabIndex = 0;
            this.ClickInterval.Text = "Click interval";
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 330);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutoClicker";
            this.Text = "AutoClicker";
            this.Load += new System.EventHandler(this.AutoClicker_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.groupBoxDcOc.ResumeLayout(false);
            this.groupBoxDcOc.PerformLayout();
            this.groupBoxLeftRight.ResumeLayout(false);
            this.groupBoxLeftRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox MinButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label ClickInterval;
        private System.Windows.Forms.Label ClickOptions;
        private System.Windows.Forms.Label labelMilSecs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxForSecs;
        private System.Windows.Forms.Label labelSecs;
        private System.Windows.Forms.TextBox textBoxForMilSecs;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPickLocation;
        private System.Windows.Forms.GroupBox groupBoxDcOc;
        private System.Windows.Forms.RadioButton buttonDouble;
        private System.Windows.Forms.RadioButton buttonOne;
        private System.Windows.Forms.GroupBox groupBoxLeftRight;
        private System.Windows.Forms.RadioButton buttonRight;
        private System.Windows.Forms.RadioButton buttonLeft;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxForY;
        private System.Windows.Forms.TextBox textBoxForX;
        private System.Windows.Forms.Button buttonInfinityClick;
    }
}

