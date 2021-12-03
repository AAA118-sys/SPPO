
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.axVLCPlugin24 = new AxAXVLC.AxVLCPlugin2();
            this.axVLCPlugin23 = new AxAXVLC.AxVLCPlugin2();
            this.axVLCPlugin22 = new AxAXVLC.AxVLCPlugin2();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(107, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.axVLCPlugin24);
            this.panel2.Controls.Add(this.axVLCPlugin23);
            this.panel2.Controls.Add(this.axVLCPlugin22);
            this.panel2.Controls.Add(this.axVLCPlugin21);
            this.panel2.Location = new System.Drawing.Point(-123, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1352, 717);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // axVLCPlugin24
            // 
            this.axVLCPlugin24.Enabled = true;
            this.axVLCPlugin24.Location = new System.Drawing.Point(677, 355);
            this.axVLCPlugin24.Name = "axVLCPlugin24";
            this.axVLCPlugin24.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin24.OcxState")));
            this.axVLCPlugin24.Size = new System.Drawing.Size(662, 358);
            this.axVLCPlugin24.TabIndex = 3;
            // 
            // axVLCPlugin23
            // 
            this.axVLCPlugin23.Enabled = true;
            this.axVLCPlugin23.Location = new System.Drawing.Point(677, 4);
            this.axVLCPlugin23.Name = "axVLCPlugin23";
            this.axVLCPlugin23.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin23.OcxState")));
            this.axVLCPlugin23.Size = new System.Drawing.Size(662, 358);
            this.axVLCPlugin23.TabIndex = 2;
            // 
            // axVLCPlugin22
            // 
            this.axVLCPlugin22.Enabled = true;
            this.axVLCPlugin22.Location = new System.Drawing.Point(3, 357);
            this.axVLCPlugin22.Name = "axVLCPlugin22";
            this.axVLCPlugin22.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin22.OcxState")));
            this.axVLCPlugin22.Size = new System.Drawing.Size(676, 355);
            this.axVLCPlugin22.TabIndex = 1;
            this.axVLCPlugin22.Enter += new System.EventHandler(this.axVLCPlugin22_Enter);
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(3, 4);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(676, 358);
            this.axVLCPlugin21.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Snow;
            this.button6.Location = new System.Drawing.Point(961, 31);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 49);
            this.button6.TabIndex = 13;
            this.button6.Text = "Сменить пользователя";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Snow;
            this.button5.Location = new System.Drawing.Point(594, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 32);
            this.button5.TabIndex = 12;
            this.button5.Text = "Р-178";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Snow;
            this.button4.Location = new System.Drawing.Point(502, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 32);
            this.button4.TabIndex = 11;
            this.button4.Text = "М-5 \"Урал\"";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.kisspng_rectangle_grey_gray_three_dimensional_crystal_buttons_5a87cf6156dde6_1037556015188498893558;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(410, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 32);
            this.button3.TabIndex = 10;
            this.button3.Text = "Р-132";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button7.BackColor = System.Drawing.Color.Snow;
            this.button7.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.close_9;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Cursor = System.Windows.Forms.Cursors.Default;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(1116, 36);
            this.button7.Name = "button7";
            this.button7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button7.Size = new System.Drawing.Size(40, 39);
            this.button7.TabIndex = 8;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button7.UseMnemonic = false;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.kisspng_rectangle_grey_gray_three_dimensional_crystal_buttons_5a87cf6156dde6_1037556015188498893558;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(318, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Р-158";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.kisspng_rectangle_grey_gray_three_dimensional_crystal_buttons_5a87cf6156dde6_1037556015188498893558;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(226, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = " М-7 \"Волга\"";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.rosavtodor;
            this.pictureBox1.Location = new System.Drawing.Point(-123, -47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 232);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(497, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "М-7 \"Волга\"";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1207, 743);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Мосты";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin24;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin23;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin22;
        private System.Windows.Forms.Label label2;
    }
}

