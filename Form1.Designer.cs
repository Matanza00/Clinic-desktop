
namespace Demo1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitsideleft = new System.Windows.Forms.SplitContainer();
            this.panelSide = new System.Windows.Forms.Panel();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC5 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC3 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC4 = new ePOSOne.btnProduct.Button_WOC();
            this.logout = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.UserName = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_WOC10 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC9 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC8 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC7 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC6 = new ePOSOne.btnProduct.Button_WOC();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitsideleft)).BeginInit();
            this.splitsideleft.Panel1.SuspendLayout();
            this.splitsideleft.Panel2.SuspendLayout();
            this.splitsideleft.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitsideleft
            // 
            this.splitsideleft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitsideleft.BackColor = System.Drawing.Color.Gainsboro;
            this.splitsideleft.Location = new System.Drawing.Point(0, 0);
            this.splitsideleft.Name = "splitsideleft";
            // 
            // splitsideleft.Panel1
            // 
            this.splitsideleft.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitsideleft.Panel1.Controls.Add(this.panelSide);
            this.splitsideleft.Panel1.Controls.Add(this.logout);
            this.splitsideleft.Panel1.Controls.Add(this.panelLogo);
            this.splitsideleft.Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.splitsideleft.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitsideleft.Panel2
            // 
            this.splitsideleft.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitsideleft.Panel2.Controls.Add(this.panelDesktop);
            this.splitsideleft.Panel2.Controls.Add(this.panelTitleBar);
            this.splitsideleft.Panel2.Controls.Add(this.panel2);
            this.splitsideleft.Size = new System.Drawing.Size(1000, 700);
            this.splitsideleft.SplitterDistance = 198;
            this.splitsideleft.TabIndex = 0;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSide.Controls.Add(this.button_WOC1);
            this.panelSide.Controls.Add(this.button_WOC5);
            this.panelSide.Controls.Add(this.button_WOC2);
            this.panelSide.Controls.Add(this.button_WOC3);
            this.panelSide.Controls.Add(this.button_WOC4);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 63);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(203, 600);
            this.panelSide.TabIndex = 7;
            this.panelSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSide_Paint);
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.Silver;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Gainsboro;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Sitka Heading", 14.75F, System.Drawing.FontStyle.Bold);
            this.button_WOC1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_WOC1.Location = new System.Drawing.Point(-2, 32);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC1.Size = new System.Drawing.Size(202, 45);
            this.button_WOC1.TabIndex = 1;
            this.button_WOC1.Text = "Home";
            this.button_WOC1.TextColor = System.Drawing.Color.Black;
            this.button_WOC1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            this.button_WOC1.Resize += new System.EventHandler(this.button_WOC1_Click);
            // 
            // button_WOC5
            // 
            this.button_WOC5.BorderColor = System.Drawing.Color.Silver;
            this.button_WOC5.ButtonColor = System.Drawing.Color.Gainsboro;
            this.button_WOC5.FlatAppearance.BorderSize = 0;
            this.button_WOC5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC5.Font = new System.Drawing.Font("Sitka Heading", 14.75F, System.Drawing.FontStyle.Bold);
            this.button_WOC5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_WOC5.Location = new System.Drawing.Point(-1, 306);
            this.button_WOC5.Name = "button_WOC5";
            this.button_WOC5.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC5.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC5.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC5.Size = new System.Drawing.Size(202, 45);
            this.button_WOC5.TabIndex = 5;
            this.button_WOC5.Text = "Payment";
            this.button_WOC5.TextColor = System.Drawing.Color.Black;
            this.button_WOC5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_WOC5.UseVisualStyleBackColor = true;
            this.button_WOC5.Click += new System.EventHandler(this.button_WOC5_Click);
            // 
            // button_WOC2
            // 
            this.button_WOC2.BorderColor = System.Drawing.Color.Silver;
            this.button_WOC2.ButtonColor = System.Drawing.Color.Gainsboro;
            this.button_WOC2.FlatAppearance.BorderSize = 0;
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Font = new System.Drawing.Font("Sitka Heading", 14.75F, System.Drawing.FontStyle.Bold);
            this.button_WOC2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_WOC2.Location = new System.Drawing.Point(3, 104);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC2.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC2.Size = new System.Drawing.Size(202, 45);
            this.button_WOC2.TabIndex = 2;
            this.button_WOC2.Text = "Patients";
            this.button_WOC2.TextColor = System.Drawing.Color.Black;
            this.button_WOC2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_WOC2.UseVisualStyleBackColor = true;
            this.button_WOC2.Click += new System.EventHandler(this.button_WOC2_Click);
            // 
            // button_WOC3
            // 
            this.button_WOC3.BorderColor = System.Drawing.Color.Silver;
            this.button_WOC3.ButtonColor = System.Drawing.Color.Gainsboro;
            this.button_WOC3.FlatAppearance.BorderSize = 0;
            this.button_WOC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC3.Font = new System.Drawing.Font("Sitka Heading", 14.75F, System.Drawing.FontStyle.Bold);
            this.button_WOC3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_WOC3.Location = new System.Drawing.Point(1, 171);
            this.button_WOC3.Name = "button_WOC3";
            this.button_WOC3.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC3.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC3.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC3.Size = new System.Drawing.Size(202, 45);
            this.button_WOC3.TabIndex = 3;
            this.button_WOC3.Text = "Appointment";
            this.button_WOC3.TextColor = System.Drawing.Color.Black;
            this.button_WOC3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_WOC3.UseVisualStyleBackColor = true;
            this.button_WOC3.Click += new System.EventHandler(this.button_WOC3_Click);
            // 
            // button_WOC4
            // 
            this.button_WOC4.BorderColor = System.Drawing.Color.Silver;
            this.button_WOC4.ButtonColor = System.Drawing.Color.Gainsboro;
            this.button_WOC4.FlatAppearance.BorderSize = 0;
            this.button_WOC4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC4.Font = new System.Drawing.Font("Sitka Heading", 14.75F, System.Drawing.FontStyle.Bold);
            this.button_WOC4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_WOC4.Location = new System.Drawing.Point(-1, 237);
            this.button_WOC4.Name = "button_WOC4";
            this.button_WOC4.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC4.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC4.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC4.Size = new System.Drawing.Size(202, 45);
            this.button_WOC4.TabIndex = 4;
            this.button_WOC4.Text = "Search";
            this.button_WOC4.TextColor = System.Drawing.Color.Black;
            this.button_WOC4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_WOC4.UseVisualStyleBackColor = true;
            this.button_WOC4.Click += new System.EventHandler(this.button_WOC4_Click);
            // 
            // logout
            // 
            this.logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Sitka Heading", 14.75F, System.Drawing.FontStyle.Bold);
            this.logout.Location = new System.Drawing.Point(0, 663);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(198, 37);
            this.logout.TabIndex = 6;
            this.logout.Text = "LogOut";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLogo.Controls.Add(this.UserName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(198, 63);
            this.panelLogo.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Sitka Heading", 14.75F, System.Drawing.FontStyle.Bold);
            this.UserName.Location = new System.Drawing.Point(65, 23);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(71, 29);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "Admin";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktop.Location = new System.Drawing.Point(58, 70);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(735, 630);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(51, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(747, 63);
            this.panelTitleBar.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Mistral", 30.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(292, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Shape N Shine";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_WOC10);
            this.panel2.Controls.Add(this.button_WOC9);
            this.panel2.Controls.Add(this.button_WOC8);
            this.panel2.Controls.Add(this.button_WOC7);
            this.panel2.Controls.Add(this.button_WOC6);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(51, 700);
            this.panel2.TabIndex = 1;
            // 
            // button_WOC10
            // 
            this.button_WOC10.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC10.ButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC10.FlatAppearance.BorderSize = 0;
            this.button_WOC10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_WOC10.Image = ((System.Drawing.Image)(resources.GetObject("button_WOC10.Image")));
            this.button_WOC10.Location = new System.Drawing.Point(0, 369);
            this.button_WOC10.Name = "button_WOC10";
            this.button_WOC10.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC10.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC10.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC10.Size = new System.Drawing.Size(51, 45);
            this.button_WOC10.TabIndex = 5;
            this.button_WOC10.TextColor = System.Drawing.Color.Black;
            this.button_WOC10.UseVisualStyleBackColor = true;
            this.button_WOC10.Click += new System.EventHandler(this.button_WOC10_Click);
            // 
            // button_WOC9
            // 
            this.button_WOC9.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC9.ButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC9.FlatAppearance.BorderSize = 0;
            this.button_WOC9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_WOC9.Image = ((System.Drawing.Image)(resources.GetObject("button_WOC9.Image")));
            this.button_WOC9.Location = new System.Drawing.Point(-1, 300);
            this.button_WOC9.Name = "button_WOC9";
            this.button_WOC9.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC9.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC9.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC9.Size = new System.Drawing.Size(51, 45);
            this.button_WOC9.TabIndex = 4;
            this.button_WOC9.TextColor = System.Drawing.Color.Black;
            this.button_WOC9.UseVisualStyleBackColor = true;
            this.button_WOC9.Click += new System.EventHandler(this.button_WOC9_Click);
            // 
            // button_WOC8
            // 
            this.button_WOC8.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC8.ButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC8.FlatAppearance.BorderSize = 0;
            this.button_WOC8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_WOC8.Image = ((System.Drawing.Image)(resources.GetObject("button_WOC8.Image")));
            this.button_WOC8.Location = new System.Drawing.Point(-1, 234);
            this.button_WOC8.Name = "button_WOC8";
            this.button_WOC8.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC8.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC8.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC8.Size = new System.Drawing.Size(51, 45);
            this.button_WOC8.TabIndex = 3;
            this.button_WOC8.TextColor = System.Drawing.Color.Black;
            this.button_WOC8.UseVisualStyleBackColor = true;
            this.button_WOC8.Click += new System.EventHandler(this.button_WOC8_Click);
            // 
            // button_WOC7
            // 
            this.button_WOC7.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC7.ButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC7.FlatAppearance.BorderSize = 0;
            this.button_WOC7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_WOC7.Image = ((System.Drawing.Image)(resources.GetObject("button_WOC7.Image")));
            this.button_WOC7.Location = new System.Drawing.Point(-1, 167);
            this.button_WOC7.Name = "button_WOC7";
            this.button_WOC7.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC7.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC7.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC7.Size = new System.Drawing.Size(51, 45);
            this.button_WOC7.TabIndex = 2;
            this.button_WOC7.TextColor = System.Drawing.Color.Black;
            this.button_WOC7.UseVisualStyleBackColor = true;
            this.button_WOC7.Click += new System.EventHandler(this.button_WOC7_Click);
            // 
            // button_WOC6
            // 
            this.button_WOC6.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC6.ButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC6.FlatAppearance.BorderSize = 0;
            this.button_WOC6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_WOC6.Image = ((System.Drawing.Image)(resources.GetObject("button_WOC6.Image")));
            this.button_WOC6.Location = new System.Drawing.Point(0, 95);
            this.button_WOC6.Name = "button_WOC6";
            this.button_WOC6.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC6.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC6.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC6.Size = new System.Drawing.Size(51, 45);
            this.button_WOC6.TabIndex = 1;
            this.button_WOC6.TextColor = System.Drawing.Color.Black;
            this.button_WOC6.UseVisualStyleBackColor = true;
            this.button_WOC6.Click += new System.EventHandler(this.button_WOC6_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(10, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.splitsideleft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitsideleft.Panel1.ResumeLayout(false);
            this.splitsideleft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitsideleft)).EndInit();
            this.splitsideleft.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitsideleft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel2;
        private ePOSOne.btnProduct.Button_WOC button_WOC6;
        private ePOSOne.btnProduct.Button_WOC button_WOC10;
        private ePOSOne.btnProduct.Button_WOC button_WOC9;
        private ePOSOne.btnProduct.Button_WOC button_WOC8;
        private ePOSOne.btnProduct.Button_WOC button_WOC7;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label UserName;
        private ePOSOne.btnProduct.Button_WOC button_WOC5;
        private ePOSOne.btnProduct.Button_WOC button_WOC4;
        private ePOSOne.btnProduct.Button_WOC button_WOC3;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSide;
    }
}

